﻿namespace Machete.Internals.Mapping
{
    using System.Collections.Generic;
    using Reflection;


    public class ObjectListDictionaryMapper<T, TElement> :
        IDictionaryMapper<T>
    {
        readonly IDictionaryConverter _elementConverter;
        readonly ReadOnlyProperty<T> _property;

        public ObjectListDictionaryMapper(ReadOnlyProperty<T> property, IDictionaryConverter elementConverter)
        {
            _property = property;
            _elementConverter = elementConverter;
        }

        public void WritePropertyToDictionary(IDictionary<string, object> dictionary, T obj)
        {
            var value = _property.Get(obj);

            var values = value as IList<TElement>;
            if (values == null)
                return;

            var elements = new object[values.Count];
            for (var i = 0; i < values.Count; i++)
                elements[i] = _elementConverter.GetDictionary(values[i]);

            dictionary.Add(_property.Property.Name, elements);
        }
    }
}