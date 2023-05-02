using Microsoft.VisualStudio.TestTools.UnitTesting;
using HRLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ShowsLibrary;
using Assert = NUnit.Framework.Assert;

namespace HRLibrary.UnitTests 
{ 
    [TestFixture] 
    public class PersonTests 
    { 
        static Showw show1;
        [SetUp] 
        public void Setup() 
        { 
            show1 = new Showw("John", "Smith", "15.07.2003", Gender.Male);
        }
        [Test]
        public void ConstructorTest()
        { 
            Assert.That(show1.Name, Is.EqualTo("John"));
            Assert.That(show1.Surname, Is.EqualTo("Smith")); 
            Assert.That(show1.Birthday.ToShortDateString(), Is.EqualTo("15.07.2003")); 
            Assert.That(show1.Gender, Is.EqualTo(Gender.Male)); 
        } 
        [Test]
        public void AgeGetter_Person_CurrentAge() 
        { 
            Assert.That(show1.Age, Is.EqualTo(DateTime.Now.Year - 2003));
        } 
        [Test]
        public void GetInfo_Person_ValuesString() 
        { 
            string expectedInfo = "John Smith. ";
            expectedInfo += "Датарождения: 15.07.2003. ";
            expectedInfo += "Пол: мужской. "; expectedInfo += $"Возраст: {DateTime.Now.Year - 2003}.";
            Assert.That(show1.GetInfo(), Is.EqualTo(expectedInfo)); 
        } 
    } 
}