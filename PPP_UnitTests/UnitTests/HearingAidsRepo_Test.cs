using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPP.Database;
using PPP.Models;
using SQLite;
using SQLitePCL;

namespace PPP_UnitTests.UnitTests
{
    [TestClass]
    public class HearingAidsRepo_Test
    {

        private IHearingAidsRepo _hearingAidsRepo;
        private IDatabaseConnection _databaseConnection;

        public HearingAidsRepo_Test(IHearingAidsRepo hearingAidsRepo, IDatabaseConnection databaseConnection)
        {
            _hearingAidsRepo = hearingAidsRepo;
            _databaseConnection = databaseConnection;
        }

        public HearingAidsRepo_Test()
        {
            
        }

        [TestMethod]
        public void CheckIfHisAvailable()
        {
            var repo = new HearingAidsRepo(_databaseConnection);
            var hearingAidsList = repo.GetAllHis();

            Assert.IsNull(hearingAidsList);

        }
    }
}
