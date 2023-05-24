using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestProject1.src.code.control;

namespace TestProject1.src.code.page
{
    public class LeftSite
    {

        public Button addNewProjectButton = new Button(By.CssSelector("button.plus_add_button"));
        public TextBox projectNameTxtBox = new TextBox(By.CssSelector("p[data-placeholder='Nombre de la tarea']"));
        public Button addButton = new Button(By.CssSelector("button[data-testid='task-editor-submit-button']"));

        public Button subMenuIcon = new Button(By.CssSelector("div[project-name='Nuevo Proyecto de Prueba']"));
        public Button editButton = new Button(By.CssSelector("input[name='name']"));
        public TextBox projectNameEditTxtBox = new TextBox(By.CssSelector("button[data-track='project|update']"));
        public Button saveButton = new Button(By.CssSelector("div[project-name='Proyecto Actualizado']"));

        public Button moreoptions = new Button(By.CssSelector("button[aria-label='Más opciones']"));
        public Button deleteButton = new Button(By.CssSelector("button[data-track='project|delete']"));
        public void ClickProjectName(String nameValue)
        {
            control.Label nameProject = new control.Label(By.XPath("(//ul[@id=\"mainProjectList\"]/li//td[text()='" + nameValue + "'])[last()]"));
            nameProject.Click();
        }

    }
}
