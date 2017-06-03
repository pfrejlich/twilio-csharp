using System;
using NUnit.Framework;
using Twilio.TwiML;

namespace Twilio.Tests.TwiML
{
    [TestFixture]
    public class GatherTest
    {
        [Test]
        public void TestGatherEmptyInput()
        {
            var g = new Gather();
            g.Say("Hello");

            Assert.AreEqual(
                g.ToString(),
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Gather>" + Environment.NewLine +
                "  <Say>Hello</Say>" + Environment.NewLine +
                "</Gather>"
            );
        }

        [Test]
        public void TestGatherInput()
        {
          var g = new Gather(input: "dtmf");
          g.Say("Hello");

          Assert.AreEqual(
              g.ToString(),
              "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
              "<Gather input=\"dtmf\">" + Environment.NewLine +
              "  <Say>Hello</Say>" + Environment.NewLine +
              "</Gather>"
          );
        }
    }
}
