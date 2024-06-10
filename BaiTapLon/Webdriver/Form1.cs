using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Webdriver
{
    public partial class Form1 : Form
    {
        IWebDriver driver = null;
        ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();

        public Form1()
        {
            InitializeComponent();
            chrome.HideCommandPromptWindow = true;
            driver = new ChromeDriver(chrome);
        }

        private void AS_14_VoLeHau_Click(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("https://www.artstation.com");

            IWebElement sign_in_button = driver.find_element(By.CSS_SELECTOR, "a.menu-item-signin");
        }
    }
}
