using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace StringCalculatorKata
{
    public interface IStringCalculator
    {
        int Add(string valueString);
    }

    public class StringCalculator : IStringCalculator
    {
        private string value;
        private readonly List<char> delimiters = new List<char>{','};
        public int Add(string valueString)
        {
            var result = CalculateSum(valueString);
            return result;
        }

        private int CalculateSum(string valueString)
        {
            var sum = 0;
            value = valueString;
            HandleEmptyValue();
            ExtractValue().ForEach(val=> sum += val);
            return sum;
        }

        private List<int> ExtractValue()
        {
            var values = new List<int>();
            Array.ForEach(value.Split(delimiters.ToArray()), 
                ExtractValue(values));

            return values;
        }

        private Action<string> ExtractValue(List<int> values)
        {
            return s =>
            {
                var number = int.Parse(s);
                values.Add(number);
            };
        }


        private void HandleEmptyValue()
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                value = "0";
            }
        }
    }
}