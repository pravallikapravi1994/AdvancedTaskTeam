using System;
using TechTalk.SpecFlow;
using MarsQA_1.Utils;
using MarsQA_1.SpecflowPages.Pages;

namespace MarsQA_1
{
    [Binding]
    public class _3ProfileSteps
    {
        [Given(@"User Navigates to Education Tab")]
        public void GivenUserNavigatesToEducationTab()
        {
            Profile.NavigateToEducationTab();
            
        }
        
        [When(@"User adds Educations")]
        public void WhenUserAddsEducations()
        {
            Profile.AddEducation();
           
        }
        
        [Then(@"Verify if Education is added")]
        public void ThenVerifyIfEducationIsAdded()
        {
            Profile.VerifyAddEducation();
        }

        [When(@"User edits Educations")]
        public void WhenUserEditsEducations()
        {
            Profile.EditEducation();
        }

        [Then(@"Verify if Education is Edited")]
        public void ThenVerifyIfEducationIsEdited()
        {
            Profile.VerifyEditEducation();
        }


        [When(@"User Deletes Education")]
        public void WhenUserDeletesEducation()
        {
            Profile.DeleteEducation();
        }

        [Then(@"Verify if Education is Deleted")]
        public void ThenVerifyIfEducationIsDeleted()
        {
            Profile.VerifyDeleteEducation();
        }


    }
}
