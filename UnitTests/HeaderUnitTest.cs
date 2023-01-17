using System.Xml.Serialization;
using Kenso.Loaders.Gom.Model;


namespace UnitTests
{
    public class HeaderUnitTest
    {
        public const string XmlStart = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom>";
        public const string XmlEnd = "</gom>";
        public const string HeaderXml =
            "<header>\r\n    <version>2019.1</version>\r\n" +
            "<length_unit>mm</length_unit>\r\n    " +
            "<angle_unit>deg</angle_unit>\r\n " +
            "</header>";


        private string GetHeaderXml()
        {
            return XmlStart + HeaderXml + XmlEnd;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestHeader()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(GetHeaderXml());
            var gomXml = reader.Deserialize(file) as Gom;
            
            Assert.That(gomXml, Is.Not.Null);
            Assert.That(gomXml!.Header, Is.Not.Null);
            Assert.That(gomXml.Header!.LengthUnit, Is.EqualTo("mm"));
            Assert.That(gomXml.Header.AngleUnit, Is.EqualTo("deg"));
            Assert.That(gomXml.Header.Version, Is.EqualTo(2019.1M));
        }
    }
}