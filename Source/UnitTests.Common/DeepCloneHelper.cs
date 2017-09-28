using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Deipax.Cloning.Common;

namespace UnitTests.Common
{
	public static class DeepCloneHelper
	{
		#region Field Members
		private static ConcurrentDictionary<string, IEnumerable<FieldInfo>> _cloneFields = new ConcurrentDictionary<string, IEnumerable<FieldInfo>>();
		#endregion

		public static T GetClone<T>(T obj)
		{
			return (T)CloneProcedure(obj);
		}

		#region Private Members
		private static object CloneProcedure(object obj)
		{
			if (obj == null)
			{
				return null;
			}

			Type type = obj.GetType();

			if (type.IsPrimitive || type.IsEnum || type == typeof(string))
			{
				return obj;
			}
			else if (type.IsArray)
			{
				Type typeElement = type.GetElementType();
				var array = obj as Array;
				Array copiedArray = Array.CreateInstance(typeElement, array.Length);

				if (typeElement.IsPrimitive || typeElement.IsEnum || typeElement == typeof(string))
				{
					array.CopyTo(copiedArray, 0);
				}
				else
				{
					for (int i = 0; i < array.Length; i++)
					{
						copiedArray.SetValue(CloneProcedure(array.GetValue(i)), i);
					}
				}

				return copiedArray;
			}
			else if (type.IsClass || type.IsValueType)
			{
				object copiedObject = Activator.CreateInstance(type);

				foreach (FieldInfo field in GetCloneFields(type))
				{
					object fieldValue = field.GetValue(obj);

					if (fieldValue != null)
					{
						field.SetValue(copiedObject, CloneProcedure(fieldValue));
					}
				}

				return copiedObject;
			}
			else
			{
				throw new ArgumentException("The object is unknown type");
			}
		}

		private static IEnumerable<FieldInfo> GetCloneFields(Type t)
		{
			if (!_cloneFields.ContainsKey(t.FullName))
			{
				var noCloneProperties = GetNoClonePropertiesNames(t);
				var allFields = GetNoCloneFields(t);

				var fields = allFields
					.Where(x => !noCloneProperties.Exists(y => x.Name.IndexOf(y) >= 0))
					.ToList();

				_cloneFields.TryAdd(t.FullName, fields);
			}

			return _cloneFields[t.FullName].ToList();
		}

		private static List<string> GetNoClonePropertiesNames(Type t)
		{
			if (t == null)
			{
				return new List<string>();
			}

			var noCloneProps = t
				.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
				.Where(x => x.GetCustomAttributes<NoCloneAttribute>().Count() > 0)
				.Select(x => "<" + x.Name + ">")
				.ToList();

			noCloneProps.AddRange(GetNoClonePropertiesNames(t.BaseType));

			return noCloneProps.Distinct().ToList();
		}

		private static List<FieldInfo> GetNoCloneFields(Type t)
		{
			if (t == null)
			{
				return new List<FieldInfo>();
			}

			var fields = t
				.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
				.Where(x => x.GetCustomAttributes<NoCloneAttribute>().Count() == 0)
				.ToList();

			fields.AddRange(GetNoCloneFields(t.BaseType));

			return fields;
		}
		#endregion
	}
}