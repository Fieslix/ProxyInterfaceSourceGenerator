﻿using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace ProxyInterfaceSourceGenerator.Extensions
{
    internal static class SymbolExtensions
    {
        public static string ToPropertyText(this IPropertySymbol property, string? overrideType = null)
        {
            var get = property.GetMethod != null ? "get; " : string.Empty;
            var set = property.SetMethod != null ? "set; " : string.Empty;

            var type = !string.IsNullOrEmpty(overrideType) ? overrideType : $"{property.Type}";

            return $"{type} {property.Name} {{ {get}{set}}}";
        }

        public static string ToPropertyTextForClass(this IPropertySymbol property)
        {
            var get = property.GetMethod != null ? $"get => _instance.{property.Name}; " : string.Empty;
            var set = property.SetMethod != null ? $"set => _instance.{property.Name} = value; " : string.Empty;

            return $"{property.Type} {property.Name} {{ {get}{set}}}";
        }

        public static string ToMethodTextForInterface(this IMethodSymbol method)
        {
            var parameters = new List<string>();
            foreach (var ps in method.Parameters)
            {
                parameters.Add($"{ps.Type} {ps.Name}");
            }

            return $"{method.ReturnType} {method.Name}({string.Join(", ", parameters)})";
        }

        public static string ToMethodTextForClass(this IMethodSymbol method)
        {
            var parameters = new List<string>();
            foreach (var ps in method.Parameters)
            {
                parameters.Add($"{ps.Name}");
            }

            return $"{method.ToMethodTextForInterface()} => _instance.{method.Name}({string.Join(", ", parameters)});";
        }
    }
}
