using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestProject1.src.code.control;

namespace TestProject1.src.code.page
{
    public class LoginSection
    {
        public TextBox emailTxtBox = new TextBox(By.Id("element-0"));
        public TextBox pwdTxtBox = new TextBox(By.Id("element-3"));
        public Button loginButton = new Button(By.XPath("//button[contains(., 'Iniciar sesión')]"));

        public void Login(String user, String pwd)
        {
            emailTxtBox.SetText(user);
            pwdTxtBox.SetText(pwd);
            loginButton.Click();
        }
    }

}
