using System.Xml.Serialization;
using Kenso.Loaders.Gom.Model;

namespace UnitTests
{
    public class NominalDimensionUnitTest
    {
        public const uint Id = 16778863;
        public const string Name = "Distance 4";
        public const uint Actual = 16778936;
        public const string State = "ok";
        public const decimal GeometryDistance = 10.000000M;
        public const decimal GeometryActualPosition1X = 443.922068M;
        public const decimal GeometryActualPosition1Y = 750.968386M;
        public const decimal GeometryActualPosition1Z = -5.490376M;
        public const decimal GeometryActualPosition2X = 443.922068M;
        public const decimal GeometryActualPosition2Y = 751.089048M;
        public const decimal GeometryActualPosition2Z = -15.703472M;
        public const decimal GeometryAngle = 90.000000M;
        public const decimal GeometryPositionX = 546.610309M;
        public const decimal GeometryPositionY = 725.936143M;
        public const decimal GeometryPositionZ = 27.093177M;
        public const decimal GeometryPosition1X = 443.922068M;
        public const decimal GeometryPosition1Y = 250.961386M;
        public const decimal GeometryPosition1Z = -5.490376M;
        public const decimal GeometryPosition2X = 443.322068M;
        public const decimal GeometryPosition2Y = 150.938386M;
        public const decimal GeometryPosition2Z = -5.443376M;

        public const byte ResultDimensionChecked = 1;
        public const string ResultDimensionUnitName = "length";
        public const decimal ResultDimensionNominalScalar = 10.000000M;
        public const decimal ResultDimensionDeviation = 0.213809M;
        public const decimal ResultDimensionMeasured = 10.213809M;
        public const string ResultAngleName = "Angle";
        public const byte ResultAngleChecked = 1;
        public const string ResultAngleUnitName = "angle";
        public const decimal ResultAngleLowerLimit = -5.000000M;
        public const decimal ResultAngleUpperLimit = 5.000000M;
        public const decimal ResultAngleNominalScalar = 90.000000M;
        public const decimal ResultAngleDeviation = -0.473927M;
        public const decimal ResultAngleMeasured = 89.526073M;

        public static readonly string CircleNominalXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom><nominal>" +
                                                         $"    <dimension id=\"{Id}\" name=\"{Name}\">\r\n" +
                                                         $"      <actual>{Actual}</actual>\r\n" +
                                                         $"      <state>{State}</state>\r\n" +
                                                         "      <geometry>\r\n" +
                                                         $"        <distance>{GeometryDistance}</distance>\r\n" +
                                                         $"        <actual_pos1 x=\"{GeometryActualPosition1X}\" y=\"{GeometryActualPosition1Y}\" z=\"{GeometryActualPosition1Z}\"></actual_pos1>\r\n" +
                                                         $"        <actual_pos2 x=\"{GeometryActualPosition2X}\" y=\"{GeometryActualPosition2Y}\" z=\"{GeometryActualPosition2Z}\"></actual_pos2>\r\n" +
                                                         $"        <pos1 x=\"{GeometryPosition1X}\" y=\"{GeometryPosition1Y}\" z=\"{GeometryPosition1Z}\"></pos1>\r\n" +
                                                         $"        <pos2 x=\"{GeometryPosition2X}\" y=\"{GeometryPosition2Y}\" z=\"{GeometryPosition2Z}\"></pos2>\r\n" +
                                                         $"        <angle>{GeometryAngle}</angle>"+
                                                         $"        <pos x=\"{GeometryPositionX}\" y=\"{GeometryPositionY}\" z=\"{GeometryPositionZ}\"></pos>" +
                                                         "      </geometry>\r\n" +
                                                         "      <result>\r\n" +
                                                         $"        <dimension checked=\"{ResultDimensionChecked}\" name=\"{Name}\" unit_name=\"{ResultDimensionUnitName}\">\r\n" +
                                                         $"          <nominal_scalar value=\"{ResultDimensionNominalScalar}\"></nominal_scalar>\r\n" +
                                                         $"          <deviation value=\"{ResultDimensionDeviation}\"></deviation>\r\n" +
                                                         $"          <measured value=\"{ResultDimensionMeasured}\"></measured>\r\n" +
                                                         "        </dimension>\r\n" +
                                                         $"        <angle checked=\"1\" name=\"{ResultAngleName}\" unit_name=\"{ResultAngleUnitName}\">\r\n" +
                                                         $"          <tolerance lower_limit=\"{ResultAngleLowerLimit}\" upper_limit=\"{ResultAngleUpperLimit}\"></tolerance>\r\n" +
                                                         $"          <nominal_scalar value=\"{ResultAngleNominalScalar}\"></nominal_scalar>\r\n" +
                                                         $"          <deviation value=\"{ResultAngleDeviation}\"></deviation>\r\n" +
                                                         $"          <measured value=\"{ResultAngleMeasured}\"></measured>\r\n" +
                                                         $"        </angle>" +
                                                         "      </result>\r\n" +
                                                         "    </dimension>" +
                                                         "</nominal></gom>";

        [Test]
        public void TestDimension()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(CircleNominalXml);
            var gomXml = reader.Deserialize(file) as Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var dim = gomXml.Nominal!.Items.First() as Dimension;
            Assert.That(dim, Is.Not.Null);
            Assert.That(dim!.Name, Is.EqualTo(Name));
            Assert.That(dim.Actual, Is.EqualTo(Actual));
            Assert.That(dim.State, Is.EqualTo(State));
            Assert.That(dim.Id, Is.EqualTo(Id));
        }

        [Test]
        public void TestDimensionGeometry()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(CircleNominalXml);
            var gomXml = reader.Deserialize(file) as Gom;
            var dim = gomXml!.Nominal!.Items.First() as Dimension;
            var geometry = dim!.Geometry;

            Assert.That(geometry, Is.Not.Null);
            Assert.That(geometry.ActualPos1.X, Is.EqualTo(GeometryActualPosition1X));
            Assert.That(geometry.ActualPos1.Y, Is.EqualTo(GeometryActualPosition1Y));
            Assert.That(geometry.ActualPos1.Z, Is.EqualTo(GeometryActualPosition1Z));
            Assert.That(geometry.ActualPos2.X, Is.EqualTo(GeometryActualPosition2X));
            Assert.That(geometry.ActualPos2.Y, Is.EqualTo(GeometryActualPosition2Y));
            Assert.That(geometry.ActualPos2.Z, Is.EqualTo(GeometryActualPosition2Z));
            //Assert.That(geometry.Pos.X, Is.EqualTo(GeometryPositionX));
            //Assert.That(geometry.Pos.Y, Is.EqualTo(GeometryPositionY));
            //Assert.That(geometry.Pos.Z, Is.EqualTo(GeometryPositionZ));
            //Assert.That(geometry.Pos1.X, Is.EqualTo(GeometryPosition1X));
            //Assert.That(geometry.Pos1.Y, Is.EqualTo(GeometryPosition1Y));
            //Assert.That(geometry.Pos1.Z, Is.EqualTo(GeometryPosition1Z));
            //Assert.That(geometry.Pos2.X, Is.EqualTo(GeometryPosition2X));
            //Assert.That(geometry.Pos2.Y, Is.EqualTo(GeometryPosition2Y));
            //Assert.That(geometry.Pos2.Z, Is.EqualTo(GeometryPosition2Z));
            Assert.That(geometry.Distance, Is.EqualTo(GeometryDistance));
            Assert.That(geometry.Angle, Is.EqualTo(GeometryAngle));
            //Assert.That(geometry.Pos.X, Is.EqualTo(GeometryPositionX));
            //Assert.That(geometry.Pos.Y, Is.EqualTo(GeometryPositionY));
            //Assert.That(geometry.Pos.Z, Is.EqualTo(GeometryPositionZ));
        }

        //[Test]
        //public void TestDimensionResult()
        //{
        //    var reader = new XmlSerializer(typeof(Gom));
        //    var file = new StringReader(CircleNominalXml);
        //    var gomXml = reader.Deserialize(file) as Gom;
        //    var dim = gomXml!.Nominal!.Items.First() as NominalDimension;
        //    var result = dim!.Result;

        //    Assert.That(result, Is.Not.Null);
        //    Assert.That(result.Dimension.Checked, Is.EqualTo(ResultDimensionChecked));
        //    Assert.That(result.Dimension.NominalScalar!.Value, Is.EqualTo(ResultDimensionNominalScalar));
        //    Assert.That(result.Dimension.UnitName, Is.EqualTo(ResultDimensionUnitName));
        //    Assert.That(result.Dimension.Name, Is.EqualTo(Name));
        //    Assert.That(result.Dimension.Deviation!.Value, Is.Not.Empty);
        //    Assert.That(decimal.TryParse(result.Dimension.Measured.Value, out var meas), Is.True);
        //    Assert.That(meas, Is.EqualTo(ResultDimensionMeasured));
        //    Assert.That(decimal.TryParse(result.Dimension.Deviation.Value, out var dev), Is.True);
        //    Assert.That(dev, Is.EqualTo(ResultDimensionDeviation));
            
        //}

        [Test]
        public void TestAngleResult()
        {
            var reader = new XmlSerializer(typeof(Gom));
            var file = new StringReader(CircleNominalXml);
            var gomXml = reader.Deserialize(file) as Gom;
            var dim = gomXml!.Nominal!.Items.First() as Dimension;
            var result = dim!.Result;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Angle.Measured!.Value, Is.Not.Empty);
            Assert.That(result.Angle.Deviation!.Value, Is.Not.Empty);
            Assert.That(decimal.TryParse(result.Angle.Measured.Value, out var angle), Is.True);
            Assert.That(angle, Is.EqualTo(ResultAngleMeasured));
            Assert.That(decimal.TryParse(result.Angle.Deviation.Value, out var dev), Is.True);
            Assert.That(angle, Is.EqualTo(ResultAngleMeasured));
            Assert.That(result.Angle.Checked, Is.EqualTo(ResultAngleChecked));
            Assert.That(result.Angle.NominalScalar!.Value, Is.EqualTo(ResultAngleNominalScalar));
            Assert.That(result.Angle.Tolerance, Is.Not.Null);
            Assert.That(result.Angle.Tolerance!.LowerLimit, Is.EqualTo(ResultAngleLowerLimit));
            Assert.That(result.Angle.Tolerance.UpperLimit, Is.EqualTo(ResultAngleUpperLimit));
            Assert.That(result.Angle.UnitName, Is.EqualTo(ResultAngleUnitName));
        }
    }
}

