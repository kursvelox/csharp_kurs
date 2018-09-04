using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]

    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Testovaya", "Test");
            newData.Nickname = null;
            newData.Title = null;
            newData.Company = null;
            newData.Address = null;
            newData.Home = null;
            newData.Mobile = null;
            newData.Work = null;
            newData.Fax = null;
            newData.Email = null;
            newData.Email2 = null;
            newData.Email3 = null;
            newData.Homepage = null;
            newData.Address2 = null;
            newData.Notes = null;

            app.Contact.ModifyContact(1, newData);
        }
    }
}
