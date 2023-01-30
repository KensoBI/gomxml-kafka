using System.Xml.Serialization;

namespace Kenso.Loaders.Gom.Model
{
    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Geometry
    {
        [XmlElement("pos", IsNullable = true)] public GeometryPosition? Position { get; set; }
        [XmlElement("normal", IsNullable = true)] public GeometryPosition? Normal { get; set; }
        [XmlElement("radius", IsNullable = true)] public decimal? Radius { get; set; }
        [XmlElement("pos1", IsNullable = true)] public GeometryPosition? Position1 { get; set; }
        [XmlElement("pos2", IsNullable = true)] public GeometryPosition? Position2 { get; set; }
        [XmlElement("dir", IsNullable = true)] public GeometryPosition? Direction { get; set; }
        [XmlElement("radius1", IsNullable = true)] public decimal? Radius1 { get; set; }
        [XmlElement("radius2", IsNullable = true)] public decimal? Radius2 { get; set; }
        [XmlElement("angle", IsNullable = true)] public decimal? Angle { get; set; }
        [XmlElement("origin", IsNullable = true)] public GeometryPosition? Origin { get; set; }
        [XmlElement("height1", IsNullable = true)] public decimal? Height1 { get; set; }
        [XmlElement("height2", IsNullable = true)] public decimal? Height2 { get; set; }
        [XmlElement("length", IsNullable = true)] public decimal? Length { get; set; }
        [XmlElement("location", IsNullable = true)] public string? Location { get; set; }
        [XmlElement("inner_radius", IsNullable = true)] public decimal? InnerRadius { get; set; }
        [XmlElement("outer_radius", IsNullable = true)] public decimal? OuterRadius { get; set; }
        [XmlElement("trim", IsNullable = true)] public GeometryPosition? Trim { get; set; }
        [XmlElement("width", IsNullable = true)] public decimal? Width { get; set; }
        [XmlElement("orientation", IsNullable = true)] public decimal? Orientation { get; set; }
        [XmlElement("num_points", IsNullable = true)] public byte? NumPoints { get; set; }
        [XmlElement("distance", IsNullable = true)] public decimal? Distance { get; set; }
        [XmlElement("actual_pos1", IsNullable = true)] public GeometryPosition? ActualPos1 { get; set; }
        [XmlElement("actual_pos2", IsNullable = true)] public GeometryPosition? ActualPos2 { get; set; }
        [XmlElement("restriction", IsNullable = true)] public decimal? Restriction { get; set; }
        [XmlElement("edge_radius", IsNullable = true)] public decimal? EdgeRadius { get; set; }
    }
}
