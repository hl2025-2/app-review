// ===== BEGIN GENERATED CODE BY ATOS POLARIS AI FOR DEVELOPMENT ON 2025-09-10 16:16:39 ========
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Moq;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcApp;

namespace CalculationTests
{
    public class CalculationTests
    {
        private Calculation calculation;
        [TestInitialize]
        public void Setup()
        {
            calculation = new Calculation();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestAdd_WithInvalidInput_ShouldThrowFormatException()
        {
            // Arrange
            object number1 = 2;
            object number2 = "two";
            // Act
            calculation.Add(number1, number2);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivide_WithZeroDenominator_ShouldThrowDivideByZeroException()
        {
            // Arrange
            object number1 = 2;
            object number2 = 0;
            // Act
            calculation.Divide(number1, number2);
        }

        //private Calculation _calculation;
        //[TestInitialize]
        //public void Setup()
        //{
        //    _calculation = new Calculation();
        //}

        //[TestMethod]
        //[ExpectedException(typeof(FormatException))]
        //public void TestAdd_InvalidInput_ThrowsFormatException()
        //{
        //    // Arrange
        //    int x = 4;
        //    string y = "invalid";
        //    // Act
        //    _calculation.TestAdd(x, y);
        //}

        //[TestMethod]
        //public void TestAdd_ValidInput_ReturnsConcatenatedResult()
        //{
        //    // Arrange
        //    int x = 4;
        //    string y = "12";
        //    // Act
        //    var result = _calculation.TestAdd(x, y);
        //    // Assert
        //    Assert.AreEqual("412", result);
        //}

        //[TestMethod]
        //public void TaxCalc_EmptyCustomerList_NoTaxCalculated()
        //{
        //    // Arrange
        //    var mockCustomerModelList = new List<CustomerModel>();
        //    // Act
        //    var result = _calculation.TaxCalc(mockCustomerModelList);
        //    // Assert
        //    Assert.AreEqual(0, result);
        //}

        //[TestMethod]
        //public void TaxCalc_CustomersInFL_TaxCalculatedCorrectly()
        //{
        //    // Arrange
        //    var mockCustomerModelList = new List<CustomerModel>
        //    {
        //        new CustomerModel
        //        {
        //            State = "FL",
        //            Balance = 100
        //        },
        //        new CustomerModel
        //        {
        //            State = "NY",
        //            Balance = 200
        //        },
        //        new CustomerModel
        //        {
        //            State = "FL",
        //            Balance = 300
        //        }
        //    };
        //    // Act
        //    var result = _calculation.TaxCalc(mockCustomerModelList);
        //    // Assert
        //    Assert.AreEqual(400, result);
        //}

        public string State { get; set; }
        public double Balance { get; set; }
    }
}
// ===== END GENERATED CODE BY ATOS POLARIS AI FOR DEVELOPMENT =====
