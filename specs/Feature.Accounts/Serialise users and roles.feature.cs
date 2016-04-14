﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SerialiseUsersAndRolesFeature : Xunit.IClassFixture<SerialiseUsersAndRolesFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Serialise users and roles.feature"
#line hidden
        
        public SerialiseUsersAndRolesFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Serialise users and roles", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(SerialiseUsersAndRolesFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Serialise users and roles")]
        [Xunit.TraitAttribute("Description", "Serialise users and roles_UC1_Habitat modules roles available in Role Manager")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void SerialiseUsersAndRoles_UC1_HabitatModulesRolesAvailableInRoleManager()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialise users and roles_UC1_Habitat modules roles available in Role Manager", new string[] {
                        "NeedImplementation"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Role"});
            table1.AddRow(new string[] {
                        "habitat\\Project Habitat Content Author"});
            table1.AddRow(new string[] {
                        "habitat\\Project Habitat Modules Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Accounts Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Demo Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature FAQ Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Identity Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Language Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Maps Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Media Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Metadata Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Multisite Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Navigation Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature News Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature PageContent Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Person Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Search Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Social Admin"});
            table1.AddRow(new string[] {
                        "modules\\Feature Teasers Admin"});
            table1.AddRow(new string[] {
                        "modules\\Foundation Assets Admin"});
            table1.AddRow(new string[] {
                        "modules\\Foundation Indexing Admin"});
            table1.AddRow(new string[] {
                        "modules\\Foundation Multisite Admin"});
#line 7
 testRunner.Then("Following roles available", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Serialise users and roles")]
        [Xunit.TraitAttribute("Description", "Serialise users and roles_UC2_Non-admin user without modules admin rights")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void SerialiseUsersAndRoles_UC2_Non_AdminUserWithoutModulesAdminRights()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialise users and roles_UC2_Non-admin user without modules admin rights", new string[] {
                        "NeedImplementation"});
#line 33
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Role"});
            table2.AddRow(new string[] {
                        "habitat\\Project Habitat Content Author"});
#line 34
 testRunner.Given("User habitat\\UserRoles with u password and following roles created in Habitat", ((string)(null)), table2, "Given ");
#line 38
  testRunner.Then("habitat\\UserRoles has Deny Write access to all available item fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Serialise users and roles")]
        [Xunit.TraitAttribute("Description", "Serialise users and roles_UC3_Admin user with modules admin rights")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void SerialiseUsersAndRoles_UC3_AdminUserWithModulesAdminRights()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialise users and roles_UC3_Admin user with modules admin rights", new string[] {
                        "NeedImplementation"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Role"});
            table3.AddRow(new string[] {
                        "habitat\\Project Habitat Content Author"});
            table3.AddRow(new string[] {
                        "habitat\\Project Habitat Modules Admin"});
#line 44
 testRunner.Given("User habitat\\UserRoles with u password and following roles created in Habitat", ((string)(null)), table3, "Given ");
#line 50
  testRunner.Then("habitat\\UserRoles has  Write access to all available item fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Serialise users and roles")]
        [Xunit.TraitAttribute("Description", "Serialise users and roles_UC4_Admin user with multisite admin rights")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void SerialiseUsersAndRoles_UC4_AdminUserWithMultisiteAdminRights()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialise users and roles_UC4_Admin user with multisite admin rights", new string[] {
                        "NeedImplementation"});
#line 54
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Role"});
            table4.AddRow(new string[] {
                        "habitat\\Project Habitat Content Author"});
            table4.AddRow(new string[] {
                        "habitat\\Project Habitat Modules Admin"});
#line 55
 testRunner.Given("User habitat\\UserRoles with u password and following roles created in Habitat", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item name"});
            table5.AddRow(new string[] {
                        "Datasource Location"});
            table5.AddRow(new string[] {
                        "Datasource Template"});
#line 60
  testRunner.Then("habitat\\UserRoles has  Write access to following item fields", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SerialiseUsersAndRolesFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SerialiseUsersAndRolesFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
