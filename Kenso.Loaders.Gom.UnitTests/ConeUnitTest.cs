using System.Xml.Serialization;
using Kenso.Loaders.Gom.Model;

namespace Kenso.Loaders.Gom.UnitTests
{
    public class ConeUnitTest
    {
        public const decimal Radius1 = 10.002147M;
        public const decimal Radius2 = 12M;
        public const decimal Angle = 10M;
        public const decimal Height1 = 12M;
        public const decimal Height2 = 2M;
        public const string Location ="test";
        public static readonly string Xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom><nominal>" +
                                                  "     <cone id=\"1234567\" name=\"SomeName\">\r\n" +
                                                  "      <geometry>\r\n" +
                                                  "        <pos1 x=\"1\" y=\"2\" z=\"2\"></pos1>\r\n" +
                                                  "        <pos2 x=\"1\" y=\"2\" z=\"2\"></pos2>\r\n" +
                                                  "        <dir x=\"1\" y=\"2\" z=\"2\"></dir>\r\n" +
                                                  $"        <radius1>{Radius1}</radius1>\r\n" +
                                                  $"        <radius2>{Radius2}</radius2>\r\n" +
                                                  $"        <angle>{Angle}</angle>\r\n" +
                                                  "        <origin x=\"1\" y=\"2\" z=\"2\"></origin>\r\n" +
                                                  $"        <height1>{Height1}</height1>\r\n" +
                                                  $"        <height2>{Height2}</height2>\r\n" +
                                                  $"        <location>{Location}</location>\r\n" +
                                                  "      </geometry>\r\n" +
                                                  "    </cone>" +
                                                  "</nominal></gom>";

        [Test]
        public void TestCone()
        {
            var reader = new XmlSerializer(typeof(Model.Gom));
            var file = new StringReader(Xml);
            var gomXml = reader.Deserialize(file) as Model.Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var element = gomXml.Nominal!.Items.First() as Cone;
            Assert.That(element, Is.Not.Null);
            Assert.That(element.Geometry, Is.Not.Null);
            Assert.That(element.Geometry.Position1, Is.Not.Null);
            Assert.That(element.Geometry.Position2, Is.Not.Null);
            Assert.That(element.Geometry.Direction, Is.Not.Null);
            Assert.That(element.Geometry.Radius1, Is.EqualTo(Radius1));
            Assert.That(element.Geometry.Radius2, Is.EqualTo(Radius2));
            Assert.That(element.Geometry.Angle, Is.EqualTo(Angle));
            Assert.That(element.Geometry.Origin, Is.Not.Null);
            Assert.That(element.Geometry.Height1, Is.EqualTo(Height1));
            Assert.That(element.Geometry.Height2, Is.EqualTo(Height2));
            Assert.That(element.Geometry.Location, Is.EqualTo(Location));
        }

    }
}
