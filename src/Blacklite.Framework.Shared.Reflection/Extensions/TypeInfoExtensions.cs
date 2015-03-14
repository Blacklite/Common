using System;
using System.Collections.Generic;

namespace System.Reflection
{
    public static class TypeInfoExtensions
    {
        public static PropertyInfo FindDeclaredProperty(this TypeInfo typeInfo, string name)
        {
            while (typeInfo != null)
            {
                var property = typeInfo.GetDeclaredProperty(name);
                if (property != null)
                    return property;

                typeInfo = typeInfo?.BaseType?.GetTypeInfo();
            }

            return null;
        }

        public static IEnumerable<PropertyInfo> GetDeclaredProperties(this TypeInfo typeInfo)
        {
            while (typeInfo != null)
            {
                var properties = typeInfo.DeclaredProperties;
                foreach (var property in properties)
                    yield return property;

                typeInfo = typeInfo?.BaseType?.GetTypeInfo();
            }
        }
    }
}
