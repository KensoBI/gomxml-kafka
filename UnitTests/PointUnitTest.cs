using System.Xml.Serialization;
using Kenso.Loaders.Gom.Model;

namespace UnitTests
{
    public class PointUnitTest
    {
        public static readonly string Xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom><nominal>" +
                                                  "     <point id=\"1234567\" name=\"SomeName\">\r\n" +
                                                  "      <geometry>\r\n" +
                                                  "        <pos x=\"123\" y=\"111\" z=\"345\"></pos>\r\n" +
                                                  "        <normal x=\"123\" y=\"111\" z=\"345\"></normal>\r\n" +
                                                  "        <trim x=\"123\" y=\"111\" z=\"345\"></trim>\r\n" +
                                                  "      </geometry>\r\n" +
                                                  "    </point>" +
                                                  "</nominal></gom>";

        [Test]
        public void TestPoint()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(Xml);
            var gomXml = reader.Deserialize(file) as Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var point = gomXml.Nominal!.Items.First() as Point;
            Assert.That(point, Is.Not.Null);
            Assert.That(point.Geometry, Is.Not.Null);
            Assert.That(point.Geometry.Position, Is.Not.Null);
            Assert.That(point.Geometry.Normal, Is.Not.Null);
            Assert.That(point.Geometry.Trim, Is.Not.Null);
        }
    }
}
