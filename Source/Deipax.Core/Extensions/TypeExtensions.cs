using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Deipax.Core.Extensions
{
	public static class TypeExtensions
	{
		#region Field Members
		private static HashSet<Type> _immutableTypes = new HashSet<Type>()
		{
			typeof(string), typeof(DateTime), typeof(TimeSpan)
		};
		#endregion

		#region Public Members
		public static bool IsNullable(this Type source)
		{
			return source.IsGenericType() && source.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		public static bool IsImmutable(this Type source)
		{
			return _immutableTypes.Contains(source);
		}

		public static bool HasDefaultConstructor(this Type t)
		{
			return t.IsValueType() || t.GetConstructor(Type.EmptyTypes) != null;
		}

		public static bool IsPrimitive(this Type type)
		{
			return type.GetTypeInfo().IsPrimitive;
		}

		public static bool IsAbstract(this Type type)
		{
			return type.GetTypeInfo().IsAbstract;
		}

		public static bool IsClass(this Type type)
		{
			return type.GetTypeInfo().IsClass;
		}

		public static bool IsGenericType(this Type type)
		{
			return type.GetTypeInfo().IsGenericType;
		}

		public static bool IsInterface(this Type type)
		{
			return type.GetTypeInfo().IsInterface;
		}

		public static bool IsValueType(this Type type)
		{
			return type.GetTypeInfo().IsValueType;
		}

		public static Type BaseType(this Type type)
		{
			return type.GetTypeInfo().BaseType;
		}

		public static bool IsEnum(this Type type)
		{
			return type.GetTypeInfo().IsEnum;
		}

		public static IReadOnlyList<IFieldModelInfo> GetAllFields(this Type type)
		{
			return GetAllFieldsHelper(type, 0);
		}

		public static IReadOnlyList<IPropertyModelInfo> GetAllProperties(
			this Type type,
			IEnumerable<IFieldModelInfo> fields = null)
		{
			var allFields = fields != null ?
				fields :
				GetAllFields(type);

			return GetAllPropertiesHelper(allFields, type, 0);
		}

	    public static IReadOnlyList<IPropertyModelInfo> GetFilteredProperties(
	        this Type type,
	        IEnumerable<IFieldModelInfo> fields = null)
	    {
	        List<IPropertyModelInfo> properties = new List<IPropertyModelInfo>();
	        var allProperties = type.GetAllProperties(fields);

	        // If properties that share a name are marked as abstract
	        // or virtual, then only one of them is needed in order to
	        // set/get the value of the property.  Any of them should 
	        // work correctly, use the first one.
	        allProperties
	            .Where(x => x.IsAbstract || x.IsVirtual)
	            .Select(x => x)
	            .GroupBy(x => x.Name)
	            .ToList()
	            .ForEach(x => properties.Add(x.OrderBy(y => y.Depth).First()));

	        // Add all non-virtual/non-abstract properties
	        properties.AddRange(allProperties.Where(x => !(x.IsAbstract || x.IsVirtual)).Select(x => x));

	        return properties;
        }
	    #endregion

            #region Private Members
        private static IReadOnlyList<IFieldModelInfo> GetAllFieldsHelper(
			Type type,
			int depth = 0)
		{
			if (type == null)
			{
				return new List<IFieldModelInfo>();
			}

			var fields = type
				.GetTypeInfo()
				.GetFields(
					BindingFlags.Public |
					BindingFlags.NonPublic |
					BindingFlags.Static |
					BindingFlags.Instance |
					BindingFlags.DeclaredOnly)
				.Select(x => FieldModelInfo.Create(x, depth))
				.ToList();

			fields.AddRange(GetAllFieldsHelper(type.BaseType(), ++depth));

			return fields;
		}

		private static IReadOnlyList<IPropertyModelInfo> GetAllPropertiesHelper(
			IEnumerable<IFieldModelInfo> fields,
			Type type,
			int depth = 0)
		{
			if (type == null)
			{
				return new List<IPropertyModelInfo>();
			}

			var props = type
				.GetTypeInfo()
				.GetProperties(
					BindingFlags.Public |
					BindingFlags.NonPublic |
					BindingFlags.Static |
					BindingFlags.Instance |
					BindingFlags.DeclaredOnly)
				.Select(x => PropertyModelInfo.Create(fields, x, depth))
				.ToList();

			props.AddRange(GetAllPropertiesHelper(fields, type.BaseType(), ++depth));

			return props;
		}
        #endregion

        #region Helpers
	    [DebuggerDisplay("{FieldInfo.FieldType.Name} {FieldInfo.Name} {FieldInfo.DeclaringType.Name}")]
        class FieldModelInfo : IFieldModelInfo
		{
			public static IFieldModelInfo Create(
				FieldInfo info,
				int depth)
			{
				return new FieldModelInfo()
				{
					Name = info.Name,
					Type = info.FieldType,
					FieldInfo = info,
					MemberInfo = info,
					IsStatic = info.IsStatic,
					IsPublic = info.IsPublic,
					CanRead = true,
					CanWrite = !info.IsInitOnly && !info.IsLiteral,
					IsBackingField = info.IsBackingField(false),
					Depth = depth,
					IsLiteral = info.IsLiteral
				};
			}

			public string Name { get; private set; }
			public Type Type { get; private set; }
			public MemberInfo MemberInfo { get; private set; }
			public FieldInfo FieldInfo { get; private set; }
			public bool IsStatic { get; private set; }
			public bool IsPublic { get; private set; }
			public bool CanRead { get; private set; }
			public bool CanWrite { get; private set; }
			public bool IsBackingField { get; private set; }
			public int Depth { get; private set; }
			public bool IsLiteral { get; private set; }
		}

        [DebuggerDisplay("{PropertyInfo.PropertyType.Name} {PropertyInfo.Name} {PropertyInfo.DeclaringType.Name}")]
		class PropertyModelInfo : IPropertyModelInfo
		{
			public static IPropertyModelInfo Create(
				IEnumerable<IFieldModelInfo> fields,
				PropertyInfo info,
				int depth)
			{
				string key = string.Format("<{0}>k__BackingField", info.Name);

				var backingField = fields
					.Where(x =>
						x.IsBackingField &&
						string.Equals(x.FieldInfo.Name, key) &&
						x.FieldInfo.DeclaringType == info.DeclaringType &&
						x.Depth == depth)
					.FirstOrDefault();

				return new PropertyModelInfo()
				{
					Name = info.Name,
					Type = info.PropertyType,
					MemberInfo = info,
					PropertyInfo = info,
					BackingField = backingField,
					IsStatic = info.IsStatic(false),
					IsPublic = info.IsPublic(false),
					CanRead = info.CanRead(false),
					CanWrite = info.CanWrite(false),
					HasParameters = info.HasParameters(false),
					HasBackingField = backingField != null,
					Depth = depth,
					IsLiteral = false,
					IsAbstract = info.IsAbstract(false),
					IsVirtual = info.IsVitrual(false)
				};
			}

			public string Name { get; private set; }
			public Type Type { get; private set; }
			public MemberInfo MemberInfo { get; private set; }
			public PropertyInfo PropertyInfo { get; private set; }
			public IFieldModelInfo BackingField { get; private set; }
			public bool IsStatic { get; private set; }
			public bool IsPublic { get; private set; }
			public bool CanRead { get; private set; }
			public bool CanWrite { get; private set; }
			public bool HasParameters { get; private set; }
			public bool HasBackingField { get; private set; }
			public int Depth { get; private set; }
			public bool IsLiteral { get; private set; }
			public bool IsAbstract { get; private set; }
			public bool IsVirtual { get; private set; }
		}
		#endregion
	}
}