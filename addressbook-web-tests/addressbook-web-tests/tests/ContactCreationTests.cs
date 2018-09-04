using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {            
            ContactData contact = new ContactData("Korteleva", "Julia");
            contact.Nickname = "kortik";
            contact.Title = "test";
            contact.Company = "Velox";
            contact.Address = "g.Grodno, ul. Repina";
            contact.Home = "8888888";
            contact.Mobile = "9999999";
            contact.Work = "7777777";
            contact.Fax = "6666666";
            contact.Email = "q_lja@mail.ru";
            contact.Email2 = "julia_kortik@gmail.com";
            contact.Email3 = "test_curs@mail.ru";
            contact.Homepage = "test";
            contact.Address2 = "g. Grodno, ul. Sovetskaya";
            contact.Notes = "test";

            app.Contact.CreateCont(contact);
        }
        
        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData("","");
            contact.Nickname = "";
            contact.Title = "";
            contact.Company = "";
            contact.Address = "";
            contact.Home = "";
            contact.Mobile = "";
            contact.Work = "";
            contact.Fax = "";
            contact.Email = "";
            contact.Email2 = "";
            contact.Email3 = "";
            contact.Homepage = "";
            contact.Address2 = "";
            contact.Notes = "";

            app.Contact.CreateCont(contact);
        }
    }
}
