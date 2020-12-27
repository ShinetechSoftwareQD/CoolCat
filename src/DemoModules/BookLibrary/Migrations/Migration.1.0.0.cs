﻿using CoolCat.Core.Contracts;
using CoolCat.Core.DomainModel;

namespace BookLibrary.Migrations
{
    public class Migration_1_0_0 : BaseMigration
    {
        private static readonly CoolCat.Core.DomainModel.Version _version = new CoolCat.Core.DomainModel.Version("1.0.0");

        public override string UpScripts => @"CREATE TABLE `rent_history`(
  `RentId` char(36) NOT NULL,
  `BookId` char(36) NOT NULL,
  `BookName` varchar(255) NULL DEFAULT NULL,
  `ISBN` varchar(255)NULL DEFAULT NULL,
  `DateIssued` datetime(0) NULL DEFAULT NULL,
  `RentDate` datetime(0) NULL DEFAULT NULL,
  `ReturnDate` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`RentId`) USING BTREE
)";

        public override string DownScripts => @"DROP TABLE rent_history";

        public Migration_1_0_0(IDbConnectionFactory dbConnectionFactory) : base(_version, dbConnectionFactory)
        {

        }
    }
}
