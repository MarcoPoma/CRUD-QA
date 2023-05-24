using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.src.code.page;

namespace TestProject1.src.code.test
{
    //[TestClass]
    public class LoginTest : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        MenuSection menuSection = new MenuSection();

        [TestMethod]
        public void VerifyTheLoginIsSuccessfuly2()
        {
            mainPage.loginButton.Click();
            loginSection.emailTxtBox.SetText("marcopoma943@gmail.com");
            loginSection.pwdTxtBox.SetText("marcopoma23");
            loginSection.loginButton.Click();

            Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(),
                "ERROR !! the login was not successfully, review credentials please");
        }

    }
}
