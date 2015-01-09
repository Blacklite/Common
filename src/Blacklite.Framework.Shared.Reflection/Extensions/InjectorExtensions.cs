﻿using Blacklite.Framework.Shared.Reflection.Extensions.InjectorExtension;
using Microsoft.Framework.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Framework.Shared.Reflection
{
    public static class InjectorExtensions
    {
        public static InjectableMethodBuilder CreateInjectableMethod(this TypeInfo typeInfo, string methodName, Func<MethodInfo, bool> predicate = null)
        {
            // Warn that there is no execute method.
            var methodInfos = typeInfo.DeclaredMethods
                .Where(x => x.Name == methodName);

            if (predicate != null)
                methodInfos = methodInfos.Where(predicate);

            var methodInfo = methodInfos.FirstOrDefault();

            if (methodInfo == null)
                return null;

            return methodInfo.CreateInjectableMethod();
        }

        public static InjectableMethodBuilder CreateInjectableMethod(this MethodInfo methodInfo)
        {
            return new InjectableMethodBuilder(methodInfo);
        }
    }
}