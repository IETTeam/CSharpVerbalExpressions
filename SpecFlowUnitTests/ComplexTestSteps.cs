using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using CSharpVerbalExpressions;

namespace SpecFlowUnitTests
{
    [Binding]
    public class ComplexTestSteps
    {
        private VerbalExpressions verb = VerbalExpressions.DefaultExpression;

        [Given(@"I add '(.*)' to the expressions")]
        public void GivenIAddToTheExpressions(string p0)
        {
            verb.Add(p0);
        }
        
        [Given(@"I add '(.*)' (.*) times then anything can follow")]
        public void GivenIAddTimesThenAnythingCanFollow(string p0, int p1)
        {
            verb.BeginCapture().Add(p0).EndCapture().RepeatPrevious(3).Something();
        }
        
        [Given(@"I end the expression '(.*)'")]
        public void GivenIEndTheExpression(string p0)
        {
            verb.Add(p0).EndOfLine();
        }
        
        [Then(@"the result should match '(.*)'")]
        public void ThenTheResultShouldMatch(string p0)
        {
            Assert.IsTrue(verb.IsMatch(p0));
        }
    }
}
