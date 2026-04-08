using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; // Ensure NUnit is referenced

namespace PageFactoryTests_NUnit3
{
    public class BmiCalcTests
    {
        [TestCase]
        public void TestBmiCalculator()
        {
            BmiCalcPage bmiCalcPage = new BmiCalcPage();
            bmiCalcPage.Load();
            // Assert.IsTrue(bmiCalcPage.IsLoaded);
            Thread.Sleep(2000);
            bmiCalcPage.CalculateBmi("181", "80");
            Thread.Sleep(2000);
            Assert.IsTrue(bmiCalcPage.Bmi.Contains("24.4"));
            //Assert.AreEqual("Normal", bmiCalcPage.BmiCategory);
            bmiCalcPage.Close();
        }
    }
}
