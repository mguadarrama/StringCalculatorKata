using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringCalculatorKata
{
    public class StringCalculatorTest
    {

        [Fact]
        public void Add_WithEmptyString_ReturnZero()
        {
            var result = Add("");
            Assert.Equal(0,result);
        }

        [Fact]
        public void Add_WithOneNumber_ReturnsNumber()
        {
            var result = Add("1");
            Assert.Equal(1,result);
        }
        [Fact]
        public void Add_MultipleNumbersSeparatedByDelimiter_ReturnSum()
        {
            var result = Add("1,2");
            Assert.Equal(3, result);

           
        }




        public int Add(string value)
        {
            var result = new StringCalculator().Add(value);
            return result;
        }
        

    }
}

