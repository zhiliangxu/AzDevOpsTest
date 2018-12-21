using System;
using System.Collections;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Test1()
        {
            string secret = Environment.GetEnvironmentVariable("EMAILCLIENTID");

            IDictionary dict = Environment.GetEnvironmentVariables();
            this.output.WriteLine(string.Join(",", dict.Keys.OfType<string>()));
            this.output.WriteLine(string.Join(", ", secret.ToCharArray()));
            Console.WriteLine("In XUnit, I got environment variable value: {0}", secret);
            Console.WriteLine("Interleaved with comma: {0}", string.Join(",", secret.ToCharArray()));

            Assert.NotNull(secret);
            Assert.NotEmpty(secret);
            Assert.Contains("f3a3", secret);
        }
    }
}
