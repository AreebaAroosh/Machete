﻿namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
    using Formatters;
    using Values;


    public class PropertyListPropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema, TValue>,
        IPropertyListConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        IValueConverter<TValue> _valueConverter;
        IValueFormatter<TValue> _valueFormatter;

        public PropertyListPropertySpecification(PropertyInfo property, int position, IValueConverter<TValue> valueConverter, IValueFormatter<TValue> valueFormatter)
            : base(property, position)
        {
            _valueConverter = valueConverter;
            _valueFormatter = valueFormatter;

            SetList();
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            var converter = new ValueListEntityPropertyConverter<TEntity, TValue>(Property.Name, Position, GetValue, SliceProvider);

            builder.Add(Property.Name, GetValueInfo(), converter);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            if (Formatting.HasFlag(FormatOptions.Exclude))
                return;

            var formatter = new ValueListEntityPropertyFormatter<TEntity, TValue>(Property, _valueFormatter);

            builder.Add(Position, formatter);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            if (SliceProvider == null)
                yield return this.Error("Must be specified", nameof(SliceProvider));
        }

        ValueList<TValue> GetValue(TextSlice slice)
        {
            return new EntityValueList<TValue>(slice, _valueConverter);
        }

        public IValueConverter<TValue> Converter
        {
            set => _valueConverter = value;
        }

        public IValueFormatter<TValue> Formatter
        {
            set => _valueFormatter = value;
        }
    }
}