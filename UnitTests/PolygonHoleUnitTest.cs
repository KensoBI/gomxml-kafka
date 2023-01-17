using System.Xml.Serialization;
using Kenso.Loaders.Gom.Model;

namespace UnitTests
{
    public class PolygonHoleUnitTest
    {
        public static readonly string Xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom><nominal>" +
                                                  "     <polygon_hole id=\"1234567\" name=\"SomeName\">\r\n" +
                                                  "      <geometry>\r\n" +
                                                  "        <pos x=\"123\" y=\"111\" z=\"345\"></pos>\r\n" +
                                                  "        <normal x=\"123\" y=\"111\" z=\"345\"></normal>\r\n" +
                                                  "        <dir x=\"123\" y=\"111\" z=\"345\"></dir>\r\n" +
                                                  "        <outer_radius>1</outer_radius>\r\n" +
                                                  "        <inner_radius>2</inner_radius>\r\n" +
                                                  "      </geometry>\r\n" +
                                                  "    </polygon_hole>" +
                                                  "</nominal></gom>";

        [Test]
        public void TestLine()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(Xml);
            var gomXml = reader.Deserialize(file) as Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var element = gomXml.Nominal!.Items.First() as PolygonHole;
            Assert.That(element, Is.Not.Null);
            Assert.That(element.Geometry, Is.Not.Null);
            Assert.That(element.Geometry.Position, Is.Not.Null);
            Assert.That(element.Geometry.Normal, Is.Not.Null);
            Assert.That(element.Geometry.Direction, Is.Not.Null);
            Assert.That(element.Geometry.OuterRadius, Is.Not.Null);
            Assert.That(element.Geometry.InnerRadius, Is.Not.Null);
        }
    }
}
