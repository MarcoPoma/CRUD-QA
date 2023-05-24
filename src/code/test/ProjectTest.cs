using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestProject1.src.code.page;

namespace TestProject1.src.code.test
{
    [TestClass]
    public class ProjectTest : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        MenuSection menuSection = new MenuSection();
        LeftSite leftSite = new LeftSite();



        [TestMethod]
        public void VerifyCRUDProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("marcopoma943@gmail.com", "marcopoma23");
            loginSection.loginButton.Click();
            loginSection.loginButton.Click();
            
           
            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText("asd");
            leftSite.addButton.Click();


            leftSite.ClickProjectName("asd");
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            leftSite.projectNameEditTxtBox.SetText("MojixUpdateddddd");
            leftSite.saveButton.Click();

            leftSite.moreoptions.Click();
            leftSite.deleteButton.Click();

            

            Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(),
                "ERROR !! the login was not successfully, review credentials please");
            // add verificacion
            //Assert.IsTrue(leftSite.ProjectNameIsDisplayed("Mojix909090"), "ERROR!The project was not created");
        }
    }
}
