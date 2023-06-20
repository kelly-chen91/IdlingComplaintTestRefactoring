﻿using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using IdlingComplaintTest.Pages.Login;
using System.Drawing;

namespace IdlingComplaintTest.Tests.Login;

[Parallelizable(ParallelScope.Children)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
/*This is user login verification test
 */

internal class LoginVerificationTest : LoginModel
{
    [SetUp]
    public void SetUp()
    {
        Driver.Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net/login");
        Driver.Manage().Window.Size = new Size(1920, 1200);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }

    //Explicit wait to test user login 
    [Test]
    [Category("Passing Test: Valid Login")]
    public void ExplicitWaitValidLogin()
    {
        //locate login field
        EmailInput = "ttseng@dep.nyc.gov";
        PasswordInput = "Testing1#";
        ClickLoginButton();

        var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10)); //1 - too short
        wait.Until(d => d.FindElement(By.CssSelector("button[routerlink='idlingcomplaint/new']")));
    }

    [Test]
    [Category("Passing Test: Valid Login")]
    public void ImplicitWaitValidLogin()
    {
        //locate login field
        EmailInput = "ttseng@dep.nyc.gov";
        PasswordInput = "Testing1#";
        ClickLoginButton();

        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        var newComplaintButton = Driver.FindElement(By.CssSelector("button[routerlink = 'idlingcomplaint/new']"));
        //Assert.That(GetDriver().FindElement(By.CssSelector("button[routerlink='idlingcomplaint/new']")), !Is.Null);
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        Assert.IsNotNull(newComplaintButton);

    }

    //Explicit wait to test user login 
    [Test]
    [Category("Failed Test: Invalid Login")]
    public void ExplicitWaitInvalidLogin()
    {
        //locate login field
        //EmailInput = "ttseng@dep.nyc.gov";
        //PasswordInput = "Testing1";
        //ClickLoginButton();
        //
        //var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10)); //1 - too short
        //wait.Until(d => d.FindElement(By.CssSelector("button[routerlink = 'idlingcomplaint/new']")));
        //locate login field
        EmailInput = "ttseng@dep.nyc.gov";
        PasswordInput = "Testing1";
        ClickLoginButton();
        var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10)); //1 - too short
        wait.Until(d => d.FindElement(By.TagName("simple-snack-bar")));
    }

    //Email/Password does not match
    [Test]
    [Category("Failed Test: Invalid Login")]
    public void ImplicitWaitInvalidLogin()
    {
        //locate login field
        //EmailInput = "ttseng@dep.nyc.gov";
        //PasswordInput = "Testing1";
        //ClickLoginButton();
        //
        //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        //var newComplaintButton = Driver.FindElement(By.CssSelector("button[routerlink = 'idlingcomplaint/new']"));
        //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        //Assert.IsNull(newComplaintButton);

        //locate login field
        EmailInput = "ttseng@dep.nyc.gov";
        PasswordInput = "Testing1";
        ClickLoginButton();
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        var invalidLoginButton = Driver.FindElement(By.TagName("simple-snack-bar")); //text is in span
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        Assert.IsNotNull(invalidLoginButton);
        Assert.That(invalidLoginButton.Text.Trim(), Is.EqualTo("Email and password do not match."));
        //Assert.That(invalidLoginButton.Text.Trim(), Is.EqualTo("Email and password do not match.\r\nx"));
    }

}
