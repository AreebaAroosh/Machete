﻿namespace Machete.Layouts
{
    using System;


    /// <summary>
    /// A missing value array is used when the source fragment is missing.
    /// </summary>
    /// <typeparam name="TLayout">The value type</typeparam>
    public class MissingLayoutList<TLayout> :
        LayoutList<TLayout>
        where TLayout : Layout
    {
        public Type LayoutType => typeof(TLayout);
        public bool HasValue => false;
        
        public Layout<TLayout> this[int index] => throw new ValueMissingException("The layout is missing.");

        bool LayoutList<TLayout>.TryGetValue(int index, out Layout<TLayout> value)
        {
            throw new ValueMissingException("The layout is missing.");
        }
    }
}