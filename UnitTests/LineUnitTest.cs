using System.Xml.Serialization;
using Kenso.Loaders.Gom.Model;

namespace UnitTests
{
    public class LineUnitTest
    {
        public static readonly string Xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom><nominal>" +
                                                  "     <line id=\"1234567\" name=\"SomeName\">\r\n" +
                                                  "      <geometry>\r\n" +
                                                  "        <pos1 x=\"123\" y=\"111\" z=\"345\"></pos1>\r\n" +
                                                  "        <pos2 x=\"123\" y=\"111\" z=\"345\"></pos2>\r\n" +
                                                  "        <dir x=\"123\" y=\"111\" z=\"345\"></dir>\r\n" +
                                                  "      </geometry>\r\n" +
                                                  "    </line>" +
                                                  "</nominal></gom>";

        [Test]
        public void TestLine()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(Xml);
            var gomXml = reader.Deserialize(file) as Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var line = gomXml.Nominal!.Items.First() as Line;
            Assert.That(line, Is.Not.Null);
            Assert.That(line.Geometry, Is.Not.Null);
            Assert.That(line.Geometry.Position1, Is.Not.Null);
            Assert.That(line.Geometry.Position2, Is.Not.Null);
            Assert.That(line.Geometry.Direction, Is.Not.Null);
        }
    }
}
