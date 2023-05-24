using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestProject1.src.code.control;

namespace TestProject1.src.code.page
{
    public class MainPage
    {
        public Button loginButton = new Button(By.LinkText("Iniciar sesión"));

        //public Button loginButton = new Button(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]"));
    }
}
