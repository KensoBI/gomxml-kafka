using System.Xml.Serialization;

namespace Kenso.Loaders.Gom.Model
{
    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot("gom", Namespace = "", IsNullable = false)]
    public class Gom
    {
        [XmlElement("header", IsNullable = false)]
        public GomHeader? Header { get; set; }

        [XmlElement("nominal")] public ElementGroup? Nominal { get; set; }

        [XmlElement("measured")] public ElementGroup? Measured { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public abstract class Element
    {
        [XmlAttribute("id")] public uint Id { get; set; }

        [XmlAttribute("name")] public string Name { get; set; } = string.Empty;

        public abstract FeatureType ElementType { get; }

        [XmlElement("state", IsNullable = false)]
        public string? State { get; set; }

        [XmlElement("actual", IsNullable = true)]
        public uint? Actual { get; set; }

        [XmlElement("comment")] public string? Comment { get; set; }

        [XmlElement("measure_opposite", IsNullable = false)]
        public MeasureOpposite? MeasureOpposite { get; set; }

        [XmlElement("actualSpecified", IsNullable = false)]
        public bool ActualSpecified { get; set; }

        [XmlElement("geometry", IsNullable = false)]
        public Geometry? Geometry { get; set; }
        [XmlElement("result")] public Result? Result { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class GomHeader
    {
        [XmlElement("version", IsNullable = false)]
        public decimal Version { get; set; }

        [XmlElement("length_unit", IsNullable = false)]
        public string LengthUnit { get; set; } = string.Empty;

        [XmlElement("angle_unit", IsNullable = false)]
        public string AngleUnit { get; set; } = string.Empty;
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ElementGroup
    {
        [XmlElement("point", typeof(Point))]
        [XmlElement("line", typeof(Line))]
        [XmlElement("plane", typeof(Plane))]
        [XmlElement("circle", typeof(Circle))]
        [XmlElement("ellipse", typeof(Ellipse))]
        [XmlElement("slotted_hole", typeof(SlottedHole))]
        [XmlElement("rectangular_hole", typeof(RectangularHole))]
        [XmlElement("sphere", typeof(Sphere))]
        [XmlElement("cylinder", typeof(Cylinder))]
        [XmlElement("cone", typeof(Cone))]
        [XmlElement("polygon_hole", typeof(PolygonHole))]
        [XmlElement("dimension", typeof(Dimension))]
        //[XmlElement("distance", typeof(gomNominalDistance))] //todo distance + angle

        public Element[] Items { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class GeometryPosition
    {
        [XmlAttribute("x")] public decimal X { get; set; }

        [XmlAttribute("y")] public decimal Y { get; set; }

        [XmlAttribute("z")] public decimal Z { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class MeasureOpposite
    {
        [XmlAttribute("use")] public string? Use { get; set; }

        [XmlText] public decimal Value { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Result
    {
        [XmlElement("x")] public ElementResult? X { get; set; }
        [XmlElement("y")] public ElementResult? Y { get; set; }
        [XmlElement("z")] public ElementResult? Z { get; set; }
        [XmlElement("all")] public ElementResult? All { get; set; }
        [XmlElement("radius")] public ElementResult? Radius { get; set; }
        [XmlElement("diameter")] public ElementResult? Diameter { get; set; }
        [XmlElement("width")] public ElementResult? Width { get; set; }
        [XmlElement("normal")] public ElementResult? Normal { get; set; }
        [XmlElement("trim")] public ElementResult? Trim { get; set; }
        [XmlElement("inplane")] public ElementResult? Inplane { get; set; }
        [XmlElement("length")] public ElementResult? Length { get; set; }
        [XmlElement("angle")] public ElementResult? Angle { get; set; }
        [XmlElement("inner_radius")] public ElementResult? InnerRadius { get; set; }
        [XmlElement("outer_radius")] public ElementResult? OuterRadius { get; set; }
        [XmlElement("inner_diameter")] public ElementResult? InnerDiameter { get; set; }
        [XmlElement("outer_diameter")] public ElementResult? OuterDiameter { get; set; }
        [XmlElement("tol_size")] public ElementResult? TolSize { get; set; }
        [XmlElement("direction1")] public ElementResult? Direction1 { get; set; }
        [XmlElement("direction2")] public ElementResult? Direction2 { get; set; }
        [XmlElement("direction3")] public ElementResult? Direction3 { get; set; }
        [XmlElement("linear_size")] public ElementResult? LinearSize { get; set; }
        [XmlElement("acceleration")] public ElementResult? Acceleration { get; set; }
        [XmlElement("velocity")] public ElementResult? Velocity { get; set; }
        [XmlElement("displacement")] public ElementResult? Displacement { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    public class Tolerance
    {
        [XmlAttribute("lower_limit")] public decimal LowerLimit { get; set; }

        [XmlAttribute("upper_limit")] public decimal UpperLimit { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ElementResult
    {
        [XmlElement("tolerance")] public Tolerance? Tolerance { get; set; }
        [XmlElement("nominal_scalar")] public DecimalResult? NominalScalar { get; set; }
        [XmlElement("deviation")] public StringResult? Deviation { get; set; }
        [XmlElement("measured")] public MeasuredResult? Measured { get; set; }
        [XmlAttribute("checked")] public byte Checked { get; set; }
        [XmlAttribute("unit_name")] public string? UnitName { get; set; }
        [XmlAttribute("name")] public string? Name { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class DecimalResult
    {
        [XmlAttribute("value")] public decimal Value { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class StringResult
    {
        [XmlAttribute("value")] public string? Value { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class MeasuredResult
    {
        [XmlAttribute("value")] public string? Value { get; set; }
        [XmlAttribute("x")] public decimal X { get; set; }
        [XmlAttribute("y")] public decimal Y { get; set; }
        [XmlAttribute("z")] public decimal Z { get; set; }
    }
}