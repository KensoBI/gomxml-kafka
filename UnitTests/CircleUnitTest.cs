using System.Xml.Serialization;
using Kenso.Loaders.Gom.Model;

namespace UnitTests
{
    public class CircleUnitTest
    {
        public const decimal PositionX = 443.501308M;
        public const decimal PositionY = 750.000000M;
        public const decimal PositionZ = -4.992824M;
        public const decimal Radius = 10.002147M;

        public static readonly string Xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom><nominal>" +
                                                  "     <circle id=\"1234567\" name=\"SomeName\">\r\n" +
                                                  "      <geometry>\r\n" +
                                                  $"        <pos x=\"{PositionX}\" y=\"{PositionY}\" z=\"{PositionZ}\"></pos>\r\n" +
                                                  $"        <normal x=\"123\" y=\"111\" z=\"345\"></normal>\r\n" +
                                                  $"        <radius>{Radius}</radius>\r\n" +
                                                  "      </geometry>\r\n" +
                                                  "    </circle>" +
                                                  "</nominal></gom>";

        [Test]
        public void TestCircle()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(Xml);
            var gomXml = reader.Deserialize(file) as Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var element = gomXml.Nominal!.Items.First() as Circle;
            Assert.That(element, Is.Not.Null);
            Assert.That(element.Geometry, Is.Not.Null);
            Assert.That(element.Geometry.Position, Is.Not.Null);
            Assert.That(element.Geometry.Normal, Is.Not.Null);
            Assert.That(element.Geometry.Radius, Is.EqualTo(Radius));
        }

        [Test]
        public void TestPos()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(Xml);
            var gomXml = reader.Deserialize(file) as Gom;
            var circle = gomXml!.Nominal!.Items.First() as Circle;
            var geometry = circle!.Geometry;

            Assert.That(geometry, Is.Not.Null);
            Assert.That(geometry.Position.X, Is.EqualTo(PositionX));
            Assert.That(geometry.Position.Y, Is.EqualTo(PositionY));
            Assert.That(geometry.Position.Z, Is.EqualTo(PositionZ));
        }

        [Test]
        public void TestRadius()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(Xml);
            var gomXml = reader.Deserialize(file) as Gom;
            var circle = gomXml!.Nominal!.Items.First() as Circle;
            var geometry = circle!.Geometry;

            Assert.That(geometry, Is.Not.Null);
            Assert.That(geometry.Radius, Is.EqualTo(Radius));
        }
    }
}
