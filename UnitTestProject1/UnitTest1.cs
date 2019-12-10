using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using java.sql;
using NUnit.Framework;
using OpenQA.Selenium;
//using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class PR
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        //private string baseURL;
        private bool acceptNextAlert = true;
        

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            //baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void AThePRTest()
        {
            driver.Navigate().GoToUrl("http://172.16.18.106/PAIS_Selenium/");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t23")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep")).Click();
            Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep"))).SelectByText("Admissions");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Institutional Fund");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("hello");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("142536");
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCmt")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCmt")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextCmt")).SendKeys("for test6");
            Task.Delay(2000).Wait();

            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='EQUIPMENT'])[2]/following::a[1]")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_QtyReq_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_QtyReq_0")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_QtyReq_0")).SendKeys("25");
            Task.Delay(2000).Wait();
            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            //acceptNextAlert = true;
            Task.Delay(5000).Wait();

            //String myOrderText = driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/table[2]/tbody[1]/tr[1]/td[1]/div[1]/div[2]/div[1]/div[1]/fieldset[1]/center[1]/div[1]/table[1]/tbody[1]/tr[2]/td[3]")).GetAttribute("");

            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception

            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Do You Want To Continue[\\s\\S]$"));
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void BThePRApprovalTest()
        {
            driver.Navigate().GoToUrl("http://172.16.18.106/PAIS_Selenium/Login.aspx");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu6");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t21"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t21")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();
            acceptNextAlert = true;
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Save"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Save")).Click();
            Task.Delay(2000).Wait();
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Status is in Approval\\.\\.\\.Do You Want To Continue[\\s\\S]$"));
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void CThePRHOIApprovalTest()
        {
            driver.Navigate().GoToUrl("http://172.16.18.106/PAIS_Selenium/Login.aspx");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu2");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t16")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            Task.Delay(2000).Wait();
            
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
