using System.Xml.Serialization;
using Kenso.Loaders.Gom.Model;

namespace UnitTests
{
    public class SphereUnitTest
    {
        public static readonly string Xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom><nominal>" +
                                                  "     <sphere id=\"1234567\" name=\"SomeName\">\r\n" +
                                                  "      <geometry>\r\n" +
                                                  "        <pos x=\"1\" y=\"2\" z=\"2\"></pos>\r\n" +
                                                  "        <radius>2</radius>\r\n" +
                                                  "      </geometry>\r\n" +
                                                  "    </sphere>" +
                                                  "</nominal></gom>";

        [Test]
        public void TestSphere()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(Xml);
            var gomXml = reader.Deserialize(file) as Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var element = gomXml.Nominal!.Items.First() as Sphere;
            Assert.That(element, Is.Not.Null);
            Assert.That(element.Geometry, Is.Not.Null);
            Assert.That(element.Geometry.Position, Is.Not.Null);
            Assert.That(element.Geometry.Radius, Is.Not.Null);
        }

    }
}
