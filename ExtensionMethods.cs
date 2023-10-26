
using System;
using System.Collections.Generic;

namespace CsProfHomeWork6
{
    public static class ExtensionMethods
    {
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {
            float maxVal = float.MinValue;
            T maxItem = null;
            foreach (var item in collection)
            {
                var val = convertToNumber(item);
                if (val > maxVal)
                {
                    maxVal = val;
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
