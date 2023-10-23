
using System;
using System.Collections.Generic;

namespace CsProfHomeWork6
{
    public static class ExtensionMethods
    {
        public static T GetMax<T>(this IEnumerable<T> e, Func<T, float> getParameter) where T : class
        {
            T maxItem = null;
            float maxParameter = float.MinValue;

            foreach (T item in e)
            {
                float parameter = getParameter(item);
                if (parameter > maxParameter)
                {
                    maxParameter = parameter;
                    maxItem = item;
                }
            }

            return maxItem;
        }
    }
    public class FloatWrapper
    {
        public float Value { get; }

        public FloatWrapper(float value)
        {
            Value = value;
        }
    }
}
