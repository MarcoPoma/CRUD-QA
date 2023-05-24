using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.src.code.control
{
    public class Button : ControlSelenium
    {
        public Button(By locator) : base(locator)
        { }
    }
}
