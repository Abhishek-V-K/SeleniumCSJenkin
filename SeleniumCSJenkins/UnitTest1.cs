using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SeleniumTestProject1.start
{
    public class Ex18_HandleKeys
    {



        IWebDriver driver;
        string url = "https://the-internet.herokuapp.com/key_presses";




        [Test]
        public void Test1()
        {

            driver = new ChromeDriver();

            driver.Url = url;



            Thread.Sleep(2000);



            Actions action = new Actions(driver);



            //perform --> performing one key operation
            action.SendKeys(Keys.ArrowDown).Perform();
            IWebElement ele = driver.FindElement(By.Id("result"));
            string text = ele.Text;



            Assert.That(text, Is.EqualTo("You entered: DOWN"));



            Console.WriteLine(text);

            Thread.Sleep(1000);



            driver.Quit();




        }

    }
}
