using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class LogInHomePage
    {
        public void Name()
        {
            IWebElement name = Browser.Driver.FindElement(By.XPath(".//*[@id='FirstNameLabel']"));
            Console.WriteLine(name.Text);
            if (name.Text.Equals("Pia"))
            {
                Console.WriteLine("Test Passed");
            }else
            {
                Console.WriteLine("Test Failed");
            }
        }
        public void Shop()
        {
            IWebElement shop = Browser.Driver.FindElement(By.XPath(".//*[@id='shop-menu-link']"));
            //shop.Click();
            Console.WriteLine(shop.Text);
        }

        public void Brand()
        {
            IWebElement brand = Browser.Driver.FindElement(By.XPath(".//*[@id='brands-menu-link']"));
            //brand.Click();
            Console.WriteLine(brand.Text);
        }

        public void Deals()
        {
            IWebElement deals = Browser.Driver.FindElement(By.XPath(".//*[@id='deals-menu-link']"));
            //deals.Click();
            Console.WriteLine(deals.Text);
        }
        public void Services()
        { 
            IWebElement services = Browser.Driver.FindElement(By.XPath(".//*[@id='services-menu-link']"));
            //services.Click();
            Console.WriteLine(services.Text);
        }
    }
}
