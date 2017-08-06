﻿namespace Machete.Internals.Mapping
{
    using System.Collections.Generic;
    using System.Linq;
    using Reflection;


    public class ValueObjectDictionaryDictionaryMapper<T, TKey, TValue> :
        IDictionaryMapper<T>
    {
        readonly IDictionaryConverter _elementConverter;
        readonly ReadOnlyProperty<T> _property;

        public ValueObjectDictionaryDictionaryMapper(ReadOnlyProperty<T> property, IDictionaryConverter elementConverter)
        {
            _property = property;
            _elementConverter = elementConverter;
        }

        public void WritePropertyToDictionary(IDictionary<string, object> dictionary, T obj)
        {
            var value = _property.Get(obj);

            var values = value as IDictionary<TKey, TValue>;
            if (values == null)
                return;

            var elementArray = values.Select(element => new object[] {element.Key, _elementConverter.GetDictionary(element.Value)})
                .ToArray<object>();

            dictionary.Add(_property.Property.Name, elementArray);
        }
    }
}