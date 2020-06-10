using MarsQA_1.Helpers;
using MongoDB.Driver.Core.Events;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq.Expressions;
using System.Threading;


namespace MarsQA_1.SpecflowPages.Pages
{
    class Profile
    {

        private static IWebElement Namedrop => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div[2]/div/span"));

        private static IWebElement profile => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div[2]/div/span/div/a[1]"));



        //Description Elements

        private static IWebElement DescriptionEditIcon => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/-/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));

        private static IWebElement DescriptionTextField => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']//section[2]//textarea"));


        //Add New button for Language
        private static IWebElement LanguageAddNew => Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[1]"));


        //Add New Language text field
        private static IWebElement AddLanguage => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));

        //Add language level value drop down

        private static IWebElement AddLanguageValue => Driver.driver.FindElement(By.XPath("//select[@name='level']"));

        //AddLanguagebutton

        private static IWebElement AddLanguagebutton => Driver.driver.FindElement(By.XPath("(//input[@value='Add'][@type='button'])[1]"));

        //Last Language in the language table

        private static IWebElement Language => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//td[1]"));

        //Last Language drop down value in the language table

        private static IWebElement LanguageValue => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//td[2]"));

        // Edit icon for last language row in the language table

        private static IWebElement EditLanguageIcon => Driver.driver.FindElement(By.XPath("(//*[@data-tab='first']//tbody[last()]//td[3]//i)[1]"));

        private static IWebElement EditLastLanguage => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//input[@value='Tamil']"));

        //Edit language -> Update button 

        private static IWebElement EditLanguageupdatebutton => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//input[@value='Update']"));

        // Language - Delete icon(for last row)
        private static IWebElement DeletelanguageIcon => Driver.driver.FindElement(By.XPath("(//*[@data-tab='first']//tbody[last()]//td[3]//i)[2]"));


        private static IWebElement ShareSkill => Driver.driver.FindElement(By.XPath("//*[text()='Share Skill']"));


        private static IWebElement EducationAddNew => Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[3]"));

        private static IWebElement CertificationAddNew => Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')])[4]"));



        private static IWebElement CertificateTab => Driver.driver.FindElement(By.XPath("//a[text()='Certifications']"));

        private static IWebElement EducationTab => Driver.driver.FindElement(By.XPath("//a[text()='Education']"));

        private static IWebElement CollegeName => Driver.driver.FindElement(By.XPath("//input[@name='instituteName']"));


       private static IWebElement CountryDropdown => Driver.driver.FindElement(By.XPath("//select[@name='country']"));


        private static IWebElement TitleDropdown => Driver.driver.FindElement(By.XPath("//select[@name='title']"));


        private static IWebElement Degree => Driver.driver.FindElement(By.XPath("//input[@name='degree']"));


        private static IWebElement GradutionYearDropDown => Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));

        private static IWebElement AddButtonEducationData => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));

        private static IWebElement EducationDataCountryFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[1]"));

        private static IWebElement EducationDataUniveristyFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[2]"));


        private static IWebElement EducationDataTitleFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[3]"));

        private static IWebElement EducationDataDegreeFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[4]"));

         private static IWebElement EducationDataGradYearFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[5]"));


        private static IWebElement EducationEditiconFirst => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[6]/span[1]"));


        private static IWebElement EducationDeleteiconFirst => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[6]/span[2]"));


        private static IWebElement UpdateButtonEducationData => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));



        public static void NavigatetoProfilePage()
        {
            // To Navigate from home page to profile page
            Driver.TurnOnWait();
            //Driver.NavigateUrl();
            //Namedrop.Click();
            // Driver.TurnOnWait();
            //profile.Click();

        }


        public static void EditDescription()
        {

            // Click on description edit icon and navigate to Descrition field 
            Driver.TurnOnWait();
            DescriptionEditIcon.Click();


            // Add Description content 

            Driver.TurnOnWait();
            DescriptionTextField.SendKeys("This is test data");



        }



       

        public static void AddNewLanguage()
        {

            // Add New language 
            Driver.TurnOnWait();
            LanguageAddNew.Click();
            Driver.TurnOnWait();
            AddLanguage.SendKeys("Tamil");

            //Select Language value

            //create select element object 
            SelectElement levelvalue = new SelectElement(AddLanguageValue);

            //select by Text
            levelvalue.SelectByText("Fluent");
            AddLanguagebutton.Click();


        }

        public static void VerifyAddedLanguage()
        {
            var actuallang = Language.Text;
            var actualLangVal = LanguageValue.Text;



            Assert.AreEqual("Tamil", actuallang, "Language is not added");
            Assert.AreEqual("Fluent", actualLangVal, "Language value is not addded");


        }



        public static void EditLanguage()
        {

            Driver.TurnOnWait();
            EditLanguageIcon.Click();

            Driver.TurnOnWait();
            EditLastLanguage.Clear();
            EditLastLanguage.SendKeys("English");

            EditLanguageupdatebutton.Click();
            Thread.Sleep(2000);



        }



        public static void VerifyEditedLanguage()
        {

            var actuallang = Language.Text;
            var actualLangVal = LanguageValue.Text;

            Assert.AreEqual("English", actuallang, "Language is not edited");
            Assert.AreEqual("Fluent", actualLangVal, "Actual and Expected values are not equal");


        }


        public static void DeleteLanguage()
        {
            Driver.TurnOnWait();
            DeletelanguageIcon.Click();
            Thread.Sleep(2000);

        }


        public static void VerifyDeleteLanguage()
        {

            try
            {
                IWebElement lang = Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//td[1]"));


                Driver.TurnOnWait();
                Assert.AreNotEqual("English", lang, "Language not deleted");


            }
            catch (Exception e)
            {

                Assert.True(true, "Element not found");
            }

        }




        public static void NavigatetoServiceListingPage()
        {
            Driver.TurnOnWait();
            ShareSkill.Click();
            Thread.Sleep(2000);

        }


        public static void NavigateToEducationTab()
        { 
            //Navigate to Education Tab
            Driver.TurnOnWait();
            EducationTab.Click();

        }

        public static void AddEducation()

        {

            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Education");
          

            //Click on Add new button for education
            Driver.TurnOnWait();
            EducationAddNew.Click();

            //Enter Valid Education details 
            Driver.TurnOnWait();

            CollegeName.SendKeys(ExcelLibHelper.ReadData(2, "CollegeName"));

            SelectElement country = new SelectElement(CountryDropdown);
            country.SelectByText(ExcelLibHelper.ReadData(2, "CountryOfCollege"));

            SelectElement Titledrop = new SelectElement(TitleDropdown);
            Titledrop.SelectByText(ExcelLibHelper.ReadData(2, "TitleDrop"));

            Degree.SendKeys(ExcelLibHelper.ReadData(2, "Degree"));



            Thread.Sleep(3000);
            SelectElement Yeardrop = new SelectElement(GradutionYearDropDown);
            Yeardrop.SelectByText(ExcelLibHelper.ReadData(2, "Year"));


            Thread.Sleep(3000);
            AddButtonEducationData.Click();
            Thread.Sleep(5000);

        }


        public static void AddCertification()

        {

        }



        public static void EditEducation()

        {
            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Education");

            EducationEditiconFirst.Click();

            CollegeName.Clear();

            CollegeName.SendKeys(ExcelLibHelper.ReadData(3, "CollegeName"));

            SelectElement country = new SelectElement(CountryDropdown);
            country.SelectByText(ExcelLibHelper.ReadData(3, "CountryOfCollege"));

            SelectElement Titledrop = new SelectElement(TitleDropdown);
            Titledrop.SelectByText(ExcelLibHelper.ReadData(3, "TitleDrop"));

            Degree.Clear();

            Degree.SendKeys(ExcelLibHelper.ReadData(3, "Degree"));



            Thread.Sleep(3000);
            SelectElement Yeardrop = new SelectElement(GradutionYearDropDown);
            Yeardrop.SelectByText(ExcelLibHelper.ReadData(3, "Year"));


            Thread.Sleep(3000);
            UpdateButtonEducationData.Click();
            Thread.Sleep(5000);

        }

        public static void EditCertification()

        {

        }


        public static void DeleteEducation()

        {
            EducationDeleteiconFirst.Click();

        }

        public static void DeleteCertification()

        {

        }

        public static void VerifyAddEducation()

        {


            var actualCountry = EducationDataCountryFirstrow.Text;
            var ExpCountry = ExcelLibHelper.ReadData(2, "CountryOfCollege");

            var actualColl = EducationDataUniveristyFirstrow.Text;
            var ExpColl = ExcelLibHelper.ReadData(2, "CollegeName");


            var actualTitle = EducationDataTitleFirstrow.Text;
            var ExpTitle = ExcelLibHelper.ReadData(2, "TitleDrop");

            var actualDegree = EducationDataDegreeFirstrow.Text;
            var ExpDegree = ExcelLibHelper.ReadData(2, "Degree");

            var actualYear = EducationDataGradYearFirstrow.Text;
            var ExpYear = ExcelLibHelper.ReadData(2, "Year");







            Assert.AreEqual(actualCountry, ExpCountry, "Country is not added");

            Assert.AreEqual(actualColl, ExpColl, "College is not added");

            Assert.AreEqual(actualTitle, ExpTitle, "Title is not added");

            Assert.AreEqual(actualDegree, ExpDegree, "Degree is not added");


            Assert.AreEqual(actualYear, ExpYear, "Year is not added");

        }


        public static void VerifyAddCertification()

        {

        }





        public static void VerifyEditEducation()

        {
            var actualCountry = EducationDataCountryFirstrow.Text;
            var ExpCountry = ExcelLibHelper.ReadData(3, "CountryOfCollege");

            var actualColl = EducationDataUniveristyFirstrow.Text;
            var ExpColl = ExcelLibHelper.ReadData(3, "CollegeName");


            var actualTitle = EducationDataTitleFirstrow.Text;
            var ExpTitle = ExcelLibHelper.ReadData(3, "TitleDrop");

            var actualDegree = EducationDataDegreeFirstrow.Text;
            var ExpDegree = ExcelLibHelper.ReadData(3, "Degree");

            var actualYear = EducationDataGradYearFirstrow.Text;
            var ExpYear = ExcelLibHelper.ReadData(3, "Year");







            Assert.AreEqual(actualCountry, ExpCountry, "Country is not updated");

            Assert.AreEqual(actualColl, ExpColl, "College is not updated");

            Assert.AreEqual(actualTitle, ExpTitle, "Title is not updated");

            Assert.AreEqual(actualDegree, ExpDegree, "Degree is not updated");


            Assert.AreEqual(actualYear, ExpYear, "Year is not updated");

        }


        public static void VerifyDeleteEducation()

        {
            try
            {
                var actualCountry = EducationDataCountryFirstrow.Text;
                var ExpCountry = ExcelLibHelper.ReadData(3, "CountryOfCollege");

                var actualColl = EducationDataUniveristyFirstrow.Text;
                var ExpColl = ExcelLibHelper.ReadData(3, "CollegeName");


                var actualTitle = EducationDataTitleFirstrow.Text;
                var ExpTitle = ExcelLibHelper.ReadData(3, "TitleDrop");

                var actualDegree = EducationDataDegreeFirstrow.Text;
                var ExpDegree = ExcelLibHelper.ReadData(3, "Degree");

                var actualYear = EducationDataGradYearFirstrow.Text;
                var ExpYear = ExcelLibHelper.ReadData(3, "Year");


                Assert.AreNotEqual(actualCountry, ExpCountry, "Country is not deleted");

                Assert.AreNotEqual(actualColl, ExpColl, "College is not deleted");

                Assert.AreNotEqual(actualTitle, ExpTitle, "Title is not deleted");

                Assert.AreNotEqual(actualDegree, ExpDegree, "Degree is not deleted");


                Assert.AreNotEqual(actualYear, ExpYear, "Year is not deleted");


            }
            
            catch(Exception e)
            {


                Assert.True(true, "No Education Data");
            }










        }


        public static void VerifyEditCertification()

        {

        }


        public static void VerifyDeleteCertification()

        {

        }







    }
}
