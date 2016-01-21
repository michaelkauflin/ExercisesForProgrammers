using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Should;

namespace TipCalculator.Tests.Fixie
{
    [TestFixture]
    internal class EngineFixture
    {
        [Test]
        public void TipTest()
        {
            var calculator = new Engine("200", "15");
            calculator.Tip.ShouldEqual(30.00);
        }

        [Test]
        public void TotalTest()
        {
            var calculator = new Engine("200", "15");
            calculator.Total.ShouldEqual(230.00);
        }
    }
}
