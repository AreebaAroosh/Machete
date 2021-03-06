﻿namespace Machete.TranslatorConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Configuration;
    using Translators.PropertyTranslators;


    public class SetValuePropertyTranslatorSpecification<TResult, TValue, TInput, TSchema> :
        PropertyTranslatorSpecification<TResult, Value<TValue>, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        readonly SetValueProvider<TInput, TSchema, TValue> _valueProvider;

        public SetValuePropertyTranslatorSpecification(Expression<Func<TResult, Value<TValue>>> propertyExpression, SetValueProvider<TInput, TSchema, TValue> valueProvider) :
            base(propertyExpression)
        {
            _valueProvider = valueProvider;
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            return Enumerable.Empty<ValidateResult>();
        }

        public override void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            var translator = new ValueInputPropertyTranslator<TResult, TValue, TInput, TSchema>(ResultPropertyInfo, InputPropertyInfo, _valueProvider);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}