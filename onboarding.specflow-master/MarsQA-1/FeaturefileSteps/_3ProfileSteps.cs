using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class _3ProfileSteps
    {
        [Given(@"User is loggedIn and is in profile page")]
        public void GivenUserIsLoggedInAndIsInProfilePage()
        {
            
        }
        
        [Given(@"User is in language tab")]
        public void GivenUserIsInLanguageTab()
        {
          
        }
        
        [Given(@"User clicks on Add new and Enters the language details")]
        public void GivenUserClicksOnAddNewAndEntersTheLanguageDetails()
        {
            
        }
        
        [Given(@"User navigates to Skills tab and selects Add New")]
        public void GivenUserNavigatesToSkillsTabAndSelectsAddNew()
        {
            
        }
        
        [Given(@"User enters skill and chooses Skill level")]
        public void GivenUserEntersSkillAndChoosesSkillLevel()
        {
          
        }
        
        [Given(@"User navigates to Education tab  and selects Add New")]
        public void GivenUserNavigatesToEducationTabAndSelectsAddNew()
        {

            Profile.NavigateToEducationTab();
          
        }
        
        [Given(@"User enters all the required education details")]
        public void GivenUserEntersAllTheRequiredEducationDetails()
        {
            Profile.AddEducation();
        }
        
        [Given(@"User navigates to certification tab  and selects Add New")]
        public void GivenUserNavigatesToCertificationTabAndSelectsAddNew()
        {
        }
        
        [Given(@"User enters certification details and selects year")]
        public void GivenUserEntersCertificationDetailsAndSelectsYear()
        {
            
        }
        
       
        
        [Given(@"User is in Language tab and User has languages added")]
        public void GivenUserIsInLanguageTabAndUserHasLanguagesAdded()
        {
            
        }
        
        [Given(@"User clicks on Edit icon and Edits selected language")]
        public void GivenUserClicksOnEditIconAndEditsSelectedLanguage()
        {
           
        }
        
        [Given(@"User is in Skill tab and User has Skills added")]
        public void GivenUserIsInSkillTabAndUserHasSkillsAdded()
        {
           
        }
        
        [Given(@"User clicks on Edit icon and Edits selected skill details")]
        public void GivenUserClicksOnEditIconAndEditsSelectedSkillDetails()
        {
           
        }
        
        [Given(@"User is in Education tab and User has Education added")]
        public void GivenUserIsInEducationTabAndUserHasEducationAdded()
        {
        }
        
        [Given(@"User clicks on Edit icon and Edits selected Education details")]
        public void GivenUserClicksOnEditIconAndEditsSelectedEducationDetails()
        {
           
        }
        
        [Given(@"User is in certificate tab and User has certifications added")]
        public void GivenUserIsInCertificateTabAndUserHasCertificationsAdded()
        {
         
        }
        
        [Given(@"User clicks on Edit icon and Edits selected certificate details")]
        public void GivenUserClicksOnEditIconAndEditsSelectedCertificateDetails()
        {
           
        }
        
        [Given(@"User has languge added to the profile")]
        public void GivenUserHasLangugeAddedToTheProfile()
        {
            
        }
        
        [Given(@"User has Skill added to the profile")]
        public void GivenUserHasSkillAddedToTheProfile()
        {
            
        }
        
        [Given(@"User has Education added to the profile")]
        public void GivenUserHasEducationAddedToTheProfile()
        {
           
        }
        
        [Given(@"User has certification added to the profile")]
        public void GivenUserHasCertificationAddedToTheProfile()
        {
            
        }
        
        [When(@"User clicks on Add")]
        public void WhenUserClicksOnAdd()
        {
            
        }
        
        [When(@"User clicks on Add button")]
        public void WhenUserClicksOnAddButton()
        {
        }
        
        [When(@"User clicks on update button in language tab")]
        public void WhenUserClicksOnUpdateButtonInLanguageTab()
        {

        }
        
        [When(@"User clicks on update button in skill tab")]
        public void WhenUserClicksOnUpdateButtonInSkillTab()
        {
         
        }
        
        [When(@"User clicks on update button in Education tab")]
        public void WhenUserClicksOnUpdateButtonInEducationTab()
        {
            
        }
        
        [When(@"User clicks on update button in certificate tab")]
        public void WhenUserClicksOnUpdateButtonInCertificateTab()
        {
            
        }
        
        [When(@"User clicks on Delete icon of a language")]
        public void WhenUserClicksOnDeleteIconOfALanguage()
        {
           
        }
        
        [When(@"User clicks on Delete icon of a Skill")]
        public void WhenUserClicksOnDeleteIconOfASkill()
        {
            
        }
        
        [When(@"User clicks on Delete icon of a Education")]
        public void WhenUserClicksOnDeleteIconOfAEducation()
        {
            
        }
        
        [When(@"User clicks on Delete icon of a Certificate")]
        public void WhenUserClicksOnDeleteIconOfACertificate()
        {
            
        }
        
        [Then(@"Language should be added to the profile")]
        public void ThenLanguageShouldBeAddedToTheProfile()
        {
            
        }
        
        [Then(@"Skill should be added to the profile")]
        public void ThenSkillShouldBeAddedToTheProfile()
        {
           
        }
        
        [Then(@"Education should be added to the profile")]
        public void ThenEducationShouldBeAddedToTheProfile()
        {
            
        }
        
        [Then(@"Certification should be added to the profile")]
        public void ThenCertificationShouldBeAddedToTheProfile()
        {
           
        }
        
        [Then(@"edited language should be updated in the profile page")]
        public void ThenEditedLanguageShouldBeUpdatedInTheProfilePage()
        {
            
        }
        
        [Then(@"edited skill should be updated in the profile page")]
        public void ThenEditedSkillShouldBeUpdatedInTheProfilePage()
        {
        }
        
        [Then(@"edited education details should be updated in the profile page")]
        public void ThenEditedEducationDetailsShouldBeUpdatedInTheProfilePage()
        {
        }
        
        [Then(@"edited certificate details should be updated in the profile page")]
        public void ThenEditedCertificateDetailsShouldBeUpdatedInTheProfilePage()
        {
            
        }
        
        [Then(@"particular language should be removed from the user profile")]
        public void ThenParticularLanguageShouldBeRemovedFromTheUserProfile()
        {
          
        }
        
        [Then(@"particular skill should be removed from the user profile")]
        public void ThenParticularSkillShouldBeRemovedFromTheUserProfile()
        {
            
        }
        
        [Then(@"particular education details should be removed from the user profile")]
        public void ThenParticularEducationDetailsShouldBeRemovedFromTheUserProfile()
        {
        }
        
        [Then(@"particular certification details should be removed from the user profile")]
        public void ThenParticularCertificationDetailsShouldBeRemovedFromTheUserProfile()
        {
            
        }
    }
}
