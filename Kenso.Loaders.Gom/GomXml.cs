using System.Xml.Serialization;

namespace Kenso.Loaders.Gom;

[Serializable]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlType(AnonymousType = true)]
[XmlRoot("gom", Namespace = "", IsNullable = false)]
public class GomXml
{
    private gomMeasured measuredField;

    [XmlElement("header", IsNullable = false)]
    public GomHeader Header { get; set; }

    /// <remarks/>
    public Nominal nominal { get; set; }

    /// <remarks/>
    public gomMeasured measured
    {
        get
        {
            return measuredField;
        }
        set
        {
            measuredField = value;
        }
    }

    /// <remarks/>
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

   


    /// <remarks/>
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    public class Nominal
    {


        /// <remarks/>
        [XmlElement("circle", typeof(NominalCircle))]
        [XmlElement("curve", typeof(gomNominalCurve))]
        [XmlElement("dimension", typeof(gomNominalDimension))]
        [XmlElement("distance", typeof(gomNominalDistance))]
        [XmlElement("point", typeof(gomNominalPoint))]
        [XmlElement("point_cloud", typeof(gomNominalPoint_cloud))]
        [XmlElement("polygon_hole", typeof(gomNominalPolygon_hole))]
        [XmlElement("rectangular_hole", typeof(gomNominalRectangular_hole))]
        [XmlElement("slotted_hole", typeof(gomNominalSlotted_hole))]
        public object[] Items { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType("gomNominalCircle", AnonymousType = true)]
    public class NominalCircle
    {
        [XmlElement("measure_opposite", IsNullable = false)]
        public gomNominalCircleMeasure_opposite MeasureOpposite { get; set; }

        [XmlElement("actual", IsNullable = false)]
        public uint Actual { get; set; }

        [XmlElement("actualSpecified", IsNullable = false)]
        public bool ActualSpecified { get; set; }

        [XmlElement("state", IsNullable = false)]
        public string State { get; set; }

        [XmlElement("geometry", IsNullable = false)]
        public GomNominalCircleGeometry Geometry { get; set; }

        [XmlElement("result", IsNullable = false)]
        public gomNominalCircleResult Result { get; set; }

        [XmlElement("id", IsNullable = false)]
        public uint Id { get; set; }

        [XmlElement("name", IsNullable = false)]
        public string? Name { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType("gomNominalCircleGeometry", AnonymousType = true)]
    public class GomNominalCircleGeometry
    {
        [XmlElement("pos")]
        public GeometryPosition? Position { get; set; }

        [XmlElement("normal")]
        public GeometryPosition? Normal { get; set; }

        [XmlElement("radius")]
        public decimal Radius { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType("gomNominalCircleGeometryPos", AnonymousType = true)]

    public class GeometryPosition
    {
        [XmlAttribute("x")]
        public decimal X { get; set; }

        [XmlAttribute("y")]
        public decimal Y { get; set; }

        [XmlAttribute("z")]
        public decimal Z { get; set; }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("gomNominalCircleMeasure_opposite", AnonymousType = true)]
    public class MeasureOpposite
    {

        [XmlAttribute("use")]
        public string? Use { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }


}

