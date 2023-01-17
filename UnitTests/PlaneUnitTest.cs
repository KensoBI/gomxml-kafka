using Kenso.Loaders.Gom.Model;
using System.Xml.Serialization;

namespace UnitTests
{
    public class PlaneUnitTest
    {
        public const decimal Orientation = 123.123M;
        public const decimal Width = 1.123M;
        public const decimal Distance = 1M;
        public const decimal Length = 2.123M;
        public static readonly string Xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom><nominal>" +
                                                  "     <plane id=\"1234567\" name=\"SomeName\">\r\n" +
                                                  "      <geometry>\r\n" +
                                                  "        <pos x=\"123\" y=\"111\" z=\"345\"></pos>\r\n" +
                                                  "        <normal x=\"123\" y=\"111\" z=\"345\"></normal>\r\n" +
                                                  $"        <distance>{Distance}</distance>\r\n" +
                                                  $"        <length>{Length}</length>>\r\n" +
                                                  $"        <width>{Width}</width>\r\n" +
                                                  $"        <orientation>{Orientation}</orientation>\r\n" +
                                                  "      </geometry>\r\n" +
                                                  "    </plane>" +
                                                  "</nominal></gom>";

        [Test]
        public void TestPlane()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(Xml);
            var gomXml = reader.Deserialize(file) as Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var plane = gomXml.Nominal!.Items.First() as Plane;
            Assert.That(plane, Is.Not.Null);
            Assert.That(plane.Geometry, Is.Not.Null);
            Assert.That(plane.Geometry.Normal, Is.Not.Null);
            Assert.That(plane.Geometry.Position, Is.Not.Null);
            Assert.That(plane.Geometry.Distance, Is.EqualTo(Distance));
            Assert.That(plane.Geometry.Length, Is.EqualTo(Length));
            Assert.That(plane.Geometry.Width, Is.EqualTo(Width));
            Assert.That(plane.Geometry.Orientation, Is.EqualTo(Orientation));
        }
    }
}
