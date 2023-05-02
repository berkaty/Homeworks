using HRLibrary;
using NUnit.Framework;
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
            Assert.That(show.Name, Is.EqualTo("Late Night"));
            Assert.That(show.Discription, Is.EqualTo("talk-show"));
            Assert.That(show.Host, Is.EqualTo("Jimmy Fallon"));
            Assert.That(show.Frequency, Is.EqualTo(Frequency.daily));
            Assert.That(show.Time.ToShortDateString(), Is.EqualTo("1PM"));      
        }
        [Test]
        public void GetInfo_Person_ValuesString()
        {
            string expectedInfo = "Late Night ";
            expectedInfo += "talk-show ";
            expectedInfo += "Jimmy Fallon "; 
            expectedInfo += $"Время выхода: 1PM."; 
            Assert.That(show.GetInfo(), Is.EqualTo(expectedInfo)); 
        }
    }
}
