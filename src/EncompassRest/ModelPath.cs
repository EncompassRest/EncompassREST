﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using EncompassRest.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest
{
    internal sealed class ModelPath : IEquatable<ModelPath>
    {
        public static ModelPath Create(string modelPath)
        {
            try
            {
                if (!string.IsNullOrEmpty(modelPath))
                {
                    return new ModelPath(modelPath);
                }
            }
            catch
            {
            }
            return null;
        }

        public string RootObjectName { get; }

        public IReadOnlyList<PathSegment> Segments { get; }

        public ModelPath(string modelPath)
        {
            Preconditions.NotNullOrEmpty(modelPath, nameof(modelPath));

            var segments = new List<PathSegment>();
            var i = 0;
            int start;
            while (i < modelPath.Length)
            {
                var c = modelPath[i];
                switch (c)
                {
                    case '[':
                        if (RootObjectName == null)
                        {
                            RootObjectName = modelPath.Substring(0, i);
                        }
                        Increment(ref i);
                        c = modelPath[i];
                        StringBuilder sb;
                        int? index;
                        string propertyName;
                        switch (c)
                        {
                            case '(':
                                Increment(ref i);
                                EatWhiteSpace(modelPath, ref i);
                                sb = new StringBuilder();
                                c = modelPath[i];
                                ObjectFilter filter = null;
                                while (c != ')')
                                {
                                    switch (c)
                                    {
                                        case '\'':
                                            Increment(ref i);
                                            propertyName = GetPropertyName(modelPath, ref i);
                                            if (string.IsNullOrEmpty(propertyName))
                                            {
                                                throw new ArgumentException("bad path");
                                            }
                                            Increment(ref i);
                                            break;
                                        default:
                                            var s = i;
                                            while (char.IsLetterOrDigit(c) || c == '_')
                                            {
                                                Increment(ref i);
                                                c = modelPath[i];
                                            }
                                            if (s == i)
                                            {
                                                throw new ArgumentException("bad path");
                                            }
                                            propertyName = modelPath.Substring(s, i - s);
                                            break;
                                    }
                                    EatWhiteSpace(modelPath, ref i);
                                    if (modelPath[i] != '=')
                                    {
                                        throw new ArgumentException("bad path");
                                    }
                                    Increment(ref i);
                                    if (modelPath[i] != '=')
                                    {
                                        throw new ArgumentException("bad path");
                                    }
                                    Increment(ref i);
                                    EatWhiteSpace(modelPath, ref i);

                                    string value;
                                    c = modelPath[i];
                                    switch (c)
                                    {
                                        case '\'':
                                            Increment(ref i);
                                            value = GetPropertyName(modelPath, ref i);
                                            Increment(ref i);
                                            break;
                                        default:
                                            start = i;
                                            var integerValue = 0;
                                            while (char.IsDigit(c))
                                            {
                                                integerValue = integerValue * 10 + (c - '0');
                                                Increment(ref i);
                                                c = modelPath[i];
                                            }
                                            if (start == i)
                                            {
                                                throw new ArgumentException("only integers allowed in unescaped filter values");
                                            }
                                            value = integerValue.ToString();
                                            break;
                                    }
                                    var propertyFilter = new PropertyFilter(propertyName, value);
                                    EatWhiteSpace(modelPath, ref i);
                                    c = modelPath[i];
                                    if (c == '&')
                                    {
                                        Increment(ref i);
                                        if (modelPath[i] != '&')
                                        {
                                            throw new ArgumentException("bad path");
                                        }
                                        Increment(ref i);
                                        EatWhiteSpace(modelPath, ref i);
                                        if (modelPath[i] == ')')
                                        {
                                            throw new ArgumentException("bad path");
                                        }
                                    }
                                    filter = filter?.And(propertyFilter) ?? propertyFilter;
                                    c = modelPath[i];
                                }
                                if (filter == null)
                                {
                                    throw new ArgumentException("bad path");
                                }
                                Increment(ref i);
                                if (modelPath[i] != ']')
                                {
                                    throw new ArgumentException("bad path");
                                }
                                index = null;
                                if (i + 2 < modelPath.Length && modelPath[i + 1] == '[' && char.IsDigit(modelPath[i + 2]))
                                {
                                    i += 2;
                                    c = modelPath[i];
                                    index = 0;
                                    while (char.IsDigit(c))
                                    {
                                        index = index * 10 + (c - '0');
                                        Increment(ref i);
                                        c = modelPath[i];
                                    }
                                    if (c != ']')
                                    {
                                        throw new ArgumentException("only digits in non-filter brackets");
                                    }
                                }
                                segments.Add(new ArraySegment(filter, index));
                                break;
                            case ']':
                                throw new ArgumentException("no empty brackets");
                            case '\'':
                                Increment(ref i);
                                propertyName = GetPropertyName(modelPath, ref i);
                                if (string.IsNullOrEmpty(propertyName))
                                {
                                    throw new ArgumentException("bad path");
                                }
                                segments.Add(new PropertySegment(propertyName));
                                Increment(ref i);
                                if (modelPath[i] != ']')
                                {
                                    throw new ArgumentException("bad path");
                                }
                                break;
                            default:
                                index = 0;
                                while (char.IsDigit(c))
                                {
                                    index = index * 10 + (c - '0');
                                    Increment(ref i);
                                    c = modelPath[i];
                                }
                                if (c != ']')
                                {
                                    throw new ArgumentException("only digits in non-filter brackets");
                                }
                                segments.Add(new ArraySegment(index.GetValueOrDefault()));
                                break;
                        }
                        break;
                    case '.':
                        if (RootObjectName == null)
                        {
                            RootObjectName = modelPath.Substring(0, i);
                        }
                        Increment(ref i);
                        start = i;
                        while (i < modelPath.Length && char.IsLetterOrDigit((c = modelPath[i])) || c == '_')
                        {
                            ++i;
                        }
                        if (i == start)
                        {
                            throw new ArgumentException("bad path");
                        }
                        segments.Add(new PropertySegment(modelPath.Substring(start, i - start)));
                        --i;
                        break;
                }
                ++i;
            }
            if (RootObjectName == null)
            {
                throw new ArgumentException("bad path");
            }
            Segments = segments.AsReadOnly();

            void Increment(ref int value)
            {
                ++i;
                if (i >= modelPath.Length)
                {
                    throw new ArgumentException("bad path");
                }
            }
        }

        private static void EatWhiteSpace(string modelPath, ref int i, bool throwAtEnd = true)
        {
            while (i < modelPath.Length ? char.IsWhiteSpace(modelPath[i]) : (throwAtEnd ? throw new ArgumentException("bad path") : false))
            {
                ++i;
            }
        }

        private static string GetPropertyName(string modelPath, ref int i)
        {
            var sb = new StringBuilder();
            var c = modelPath[i];
            while (c != '\'')
            {
                if (c == '\\')
                {
                    ++i;
                    if (i >= modelPath.Length)
                    {
                        throw new ArgumentException("bad path");
                    }
                    c = modelPath[i];
                    if (c != '\\' && c != '\'')
                    {
                        throw new ArgumentException("bad escape character");
                    }
                    sb.Append(c);
                    break;
                }
                sb.Append(c);
                ++i;
                if (i >= modelPath.Length)
                {
                    throw new ArgumentException("bad path");
                }
                c = modelPath[i];
            }
            return sb.ToString();
        }

        public object GetValue(object root) => GetValue(root, out _);

        public object GetValue(object root, out Type declaredType)
        {
            Preconditions.NotNull(root, nameof(root));

            var value = root;
            declaredType = null;
            foreach (var segment in Segments)
            {
                value = segment.GetValue(value, out declaredType);
                if (value == null)
                {
                    return null;
                }
            }
            return value;
        }

        public void SetValue(object root, object value) => SetValue(root, t => value);

        public void SetValue(object root, Func<Type, object> valueProvider)
        {
            Preconditions.NotNull(root, nameof(root));
            Preconditions.NotNull(valueProvider, nameof(valueProvider));

            var parent = root;
            for (var i = 1; i < Segments.Count; ++i)
            {
                var segment = Segments[i - 1];
                parent = segment.GetValue(parent, out var declaredType, true);
            }
            Segments[Segments.Count - 1].SetValue(parent, valueProvider);
        }

        public Type GetDeclaredType(Type rootType)
        {
            var declaredType = rootType;
            foreach (var segment in Segments)
            {
                declaredType = segment.GetDeclaredType(declaredType);
            }
            return declaredType;
        }

        public override string ToString() => $"{RootObjectName}{string.Concat(Segments)}";

        public override int GetHashCode() => Segments.Aggregate(RootObjectName.GetHashCode(), (current, segment) => current ^ segment.GetHashCode());

        public override bool Equals(object obj) => Equals(obj as ModelPath);

        public bool Equals(ModelPath other)
        {
            if (other == null || !string.Equals(RootObjectName, other.RootObjectName, StringComparison.OrdinalIgnoreCase) || Segments.Count != other.Segments.Count)
            {
                return false;
            }
            for (var i = 0; i < Segments.Count; ++i)
            {
                if (!Segments[i].Equals(other.Segments[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static string EscapeWithTick(string value, out bool escapeNeeded)
        {
            escapeNeeded = char.IsDigit(value[0]) || !value.All(c => char.IsLetterOrDigit(c) || c == '_');
            return escapeNeeded ? value.Replace("'", "\\'").Replace("\\", "\\\\") : value;
        }

        public abstract class PathSegment : IEquatable<PathSegment>
        {
            internal PathSegment()
            {
            }

            public abstract Type GetDeclaredType(Type parentType);

            public object GetValue(object parent) => GetValue(parent, out _);

            public abstract object GetValue(object parent, out Type declaredType, bool createIfNotExists = false);

            public void SetValue(object parent, object value) => SetValue(parent, t => value);

            public abstract void SetValue(object parent, Func<Type, object> valueProvider);

            public abstract override string ToString();

            public abstract override int GetHashCode();

            public sealed override bool Equals(object obj) => Equals(obj as PathSegment);

            public abstract bool Equals(PathSegment other);
        }

        public sealed class PropertySegment : PathSegment
        {
            public string PropertyName { get; }

            public PropertySegment(string propertyName)
            {
                Preconditions.NotNullOrEmpty(propertyName, nameof(propertyName));

                PropertyName = propertyName;
            }

            public override Type GetDeclaredType(Type parentType)
            {
                var property = GetProperty(parentType);
                return property.PropertyType;
            }

            public override object GetValue(object parent, out Type declaredType, bool createIfNotExists = false)
            {
                var property = GetProperty(parent?.GetType());
                declaredType = property.PropertyType;
                var value = property.ValueProvider.GetValue(parent);
                if (createIfNotExists && value == null)
                {
                    var json = declaredType.GetTypeInfo().ImplementedInterfaces.Contains(TypeData<IEnumerable>.Type) ? "[]" : "{}";
                    value = JsonHelper.FromJson(json, declaredType);
                    property.ValueProvider.SetValue(parent, value);
                }
                return value;
            }

            public override void SetValue(object parent, Func<Type, object> valueProvider)
            {
                var property = GetProperty(parent?.GetType());
                var value = valueProvider(property.PropertyType);
                property.ValueProvider.SetValue(parent, value);
            }

            private JsonProperty GetProperty(Type parentType)
            {
                Preconditions.NotNull(parentType, nameof(parentType));

                var contract = JsonHelper.InternalPrivateContractResolver.ResolveContract(parentType);
                if (!(contract is JsonObjectContract objectContract))
                {
                    throw new InvalidOperationException($"parent's type must resolve to a json object contract");
                }
                var property = objectContract.Properties.GetClosestMatchProperty(PropertyName);
                if (property == null)
                {
                    throw new InvalidOperationException($"Could not find property {PropertyName} on {parentType}");
                }
                return property;
            }

            public override string ToString()
            {
                var escapedPropertyName = EscapeWithTick(PropertyName, out var escapeNeeded);
                return escapeNeeded ? $"['{escapedPropertyName}']" : $".{escapedPropertyName}";
            }

            public override int GetHashCode() => PropertyName.GetHashCode();

            public override bool Equals(PathSegment other) => other is PropertySegment propertySegment && string.Equals(PropertyName, propertySegment.PropertyName);
        }

        public sealed class ArraySegment : PathSegment
        {
            public int? Index { get; }

            public ObjectFilter Filter { get; }

            public ArraySegment(int index)
                : this(null, index)
            {
            }

            public ArraySegment(ObjectFilter filter, int? index = null)
            {
                if (!index.HasValue && filter == null)
                {
                    throw new ArgumentException("index must have a value when not using a filter");
                }

                Index = index;
                Filter = filter;
            }

            public override Type GetDeclaredType(Type parentType)
            {
                var parentTypeInfo = parentType.GetTypeInfo();
                var declaredType = TypeData<object>.Type;
                foreach (var implementedInterface in parentTypeInfo.ImplementedInterfaces)
                {
                    var implementedInterfaceTypeInfo = implementedInterface.GetTypeInfo();
                    if (implementedInterfaceTypeInfo.IsGenericType && !implementedInterfaceTypeInfo.IsGenericTypeDefinition)
                    {
                        var genericTypeDefinition = implementedInterface.GetGenericTypeDefinition();
                        if (genericTypeDefinition == TypeData.OpenIEnumerableType)
                        {
                            declaredType = implementedInterfaceTypeInfo.GenericTypeArguments[0];
                        }
                    }
                }
                return declaredType;
            }

            public override object GetValue(object parent, out Type declaredType, bool createIfNotExists = false)
            {
                Preconditions.NotNull(parent, nameof(parent));
                if (!(parent is IList list))
                {
                    throw new ArgumentException("must be IEnumerable", nameof(parent));
                }

                declaredType = GetDeclaredType(parent.GetType());

                var filteredList = list;
                if (Filter != null)
                {
                    filteredList = new List<object>();
                    foreach (var item in list)
                    {
                        if (Filter.Evaluate(item))
                        {
                            filteredList.Add(item);
                        }
                    }
                }

                var index = (Index ?? 1) - 1;
                if (index < filteredList.Count)
                {
                    return filteredList[index];
                }
                else if (createIfNotExists)
                {
                    var json = "{}";
                    if (Filter != null)
                    {
                        var sb = new StringBuilder();
                        sb.Append('{');
                        foreach (var propertyFilter in Filter)
                        {
                            sb.Append(@"""").Append(propertyFilter.PropertyName).Append(@""":");
                            var contract = (JsonObjectContract)JsonHelper.InternalPrivateContractResolver.ResolveContract(declaredType);
                            var property = contract.Properties.GetClosestMatchProperty(propertyFilter.PropertyName);
                            var propertyType = property.PropertyType;
                            if (propertyType == TypeData<int?>.Type || propertyType == TypeData<decimal?>.Type || propertyType == TypeData<bool?>.Type)
                            {
                                sb.Append(propertyFilter.Value);
                            }
                            else
                            {
                                sb.Append('"').Append(propertyFilter.Value).Append('"');
                            }
                            sb.Append(',');
                        }
                        --sb.Length;
                        sb.Append('}');
                        json = sb.ToString();
                    }
                    object result = null;
                    for (var i = filteredList.Count; i <= index; ++i)
                    {
                        result = JsonHelper.FromJson(json, declaredType);
                        list.Add(result);
                    }
                    return result;
                }
                return null;
            }

            public override void SetValue(object parent, Func<Type, object> valueProvider) => throw new NotSupportedException();

            public override string ToString() => $"{(Filter != null ? $"[({Filter.ToString()})]" : string.Empty)}{(Index.HasValue ? $"[{Index}]" : string.Empty)}";

            public override int GetHashCode() => (Index?.GetHashCode() ?? 1) ^ Filter.GetHashCode();

            public override bool Equals(PathSegment other) => other is ArraySegment arraySegment && (Index ?? 1) == (arraySegment.Index ?? 1) && (Filter != null ? Filter.Equals(arraySegment.Filter) : arraySegment.Filter == null);
        }

        public class ObjectFilter : IEnumerable<PropertyFilter>, IEquatable<ObjectFilter>
        {
            [JsonProperty("terms", NullValueHandling = NullValueHandling.Ignore)]
            private readonly List<PropertyFilter> _terms;

            internal ObjectFilter()
            {
            }

            private ObjectFilter(PropertyFilter first, PropertyFilter second)
            {
                _terms = new List<PropertyFilter> { first, second };
            }

            public ObjectFilter And(PropertyFilter filter)
            {
                Preconditions.NotNull(filter, nameof(filter));

                if (this is PropertyFilter firstPropertyFilter)
                {
                    return new ObjectFilter(firstPropertyFilter, filter);
                }

                _terms.Add(filter);
                return this;
            }

            public virtual bool Evaluate(object value) => _terms.All(term => term.Evaluate(value));

            public override string ToString() => string.Join(" && ", _terms);

            public override int GetHashCode() => _terms.Aggregate(0, (current, filter) => current ^ filter.GetHashCode());

            public sealed override bool Equals(object obj) => Equals(obj as ObjectFilter);

            public virtual bool Equals(ObjectFilter other)
            {
                if (other?._terms?.Count != _terms.Count)
                {
                    return false;
                }

                foreach (var term in _terms)
                {
                    if (!other._terms.Any(t => term.Equals(t)))
                    {
                        return false;
                    }
                }
                return true;
            }

            public IEnumerator<PropertyFilter> GetEnumerator()
            {
                if (this is PropertyFilter propertyFilter)
                {
                    yield return propertyFilter;
                }
                else
                {
                    foreach (var term in _terms)
                    {
                        yield return term;
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public sealed class PropertyFilter : ObjectFilter
        {
            public string PropertyName { get; }

            public string Value { get; }

            public PropertyFilter(string propertyName, string value)
            {
                Preconditions.NotNullOrEmpty(propertyName, nameof(propertyName));

                PropertyName = propertyName;
                Value = value;
            }

            public override bool Evaluate(object value)
            {
                Preconditions.NotNull(value, nameof(value));

                var valueType = value.GetType();
                var contract = JsonHelper.InternalPrivateContractResolver.ResolveContract(valueType);
                if (!(contract is JsonObjectContract objectContract))
                {
                    throw new InvalidOperationException($"value's type must resolve to a json object contract");
                }
                var property = objectContract.Properties.GetClosestMatchProperty(PropertyName);
                if (property == null)
                {
                    throw new InvalidOperationException($"Could not find property {PropertyName} on {valueType}");
                }

                var retrievedValue = property.ValueProvider.GetValue(value);
                return string.Equals(Value, retrievedValue?.ToString(), StringComparison.OrdinalIgnoreCase);
            }

            public override int GetHashCode() => PropertyName.GetHashCode() ^ (Value?.GetHashCode() ?? 0);

            public override string ToString()
            {
                var propertyNameEscaped = EscapeWithTick(PropertyName, out var escapeNeeded);
                return $"{(escapeNeeded ? $"'{propertyNameEscaped}'" : propertyNameEscaped)} == '{EscapeWithTick(Value, out _)}'";
            }

            public override bool Equals(ObjectFilter other) => other is PropertyFilter propertyFilter && string.Equals(PropertyName, propertyFilter.PropertyName, StringComparison.OrdinalIgnoreCase) && string.Equals(Value, propertyFilter.Value, StringComparison.OrdinalIgnoreCase);
        }
    }
}