using HRLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowsLibrary.UnitTests
{
    [TestFixture]
    public class ShowsTests
    {
        static Show show;
        [SetUp]
        public void Setup()
        {
            show = new Show("Late Night", "talk-show","Jimmy Fallon", Frequency.daily, "1PM");
        }
        [Test]
        public void ConstructorTest()
        {
            Assert.That(show.Name, Is.EqualTo("John"));
            Assert.That(show.Discription, Is.EqualTo("Smith"));
            Assert.That(show.Host, Is.EqualTo("Smith"));
            Assert.That(show.Frequency, Is.EqualTo(Frequency.daily));
            Assert.That(show.Time.ToShortDateString(), Is.EqualTo("15.07.2003"));       ///&&&&&&&&&&7
        }
        //[Test]
        //public void AgeGetter_Person_CurrentAge()
        //{
        //    Assert.That(show.Age, Is.EqualTo(DateTime.Now.Year - 2003));
        //}
        [Test]
        public void GetInfo_Person_ValuesString()
        {
            string expectedInfo = "Late Night ";
            expectedInfo += "Датарождения: 15.07.2003. ";
            expectedInfo += "Пол: мужской. "; expectedInfo += $"Возраст: {DateTime.Now.Year - 2003}."; ///////
            Assert.That(show.GetInfo(), Is.EqualTo(expectedInfo)); ////////////
        }
    }
}
