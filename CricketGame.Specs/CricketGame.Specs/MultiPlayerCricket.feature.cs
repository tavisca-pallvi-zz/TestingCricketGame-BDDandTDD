﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CricketGame.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class MultiPlayerCricketFeature : Xunit.IClassFixture<MultiPlayerCricketFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "MultiPlayerCricket.feature"
#line hidden
        
        public MultiPlayerCricketFeature(MultiPlayerCricketFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MultiPlayerCricket", "\tIn order to enjoy the multiplayer cricket competition\r\n\tAs a player\r\n\tI want to " +
                    "be told the winner of game", ProgrammingLanguage.CSharp, ((string[])(null)));
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
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="PlayerFirst and PlayerSecond score is zero when game starts")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayerCricket")]
        [Xunit.TraitAttribute("Description", "PlayerFirst and PlayerSecond score is zero when game starts")]
        [Xunit.TraitAttribute("Category", "mytag")]
        public virtual void PlayerFirstAndPlayerSecondScoreIsZeroWhenGameStarts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PlayerFirst and PlayerSecond score is zero when game starts", new string[] {
                        "mytag"});
#line 7
    this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.When("PlayerFirst and PlayerSecond starts a game of cricket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("PlayerFirst and PlayerSecond scores should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="PlayerFirst should be able to score runs")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayerCricket")]
        [Xunit.TraitAttribute("Description", "PlayerFirst should be able to score runs")]
        public virtual void PlayerFirstShouldBeAbleToScoreRuns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PlayerFirst should be able to score runs", ((string[])(null)));
#line 12
 this.ScenarioSetup(scenarioInfo);
#line 13
 testRunner.Given("Cricket game has started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.When("PlayerFirst scores 4 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("PlayerFirst scores should be 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="PlayerSecond should be able to score runs")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayerCricket")]
        [Xunit.TraitAttribute("Description", "PlayerSecond should be able to score runs")]
        public virtual void PlayerSecondShouldBeAbleToScoreRuns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PlayerSecond should be able to score runs", ((string[])(null)));
#line 17
 this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("Cricket game has started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.When("PlayerSecond scores 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("PlayerSecond scores should be 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="PlayerFirst should be able to score multiple runs")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayerCricket")]
        [Xunit.TraitAttribute("Description", "PlayerFirst should be able to score multiple runs")]
        public virtual void PlayerFirstShouldBeAbleToScoreMultipleRuns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PlayerFirst should be able to score multiple runs", ((string[])(null)));
#line 24
 this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given("Cricket game has started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.And("PlayerFirst has scored 4 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
    testRunner.When("PlayerFirst scores 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("PlayerFirst scores should be 7", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="PlayerSecond should be able to score multiple runs")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayerCricket")]
        [Xunit.TraitAttribute("Description", "PlayerSecond should be able to score multiple runs")]
        public virtual void PlayerSecondShouldBeAbleToScoreMultipleRuns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PlayerSecond should be able to score multiple runs", ((string[])(null)));
#line 32
 this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("Cricket game has started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.And("PlayerSecond has scored 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.When("PlayerSecond scores 6 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("PlayerSecond scores should be 9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="PlayerFirst should not be able to score runs after getting out")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayerCricket")]
        [Xunit.TraitAttribute("Description", "PlayerFirst should not be able to score runs after getting out")]
        public virtual void PlayerFirstShouldNotBeAbleToScoreRunsAfterGettingOut()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PlayerFirst should not be able to score runs after getting out", ((string[])(null)));
#line 40
 this.ScenarioSetup(scenarioInfo);
#line 41
 testRunner.Given("Cricket game has started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
 testRunner.And("PlayerFirst has scored 4 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("PlayerFirst gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.When("PlayerFirst scores 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("PlayerFirst scores should be 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="PlayerSecond should not be able to score runs after getting out")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayerCricket")]
        [Xunit.TraitAttribute("Description", "PlayerSecond should not be able to score runs after getting out")]
        public virtual void PlayerSecondShouldNotBeAbleToScoreRunsAfterGettingOut()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PlayerSecond should not be able to score runs after getting out", ((string[])(null)));
#line 48
 this.ScenarioSetup(scenarioInfo);
#line 49
 testRunner.Given("Cricket game has started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
 testRunner.And("PlayerSecond has scored 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("PlayerSecond gets out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.When("PlayerSecond scores 6 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("PlayerSecond scores should be 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="PlayerSecond is winner")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayerCricket")]
        [Xunit.TraitAttribute("Description", "PlayerSecond is winner")]
        public virtual void PlayerSecondIsWinner()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PlayerSecond is winner", ((string[])(null)));
#line 56
 this.ScenarioSetup(scenarioInfo);
#line 57
 testRunner.Given("Cricket game has started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
 testRunner.And("PlayerSecond has scored 9 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("PlayerFirst has scored  6 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.Then("PlayerSecond is winner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="PlayerFirst is winner")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayerCricket")]
        [Xunit.TraitAttribute("Description", "PlayerFirst is winner")]
        public virtual void PlayerFirstIsWinner()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PlayerFirst is winner", ((string[])(null)));
#line 63
 this.ScenarioSetup(scenarioInfo);
#line 64
 testRunner.Given("Cricket game has started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
 testRunner.And("PlayerFirst has scored 6 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("PlayerSecond has scored 3 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.Then("PlayerFirst is winner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Match is tie")]
        [Xunit.TraitAttribute("FeatureTitle", "MultiPlayerCricket")]
        [Xunit.TraitAttribute("Description", "Match is tie")]
        public virtual void MatchIsTie()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Match is tie", ((string[])(null)));
#line 69
    this.ScenarioSetup(scenarioInfo);
#line 70
 testRunner.Given("Cricket game has started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 71
 testRunner.And("PlayerFirst has scored 6 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("PlayerSecond has scored 6 runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.Then("Match is tie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                MultiPlayerCricketFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                MultiPlayerCricketFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion