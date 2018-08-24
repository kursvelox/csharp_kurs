using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]

    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Testovaya", "Test");
            newData.Nickname = "test";
            newData.Title = "test";
            newData.Company = "test";
            newData.Address = "g.test, ul. test";
            newData.Home = "1111111";
            newData.Mobile = "2222222";
            newData.Work = "3333333";
            newData.Fax = "4444444";
            newData.Email = "test";
            newData.Email2 = "test2";
            newData.Email3 = "test3";
            newData.Homepage = "test";
            newData.Address2 = "g. test2, ul. test2";
            newData.Notes = "addendum";

            app.Contact.ModifyContact(1, newData);
        }
    }
}
