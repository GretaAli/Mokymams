using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;


namespace SeleniumTemplate
{
    [Binding]
    public class StepDefinition
    {
        private PageObject _pageObject;
        public PageObject PageObject => _pageObject ?? (_pageObject = new PageObject());
        public static IWebDriver Driver;
        public class Browser 

        {
            public IWebDriver Chrome;

            public Browser()
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                Chrome = new ChromeDriver(options);
            }
        }

        public StepDefinition(Browser browser)
        {
            Driver = browser.Chrome;
            PageFactory.InitElements(Driver, PageObject);
        }

        [Given(@"I navigate to claims")]
        public void GivenINavigateToClaims()
        {
            Driver.Url = "https://claim.skycop.com/";
            
        }
        [Then(@"I set Kaunas as departure airport")]
        public void ThenISetKaunasAsDepartureAirport()
        {
            Thread.Sleep(5000);
            PageObject.departureAirportField.SendKeys(Constants.departureAirport);
            Thread.Sleep(1000);
            PageObject.kaunasSelection.Click();
        }
        [Then(@"I set London Gatwick as arrival airport")]
        public void ThenISetLondonGatwickAsArrivalAirport()
        {
            Thread.Sleep(5000);
            PageObject.arrivalAirportField.SendKeys(Constants.arrivalAirport);
            Thread.Sleep(1000);
            PageObject.gatwickSelection.Click();
        }
        [Then(@"I select airlines")]
        public void ThenISelectAirlines()
        {
           
          PageObject.airlinesField.SendKeys(Constants.airlinesField);
           Thread.Sleep(4000);
            PageObject.airlineSelection.Click();
        
        }
        [Then(@"I select flight number")]
        public void ThenISelectFlightNumber()
        {
            var flightNumberField = Driver.FindElement(By.XPath("//input[@name='failedFlightNumberDigits']"));
            flightNumberField.SendKeys("100");
            Thread.Sleep(4000);
            var flightNumberSelection = Driver.FindElement(By.XPath("//input[@value='100']"));
            flightNumberSelection.Click();
        }
        [Then(@"I select flight date")]
        public void ThenISelectFlightDate()
        {
            var flightDateField = Driver.FindElement(By.XPath("//input[@placeholder='Date']"));
            flightDateField.Click();
            Thread.Sleep(4000);
            var flightDateSelection = Driver.FindElement(By.XPath("//td[@data-value='16']"));
            flightDateSelection.Click();
        }
        [Then(@"I select flight problem")]
        public void ThenISelectFlightProblem()
        {
            Thread.Sleep(4000);
            var flightProblemField = Driver.FindElement(By.XPath("(//label[@class='mobile-mb-15 js-checkable sc-eqIVtm buildE'])[1]"));
            flightProblemField.Click();
            


        }
        [Then(@"I select delay duration")]
        public void ThenISelectDelayDuration()
        {
            Thread.Sleep(4000);
            var delayDurationField = Driver.FindElement(By.XPath("(//label[@class='mobile-mb-15 js-checkable sc-eqIVtm buildE'])[5]"));
            delayDurationField.Click();

        }
        [Then(@"I choose reason provided by airlines")]
        public void ThenIChooseReasonProvidedByAirlines()
        {
            Thread.Sleep(2000);
            var reasonByAirlinesField = Driver.FindElement(By.XPath("//span[@id='react-select-6--value']"));
            reasonByAirlinesField.Click();
            Thread.Sleep(2000);
            var badWeatherSelection = Driver.FindElement(By.XPath("//div[text()='Bad weather conditions']"));
            badWeatherSelection.Click();
        }
        [Then(@"I choose where did I hear about them")]
        public void ThenIChooseWhereDidIHearAboutThem()
        {
            Thread.Sleep(2000);
            var whereHearField = Driver.FindElement(By.XPath("//span[@id='react-select-7--value']"));
            whereHearField.Click();
            Thread.Sleep(2000);
            var facebookSelection = Driver.FindElement(By.XPath("//div[text()='Facebook']"));
            facebookSelection.Click();
        }
        [Then(@"I select next step")]
        public void ThenISelectNextStep()
        {
            Thread.Sleep(4000);
            var nextStepButton = Driver.FindElement(By.XPath("//button[@type='submit']"));
            nextStepButton.Click();
        }
        [Then(@"I describe situation")]
        public void ThenIDescribeSituation()
        {
            Thread.Sleep(2000);
            var descriptionField = Driver.FindElement(By.XPath("//textarea[@class='form-control sc-dUjcNx eiJlti']"));
            descriptionField.SendKeys("Kas buvo - prazuvo");
           
        }
        [Then(@"I enter reservation number")]
        public void ThenIEnterReservationNumber()
        {
            var flightReservationNumberField = Driver.FindElement(By.XPath("//input[@name='bookingNumber']"));
            flightReservationNumberField.SendKeys("a1234a");
            Thread.Sleep(4000);
            var flightReservationNumberSelection = Driver.FindElement(By.XPath("//input[@value='A1234A']"));
            flightReservationNumberSelection.Click();
        }

        [Then(@"I enter travellers details")]
        public void ThenIEnterTravellersDetails()
        {
            Thread.Sleep(4000);
            var travellersDetailButton = Driver.FindElement(By.XPath("//button[@type='submit']"));
            travellersDetailButton.Click();
        }
        [Then(@"I enter name")]
        public void ThenIEnterName()
        {
            Thread.Sleep(2000);
            var nameField = Driver.FindElement(By.XPath("//input[@name='userName']"));
            nameField.SendKeys("Vardenis");
        }
        [Then(@"I enter surname")]
        public void ThenIEnterSurname()
        {
            Thread.Sleep(2000);
            var surnameField = Driver.FindElement(By.XPath("//input[@name='userSurname']"));
            surnameField.SendKeys("Pavardenis");
        }
        [Then(@"I enter birthdate")]
        public void ThenIEnterBirthdate()
        {
            var birthdayField = Driver.FindElement(By.XPath("//input[@placeholder='Enter birthdate']"));
            birthdayField.Click();
            Thread.Sleep(4000);
            var birthyearSelection = Driver.FindElement(By.XPath("//td[@data-value='1990'] "));
            birthyearSelection.Click();
            var birthmonthSelection = Driver.FindElement(By.XPath("//td[@data-value='11'] "));
            birthmonthSelection.Click();
            var birthdaySelection = Driver.FindElement(By.XPath("//td[@data-value='11'] "));
            birthdaySelection.Click();
        }
        [Then(@"I enter e-mail")]
        public void ThenIEnterE_Mail()
        {
            Thread.Sleep(2000);
            var emailField = Driver.FindElement(By.XPath("//input[@name='userEmail']"));
            emailField.SendKeys("labas@labas.com");
        }
        [Then(@"I re-enter e-mail")]
        public void ThenIRe_EnterE_Mail()
        {
            var repeatEmailField = Driver.FindElement(By.XPath("//input[@name='repeatEmail']"));
            repeatEmailField.SendKeys("labas@labas.com");
        }
        [Then(@"I enter mobile phone")]
        public void ThenIEnterMobilePhone()
        {
            var numberCodeField = Driver.FindElement(By.XPath("//input[@name='userPhoneCode']"));
            numberCodeField.Click();
            Thread.Sleep(2000);
            var numberCodeSelection = Driver.FindElement(By.XPath("//div[text()='+370']"));
            numberCodeSelection.Click();
            var phoneField = Driver.FindElement(By.XPath("//input[@name='userPhone']"));
            phoneField.SendKeys("62649762");
        }
        [Then(@"I enter adress")]
        public void ThenIEnterAdress()
        {
            var addressField = Driver.FindElement(By.XPath("//input[@name='userAddress']"));
            addressField.SendKeys("Neziniuku gatve 15");
        }
        [Then(@"I enter city")]
        public void ThenIEnterCity()
        {
            var cityField = Driver.FindElement(By.XPath("//input[@name='userCity']"));
            cityField.SendKeys("Neziniavilis");
        }
        [Then(@"I enter postcode")]
        public void ThenIEnterPostcode()
        {
            var postCodeField = Driver.FindElement(By.XPath("//input[@name='userPostCode']"));
            postCodeField.SendKeys("43214");
        }
        [Then(@"I choose country")]
        public void ThenIChooseCountry()
        {
            var countryField = Driver.FindElement(By.XPath("(//div[@class='Select-placeholder'])[2]"));
            countryField.Click();
            var countrySecondField = Driver.FindElement(By.XPath("//span[@id='react-select-10--value']//input[@class='Select-input']"));
            countrySecondField.SendKeys("Lithuania");
            Thread.Sleep(2000);
            var countrySelection = Driver.FindElement(By.XPath("//div[text()='Lithuania']"));
            countrySelection.Click();
        }
        [Then(@"I choose language")]
        public void ThenIChooseLanguage()
        {
            var languageField = Driver.FindElement(By.XPath("(//div[@class='Select-placeholder'])[2]"));
            languageField.Click();
            Thread.Sleep(2000);
            var Lietuvių = Driver.FindElement(By.XPath("//div[@id='react-select-11--option-5']"));
            Lietuvių.Click();
        }
        [Then(@"I choose trevellers number")]
        public void ThenIChooseTrevellersNumber()
        {
            Thread.Sleep(4000);
            var travellersNumbersButton = Driver.FindElement(By.XPath("//button[@type='travellingAlone']"));
            travellersNumbersButton.Click();
        }

    }
}