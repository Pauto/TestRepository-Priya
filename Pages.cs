using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime.InteropServices;
using OpenQA.Selenium;
namespace Framework.Pages
{
    //[SerializableAttribute]
    //[ComVisibleAttribute(true)]
    //public sealed class TypeInitializationException : SystemException
    //{
    //}

    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static LogInHomePage Home
        {
            get { return GetPage<LogInHomePage>(); }
        }
    }
}
