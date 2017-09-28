using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using Deipax.Cloning.Common;
using Deipax.Core.Common;
using Deipax.Core.Extensions;

namespace UnitTests.Common
{
	public class CloneFactory2
	{
		static CloneFactory2()
		{
			_cache = new ConcurrentDictionary<Type, CloneFactory2>();
		}

		private CloneFactory2(Type t)
		{
			this.Type = t;

			_modelAccess = ModelAccess.Create(this.Type);

			_cloneTargets = new Lazy<IReadOnlyList<CloneTarget>>(() =>
			{
				return
				(from g in _modelAccess.AllGetters
				 from s in _modelAccess.AllSetters
				 where
					 g.Name == s.Name &&
					 g.ModelInfo.MemberInfo.DeclaringType == s.ModelInfo.MemberInfo.DeclaringType &&
					 g.ModelInfo.Depth == s.ModelInfo.Depth &&
					 g.ModelInfo.MemberInfo.GetCustomAttributes<NoCloneAttribute>().Count() == 0 &&
					 s.ModelInfo.MemberInfo.GetCustomAttributes<NoCloneAttribute>().Count() == 0
				 select new CloneTarget()
				 {
					 Name = g.Name,
					 Get = g.Get,
					 Set = s.Set,
					 CloneFunc = CloneFactory2.Create(g.ModelInfo.Type).GetClone
				 })
				.ToList();
			},
			LazyThreadSafetyMode.ExecutionAndPublication);

			_initializer = ObjectActivator.GetActivator(this.Type).Create;
			_isPrimitive = this.Type.IsPrimitive;
			_isEnum = this.Type.IsEnum;
			_isArray = this.Type.IsArray;
			_isValueType = this.Type.IsValueType;
			_isClass = this.Type.IsClass;
			_isImmutable = this.Type.IsImmutable();
			_isAbstract = this.Type.IsAbstract;
			_isInterface = this.Type.IsInterface;
			_isGenericType = this.Type.IsGenericType;
			_isNullableType = this.Type.IsGenericType && this.Type.GetGenericTypeDefinition() == typeof(Nullable<>);
			_isDelegate = typeof(Delegate).IsAssignableFrom(this.Type);

			_typeElement = _isArray ?
				this.Type.GetElementType() :
				null;

			_isTypeElementPrimitive = _typeElement != null ?
				_typeElement.IsPrimitive :
				false;

			_isTypeElementEnum = _typeElement != null ?
				_typeElement.IsEnum :
				false;

			_isTypeElementImmutable = _typeElement != null ?
				_typeElement.IsImmutable() :
				false;

			_typeElementCloneFunc = _typeElement != null ?
				CloneFactory2.Create(_typeElement).GetClone :
				(Func<object, object>)null;
		}

		private CloneFactory2()
		{
		}

		#region Field Members
		private static ConcurrentDictionary<Type, CloneFactory2> _cache;

		private Lazy<IReadOnlyList<CloneTarget>> _cloneTargets;
		private Func<object> _initializer;
		private ModelAccess _modelAccess;
		private bool _isPrimitive;
		private bool _isEnum;
		private bool _isArray;
		private bool _isValueType;
		private bool _isClass;
		private bool _isImmutable;
		private bool _isAbstract;
		private bool _isInterface;
		private bool _isGenericType;
		private bool _isNullableType;
		private bool _isDelegate;

		private Type _typeElement;
		private bool _isTypeElementPrimitive;
		private bool _isTypeElementEnum;
		private bool _isTypeElementImmutable;
		private Func<object, object> _typeElementCloneFunc;
		#endregion

		#region Public Members
		public static CloneFactory2 Create(Type t)
		{
			if (t != null)
			{
				return _cache.GetOrAdd(t, (x) =>
				{
					return new CloneFactory2(x);
				});
			}

			return null;
		}

		public static CloneFactory2 Create(object source)
		{
			if (source != null)
			{
				return CloneFactory2.Create(source.GetType());
			}

			return null;
		}

		public Type Type { get; private set; }

		public object GetClone(object source)
		{
			if (source == null)
			{
				return null;
			}

			if (_isPrimitive || _isEnum || _isImmutable || _isDelegate)
			{
				return source;
			}
			else if (_isArray)
			{
				var array = source as Array;
				Array copiedArray = Array.CreateInstance(_typeElement, array.Length);

				if (_isTypeElementPrimitive || _isTypeElementEnum || _isTypeElementImmutable || _isDelegate)
				{
					array.CopyTo(copiedArray, 0);
				}
				else
				{
					for (int i = 0; i < array.Length; i++)
					{
						copiedArray.SetValue(_typeElementCloneFunc(array.GetValue(i)), i);
					}
				}

				return copiedArray;
			}
			else if (_isGenericType && _isNullableType)
			{
				object dest = _initializer();
				dest = source;
				return dest;
			}
			else if (_isClass || _isValueType)
			{
				object dest = _initializer();

				_cloneTargets.Value.ToList().ForEach(x =>
				{
					x.Set(dest, x.CloneFunc(x.Get(source)));
				});

				return dest;
			}
			else
			{
				var sourceType = source.GetType();
				
				if (this.Type.IsAssignableFrom(sourceType))
				{
					var cloner = CloneFactory2.Create(sourceType);
					return cloner.GetClone(source);
				}

				throw new ArgumentException("The object is unknown type");
			}
		}
		#endregion

		#region Helpers
		class CloneTarget
		{
			public Func<object, object> Get { get; set; }
			public string Name { get; set; }
			public Action<object, object> Set { get; set; }
			public Func<object, object> CloneFunc { get; set; }
		}
		#endregion
	}

	public static class CloneFactory<T>
	{
		#region Field Members
		private static Func<object, object> _cloneFunc = CloneFactory2.Create(typeof(T)).GetClone;
		#endregion

		#region Public Members
		public static T GetClone(T source)
		{
			return (T)_cloneFunc(source);
		}
		#endregion
	}
}