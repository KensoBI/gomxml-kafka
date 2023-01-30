using System.Xml.Serialization;
using Kenso.Loaders.Gom.Model;

namespace Kenso.Loaders.Gom.UnitTests
{
    public class ElementUnitTest
    {
        public const uint Id = 16778846;
        public const string Name = "Circle 2";
        public const uint Actual = 16778933;
        public const string State = "ok";
        public const string Comment = "test comment";
        public const byte AllChecked = 1;
        public const string AllUnitName = "length";
        public const decimal AllLowerLimit = -0.800000M;
        public const decimal AllUpperLimit = 0.800000M;
        public const decimal AllNominalScalar = 0.300000M;
        public const decimal AllDeviation = 1.167205M;
        public const decimal AllMeasuredX = 443.922068M;
        public const decimal AllMeasuredY = 750.968386M;
        public const decimal AllMeasuredZ = -5.490376M;
        public const decimal AllMeasuredValue = 20.427618M;

        public static readonly string CircleNominalXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><gom><nominal>" +
                                                         $"     <circle id=\"{Id}\" name=\"{Name}\">\r\n" +
                                                         $"      <actual>{Actual}</actual>\r\n" +
                                                         $"      <state>{State}</state>\r\n" +
                                                         $"      <comment>{Comment}</comment>\r\n" +
                                                         "      <result>\r\n" +
                                                         $"        <all checked=\"{AllChecked}\" unit_name=\"{AllUnitName}\">\r\n" +
                                                         $"          <tolerance lower_limit=\"{AllLowerLimit}\" upper_limit=\"{AllUpperLimit}\"></tolerance>\r\n" +
                                                         $"          <nominal_scalar value=\"{AllNominalScalar}\"></nominal_scalar>\r\n" +
                                                         $"          <deviation value=\"{AllDeviation}\"></deviation>\r\n" +
                                                         $"          <measured x=\"{AllMeasuredX}\" y=\"{AllMeasuredY}\" z=\"{AllMeasuredZ}\" value=\"{AllMeasuredValue}\"></measured>\r\n" +
                                                         "        </all>" +
                                                         "        <x checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </x>\r\n" +
                                                         "        <y checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-0.500000\" upper_limit=\"0.500000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"0.000000\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.651611\"></deviation>\r\n " +
                                                         "          <measured x=\"0.420760\" y=\"0.000000\" z=\"-0.497552\"></measured>\r\n" +
                                                         "        </y>\r\n" +
                                                         "        <z checked=\"0\" name=\"Circle 2\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </z>" +
                                                         "        <radius checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </radius>\r\n" +
                                                         "        <diameter checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-0.500000\" upper_limit=\"0.500000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"0.000000\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.651611\"></deviation>\r\n " +
                                                         "          <measured x=\"0.420760\" y=\"0.000000\" z=\"-0.497552\"></measured>\r\n" +
                                                         "        </diameter>\r\n" +
                                                         "        <width checked=\"0\" name=\"Circle 2\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </width>" +
                                                         "        <normal checked=\"0\" name=\"Circle 2\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </normal>" +
                                                         "        <trim checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-0.500000\" upper_limit=\"0.500000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"0.000000\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.651611\"></deviation>\r\n " +
                                                         "          <measured x=\"0.420760\" y=\"0.000000\" z=\"-0.497552\"></measured>\r\n" +
                                                         "        </trim>\r\n" +
                                                         "        <inplane checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-0.500000\" upper_limit=\"0.500000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"0.000000\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.651611\"></deviation>\r\n " +
                                                         "          <measured x=\"0.420760\" y=\"0.000000\" z=\"-0.497552\"></measured>\r\n" +
                                                         "        </inplane>\r\n" +
                                                         "        <length checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </length>\r\n" +
                                                         "        <angle checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </angle>\r\n" +
                                                         "        <inner_radius checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </inner_radius>\r\n" +
                                                         "        <outer_radius checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </outer_radius>\r\n" +
                                                         "        <inner_diameter checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </inner_diameter>\r\n" +
                                                         "        <outer_diameter checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </outer_diameter>\r\n" +
                                                         "        <tol_size checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </tol_size>\r\n" +
                                                         "        <direction1 checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </direction1>\r\n" +
                                                         "        <direction2 checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </direction2>\r\n" +
                                                         "        <direction3 checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </direction3>\r\n" +
                                                         "        <linear_size checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </linear_size>\r\n" +
                                                         "        <acceleration checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </acceleration>\r\n" +
                                                         "        <velocity checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </velocity>\r\n" +
                                                         "        <displacement checked=\"1\" unit_name=\"length\">\r\n" +
                                                         "          <tolerance lower_limit=\"-1.000000\" upper_limit=\"1.000000\"></tolerance>\r\n" +
                                                         "          <nominal_scalar value=\"20.004294\"></nominal_scalar>\r\n" +
                                                         "          <deviation value=\"0.423324\"></deviation>\r\n" +
                                                         "          <measured value=\"20.427618\"></measured>\r\n" +
                                                         "        </displacement>\r\n" +
                                                         "      </result>\r\n" +
                                                         "    </circle>" +
                                                         "</nominal></gom>";

        [Test]
        public void TestNominalTag()
        {
            var reader = new XmlSerializer(typeof(Model.Gom));
            var file = new StringReader(CircleNominalXml);
            var gomXml = reader.Deserialize(file) as Model.Gom;

            Assert.That(gomXml, Is.Not.Null);
            Assert.That(gomXml!.Nominal, Is.Not.Null);
        }

        [Test]
        public void TestElementTag()
        {
            var reader = new XmlSerializer(typeof(Model.Gom));
            var file = new StringReader(CircleNominalXml);
            var gomXml = reader.Deserialize(file) as Model.Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var circle = gomXml.Nominal!.Items.First() as Circle;
            Assert.That(circle, Is.Not.Null);
            Assert.That(circle!.Name, Is.EqualTo(Name));
            Assert.That(circle.Actual, Is.EqualTo(Actual));
            Assert.That(circle.State, Is.EqualTo(State));
            Assert.That(circle.Id, Is.EqualTo(Id));
            Assert.That(circle.Comment, Is.EqualTo(Comment));
        }

        [Test]
        public void TestToleranceTypes()
        {
            var reader = new XmlSerializer(typeof(Model.Gom));
            var file = new StringReader(CircleNominalXml);
            var gomXml = reader.Deserialize(file) as Model.Gom;

            Assert.That(gomXml!.Nominal!.Items, Is.Not.Empty);

            var circle = gomXml.Nominal!.Items.First() as Circle;
            Assert.Multiple(() =>
            {
                Assert.That(circle, Is.Not.Null);
                Assert.That(circle.Result, Is.Not.Null);
                Assert.That(circle.Result.All, Is.Not.Null);
                Assert.That(circle.Result.X, Is.Not.Null);
                Assert.That(circle.Result.Y, Is.Not.Null);
                Assert.That(circle.Result.Z, Is.Not.Null);
                Assert.That(circle.Result.Radius, Is.Not.Null);
                Assert.That(circle.Result.Diameter, Is.Not.Null);
                Assert.That(circle.Result.Width, Is.Not.Null);
                Assert.That(circle.Result.Normal, Is.Not.Null);
                Assert.That(circle.Result.Trim, Is.Not.Null);
                Assert.That(circle.Result.Inplane, Is.Not.Null);
                Assert.That(circle.Result.Length, Is.Not.Null);
                Assert.That(circle.Result.Angle, Is.Not.Null);
                Assert.That(circle.Result.InnerRadius, Is.Not.Null);
                Assert.That(circle.Result.OuterRadius, Is.Not.Null);
                Assert.That(circle.Result.InnerDiameter, Is.Not.Null);
                Assert.That(circle.Result.OuterDiameter, Is.Not.Null);
                Assert.That(circle.Result.TolSize, Is.Not.Null);
                Assert.That(circle.Result.Direction1, Is.Not.Null);
                Assert.That(circle.Result.Direction2, Is.Not.Null);
                Assert.That(circle.Result.Direction3, Is.Not.Null);
                Assert.That(circle.Result.LinearSize, Is.Not.Null);
                Assert.That(circle.Result.Acceleration, Is.Not.Null);
                Assert.That(circle.Result.Velocity, Is.Not.Null);
                Assert.That(circle.Result.Displacement, Is.Not.Null);
            });
        }

        [Test]
        public void TestResultTag()
        {
            var reader = new XmlSerializer(typeof(Model.Gom));
            var file = new StringReader(CircleNominalXml);
            var gomXml = reader.Deserialize(file) as Model.Gom;
            var circle = gomXml.Nominal!.Items.First() as Circle;
            Assert.That(circle, Is.Not.Null);

            var result = circle.Result;
            Assert.Multiple(() =>
            {
                Assert.That(result.All.Measured!.Value, Is.Not.Empty);
                Assert.That(result.All.Deviation!.Value, Is.Not.Empty);
                Assert.That(result.All.Measured.X, Is.EqualTo(AllMeasuredX));
                Assert.That(result.All.Measured.Y, Is.EqualTo(AllMeasuredY));
                Assert.That(result.All.Measured.Z, Is.EqualTo(AllMeasuredZ));

                Assert.That(decimal.TryParse(result.All.Measured.Value, out var meas), Is.True);
                Assert.That(meas, Is.EqualTo(AllMeasuredValue));

                Assert.That(decimal.TryParse(result.All.Deviation.Value, out var dev), Is.True);
                Assert.That(dev, Is.EqualTo(AllDeviation));

                Assert.That(result.All.Checked, Is.EqualTo(AllChecked));
                Assert.That(result.All.NominalScalar!.Value, Is.EqualTo(AllNominalScalar));
                Assert.That(result.All.Tolerance, Is.Not.Null);
                Assert.That(result.All.UnitName, Is.EqualTo(AllUnitName));
                Assert.That(result.All.Tolerance!.LowerLimit, Is.EqualTo(AllLowerLimit));
                Assert.That(result.All.Tolerance.UpperLimit, Is.EqualTo(AllUpperLimit));
            });
        }
    }
}
