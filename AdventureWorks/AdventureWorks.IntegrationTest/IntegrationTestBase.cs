using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AdventureWorks.IntegrationTest
{
    public class IntegrationTestBase
    {
        protected AdventureWorksContext adventureWorksContext;

        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
            adventureWorksContext = new AdventureWorksContext("AdventureWorks");
        }

        [TestFixtureTearDown]
        public void FixtureTearDown()
        {
            if (adventureWorksContext != null)
            {
                adventureWorksContext.Dispose();
            }
        }
    }
}
