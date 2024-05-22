using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using NUnitLite;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework.Legacy;

public class AlloWebsiteTests
{
    private IWebDriver driver;
    private WebDriverWait wait;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // Implicit wait
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(25)); // Explicit wait
    }

    [TearDown]
    public void Teardown()
    {
        driver.Quit();
    }

    [Test]
    public void ComplexInteractions()
    {
        // Navigate to the website
        driver.Navigate().GoToUrl("https://allo.ua");

        // Find the search input using different locators
        IWebElement searchInputById = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("search-form__input")));//1

        // Type in the search input
        searchInputById.SendKeys("iPhone");//1

        IWebElement searchButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"__layout\"]/div/header/div[1]/div[2]/div[3]/form/button[2]")));//2
        searchButton.Click();//1

        // Wait for search results
        IWebElement searchResults = wait.Until(ExpectedConditions.ElementExists(By.CssSelector(".v-catalog__products")));//3

        IWebElement firstProductImage = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("product-card__img")));//4
        Actions actions = new Actions(driver);
        actions.MoveToElement(firstProductImage).Click().Perform();//1
        /////////////////////////
        IWebElement searchInputByName = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("search")));//5
        searchInputByName.SendKeys("Laptop");
        searchButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"__layout\"]/div/header/div[1]/div[2]/div[3]/form/button[2]")));
        searchButton.Click();
        IWebElement searchthis1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"__layout\"]/div/div[1]/div[2]/div/div[1]/aside/section/div[1]/div[2]/div/div/a[1]")));
        searchthis1.Click();
        ///////////////////////////
        searchButton = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ct-button")));
        searchButton.Click();
        IWebElement listeditem = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"js-menu-wrapper\"]/div/ul/li[2]")));
        actions.MoveToElement(listeditem).Perform();
        listeditem = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"js-menu-wrapper\"]/div/ul/li[2]/div/mmc[1]/mms[1]/mmss/a[1]")));
        listeditem.Click();
        ///////////////////////////
        listeditem = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("sort-by__current")));
        actions.MoveToElement(listeditem).Perform();
        IWebElement filtr = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__layout\"]/div/div[1]/div[2]/div/div[2]/div[1]/div[1]/div[1]/div/ul/li[5]")));

    }

    //[Test]
    //public void ComplexInteractions()
    //{
    //    // Navigate to the website
    //    driver.Navigate().GoToUrl("https://allo.ua");

    //    // Perform some complex interactions (e.g., hover over an element)
    //    IWebElement navMenu = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".nav-menu")));
    //    Actions actions = new Actions(driver);
    //    actions.MoveToElement(navMenu).Perform();

    //    // Wait for sub-menu to appear
    //    IWebElement subMenu = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".sub-menu")));

    //    // Assertion
    //    ClassicAssert.IsTrue(subMenu.Displayed);
    //}

    // Add more tests for other interactions as needed
}