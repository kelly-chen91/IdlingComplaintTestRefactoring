using IdlingComplaintTest.Pages.Login;
using IdlingComplaintTest.Pages.Register;
using IdlingComplaintTest.Setup;
using IdlingComplaintTest.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdlingComplaintTest.Tests.Register
{
    [Parallelizable(ParallelScope.Children)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    internal class RegistrationErrorTests : RegisterModel
    {

        //  [OneTimeSetUp]
        //  public new void OneTimeSetUp()
        //  {
        //      base.OneTimeSetUp();
        //  }
        //
        //  [OneTimeTearDown]
        //  public new void OneTimeTearDown()
        //  {
        //      base.OneTimeTearDown();
        //  }
        [SetUp]
        public void SetUp()
        {
      
            Driver.Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net/profile");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }


        public void ValidEmailTest()
       {
           //Boolean validEmail = registerModel.IsValidEmail("kchen@dep");
           //Console.WriteLine(validEmail);
           //Console.WriteLine(validEmail);
           /* The program does not test for valid email addresses */
   
       }
   
       public void ValidZipCodeTest()
       {
           /* The program does not test for valid zip code upon entry */
       }
   
       public void ValidPhoneNumberTest()
       {
           //Console.WriteLine(registerModel.IsValidPhoneNumber("917770-0000"));
           /* The program does not test for valid phone numbers */
       }

        /*Tests for error when first name field is empty*/
        [Test]
        [Category("Passing Test: Required Empty Fields Label Test")]
        public void RequiredFirstNameTest()
        {
            FirstNameControl.SendKeys(Keys.Return);
            string error = Driver.ExtractTextFromXPath("//mat-card-content/div[1]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        [Test]
        [Category("Passing Test: Required Empty Fields Label Test")]
        public void RequiredLastNameTest()
           {
            LastNameControl.SendKeys(Keys.Return);
            string error = Driver.ExtractTextFromXPath("//mat-card-content/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
               Assert.That(error, Is.EqualTo(Constants.REQUIRED));
           }
       
           /*Tests for error when email field is empty*/
           [Test]
        [Category("Passing Test: Required Empty Fields Label Test")]
        public void RequiredEmailTest()
           {
            EmailControl.SendKeys(Keys.Return);
            string error = Driver.ExtractTextFromXPath("//mat-card-content/div[3]/mat-form-field/div/div[3]/div/mat-error/text()");
               Assert.That(error, Is.EqualTo(Constants.REQUIRED));
           }
       
           /*Tests for error when password field is empty*/
           [Test]
        [Category("Passing Test: Required Empty Fields Label Test")]
        public void RequiredPasswordTest()
           {
            PasswordControl.SendKeys(Keys.Return);
            string error = Driver.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[1]/mat-form-field/div/div[3]/div/mat-error/text()");
               Assert.That(error, Is.EqualTo(Constants.PASSWORD_REQUIRED));
           }
       
           /*Tests for error when confirm password field is empty*/
           [Test]
        [Category("Passing Test: Required Empty Fields Label Test")]
        public void RequiredConfirmPasswordTest()
           {
            ConfirmPasswordControl.SendKeys(Keys.Return);
            string error = Driver.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
               Assert.That(error, Is.EqualTo(Constants.CONFIRM_PASSWORD_REQUIRED));
           }
       
           /*Tests for error when security question field is empty*/
           [Test]
        [Category("Passing Test: Required Empty Fields Label Test")]
        public void RequiredSecurityQuestionTest()
           {
         
            SelectSecurityQuestion(0);
            string error = Driver.ExtractTextFromXPath("//mat-card-content/div[4]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
               Assert.That(error, Is.EqualTo(Constants.REQUIRED));
         
           }
       
           /*Tests for error when security answer field is empty*/
           [Test]
        [Category("Passing Test: Required Empty Fields Label Test")]
        public void RequiredSecurityAnswerTest()
           {
            SecurityAnswerControl.SendKeys(Keys.Return);
            string error = Driver.ExtractTextFromXPath("//mat-card-content/div[4]/div[3]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(Constants.REQUIRED));
            }
        
            /*Tests for error when address1 field is empty*/
            [Test]
             [Category("Passing Test: Required Empty Fields Label Test")]
             public void RequiredAddress1Test()
            {
            
                  Address1Control.SendKeys(Keys.Return);
                string error = Driver.ExtractTextFromXPath("//mat-card-content/div[5]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(Constants.REQUIRED));
            }
        
            /*Tests for error when city field is empty*/
            [Test]
        [Category("Passing Test: Required Empty Fields Label Test")]
        public void RequiredCityTest()
            {
            CityControl.SendKeys(Keys.Return);
            string error =Driver.ExtractTextFromXPath("//mat-card-content/div[7]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(Constants.REQUIRED));
            }
        
            /*Tests for error when state field is empty*/
            [Test]
        [Category("Passing Test: Required Empty Fields Label Test")]
        public void RequiredStateTest()
            {
            SelectState(0);
            string error = Driver.ExtractTextFromXPath("//mat-card-content/div[8]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(Constants.STATE_REQUIRED));
               
            }
        
            /*Tests for error when zip code field is empty*/
            [Test]
        [Category("Passing Test: Required Empty Fields Label Test")]
        public void RequiredZipCodeTest()
            {
            ZipCodeControl.SendKeys(Keys.Return);
            string error = Driver.ExtractTextFromXPath("//mat-card-content/div[9]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(Constants.REQUIRED));
            }
        
            /*Tests for error when telephone field is empty*/
            [Test]
        [Category("Passing Test: Required Empty Fields Label Test")]
        public void RequiredTelephoneTest()
            {
            TelephoneControl.SendKeys(Keys.Return);
            string error = Driver.ExtractTextFromXPath("//mat-card-content/div[10]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(Constants.REQUIRED));
            }
        
        
            /*Tests for no error when first name field is filled*/
            [Test]
            [Category("Required Filled Fields Label Test")]
            public void FilledFirstNameTest()
            {
                FirstNameInput="xxx";
                string error = Driver.ExtractTextFromXPath("//mat-card-content/div[1]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(string.Empty));
            }
        
            /*Tests for no error when last name field is filled*/
            [Test]
            [Category("Required Filled Fields Label Test")]
            public void FilledLastNameTest()
            {
                LastNameInput="xxx";
                string error = Driver.ExtractTextFromXPath("//mat-card-content/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(string.Empty));
            }
        
            /*Tests for no error when email field is filled*/
            [Test]
            [Category("Required Filled Fields Label Test")]
            public void FilledEmailTest()
            {
                EmailInput="xxx";
                string error = Driver.ExtractTextFromXPath("//mat-card-content/div[3]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(string.Empty));
            }
        
            /*Tests for no error when password field is filled*/
            [Test]
            [Category("Required Filled Fields Label Test")]
            public void FilledPasswordTest()
            {
                PasswordInput= "T3sting.222";
                Thread.Sleep(1000);
                string error = Driver.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[1]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(string.Empty));
                FilledConfirmPasswordTest();
            }
        
            /*Tests for no error when confirm password field is filled*/
            //[Test]
            //[Category("Required Filled Fields Label Test")]
            public void FilledConfirmPasswordTest()
            {
                ConfirmPasswordInput="T3sting.222";
                string error = Driver.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(string.Empty));
            }
        
            /*Tests for no error when security question field is filled*/
            [Test]
            [Category("Required Filled Fields Label Test")]
            public void FilledSecurityQuestionTest()
            {
                SelectSecurityQuestion(1);
                string error = Driver.ExtractTextFromXPath("//mat-card-content/div[4]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(string.Empty));
            }
        
            /*Tests for no error when security answer field is filled*/
            [Test]
            [Category("Required Filled Fields Label Test")]
            public void FilledSecurityAnswerTest()
            {
                SecurityAnswerInput="xxx";
                string error = Driver.ExtractTextFromXPath("//mat-card-content/div[4]/div[3]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(string.Empty));
            }
        
            /*Tests for no error when Address 1 field is filled*/
            [Test]
            [Category("Required Filled Fields Label Test")]
            public void FilledAddress1Test()
            {
                Address1Input="xxx";
                string error = Driver.ExtractTextFromXPath("//mat-card-content/div[5]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(string.Empty));
            }
        
            /*Tests for no error when city field is filled*/
            [Test]
            [Category("Required Filled Fields Label Test")]
            public void FilledCityTest()
            {
                CityInput="xxx";
                string error = Driver.ExtractTextFromXPath("//mat-card-content/div[7]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(string.Empty));
            }
        
            /*Tests for no error when state field is filled*/
            [Test]
            [Category("Required Filled Fields Label Test")]
            public void FilledStateTest()
            {
                SelectState(1);
                string error = Driver.ExtractTextFromXPath("//mat-card-content/div[8]/mat-form-field/div/div[3]/div/mat-error/text()");
                Assert.That(error, Is.EqualTo(string.Empty));
            }
        
            /*Tests for no error when zip code field is filled*/
            [Test]
            [Category("Required Filled Fields Label Test")]
            public void FilledZipCodeTest()
            {
                ZipCodeInput="xxx";
              string error = Driver.ExtractTextFromXPath("//mat-card-content/div[9]/mat-form-field/div/div[3]/div/mat-error/text()");
              Assert.That(error, Is.EqualTo(string.Empty));
          }
       
          /*Tests for no error when telephone field is filled*/
          [Test]
          [Category("Required Filled Fields Label Test")]
          public void FilledTelephoneTest()
          {
            PhoneInput="xxx";
              string error = Driver.ExtractTextFromXPath("//mat-card-content/div[10]/mat-form-field/div/div[3]/div/mat-error/text()");
              Assert.That(error, Is.EqualTo(string.Empty));
          }
       

    }
}
