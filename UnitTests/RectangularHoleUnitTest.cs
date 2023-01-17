using Kenso.Loaders.Gom.Model;
using System.Xml.Serialization;

namespace UnitTests
{
    public class RectangularHoleUnitTest
    {
        public static readonly string Xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom><nominal>" +
                                                  "     <rectangular_hole id=\"1234567\" name=\"SomeName\">\r\n" +
                                                  "      <geometry>\r\n" +
                                                  "        <pos x=\"123\" y=\"111\" z=\"345\"></pos>\r\n" +
                                                  "        <normal x=\"123\" y=\"111\" z=\"345\"></normal>\r\n" +
                                                  "        <dir x=\"123\" y=\"111\" z=\"345\"></dir>\r\n" +
                                                  "        <length>1</length>>\r\n" +
                                                  "        <width>2</width>\r\n" +
                                                  "        <edge_radius>2</edge_radius>\r\n" +
                                                  "      </geometry>\r\n" +
                                                  "    </rectangular_hole>" +
                                                  "</nominal></gom>";

        [Test]
        public void TestRectangularHole()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(Xml);
            var gomXml = reader.Deserialize(file) as Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var element = gomXml.Nominal!.Items.First() as RectangularHole;
            Assert.That(element, Is.Not.Null);
            Assert.That(element.Geometry, Is.Not.Null);
            Assert.That(element.Geometry.Normal, Is.Not.Null);
            Assert.That(element.Geometry.Position, Is.Not.Null);
            Assert.That(element.Geometry.Direction, Is.Not.Null);
            Assert.That(element.Geometry.Length, Is.Not.Null);
            Assert.That(element.Geometry.Width, Is.Not.Null);
            Assert.That(element.Geometry.EdgeRadius, Is.Not.Null);
        }
    }
}
