using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace RPA2_HIGHQUALITY
{
    class Program
    {

        static void wait(int tiempo)
        {
            System.Threading.Thread.Sleep(tiempo);
        }


        static void Main(string[] args)
        
        {
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", @"C:\Users\erick\Downloads");
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.gmail.com/mail/help/intl/es/about.html?iframe");
            driver.Manage().Window.Maximize();

            /*
            wait(1000);
            IWebElement create = driver.FindElement(By.Id("gmail-create-account"));
            create.Click();

            wait(1000);
            IWebElement name = driver.FindElement(By.Name("firstName"));
            name.SendKeys("HIGH");

            wait(1000);
            IWebElement lastname = driver.FindElement(By.Name("lastName"));
            lastname.SendKeys("QUALITY");

            wait(1000);
            IWebElement username = driver.FindElement(By.Id("username"));
            username.SendKeys("GROUPHIGHQUALITY");

            IWebElement password = driver.FindElement(By.Name("Passwd"));
            password.SendKeys("hac2u3rYL");

            wait(1000);
            IWebElement cpassword = driver.FindElement(By.Name("ConfirmPasswd"));
            cpassword.SendKeys("hac2u3rYL");

            wait(3000);
            IWebElement inicio = driver.FindElement(By.XPath("//*[@id='accountDetailsNext']/div/button"));
            inicio.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            wait(3000);
            IWebElement phone = driver.FindElement(By.XPath("//*[@id='phoneNumberId']"));
            phone.SendKeys("8297843334");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            wait(3000);
            IWebElement next = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button"));
            next.Click();

            wait(3000);
            IWebElement verifycode = driver.FindElement(By.XPath("//*[@id='code']"));
            verifycode.SendKeys("881355");

            wait(1000);
            IWebElement dia = driver.FindElement(By.XPath("//*[@id='day']"));
            dia.SendKeys("21");

            wait(1000);
            IWebElement mes = driver.FindElement(By.XPath("//*[@id='month']"));
            mes.SendKeys("Noviembre");

            wait(1000);
            IWebElement anio = driver.FindElement(By.XPath("//*[@id='year']"));
            anio.SendKeys("2000");

            wait(1000);
            IWebElement sexo = driver.FindElement(By.XPath("//*[@id='gender']"));
            sexo.SendKeys("Hombre");
            */

            wait(1000);
            IWebElement Iniciar = driver.FindElement(By.Id("gmail-sign-in"));
            Iniciar.Click();

            wait(1000);
            IWebElement correo = driver.FindElement(By.XPath("//*[@id='identifierId']"));
            correo.SendKeys("g800highquality@gmail.com");

            wait(3000);
            IWebElement siguiente = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button"));
            siguiente.Click();

            wait(1000);
            IWebElement password = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input"));
            password.SendKeys("qsYOBeZO%*6m");

            wait(3000);
            IWebElement siguiente2 = driver.FindElement(By.XPath("//*[@id='passwordNext']/div/button"));
            siguiente2.Click();

            wait(3000);
            IWebElement redactar = driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[1]/div[1]/div/div/div/div[1]/div/div"));
            redactar.Click();

            wait(1000);
            IWebElement destinatario = driver.FindElement(By.XPath("//*[@id=':9q']"));
            destinatario.SendKeys("e.grullon12@unapec.edu.do");

            wait(3000);
            IWebElement adjuntar = driver.FindElement(By.XPath("//*[@id=':as']/div/div"));
            adjuntar.Click();

            /*
            wait(1000);
            IWebElement search = driver.FindElement(By.XPath("//input[@type='file']"));
            search.SendKeys("Untitled Diagram.drawio (6).png");

            */

            wait(1000);
            driver.Navigate().GoToUrl("https://www.google.com/intl/es/drive/");
            driver.Manage().Window.Maximize();

            wait(3000);
            IWebElement ir = driver.FindElement(By.XPath("/html/body/main/section/section[1]/div/div[1]/div/div[2]/a[1]"));
            ir.Click();

            /*
            wait(3000);
            IWebElement subir = driver.FindElement(By.XPath("/html/body/div[3]/div/div[3]/div/button[1]"));
            subir.Click();
            */

        }

    }
}
 