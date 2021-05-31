using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PPP.Models;

namespace PPP_UnitTests.IntegrationTests
{
    [TestClass]    
    public class SqlDataFixture
    {

        [TestMethod]
        public void GetDataFromDB_Test()
        {
            var mock = new Mock<IHearingAidsRepo>();
            var list = mock.Setup(x => x.GetAllHis()).Returns(() => new List<Hi>());

            Assert.IsNotNull(list);
        }
    }
}
