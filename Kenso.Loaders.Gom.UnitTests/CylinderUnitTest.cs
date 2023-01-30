using System.Xml.Serialization;
using Kenso.Loaders.Gom.Model;

namespace Kenso.Loaders.Gom.UnitTests
{
    public class CylinderUnitTest
    {
        public static readonly string Xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom><nominal>" +
                                                  "     <cylinder id=\"1234567\" name=\"SomeName\">\r\n" +
                                                  "      <geometry>\r\n" +
                                                  "        <pos1 x=\"1\" y=\"2\" z=\"2\"></pos1>\r\n" +
                                                  "        <pos2 x=\"1\" y=\"2\" z=\"2\"></pos2>\r\n" +
                                                  "        <dir x=\"1\" y=\"2\" z=\"2\"></dir>\r\n" +
                                                  "        <radius>2</radius>\r\n" +
                                                  "        <length>2</length>\r\n" +
                                                  "        <location>2</location>\r\n" +
                                                  "      </geometry>\r\n" +
                                                  "    </cylinder>" +
                                                  "</nominal></gom>";

        [Test]
        public void TestCylinder()
        {
            var reader = new XmlSerializer(typeof(Model.Gom));
            var file = new StringReader(Xml);
            var gomXml = reader.Deserialize(file) as Model.Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var element = gomXml.Nominal!.Items.First() as Cylinder;
            Assert.That(element, Is.Not.Null);
            Assert.That(element.Geometry, Is.Not.Null);
            Assert.That(element.Geometry.Position1, Is.Not.Null);
            Assert.That(element.Geometry.Position2, Is.Not.Null);
            Assert.That(element.Geometry.Direction, Is.Not.Null);
            Assert.That(element.Geometry.Radius, Is.Not.Null);
            Assert.That(element.Geometry.Length, Is.Not.Null);
            Assert.That(element.Geometry.Location, Is.Not.Null);
        }

    }
}
