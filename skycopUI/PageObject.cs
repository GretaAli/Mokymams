using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTemplate
{
    public class PageObject
    {
        [FindsBy(How = How.XPath, Using = "//input[@class='Select-input']")]
        public IWebElement DeparturePort;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[1]")]
        public IWebElement departureAirportField;


        [FindsBy(How = How.XPath, Using = "//div[@title='Kaunas International Airport']")]
        public IWebElement kaunasSelection;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[2]")]
        public IWebElement arrivalAirportField;

        [FindsBy(How = How.XPath, Using = "//div[@title='London Gatwick Airport']")]
        public IWebElement gatwickSelection;


        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[3]")]
        public IWebElement airlinesField;


        [FindsBy(How = How.XPath, Using = "//div[@title='Ryanair']")]
        public IWebElement airlineSelection;


    }
}
