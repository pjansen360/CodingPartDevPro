using System;
using TechTalk.SpecFlow;

namespace CodingPart_Dev.Pro
{
    [Binding]
    public class LoggingEventsAndErrorsStepDefinitions
    {
        [Given(@"an log file ""([^""]*)""")]
        public void GivenAnLogFile(string p0)
        {
            Console.WriteLine("FUKKKKK");
        }
    }
}
