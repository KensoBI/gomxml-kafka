using System.Numerics;
using System.Xml.Serialization;
using Kenso.Loaders.Gom.Model;

namespace UnitTests
{
    public class EllipseUnitTest
    {
        public const decimal InnerRadius = 1M;
        public const decimal OuterRadius = 2.123M;

        public static readonly string Xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom><nominal>" +
                                                  "     <ellipse id=\"1234567\" name=\"SomeName\">\r\n" +
                                                  "      <geometry>\r\n" +
                                                  "        <pos x=\"123\" y=\"111\" z=\"345\"></pos>\r\n" +
                                                  "        <normal x=\"123\" y=\"111\" z=\"345\"></normal>\r\n" +
                                                  "        <pos1 x=\"123\" y=\"111\" z=\"345\"></pos1>\r\n" +
                                                  "        <pos2 x=\"123\" y=\"111\" z=\"345\"></pos2>\r\n" +
                                                  "        <dir x=\"123\" y=\"111\" z=\"345\"></dir>\r\n" +
                                                  $"        <inner_radius>{InnerRadius}</inner_radius>\r\n" +
                                                  $"        <outer_radius>{OuterRadius}</outer_radius>>\r\n" +
                                                  "      </geometry>\r\n" +
                                                  "    </ellipse>" +
                                                  "</nominal></gom>";

        [Test]
        public void TestEllipse()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(Xml);
            var gomXml = reader.Deserialize(file) as Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var ellipse = gomXml.Nominal!.Items.First() as Ellipse;
            Assert.That(ellipse, Is.Not.Null);
            Assert.That(ellipse.Geometry, Is.Not.Null);
            Assert.That(ellipse.Geometry.Position1, Is.Not.Null);
            Assert.That(ellipse.Geometry.Position2, Is.Not.Null);
            Assert.That(ellipse.Geometry.Position, Is.Not.Null);
            Assert.That(ellipse.Geometry.OuterRadius, Is.EqualTo(OuterRadius));
            Assert.That(ellipse.Geometry.InnerRadius, Is.EqualTo(InnerRadius));
        }
    }
}
