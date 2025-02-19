using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Lab_8
{
    public class ArrayUtilsTests
    {
        [Fact]
        public void TestFindMax()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int result = ArrayUtils.FindMax(arr);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestFindMin()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int result = ArrayUtils.FindMin(arr);
            Assert.Equal(1, result);
        }
    }

}
