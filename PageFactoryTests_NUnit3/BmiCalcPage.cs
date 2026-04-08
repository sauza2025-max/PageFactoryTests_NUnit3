using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace PageFactoryTests_NUnit3
{
    public class BmiCalcPage
    {
        static string Url = "https://practice.expandtesting.com/bmi";
        private static string Title = "BMI Calculator";

        private IWebDriver driver;

        public BmiCalcPage()
        {
            driver = new ChromeDriver();
        }

        public void Load()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void Close()
        {
            driver.Close();
        }

        public bool IsLoaded
        {
            get { return driver.Title.Equals(Title); }
        }

        public void CalculateBmi(String height, String weight)
        {
            driver.FindElement(By.Id("height")).Clear();
            driver.FindElement(By.Id("height")).SendKeys(height);
            driver.FindElement(By.Id("weight")).Clear();
            driver.FindElement(By.Id("weight")).SendKeys(weight);
            driver.FindElement(By.ClassName("btn-primary")).Click();
        }

        public String Bmi
        {
            get { return driver.FindElement(By.Id("BMI")).Text.ToString(); }
        }

        //public String BmiCategory
        //{
        //    get { return driver.FindElement(By.Name("bmi_category")).GetAttribute("value"); }
        //}
    }
}