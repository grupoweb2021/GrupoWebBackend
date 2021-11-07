﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GrupoWebBackend.Tests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AddServiceTestsStepsFeature : object, Xunit.IClassFixture<AddServiceTestsStepsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AddServiceTestsSteps.feature"
#line hidden
        
        public AddServiceTestsStepsFeature(AddServiceTestsStepsFeature.FixtureData fixtureData, GrupoWebBackend_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "AddServiceTestsSteps", "\tAs a developer\r\n\tI want to publish adds through API\r\n\tSo that I can get buyers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line hidden
#line 6
 testRunner.Given("the endpoint https://localhost:5001/api/v1/Advertisements is available.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Type",
                        "UserNick",
                        "Pass",
                        "Ruc",
                        "Dni",
                        "Phone",
                        "Email",
                        "Name",
                        "LastName",
                        "DistrictId"});
            table1.AddRow(new string[] {
                        "1",
                        "VET",
                        "Frank",
                        "Password",
                        "A12345rf",
                        "70258688",
                        "946401234",
                        "frank@outlook.com",
                        "Francisco",
                        "Voularte",
                        "1"});
#line 7
 testRunner.And("A User is already stored for Advertisement", ((string)(null)), table1, "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Add An Advertisement")]
        [Xunit.TraitAttribute("FeatureTitle", "AddServiceTestsSteps")]
        [Xunit.TraitAttribute("Description", "Add An Advertisement")]
        [Xunit.TraitAttribute("Category", "advertisement2-adding")]
        public virtual void AddAnAdvertisement()
        {
            string[] tagsOfScenario = new string[] {
                    "advertisement2-adding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add An Advertisement", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "DateTime",
                            "Title",
                            "Description",
                            "Discount",
                            "UrlToImage",
                            "Promoted",
                            "UserId"});
                table2.AddRow(new string[] {
                            "29/09/2021 16:20",
                            "this is a title",
                            "add description",
                            "10",
                            "https://www.lasamarillasdezipaquira.com/oc-content/uploads/1/352.jpg",
                            "true",
                            "1"});
#line 12
 testRunner.When("A Post Request of Advertisement is sent", ((string)(null)), table2, "When ");
#line hidden
#line 15
 testRunner.Then("An Advertisement response with status 200 is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Add An Advertisement with empty data")]
        [Xunit.TraitAttribute("FeatureTitle", "AddServiceTestsSteps")]
        [Xunit.TraitAttribute("Description", "Add An Advertisement with empty data")]
        public virtual void AddAnAdvertisementWithEmptyData()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add An Advertisement with empty data", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 17
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "DateTime",
                            "Title",
                            "Description",
                            "Discount",
                            "UrlToImage",
                            "Promoted",
                            "UserId"});
                table3.AddRow(new string[] {
                            "29/09/2021 16:20",
                            "",
                            "add description",
                            "10",
                            "https://www.lasamarillasdezipaquira.com/oc-content/uploads/1/352.jpg",
                            "true",
                            "1"});
#line 18
  testRunner.When("A Post Request of Advertisement is sent", ((string)(null)), table3, "When ");
#line hidden
#line 21
  testRunner.Then("An Advertisement response with status 400 is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Add an Advertisement with the same Title")]
        [Xunit.TraitAttribute("FeatureTitle", "AddServiceTestsSteps")]
        [Xunit.TraitAttribute("Description", "Add an Advertisement with the same Title")]
        public virtual void AddAnAdvertisementWithTheSameTitle()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add an Advertisement with the same Title", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 23
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "DateTime",
                            "Title",
                            "Description",
                            "Discount",
                            "UrlToImage",
                            "Promoted",
                            "UserId"});
                table4.AddRow(new string[] {
                            "29/09/2021 16:20",
                            "hola",
                            "add description",
                            "10",
                            "https://www.lasamarillasdezipaquira.com/oc-content/uploads/1/352.jpg",
                            "true",
                            "1"});
#line 24
   testRunner.Given("An advertisement is already stored", ((string)(null)), table4, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "DateTime",
                            "Title",
                            "Description",
                            "Discount",
                            "UrlToImage",
                            "Promoted",
                            "UserId"});
                table5.AddRow(new string[] {
                            "29/09/2021 16:20",
                            "hola",
                            "add description",
                            "10",
                            "https://www.lasamarillasdezipaquira.com/oc-content/uploads/1/352.jpg",
                            "true",
                            "2"});
#line 27
   testRunner.When("A Post Request of Advertisement is sent", ((string)(null)), table5, "When ");
#line hidden
#line 30
   testRunner.Then("An Advertisement response with status 200 is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AddServiceTestsStepsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AddServiceTestsStepsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
