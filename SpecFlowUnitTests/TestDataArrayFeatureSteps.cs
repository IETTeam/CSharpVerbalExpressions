using System;
using TechTalk.SpecFlow;
using CSharpVerbalExpressions;
using NUnit.Framework;

namespace SpecFlowUnitTests
{
    [Binding]
    public class TestDataArrayFeatureSteps
    {
        private VerbalExpressions verb = VerbalExpressions.DefaultExpression;

        [Given(@"I have added ""(.*)"" to the expression")]
        public void GivenIHaveAddedToTheExpression(string p0)
        {
            verb.Add(p0);
        }
        
        [Then(@"searching in ""(.*)"" , the result should be '(.*)'")]
        public void ThenSearchingInTheResultShouldBe(string p0, string p1)
        {
            if (Convert.ToBoolean(p1))
            {
                Assert.IsTrue(verb.IsMatch(p0));
            }
            else
            {
                Assert.IsFalse(verb.IsMatch(p0));
            }
        }
    }
}
