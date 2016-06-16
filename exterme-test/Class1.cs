using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using xCarpaccio.client;

namespace exterme_test
{
    [TestFixture]
    public class CTests
    {
        [Test]
        public void CalculateTotalGermany()
        {
            var billCalculator = new BillCalculator();
            var order = new Order();
            {
                Country = "DE",


            }
        }
    }
}
