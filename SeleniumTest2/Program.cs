using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace SeleniumTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            //By @by = By.XPath("//a[@class='v-btn v-btn--flat v-btn--router v-btn--text theme--light v-size--default accent--text']");

            // IWebDriver driver = new FirefoxDriver();
            // driver.Navigate().GoToUrl("https://revifast.onrender.com/");
            // //driver.Manage().Window.Maximize();
            //
            // IWebElement btnFaq = driver.FindElement(By.LinkText("FAQ"));
            // btnFaq.Click();
            // driver.Close();
            //
            // IWebDriver driver2 = new FirefoxDriver();
            // driver2.Navigate().GoToUrl("https://revifast.onrender.com/");
            // IWebElement btnAfiliados = driver.FindElement(By.LinkText("AFILIADOS"));
            // btnAfiliados.Click();
            // driver2.Close();
            
            // IWebDriver driver21 = new FirefoxDriver();
            // driver21.Navigate().GoToUrl("https://revifast.onrender.com/");
            // IWebElement btnAfiliados = driver.FindElement(By.LinkText("PROMOCIONES"));
            // btnAfiliados.Click();
            // driver21.Close();

            IWebDriver driver3 = new FirefoxDriver();
            driver3.Navigate().GoToUrl("https://revifast.onrender.com/");
            IWebElement reservation = driver3.FindElement(By.LinkText("RESERVAR AHORA"));
            reservation.Click();
            
            IWebElement name = driver3.FindElement(By.Id("input-125"));
            name.SendKeys("Richard");
            
            IWebElement lastname = driver3.FindElement(By.Id("input-128"));
            lastname.SendKeys("Cancino");
            
            IWebElement dni = driver3.FindElement(By.Id("input-131"));
            dni.SendKeys("77433995");
            
            IWebElement phone = driver3.FindElement(By.Id("input-134"));
            phone.SendKeys("951329740");
            
            IWebElement email = driver3.FindElement(By.Id("input-137"));
            email.SendKeys("richard.cancinov@gmail.com");
            
            IWebElement btnNext = driver3.FindElement(By.XPath("//button[@type='button'][@class='v-btn v-btn--contained theme--light v-size--default primary']"));
            btnNext.Click();
            
            IWebElement placa = driver3.FindElement(By.Id("input-155"));
            placa.SendKeys("100-ABC");
            
            IWebElement color = driver3.FindElement(By.Id("input-158"));
            color.SendKeys("Azul Hierro");
            
            IWebElement dateFabrication = driver3.FindElement(By.Id("input-161"));
            dateFabrication.SendKeys("2020-11-28");
            
            IWebElement search = driver3.FindElement(By.Id("input-193"));
            search.SendKeys("Jesus");
            
            driver3.Close(); // TODO = Finish the process 

            // IWebElement btnNext2= driver3.FindElement(By.XPath("//button[@type='button'][@class='v-btn v-btn--contained theme--light v-size--default primary']"));
            // btnNext2.Click();
            
            // IWebElement btnNext3 = driver3.FindElement(By.XPath("//button[@type='button'][@class='v-btn v-btn--contained theme--light v-size--default primary']"));
            // btnNext3.Click();
            
            // IWebElement parcial = driver3.FindElement(By.Id("input-241"));
            // parcial.SendKeys("1 - Parcial");
            
            // IWebElement btnEnd = driver3.FindElement(By.XPath("//button[@type='button'][@class='v-btn v-btn--contained theme--light v-size--default primary']"));
            // btnEnd.Click();
        }
    }
}