﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Habitat.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class LoginFeature : Xunit.IUseFixture<LoginFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Login.feature"
#line hidden
        
        public LoginFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Login", "\r\nIn order to access secure pages\r\nAs a website visitor\r\nI want to be able to log" +
                    " in", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void SetFixture(LoginFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC1_Open Login form")]
        public virtual void Accounts_LoginForm_UC1_OpenLoginForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC1_Open Login form", new string[] {
                        "Ready"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then("Login title presents on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field name"});
            table1.AddRow(new string[] {
                        "Email"});
            table1.AddRow(new string[] {
                        "Password"});
#line 13
 testRunner.And("Following fields present on Login form", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login Form Buttons"});
            table2.AddRow(new string[] {
                        "Cancel"});
            table2.AddRow(new string[] {
                        "Login"});
#line 17
 testRunner.And("Following buttons present on Login Form", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Aссounts_Login form_UC2_Check required fields")]
        public virtual void Aссounts_LoginForm_UC2_CheckRequiredFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Aссounts_Login form_UC2_Check required fields", new string[] {
                        "Ready"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Required fields error message"});
            table3.AddRow(new string[] {
                        "E-mail is required"});
            table3.AddRow(new string[] {
                        "Password is required"});
#line 28
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC3_Enter correct Username and Password")]
        public virtual void Accounts_LoginForm_UC3_EnterCorrectUsernameAndPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC3_Enter correct Username and Password", new string[] {
                        "Ready"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table4.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 36
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table4, "Given ");
#line 39
 testRunner.And("User was logged out from the Habitat", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table5.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k"});
#line 42
 testRunner.When("Actor enteres following data into Login form fields", ((string)(null)), table5, "When ");
#line 45
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table6.AddRow(new string[] {
                        "Login"});
            table6.AddRow(new string[] {
                        "Register"});
#line 46
 testRunner.Then("Following buttons is no longer present under User drop-drop down menu", ((string)(null)), table6, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table7.AddRow(new string[] {
                        "Logout"});
#line 50
 testRunner.And("Following buttons present under User drop-drop down menu", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC4_Enter correct username and incorrect password")]
        public virtual void Accounts_LoginForm_UC4_EnterCorrectUsernameAndIncorrectPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC4_Enter correct username and incorrect password", new string[] {
                        "Ready"});
#line 56
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table8.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 57
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table8, "Given ");
#line 60
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table9.AddRow(new string[] {
                        "kov@sitecore.net",
                        "m"});
#line 63
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table9, "When ");
#line 66
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table10.AddRow(new string[] {
                        "Username or password is not valid."});
#line 67
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC5_Enter incorrect username and correct password")]
        public virtual void Accounts_LoginForm_UC5_EnterIncorrectUsernameAndCorrectPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC5_Enter incorrect username and correct password", new string[] {
                        "Ready"});
#line 73
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table11.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 74
    testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table11, "Given ");
#line 77
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table12.AddRow(new string[] {
                        "kov1@sitecore.net",
                        "k"});
#line 80
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table12, "When ");
#line 83
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table13.AddRow(new string[] {
                        "Username or password is not valid."});
#line 84
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table13, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC6_Enter incorrect username and password")]
        public virtual void Accounts_LoginForm_UC6_EnterIncorrectUsernameAndPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC6_Enter incorrect username and password", new string[] {
                        "Ready"});
#line 90
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table14.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 91
    testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table14, "Given ");
#line 94
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table15.AddRow(new string[] {
                        "kov1@sitecore.net",
                        "k1"});
#line 97
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table15, "When ");
#line 100
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table16.AddRow(new string[] {
                        "Username or password is not valid."});
#line 101
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table16, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC7_Login with username and password of recently removed user" +
            "")]
        public virtual void Accounts_LoginForm_UC7_LoginWithUsernameAndPasswordOfRecentlyRemovedUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC7_Login with username and password of recently removed user" +
                    "", new string[] {
                        "Ready"});
#line 107
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table17.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 108
    testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table17, "Given ");
#line 111
 testRunner.And("User was deleted from the System", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table18.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k"});
#line 114
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table18, "When ");
#line 117
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table19.AddRow(new string[] {
                        "Username or password is not valid."});
#line 118
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table19, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC8_Click Cancel button on login form")]
        public virtual void Accounts_LoginForm_UC8_ClickCancelButtonOnLoginForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC8_Click Cancel button on login form", new string[] {
                        "Ready"});
#line 123
this.ScenarioSetup(scenarioInfo);
#line 124
    testRunner.Given("Login form is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table20.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k"});
#line 125
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table20, "When ");
#line 128
 testRunner.And("User clicks Cancel button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.Then("Page URL ends on /", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table21.AddRow(new string[] {
                        "Login"});
            table21.AddRow(new string[] {
                        "Register"});
#line 130
 testRunner.And("Following buttons present under User drop-drop down menu", ((string)(null)), table21, "And ");
#line 134
 testRunner.And("Login popup is no longer presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC9_Open Login page")]
        public virtual void Accounts_LoginPage_UC9_OpenLoginPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC9_Open Login page", new string[] {
                        "Ready"});
#line 138
this.ScenarioSetup(scenarioInfo);
#line 139
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 140
 testRunner.When("Actor navigates to Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 141
 testRunner.Then("LOGIN title presents on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field name"});
            table22.AddRow(new string[] {
                        "Email"});
            table22.AddRow(new string[] {
                        "Password"});
#line 142
 testRunner.And("Following fields present on Login page", ((string)(null)), table22, "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login Page Buttons"});
            table23.AddRow(new string[] {
                        "Login"});
#line 146
 testRunner.And("Following buttons present on Login Page", ((string)(null)), table23, "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login page link name"});
            table24.AddRow(new string[] {
                        "Forgot your password?"});
#line 149
 testRunner.And("Following links present on Login Page", ((string)(null)), table24, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Aссounts_Login page_UC10_Check required fields")]
        public virtual void Aссounts_LoginPage_UC10_CheckRequiredFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Aссounts_Login page_UC10_Check required fields", new string[] {
                        "Ready"});
#line 155
this.ScenarioSetup(scenarioInfo);
#line 156
 testRunner.Given("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 157
 testRunner.When("User clicks Login button on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Required fields error message"});
            table25.AddRow(new string[] {
                        "E-mail is required"});
            table25.AddRow(new string[] {
                        "Password is required"});
#line 158
 testRunner.Then("System shows following error message for the Login page", ((string)(null)), table25, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC11_Enter correct Username and Password")]
        public virtual void Accounts_LoginPage_UC11_EnterCorrectUsernameAndPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC11_Enter correct Username and Password", new string[] {
                        "Ready"});
#line 165
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table26.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 166
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table26, "Given ");
#line 169
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table27.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 170
 testRunner.When("Actor enteres following data into Login page fields", ((string)(null)), table27, "When ");
#line 173
 testRunner.And("User clicks Login button on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 174
 testRunner.Then("Habitat Main page presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table28.AddRow(new string[] {
                        "Login"});
            table28.AddRow(new string[] {
                        "Register"});
#line 175
 testRunner.And("Following buttons is no longer present under User drop-drop down menu", ((string)(null)), table28, "And ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table29.AddRow(new string[] {
                        "Logout"});
#line 179
 testRunner.And("Following buttons present under User drop-drop down menu", ((string)(null)), table29, "And ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Link name"});
            table30.AddRow(new string[] {
                        "Edit details"});
#line 182
 testRunner.And("Following links present under User drop-drop down menu", ((string)(null)), table30, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC12_Enter correct username and incorrect password")]
        public virtual void Accounts_LoginPage_UC12_EnterCorrectUsernameAndIncorrectPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC12_Enter correct username and incorrect password", new string[] {
                        "Ready"});
#line 188
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table31.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 189
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table31, "Given ");
#line 192
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table32.AddRow(new string[] {
                        "kov@sitecore.net",
                        "m"});
#line 193
 testRunner.When("Actor enteres following data into Login page fields", ((string)(null)), table32, "When ");
#line 196
 testRunner.And("User clicks Login button on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login page error message"});
            table33.AddRow(new string[] {
                        "Username or password is not valid."});
#line 197
 testRunner.Then("System shows following error message for the Login page", ((string)(null)), table33, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC13_Enter incorrect username and correct password")]
        public virtual void Accounts_LoginPage_UC13_EnterIncorrectUsernameAndCorrectPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC13_Enter incorrect username and correct password", new string[] {
                        "Ready"});
#line 203
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table34.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 204
    testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table34, "Given ");
#line 207
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table35.AddRow(new string[] {
                        "kov1@sitecore.net",
                        "k"});
#line 208
 testRunner.When("Actor enteres following data into Login page fields", ((string)(null)), table35, "When ");
#line 211
 testRunner.And("User clicks Login button on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table36.AddRow(new string[] {
                        "Username or password is not valid."});
#line 212
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table36, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC14_Enter incorrect username and password")]
        public virtual void Accounts_LoginPage_UC14_EnterIncorrectUsernameAndPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC14_Enter incorrect username and password", new string[] {
                        "Ready"});
#line 218
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table37.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 219
    testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table37, "Given ");
#line 222
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table38.AddRow(new string[] {
                        "kov1@sitecore.net",
                        "k1"});
#line 223
 testRunner.When("Actor enteres following data into Login page fields", ((string)(null)), table38, "When ");
#line 226
 testRunner.And("User clicks Login button on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table39.AddRow(new string[] {
                        "Username or password is not valid."});
#line 227
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table39, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC15_Login with username and password of recently removed use" +
            "r")]
        public virtual void Accounts_LoginPage_UC15_LoginWithUsernameAndPasswordOfRecentlyRemovedUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC15_Login with username and password of recently removed use" +
                    "r", new string[] {
                        "Ready"});
#line 233
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table40.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 234
    testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table40, "Given ");
#line 237
 testRunner.And("User was deleted from the System", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 238
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table41 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table41.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 239
 testRunner.When("Actor enteres following data into Login page fields", ((string)(null)), table41, "When ");
#line 242
 testRunner.And("User clicks Login button on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table42 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table42.AddRow(new string[] {
                        "Username or password is not valid."});
#line 243
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table42, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC16_Login form fails on Forgot Password page")]
        public virtual void Accounts_LoginPage_UC16_LoginFormFailsOnForgotPasswordPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC16_Login form fails on Forgot Password page", new string[] {
                        "Ready"});
#line 249
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table43 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table43.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 250
    testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table43, "Given ");
#line 253
 testRunner.And("Habitat website is opened on Forgot Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 254
 testRunner.When("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 255
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table44.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 256
 testRunner.When("Actor enteres following data into Login form fields", ((string)(null)), table44, "When ");
#line 259
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 260
 testRunner.Then("Habitat Main page presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table45.AddRow(new string[] {
                        "Logout"});
            table45.AddRow(new string[] {
                        "Edit details"});
#line 261
 testRunner.And("Following buttons present under User drop-drop down menu", ((string)(null)), table45, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                LoginFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                LoginFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion