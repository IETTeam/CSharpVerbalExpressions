using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpVerbalExpressions;

namespace SpecFlowUnitTests
{
    [Binding]
    public class AddFeatureSteps
    {
        private VerbalExpressions verb = VerbalExpressions.DefaultExpression;

        [Given(@"I have added '(.*)' to the expression")]
        public void GivenIHaveAddedToTheExpression(string p0)
        {
            verb.Add(p0);
        }
        
        [Then(@"it should be found in ""(.*)"" expression")]
        public void ThenItShouldBeFoundInExpression(string p0)
        {
            Assert.IsTrue(verb.IsMatch(p0));
        }
        
        [Then(@"it also shouldn't be found in ""(.*)"" expression")]
        public void ThenItAlsoShouldnTBeFoundInExpression(string p0)
        {
            Assert.IsFalse(verb.IsMatch(p0));
        }
    }
}
