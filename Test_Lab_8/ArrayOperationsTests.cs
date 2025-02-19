using Lab_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Lab_8
{
    [TestClass]
    public class ArrayOperationsTests
    {
        private ArrayOperations? _arrayOperations;

        [TestInitialize]
        public void SetUp()
        {
            _arrayOperations = new ArrayOperations();
        }

        [TestMethod]
        public void TestFindMax()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = _arrayOperations.FindMax(numbers);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestFindMin()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = _arrayOperations.FindMin(numbers);
            Assert.AreEqual(1, result);
        }
    }

}
