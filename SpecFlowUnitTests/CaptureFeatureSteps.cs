using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using CSharpVerbalExpressions;

namespace SpecFlowUnitTests
{
    [Binding]
    public class CaptureFeatureSteps
    {
        private VerbalExpressions verb = VerbalExpressions.DefaultExpression;

        [Given(@"I have addded ""(.*)"" to the expressions")]
        public void GivenIHaveAdddedToTheExpressions(string p0)
        {
            verb.BeginCapture().Add(p0);
        }

        [Given(@"I have also added ""(.*)"" in the same capture")]
        public void GivenIHaveAlsoAddedInTheSameCapture(string p0)
        {
            verb.Or(p0).EndCapture();
        }

        [Then(@"there should be a match for ""(.*)""")]
        public void ThenThereShouldBeAMatchFor(string p0)
        {
            Assert.IsTrue(verb.IsMatch(p0));
        }

        [Then(@"there should also be a match for '(.*)'")]
        public void ThenThereShouldAlsoBeAMatchFor(string p0)
        {
            Assert.IsTrue(verb.IsMatch(p0));
        }
        
        [Then(@"there souldn't be a match for ""(.*)""")]
        public void ThenThereSouldnTBeAMatchFor(string p0)
        {
            Assert.IsFalse(verb.IsMatch(p0));
        }
    }
}
