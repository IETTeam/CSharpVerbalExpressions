using System;
using TechTalk.SpecFlow;
using CSharpVerbalExpressions;
using NUnit.Framework;

namespace SpecFlowUnitTests
{
    [Binding]
    public class ModifierFeatureSteps
    {
        private VerbalExpressions verb = VerbalExpressions.DefaultExpression;
        [Given(@"I have added ""(.*)"" to the expressions")]
        public void GivenIHaveAddedToTheExpressions(string p0)
        {
            verb.Add(p0);
        }
        
        [Then(@"with ""(.*)"" modifier, it should match ""(.*)""")]
        public void ThenWithModifierItShouldMatch(char p0, string p1)
        {
            verb.AddModifier(p0);
            Assert.IsTrue(verb.IsMatch(p1));
        }
    }
}
