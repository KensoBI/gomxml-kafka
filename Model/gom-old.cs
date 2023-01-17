// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class gom_old
{

    private gomHeader headerField;

    private gomNominal nominalField;

    private gomMeasured measuredField;

    /// <remarks/>
    public gomHeader header
    {
        get
        {
            return this.headerField;
        }
        set
        {
            this.headerField = value;
        }
    }

    /// <remarks/>
    public gomNominal nominal
    {
        get
        {
            return this.nominalField;
        }
        set
        {
            this.nominalField = value;
        }
    }

    /// <remarks/>
    public gomMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomHeader
{

    private decimal versionField;

    private string length_unitField;

    private string angle_unitField;

    /// <remarks/>
    public decimal version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    public string length_unit
    {
        get
        {
            return this.length_unitField;
        }
        set
        {
            this.length_unitField = value;
        }
    }

    /// <remarks/>
    public string angle_unit
    {
        get
        {
            return this.angle_unitField;
        }
        set
        {
            this.angle_unitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominal
{

    private object[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("circle", typeof(gomNominalCircle))]
    [System.Xml.Serialization.XmlElementAttribute("curve", typeof(gomNominalCurve))]
    [System.Xml.Serialization.XmlElementAttribute("dimension", typeof(gomNominalDimension))]
    [System.Xml.Serialization.XmlElementAttribute("distance", typeof(gomNominalDistance))]
    [System.Xml.Serialization.XmlElementAttribute("point", typeof(gomNominalPoint))]
    [System.Xml.Serialization.XmlElementAttribute("point_cloud", typeof(gomNominalPoint_cloud))]
    [System.Xml.Serialization.XmlElementAttribute("polygon_hole", typeof(gomNominalPolygon_hole))]
    [System.Xml.Serialization.XmlElementAttribute("rectangular_hole", typeof(gomNominalRectangular_hole))]
    [System.Xml.Serialization.XmlElementAttribute("slotted_hole", typeof(gomNominalSlotted_hole))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircle
{

    private gomNominalCircleMeasure_opposite measure_oppositeField;

    private uint actualField;

    private bool actualFieldSpecified;

    private string stateField;

    private gomNominalCircleGeometry geometryField;

    private gomNominalCircleResult resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public gomNominalCircleMeasure_opposite measure_opposite
    {
        get
        {
            return this.measure_oppositeField;
        }
        set
        {
            this.measure_oppositeField = value;
        }
    }

    /// <remarks/>
    public uint actual
    {
        get
        {
            return this.actualField;
        }
        set
        {
            this.actualField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool actualSpecified
    {
        get
        {
            return this.actualFieldSpecified;
        }
        set
        {
            this.actualFieldSpecified = value;
        }
    }

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResult result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleMeasure_opposite
{

    private string useField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
        get
        {
            return this.useField;
        }
        set
        {
            this.useField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleGeometry
{

    private gomNominalCircleGeometryPos posField;

    private gomNominalCircleGeometryNormal normalField;

    private decimal radiusField;

    /// <remarks/>
    public gomNominalCircleGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleGeometryNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public decimal radius
    {
        get
        {
            return this.radiusField;
        }
        set
        {
            this.radiusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleGeometryNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResult
{

    private gomNominalCircleResultAll allField;

    private gomNominalCircleResultDiameter diameterField;

    private gomNominalCircleResultInplane inplaneField;

    private gomNominalCircleResultNormal normalField;

    private gomNominalCircleResultX xField;

    private gomNominalCircleResultY yField;

    private gomNominalCircleResultZ zField;

    /// <remarks/>
    public gomNominalCircleResultAll all
    {
        get
        {
            return this.allField;
        }
        set
        {
            this.allField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultDiameter diameter
    {
        get
        {
            return this.diameterField;
        }
        set
        {
            this.diameterField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultInplane inplane
    {
        get
        {
            return this.inplaneField;
        }
        set
        {
            this.inplaneField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultX x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultY y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultZ z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultAll
{

    private gomNominalCircleResultAllTolerance toleranceField;

    private gomNominalCircleResultAllNominal_scalar nominal_scalarField;

    private gomNominalCircleResultAllDeviation deviationField;

    private gomNominalCircleResultAllMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    private string nameField;

    /// <remarks/>
    public gomNominalCircleResultAllTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultAllNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultAllDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultAllMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultAllTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultAllNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultAllDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultAllMeasured
{

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultDiameter
{

    private gomNominalCircleResultDiameterTolerance toleranceField;

    private gomNominalCircleResultDiameterNominal_scalar nominal_scalarField;

    private gomNominalCircleResultDiameterDeviation deviationField;

    private gomNominalCircleResultDiameterMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalCircleResultDiameterTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultDiameterNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultDiameterDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultDiameterMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultDiameterTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultDiameterNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultDiameterDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultDiameterMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultInplane
{

    private gomNominalCircleResultInplaneTolerance toleranceField;

    private gomNominalCircleResultInplaneNominal_scalar nominal_scalarField;

    private gomNominalCircleResultInplaneDeviation deviationField;

    private gomNominalCircleResultInplaneMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalCircleResultInplaneTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultInplaneNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultInplaneDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultInplaneMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultInplaneTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultInplaneNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultInplaneDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultInplaneMeasured
{

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultNormal
{

    private gomNominalCircleResultNormalTolerance toleranceField;

    private gomNominalCircleResultNormalNominal_scalar nominal_scalarField;

    private gomNominalCircleResultNormalDeviation deviationField;

    private gomNominalCircleResultNormalMeasured measuredField;

    private byte checkedField;

    private string nameField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalCircleResultNormalTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultNormalNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultNormalDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultNormalMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultNormalTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultNormalNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultNormalDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultNormalMeasured
{

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultX
{

    private gomNominalCircleResultXTolerance toleranceField;

    private gomNominalCircleResultXNominal_scalar nominal_scalarField;

    private gomNominalCircleResultXDeviation deviationField;

    private gomNominalCircleResultXMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalCircleResultXTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultXNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultXDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultXMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultXTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultXNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultXDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultXMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultY
{

    private gomNominalCircleResultYTolerance toleranceField;

    private gomNominalCircleResultYNominal_scalar nominal_scalarField;

    private gomNominalCircleResultYDeviation deviationField;

    private gomNominalCircleResultYMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalCircleResultYTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultYNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultYDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultYMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultYTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultYNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultYDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultYMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultZ
{

    private gomNominalCircleResultZTolerance toleranceField;

    private gomNominalCircleResultZNominal_scalar nominal_scalarField;

    private gomNominalCircleResultZDeviation deviationField;

    private gomNominalCircleResultZMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalCircleResultZTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultZNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultZDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalCircleResultZMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultZTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultZNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultZDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCircleResultZMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCurve
{

    private string stateField;

    private gomNominalCurveGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomNominalCurveGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCurveGeometry
{

    private gomNominalCurveGeometryCurve_data curve_dataField;

    /// <remarks/>
    public gomNominalCurveGeometryCurve_data curve_data
    {
        get
        {
            return this.curve_dataField;
        }
        set
        {
            this.curve_dataField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalCurveGeometryCurve_data
{

    private byte chunkField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte chunk
    {
        get
        {
            return this.chunkField;
        }
        set
        {
            this.chunkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimension
{

    private string commentField;

    private uint actualField;

    private string stateField;

    private gomNominalDimensionGeometry geometryField;

    private gomNominalDimensionResult resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }

    /// <remarks/>
    public uint actual
    {
        get
        {
            return this.actualField;
        }
        set
        {
            this.actualField = value;
        }
    }

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionResult result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionGeometry
{

    private decimal distanceField;

    private bool distanceFieldSpecified;

    private gomNominalDimensionGeometryActual_pos1 actual_pos1Field;

    private gomNominalDimensionGeometryActual_pos2 actual_pos2Field;

    private decimal angleField;

    private bool angleFieldSpecified;

    private gomNominalDimensionGeometryPos posField;

    private gomNominalDimensionGeometryPos1 pos1Field;

    private gomNominalDimensionGeometryPos2 pos2Field;

    /// <remarks/>
    public decimal distance
    {
        get
        {
            return this.distanceField;
        }
        set
        {
            this.distanceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool distanceSpecified
    {
        get
        {
            return this.distanceFieldSpecified;
        }
        set
        {
            this.distanceFieldSpecified = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionGeometryActual_pos1 actual_pos1
    {
        get
        {
            return this.actual_pos1Field;
        }
        set
        {
            this.actual_pos1Field = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionGeometryActual_pos2 actual_pos2
    {
        get
        {
            return this.actual_pos2Field;
        }
        set
        {
            this.actual_pos2Field = value;
        }
    }

    /// <remarks/>
    public decimal angle
    {
        get
        {
            return this.angleField;
        }
        set
        {
            this.angleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool angleSpecified
    {
        get
        {
            return this.angleFieldSpecified;
        }
        set
        {
            this.angleFieldSpecified = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionGeometryPos1 pos1
    {
        get
        {
            return this.pos1Field;
        }
        set
        {
            this.pos1Field = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionGeometryPos2 pos2
    {
        get
        {
            return this.pos2Field;
        }
        set
        {
            this.pos2Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionGeometryActual_pos1
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionGeometryActual_pos2
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionGeometryPos1
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionGeometryPos2
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionResult
{

    private gomNominalDimensionResultDimension dimensionField;

    private gomNominalDimensionResultAngle angleField;

    /// <remarks/>
    public gomNominalDimensionResultDimension dimension
    {
        get
        {
            return this.dimensionField;
        }
        set
        {
            this.dimensionField = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionResultAngle angle
    {
        get
        {
            return this.angleField;
        }
        set
        {
            this.angleField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionResultDimension
{

    private gomNominalDimensionResultDimensionNominal_scalar nominal_scalarField;

    private gomNominalDimensionResultDimensionDeviation deviationField;

    private gomNominalDimensionResultDimensionMeasured measuredField;

    private byte checkedField;

    private string nameField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalDimensionResultDimensionNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionResultDimensionDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionResultDimensionMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionResultDimensionNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionResultDimensionDeviation
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionResultDimensionMeasured
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionResultAngle
{

    private gomNominalDimensionResultAngleTolerance toleranceField;

    private gomNominalDimensionResultAngleNominal_scalar nominal_scalarField;

    private gomNominalDimensionResultAngleDeviation deviationField;

    private gomNominalDimensionResultAngleMeasured measuredField;

    private byte checkedField;

    private string nameField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalDimensionResultAngleTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionResultAngleNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionResultAngleDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalDimensionResultAngleMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionResultAngleTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionResultAngleNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionResultAngleDeviation
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDimensionResultAngleMeasured
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDistance
{

    private uint actualField;

    private string stateField;

    private gomNominalDistanceGeometry geometryField;

    private gomNominalDistanceDistance[] resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public uint actual
    {
        get
        {
            return this.actualField;
        }
        set
        {
            this.actualField = value;
        }
    }

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomNominalDistanceGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("distance", IsNullable = false)]
    public gomNominalDistanceDistance[] result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDistanceGeometry
{

    private gomNominalDistanceGeometryDistance distanceField;

    private decimal lengthField;

    private gomNominalDistanceGeometryPos1 pos1Field;

    private gomNominalDistanceGeometryPos2 pos2Field;

    /// <remarks/>
    public gomNominalDistanceGeometryDistance distance
    {
        get
        {
            return this.distanceField;
        }
        set
        {
            this.distanceField = value;
        }
    }

    /// <remarks/>
    public decimal length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }

    /// <remarks/>
    public gomNominalDistanceGeometryPos1 pos1
    {
        get
        {
            return this.pos1Field;
        }
        set
        {
            this.pos1Field = value;
        }
    }

    /// <remarks/>
    public gomNominalDistanceGeometryPos2 pos2
    {
        get
        {
            return this.pos2Field;
        }
        set
        {
            this.pos2Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDistanceGeometryDistance
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDistanceGeometryPos1
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDistanceGeometryPos2
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDistanceDistance
{

    private gomNominalDistanceDistanceTolerance toleranceField;

    private gomNominalDistanceDistanceNominal_scalar nominal_scalarField;

    private gomNominalDistanceDistanceDeviation deviationField;

    private gomNominalDistanceDistanceMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    private string restrictionField;

    /// <remarks/>
    public gomNominalDistanceDistanceTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalDistanceDistanceNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalDistanceDistanceDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalDistanceDistanceMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string restriction
    {
        get
        {
            return this.restrictionField;
        }
        set
        {
            this.restrictionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDistanceDistanceTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDistanceDistanceNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDistanceDistanceDeviation
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalDistanceDistanceMeasured
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPoint
{

    private string commentField;

    private gomNominalPointMeasure_opposite measure_oppositeField;

    private uint actualField;

    private bool actualFieldSpecified;

    private string stateField;

    private gomNominalPointGeometry geometryField;

    private gomNominalPointResult resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointMeasure_opposite measure_opposite
    {
        get
        {
            return this.measure_oppositeField;
        }
        set
        {
            this.measure_oppositeField = value;
        }
    }

    /// <remarks/>
    public uint actual
    {
        get
        {
            return this.actualField;
        }
        set
        {
            this.actualField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool actualSpecified
    {
        get
        {
            return this.actualFieldSpecified;
        }
        set
        {
            this.actualFieldSpecified = value;
        }
    }

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResult result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointMeasure_opposite
{

    private string useField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
        get
        {
            return this.useField;
        }
        set
        {
            this.useField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointGeometry
{

    private gomNominalPointGeometryPos posField;

    private gomNominalPointGeometryNormal normalField;

    private gomNominalPointGeometryTrim trimField;

    /// <remarks/>
    public gomNominalPointGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointGeometryNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointGeometryTrim trim
    {
        get
        {
            return this.trimField;
        }
        set
        {
            this.trimField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointGeometryNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointGeometryTrim
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResult
{

    private gomNominalPointResultAll allField;

    private gomNominalPointResultInplane inplaneField;

    private gomNominalPointResultNormal normalField;

    private gomNominalPointResultTrim trimField;

    private gomNominalPointResultX xField;

    private gomNominalPointResultY yField;

    private gomNominalPointResultZ zField;

    /// <remarks/>
    public gomNominalPointResultAll all
    {
        get
        {
            return this.allField;
        }
        set
        {
            this.allField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultInplane inplane
    {
        get
        {
            return this.inplaneField;
        }
        set
        {
            this.inplaneField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultTrim trim
    {
        get
        {
            return this.trimField;
        }
        set
        {
            this.trimField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultX x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultY y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultZ z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultAll
{

    private gomNominalPointResultAllTolerance toleranceField;

    private gomNominalPointResultAllNominal_scalar nominal_scalarField;

    private gomNominalPointResultAllDeviation deviationField;

    private gomNominalPointResultAllMeasured measuredField;

    private byte checkedField;

    private string nameField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalPointResultAllTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultAllNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultAllDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultAllMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultAllTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultAllNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultAllDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultAllMeasured
{

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultInplane
{

    private gomNominalPointResultInplaneDeviation deviationField;

    private gomNominalPointResultInplaneMeasured measuredField;

    private byte checkedField;

    private string nameField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalPointResultInplaneDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultInplaneMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultInplaneDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultInplaneMeasured
{

    private string valueField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultNormal
{

    private gomNominalPointResultNormalTolerance toleranceField;

    private gomNominalPointResultNormalNominal_scalar nominal_scalarField;

    private gomNominalPointResultNormalDeviation deviationField;

    private gomNominalPointResultNormalMeasured measuredField;

    private byte checkedField;

    private string nameField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalPointResultNormalTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultNormalNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultNormalDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultNormalMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultNormalTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultNormalNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultNormalDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultNormalMeasured
{

    private string valueField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultTrim
{

    private gomNominalPointResultTrimTolerance toleranceField;

    private gomNominalPointResultTrimNominal_scalar nominal_scalarField;

    private gomNominalPointResultTrimDeviation deviationField;

    private gomNominalPointResultTrimMeasured measuredField;

    private byte checkedField;

    private string nameField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalPointResultTrimTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultTrimNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultTrimDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultTrimMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultTrimTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultTrimNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultTrimDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultTrimMeasured
{

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultX
{

    private gomNominalPointResultXTolerance toleranceField;

    private gomNominalPointResultXNominal_scalar nominal_scalarField;

    private gomNominalPointResultXDeviation deviationField;

    private gomNominalPointResultXMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalPointResultXTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultXNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultXDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultXMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultXTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultXNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultXDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultXMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultY
{

    private gomNominalPointResultYTolerance toleranceField;

    private gomNominalPointResultYNominal_scalar nominal_scalarField;

    private gomNominalPointResultYDeviation deviationField;

    private gomNominalPointResultYMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalPointResultYTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultYNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultYDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultYMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultYTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultYNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultYDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultYMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultZ
{

    private gomNominalPointResultZTolerance toleranceField;

    private gomNominalPointResultZNominal_scalar nominal_scalarField;

    private gomNominalPointResultZDeviation deviationField;

    private gomNominalPointResultZMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalPointResultZTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultZNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultZDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalPointResultZMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultZTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultZNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultZDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPointResultZMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPoint_cloud
{

    private string stateField;

    private gomNominalPoint_cloudPoint[] geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("point", IsNullable = false)]
    public gomNominalPoint_cloudPoint[] geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPoint_cloudPoint
{

    private gomNominalPoint_cloudPointNormal normalField;

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    public gomNominalPoint_cloudPointNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPoint_cloudPointNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_hole
{

    private uint actualField;

    private bool actualFieldSpecified;

    private string stateField;

    private gomNominalPolygon_holeGeometry geometryField;

    private gomNominalPolygon_holeResult resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public uint actual
    {
        get
        {
            return this.actualField;
        }
        set
        {
            this.actualField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool actualSpecified
    {
        get
        {
            return this.actualFieldSpecified;
        }
        set
        {
            this.actualFieldSpecified = value;
        }
    }

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeResult result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeGeometry
{

    private byte num_pointsField;

    private gomNominalPolygon_holeGeometryPos posField;

    private gomNominalPolygon_holeGeometryNormal normalField;

    private gomNominalPolygon_holeGeometryDir dirField;

    private decimal inner_radiusField;

    private decimal outer_radiusField;

    /// <remarks/>
    public byte num_points
    {
        get
        {
            return this.num_pointsField;
        }
        set
        {
            this.num_pointsField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeGeometryNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeGeometryDir dir
    {
        get
        {
            return this.dirField;
        }
        set
        {
            this.dirField = value;
        }
    }

    /// <remarks/>
    public decimal inner_radius
    {
        get
        {
            return this.inner_radiusField;
        }
        set
        {
            this.inner_radiusField = value;
        }
    }

    /// <remarks/>
    public decimal outer_radius
    {
        get
        {
            return this.outer_radiusField;
        }
        set
        {
            this.outer_radiusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeGeometryNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeGeometryDir
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResult
{

    private gomNominalPolygon_holeResultAll allField;

    private gomNominalPolygon_holeResultInner_diameter inner_diameterField;

    private gomNominalPolygon_holeResultInplane inplaneField;

    private gomNominalPolygon_holeResultNormal normalField;

    private gomNominalPolygon_holeResultOuter_diameter outer_diameterField;

    /// <remarks/>
    public gomNominalPolygon_holeResultAll all
    {
        get
        {
            return this.allField;
        }
        set
        {
            this.allField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeResultInner_diameter inner_diameter
    {
        get
        {
            return this.inner_diameterField;
        }
        set
        {
            this.inner_diameterField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeResultInplane inplane
    {
        get
        {
            return this.inplaneField;
        }
        set
        {
            this.inplaneField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeResultNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeResultOuter_diameter outer_diameter
    {
        get
        {
            return this.outer_diameterField;
        }
        set
        {
            this.outer_diameterField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultAll
{

    private gomNominalPolygon_holeResultAllDeviation deviationField;

    private gomNominalPolygon_holeResultAllMeasured measuredField;

    private byte checkedField;

    private string nameField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalPolygon_holeResultAllDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeResultAllMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultAllDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultAllMeasured
{

    private string valueField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultInner_diameter
{

    private gomNominalPolygon_holeResultInner_diameterDeviation deviationField;

    private gomNominalPolygon_holeResultInner_diameterMeasured measuredField;

    private byte checkedField;

    private string nameField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalPolygon_holeResultInner_diameterDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeResultInner_diameterMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultInner_diameterDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultInner_diameterMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultInplane
{

    private gomNominalPolygon_holeResultInplaneDeviation deviationField;

    private gomNominalPolygon_holeResultInplaneMeasured measuredField;

    private byte checkedField;

    private string nameField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalPolygon_holeResultInplaneDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeResultInplaneMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultInplaneDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultInplaneMeasured
{

    private string valueField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultNormal
{

    private gomNominalPolygon_holeResultNormalDeviation deviationField;

    private gomNominalPolygon_holeResultNormalMeasured measuredField;

    private byte checkedField;

    private string nameField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalPolygon_holeResultNormalDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeResultNormalMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultNormalDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultNormalMeasured
{

    private string valueField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultOuter_diameter
{

    private gomNominalPolygon_holeResultOuter_diameterDeviation deviationField;

    private gomNominalPolygon_holeResultOuter_diameterMeasured measuredField;

    private byte checkedField;

    private string nameField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalPolygon_holeResultOuter_diameterDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalPolygon_holeResultOuter_diameterMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultOuter_diameterDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalPolygon_holeResultOuter_diameterMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_hole
{

    private uint actualField;

    private bool actualFieldSpecified;

    private gomNominalRectangular_holeMeasure_opposite measure_oppositeField;

    private string stateField;

    private gomNominalRectangular_holeGeometry geometryField;

    private gomNominalRectangular_holeResult resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public uint actual
    {
        get
        {
            return this.actualField;
        }
        set
        {
            this.actualField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool actualSpecified
    {
        get
        {
            return this.actualFieldSpecified;
        }
        set
        {
            this.actualFieldSpecified = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeMeasure_opposite measure_opposite
    {
        get
        {
            return this.measure_oppositeField;
        }
        set
        {
            this.measure_oppositeField = value;
        }
    }

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResult result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeMeasure_opposite
{

    private string useField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
        get
        {
            return this.useField;
        }
        set
        {
            this.useField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeGeometry
{

    private gomNominalRectangular_holeGeometryPos posField;

    private gomNominalRectangular_holeGeometryNormal normalField;

    private gomNominalRectangular_holeGeometryDir dirField;

    private decimal widthField;

    private decimal lengthField;

    private decimal edge_radiusField;

    /// <remarks/>
    public gomNominalRectangular_holeGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeGeometryNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeGeometryDir dir
    {
        get
        {
            return this.dirField;
        }
        set
        {
            this.dirField = value;
        }
    }

    /// <remarks/>
    public decimal width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    public decimal length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }

    /// <remarks/>
    public decimal edge_radius
    {
        get
        {
            return this.edge_radiusField;
        }
        set
        {
            this.edge_radiusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeGeometryNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeGeometryDir
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResult
{

    private gomNominalRectangular_holeResultAll allField;

    private gomNominalRectangular_holeResultInplane inplaneField;

    private gomNominalRectangular_holeResultLength lengthField;

    private gomNominalRectangular_holeResultNormal normalField;

    private gomNominalRectangular_holeResultWidth widthField;

    private gomNominalRectangular_holeResultX xField;

    private gomNominalRectangular_holeResultY yField;

    private gomNominalRectangular_holeResultZ zField;

    /// <remarks/>
    public gomNominalRectangular_holeResultAll all
    {
        get
        {
            return this.allField;
        }
        set
        {
            this.allField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultInplane inplane
    {
        get
        {
            return this.inplaneField;
        }
        set
        {
            this.inplaneField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultLength length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultWidth width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultX x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultY y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultZ z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultAll
{

    private gomNominalRectangular_holeResultAllTolerance toleranceField;

    private gomNominalRectangular_holeResultAllNominal_scalar nominal_scalarField;

    private gomNominalRectangular_holeResultAllDeviation deviationField;

    private gomNominalRectangular_holeResultAllMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    private string nameField;

    /// <remarks/>
    public gomNominalRectangular_holeResultAllTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultAllNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultAllDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultAllMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultAllTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultAllNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultAllDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultAllMeasured
{

    private string valueField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultInplane
{

    private gomNominalRectangular_holeResultInplaneTolerance toleranceField;

    private gomNominalRectangular_holeResultInplaneNominal_scalar nominal_scalarField;

    private gomNominalRectangular_holeResultInplaneDeviation deviationField;

    private gomNominalRectangular_holeResultInplaneMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    private string nameField;

    /// <remarks/>
    public gomNominalRectangular_holeResultInplaneTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultInplaneNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultInplaneDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultInplaneMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultInplaneTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultInplaneNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultInplaneDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultInplaneMeasured
{

    private string valueField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultLength
{

    private gomNominalRectangular_holeResultLengthTolerance toleranceField;

    private gomNominalRectangular_holeResultLengthNominal_scalar nominal_scalarField;

    private gomNominalRectangular_holeResultLengthDeviation deviationField;

    private gomNominalRectangular_holeResultLengthMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    private string nameField;

    /// <remarks/>
    public gomNominalRectangular_holeResultLengthTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultLengthNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultLengthDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultLengthMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultLengthTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultLengthNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultLengthDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultLengthMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultNormal
{

    private gomNominalRectangular_holeResultNormalTolerance toleranceField;

    private gomNominalRectangular_holeResultNormalNominal_scalar nominal_scalarField;

    private gomNominalRectangular_holeResultNormalDeviation deviationField;

    private gomNominalRectangular_holeResultNormalMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    private string nameField;

    /// <remarks/>
    public gomNominalRectangular_holeResultNormalTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultNormalNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultNormalDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultNormalMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultNormalTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultNormalNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultNormalDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultNormalMeasured
{

    private string valueField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultWidth
{

    private gomNominalRectangular_holeResultWidthTolerance toleranceField;

    private gomNominalRectangular_holeResultWidthNominal_scalar nominal_scalarField;

    private gomNominalRectangular_holeResultWidthDeviation deviationField;

    private gomNominalRectangular_holeResultWidthMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    private string nameField;

    /// <remarks/>
    public gomNominalRectangular_holeResultWidthTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultWidthNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultWidthDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultWidthMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultWidthTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultWidthNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultWidthDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultWidthMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultX
{

    private gomNominalRectangular_holeResultXTolerance toleranceField;

    private gomNominalRectangular_holeResultXNominal_scalar nominal_scalarField;

    private gomNominalRectangular_holeResultXDeviation deviationField;

    private gomNominalRectangular_holeResultXMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalRectangular_holeResultXTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultXNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultXDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultXMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultXTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultXNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultXDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultXMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultY
{

    private gomNominalRectangular_holeResultYTolerance toleranceField;

    private gomNominalRectangular_holeResultYNominal_scalar nominal_scalarField;

    private gomNominalRectangular_holeResultYDeviation deviationField;

    private gomNominalRectangular_holeResultYMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalRectangular_holeResultYTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultYNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultYDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultYMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultYTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultYNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultYDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultYMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultZ
{

    private gomNominalRectangular_holeResultZTolerance toleranceField;

    private gomNominalRectangular_holeResultZNominal_scalar nominal_scalarField;

    private gomNominalRectangular_holeResultZDeviation deviationField;

    private gomNominalRectangular_holeResultZMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalRectangular_holeResultZTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultZNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultZDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalRectangular_holeResultZMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultZTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultZNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultZDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalRectangular_holeResultZMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_hole
{

    private uint actualField;

    private bool actualFieldSpecified;

    private gomNominalSlotted_holeMeasure_opposite measure_oppositeField;

    private string stateField;

    private gomNominalSlotted_holeGeometry geometryField;

    private gomNominalSlotted_holeResult resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public uint actual
    {
        get
        {
            return this.actualField;
        }
        set
        {
            this.actualField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool actualSpecified
    {
        get
        {
            return this.actualFieldSpecified;
        }
        set
        {
            this.actualFieldSpecified = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeMeasure_opposite measure_opposite
    {
        get
        {
            return this.measure_oppositeField;
        }
        set
        {
            this.measure_oppositeField = value;
        }
    }

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResult result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeMeasure_opposite
{

    private string useField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
        get
        {
            return this.useField;
        }
        set
        {
            this.useField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeGeometry
{

    private gomNominalSlotted_holeGeometryPos posField;

    private gomNominalSlotted_holeGeometryNormal normalField;

    private gomNominalSlotted_holeGeometryDir dirField;

    private decimal widthField;

    private decimal lengthField;

    /// <remarks/>
    public gomNominalSlotted_holeGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeGeometryNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeGeometryDir dir
    {
        get
        {
            return this.dirField;
        }
        set
        {
            this.dirField = value;
        }
    }

    /// <remarks/>
    public decimal width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    public decimal length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeGeometryNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeGeometryDir
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResult
{

    private gomNominalSlotted_holeResultAll allField;

    private gomNominalSlotted_holeResultInplane inplaneField;

    private gomNominalSlotted_holeResultLength lengthField;

    private gomNominalSlotted_holeResultNormal normalField;

    private gomNominalSlotted_holeResultWidth widthField;

    private gomNominalSlotted_holeResultX xField;

    private gomNominalSlotted_holeResultY yField;

    private gomNominalSlotted_holeResultZ zField;

    /// <remarks/>
    public gomNominalSlotted_holeResultAll all
    {
        get
        {
            return this.allField;
        }
        set
        {
            this.allField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultInplane inplane
    {
        get
        {
            return this.inplaneField;
        }
        set
        {
            this.inplaneField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultLength length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultWidth width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultX x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultY y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultZ z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultAll
{

    private gomNominalSlotted_holeResultAllTolerance toleranceField;

    private gomNominalSlotted_holeResultAllNominal_scalar nominal_scalarField;

    private gomNominalSlotted_holeResultAllDeviation deviationField;

    private gomNominalSlotted_holeResultAllMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    private string nameField;

    /// <remarks/>
    public gomNominalSlotted_holeResultAllTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultAllNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultAllDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultAllMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultAllTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultAllNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultAllDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultAllMeasured
{

    private string valueField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultInplane
{

    private gomNominalSlotted_holeResultInplaneTolerance toleranceField;

    private gomNominalSlotted_holeResultInplaneNominal_scalar nominal_scalarField;

    private gomNominalSlotted_holeResultInplaneDeviation deviationField;

    private gomNominalSlotted_holeResultInplaneMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    private string nameField;

    /// <remarks/>
    public gomNominalSlotted_holeResultInplaneTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultInplaneNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultInplaneDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultInplaneMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultInplaneTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultInplaneNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultInplaneDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultInplaneMeasured
{

    private string valueField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultLength
{

    private gomNominalSlotted_holeResultLengthTolerance toleranceField;

    private gomNominalSlotted_holeResultLengthNominal_scalar nominal_scalarField;

    private gomNominalSlotted_holeResultLengthDeviation deviationField;

    private gomNominalSlotted_holeResultLengthMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    private string nameField;

    /// <remarks/>
    public gomNominalSlotted_holeResultLengthTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultLengthNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultLengthDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultLengthMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultLengthTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultLengthNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultLengthDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultLengthMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultNormal
{

    private gomNominalSlotted_holeResultNormalTolerance toleranceField;

    private gomNominalSlotted_holeResultNormalNominal_scalar nominal_scalarField;

    private gomNominalSlotted_holeResultNormalDeviation deviationField;

    private gomNominalSlotted_holeResultNormalMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    private string nameField;

    /// <remarks/>
    public gomNominalSlotted_holeResultNormalTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultNormalNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultNormalDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultNormalMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultNormalTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultNormalNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultNormalDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultNormalMeasured
{

    private string valueField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal zField;

    private bool zFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool zSpecified
    {
        get
        {
            return this.zFieldSpecified;
        }
        set
        {
            this.zFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultWidth
{

    private gomNominalSlotted_holeResultWidthTolerance toleranceField;

    private gomNominalSlotted_holeResultWidthNominal_scalar nominal_scalarField;

    private gomNominalSlotted_holeResultWidthDeviation deviationField;

    private gomNominalSlotted_holeResultWidthMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    private string nameField;

    /// <remarks/>
    public gomNominalSlotted_holeResultWidthTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultWidthNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultWidthDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultWidthMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultWidthTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultWidthNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultWidthDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultWidthMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultX
{

    private gomNominalSlotted_holeResultXTolerance toleranceField;

    private gomNominalSlotted_holeResultXNominal_scalar nominal_scalarField;

    private gomNominalSlotted_holeResultXDeviation deviationField;

    private gomNominalSlotted_holeResultXMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalSlotted_holeResultXTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultXNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultXDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultXMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultXTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultXNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultXDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultXMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultY
{

    private gomNominalSlotted_holeResultYTolerance toleranceField;

    private gomNominalSlotted_holeResultYNominal_scalar nominal_scalarField;

    private gomNominalSlotted_holeResultYDeviation deviationField;

    private gomNominalSlotted_holeResultYMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalSlotted_holeResultYTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultYNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultYDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultYMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultYTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultYNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultYDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultYMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultZ
{

    private gomNominalSlotted_holeResultZTolerance toleranceField;

    private gomNominalSlotted_holeResultZNominal_scalar nominal_scalarField;

    private gomNominalSlotted_holeResultZDeviation deviationField;

    private gomNominalSlotted_holeResultZMeasured measuredField;

    private byte checkedField;

    private string unit_nameField;

    /// <remarks/>
    public gomNominalSlotted_holeResultZTolerance tolerance
    {
        get
        {
            return this.toleranceField;
        }
        set
        {
            this.toleranceField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultZNominal_scalar nominal_scalar
    {
        get
        {
            return this.nominal_scalarField;
        }
        set
        {
            this.nominal_scalarField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultZDeviation deviation
    {
        get
        {
            return this.deviationField;
        }
        set
        {
            this.deviationField = value;
        }
    }

    /// <remarks/>
    public gomNominalSlotted_holeResultZMeasured measured
    {
        get
        {
            return this.measuredField;
        }
        set
        {
            this.measuredField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @checked
    {
        get
        {
            return this.checkedField;
        }
        set
        {
            this.checkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit_name
    {
        get
        {
            return this.unit_nameField;
        }
        set
        {
            this.unit_nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultZTolerance
{

    private decimal lower_limitField;

    private decimal upper_limitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lower_limit
    {
        get
        {
            return this.lower_limitField;
        }
        set
        {
            this.lower_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal upper_limit
    {
        get
        {
            return this.upper_limitField;
        }
        set
        {
            this.upper_limitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultZNominal_scalar
{

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultZDeviation
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomNominalSlotted_holeResultZMeasured
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasured
{

    private object[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("angle_3d", typeof(gomMeasuredAngle_3d))]
    [System.Xml.Serialization.XmlElementAttribute("circle", typeof(gomMeasuredCircle))]
    [System.Xml.Serialization.XmlElementAttribute("cone", typeof(gomMeasuredCone))]
    [System.Xml.Serialization.XmlElementAttribute("curve", typeof(gomMeasuredCurve))]
    [System.Xml.Serialization.XmlElementAttribute("cylinder", typeof(gomMeasuredCylinder))]
    [System.Xml.Serialization.XmlElementAttribute("distance", typeof(gomMeasuredDistance))]
    [System.Xml.Serialization.XmlElementAttribute("line", typeof(gomMeasuredLine))]
    [System.Xml.Serialization.XmlElementAttribute("plane", typeof(gomMeasuredPlane))]
    [System.Xml.Serialization.XmlElementAttribute("point", typeof(gomMeasuredPoint))]
    [System.Xml.Serialization.XmlElementAttribute("point_cloud", typeof(gomMeasuredPoint_cloud))]
    [System.Xml.Serialization.XmlElementAttribute("polygon_hole", typeof(gomMeasuredPolygon_hole))]
    [System.Xml.Serialization.XmlElementAttribute("rectangular_hole", typeof(gomMeasuredRectangular_hole))]
    [System.Xml.Serialization.XmlElementAttribute("slotted_hole", typeof(gomMeasuredSlotted_hole))]
    [System.Xml.Serialization.XmlElementAttribute("sphere", typeof(gomMeasuredSphere))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredAngle_3d
{

    private string commentField;

    private string stateField;

    private gomMeasuredAngle_3dGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredAngle_3dGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredAngle_3dGeometry
{

    private decimal angleField;

    private gomMeasuredAngle_3dGeometryPos posField;

    private gomMeasuredAngle_3dGeometryPos1 pos1Field;

    private gomMeasuredAngle_3dGeometryPos2 pos2Field;

    /// <remarks/>
    public decimal angle
    {
        get
        {
            return this.angleField;
        }
        set
        {
            this.angleField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredAngle_3dGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredAngle_3dGeometryPos1 pos1
    {
        get
        {
            return this.pos1Field;
        }
        set
        {
            this.pos1Field = value;
        }
    }

    /// <remarks/>
    public gomMeasuredAngle_3dGeometryPos2 pos2
    {
        get
        {
            return this.pos2Field;
        }
        set
        {
            this.pos2Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredAngle_3dGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredAngle_3dGeometryPos1
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredAngle_3dGeometryPos2
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCircle
{

    private string stateField;

    private gomMeasuredCircleGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredCircleGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCircleGeometry
{

    private gomMeasuredCircleGeometryPos posField;

    private gomMeasuredCircleGeometryNormal normalField;

    private decimal radiusField;

    /// <remarks/>
    public gomMeasuredCircleGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredCircleGeometryNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public decimal radius
    {
        get
        {
            return this.radiusField;
        }
        set
        {
            this.radiusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCircleGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCircleGeometryNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCone
{

    private string stateField;

    private gomMeasuredConeGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredConeGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredConeGeometry
{

    private gomMeasuredConeGeometryPos1 pos1Field;

    private gomMeasuredConeGeometryPos2 pos2Field;

    private gomMeasuredConeGeometryDir dirField;

    private decimal radius1Field;

    private decimal radius2Field;

    private decimal angleField;

    private gomMeasuredConeGeometryOrigin originField;

    private decimal height1Field;

    private decimal height2Field;

    /// <remarks/>
    public gomMeasuredConeGeometryPos1 pos1
    {
        get
        {
            return this.pos1Field;
        }
        set
        {
            this.pos1Field = value;
        }
    }

    /// <remarks/>
    public gomMeasuredConeGeometryPos2 pos2
    {
        get
        {
            return this.pos2Field;
        }
        set
        {
            this.pos2Field = value;
        }
    }

    /// <remarks/>
    public gomMeasuredConeGeometryDir dir
    {
        get
        {
            return this.dirField;
        }
        set
        {
            this.dirField = value;
        }
    }

    /// <remarks/>
    public decimal radius1
    {
        get
        {
            return this.radius1Field;
        }
        set
        {
            this.radius1Field = value;
        }
    }

    /// <remarks/>
    public decimal radius2
    {
        get
        {
            return this.radius2Field;
        }
        set
        {
            this.radius2Field = value;
        }
    }

    /// <remarks/>
    public decimal angle
    {
        get
        {
            return this.angleField;
        }
        set
        {
            this.angleField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredConeGeometryOrigin origin
    {
        get
        {
            return this.originField;
        }
        set
        {
            this.originField = value;
        }
    }

    /// <remarks/>
    public decimal height1
    {
        get
        {
            return this.height1Field;
        }
        set
        {
            this.height1Field = value;
        }
    }

    /// <remarks/>
    public decimal height2
    {
        get
        {
            return this.height2Field;
        }
        set
        {
            this.height2Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredConeGeometryPos1
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredConeGeometryPos2
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredConeGeometryDir
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredConeGeometryOrigin
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCurve
{

    private string stateField;

    private gomMeasuredCurveGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredCurveGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCurveGeometry
{

    private gomMeasuredCurveGeometryCurve_data curve_dataField;

    /// <remarks/>
    public gomMeasuredCurveGeometryCurve_data curve_data
    {
        get
        {
            return this.curve_dataField;
        }
        set
        {
            this.curve_dataField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCurveGeometryCurve_data
{

    private byte chunkField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte chunk
    {
        get
        {
            return this.chunkField;
        }
        set
        {
            this.chunkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCylinder
{

    private string stateField;

    private gomMeasuredCylinderGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredCylinderGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCylinderGeometry
{

    private gomMeasuredCylinderGeometryPos1 pos1Field;

    private gomMeasuredCylinderGeometryPos2 pos2Field;

    private gomMeasuredCylinderGeometryDir dirField;

    private decimal radiusField;

    private decimal lengthField;

    /// <remarks/>
    public gomMeasuredCylinderGeometryPos1 pos1
    {
        get
        {
            return this.pos1Field;
        }
        set
        {
            this.pos1Field = value;
        }
    }

    /// <remarks/>
    public gomMeasuredCylinderGeometryPos2 pos2
    {
        get
        {
            return this.pos2Field;
        }
        set
        {
            this.pos2Field = value;
        }
    }

    /// <remarks/>
    public gomMeasuredCylinderGeometryDir dir
    {
        get
        {
            return this.dirField;
        }
        set
        {
            this.dirField = value;
        }
    }

    /// <remarks/>
    public decimal radius
    {
        get
        {
            return this.radiusField;
        }
        set
        {
            this.radiusField = value;
        }
    }

    /// <remarks/>
    public decimal length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCylinderGeometryPos1
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCylinderGeometryPos2
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredCylinderGeometryDir
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredDistance
{

    private string stateField;

    private gomMeasuredDistanceGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredDistanceGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredDistanceGeometry
{

    private gomMeasuredDistanceGeometryDistance distanceField;

    private decimal lengthField;

    private gomMeasuredDistanceGeometryPos1 pos1Field;

    private gomMeasuredDistanceGeometryPos2 pos2Field;

    /// <remarks/>
    public gomMeasuredDistanceGeometryDistance distance
    {
        get
        {
            return this.distanceField;
        }
        set
        {
            this.distanceField = value;
        }
    }

    /// <remarks/>
    public decimal length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredDistanceGeometryPos1 pos1
    {
        get
        {
            return this.pos1Field;
        }
        set
        {
            this.pos1Field = value;
        }
    }

    /// <remarks/>
    public gomMeasuredDistanceGeometryPos2 pos2
    {
        get
        {
            return this.pos2Field;
        }
        set
        {
            this.pos2Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredDistanceGeometryDistance
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredDistanceGeometryPos1
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredDistanceGeometryPos2
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredLine
{

    private string commentField;

    private string stateField;

    private gomMeasuredLineGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredLineGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredLineGeometry
{

    private gomMeasuredLineGeometryPos1 pos1Field;

    private gomMeasuredLineGeometryPos2 pos2Field;

    private decimal lengthField;

    private gomMeasuredLineGeometryDir dirField;

    /// <remarks/>
    public gomMeasuredLineGeometryPos1 pos1
    {
        get
        {
            return this.pos1Field;
        }
        set
        {
            this.pos1Field = value;
        }
    }

    /// <remarks/>
    public gomMeasuredLineGeometryPos2 pos2
    {
        get
        {
            return this.pos2Field;
        }
        set
        {
            this.pos2Field = value;
        }
    }

    /// <remarks/>
    public decimal length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredLineGeometryDir dir
    {
        get
        {
            return this.dirField;
        }
        set
        {
            this.dirField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredLineGeometryPos1
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredLineGeometryPos2
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredLineGeometryDir
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPlane
{

    private string stateField;

    private gomMeasuredPlaneGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredPlaneGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPlaneGeometry
{

    private gomMeasuredPlaneGeometryNormal normalField;

    private decimal distanceField;

    private gomMeasuredPlaneGeometryPos posField;

    private decimal lengthField;

    private decimal widthField;

    private decimal orientationField;

    /// <remarks/>
    public gomMeasuredPlaneGeometryNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public decimal distance
    {
        get
        {
            return this.distanceField;
        }
        set
        {
            this.distanceField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredPlaneGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public decimal length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }

    /// <remarks/>
    public decimal width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    public decimal orientation
    {
        get
        {
            return this.orientationField;
        }
        set
        {
            this.orientationField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPlaneGeometryNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPlaneGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPoint
{

    private string commentField;

    private string stateField;

    private gomMeasuredPointGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredPointGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPointGeometry
{

    private gomMeasuredPointGeometryPos posField;

    private gomMeasuredPointGeometryNormal normalField;

    /// <remarks/>
    public gomMeasuredPointGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredPointGeometryNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPointGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPointGeometryNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPoint_cloud
{

    private string stateField;

    private gomMeasuredPoint_cloudPoint[] geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("point", IsNullable = false)]
    public gomMeasuredPoint_cloudPoint[] geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPoint_cloudPoint
{

    private gomMeasuredPoint_cloudPointNormal normalField;

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    public gomMeasuredPoint_cloudPointNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPoint_cloudPointNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPolygon_hole
{

    private string stateField;

    private gomMeasuredPolygon_holeGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredPolygon_holeGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPolygon_holeGeometry
{

    private byte num_pointsField;

    private gomMeasuredPolygon_holeGeometryPos posField;

    private gomMeasuredPolygon_holeGeometryNormal normalField;

    private gomMeasuredPolygon_holeGeometryDir dirField;

    private decimal inner_radiusField;

    private decimal outer_radiusField;

    /// <remarks/>
    public byte num_points
    {
        get
        {
            return this.num_pointsField;
        }
        set
        {
            this.num_pointsField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredPolygon_holeGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredPolygon_holeGeometryNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredPolygon_holeGeometryDir dir
    {
        get
        {
            return this.dirField;
        }
        set
        {
            this.dirField = value;
        }
    }

    /// <remarks/>
    public decimal inner_radius
    {
        get
        {
            return this.inner_radiusField;
        }
        set
        {
            this.inner_radiusField = value;
        }
    }

    /// <remarks/>
    public decimal outer_radius
    {
        get
        {
            return this.outer_radiusField;
        }
        set
        {
            this.outer_radiusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPolygon_holeGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPolygon_holeGeometryNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredPolygon_holeGeometryDir
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredRectangular_hole
{

    private string stateField;

    private gomMeasuredRectangular_holeGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredRectangular_holeGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredRectangular_holeGeometry
{

    private gomMeasuredRectangular_holeGeometryPos posField;

    private gomMeasuredRectangular_holeGeometryNormal normalField;

    private gomMeasuredRectangular_holeGeometryDir dirField;

    private decimal widthField;

    private decimal lengthField;

    private decimal edge_radiusField;

    /// <remarks/>
    public gomMeasuredRectangular_holeGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredRectangular_holeGeometryNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredRectangular_holeGeometryDir dir
    {
        get
        {
            return this.dirField;
        }
        set
        {
            this.dirField = value;
        }
    }

    /// <remarks/>
    public decimal width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    public decimal length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }

    /// <remarks/>
    public decimal edge_radius
    {
        get
        {
            return this.edge_radiusField;
        }
        set
        {
            this.edge_radiusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredRectangular_holeGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredRectangular_holeGeometryNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredRectangular_holeGeometryDir
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredSlotted_hole
{

    private string stateField;

    private gomMeasuredSlotted_holeGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredSlotted_holeGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredSlotted_holeGeometry
{

    private gomMeasuredSlotted_holeGeometryPos posField;

    private gomMeasuredSlotted_holeGeometryNormal normalField;

    private gomMeasuredSlotted_holeGeometryDir dirField;

    private decimal widthField;

    private decimal lengthField;

    /// <remarks/>
    public gomMeasuredSlotted_holeGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredSlotted_holeGeometryNormal normal
    {
        get
        {
            return this.normalField;
        }
        set
        {
            this.normalField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredSlotted_holeGeometryDir dir
    {
        get
        {
            return this.dirField;
        }
        set
        {
            this.dirField = value;
        }
    }

    /// <remarks/>
    public decimal width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    public decimal length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredSlotted_holeGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredSlotted_holeGeometryNormal
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredSlotted_holeGeometryDir
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredSphere
{

    private string stateField;

    private gomMeasuredSphereGeometry geometryField;

    private object resultField;

    private uint idField;

    private string nameField;

    /// <remarks/>
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public gomMeasuredSphereGeometry geometry
    {
        get
        {
            return this.geometryField;
        }
        set
        {
            this.geometryField = value;
        }
    }

    /// <remarks/>
    public object result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredSphereGeometry
{

    private gomMeasuredSphereGeometryPos posField;

    private decimal radiusField;

    /// <remarks/>
    public gomMeasuredSphereGeometryPos pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    public decimal radius
    {
        get
        {
            return this.radiusField;
        }
        set
        {
            this.radiusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class gomMeasuredSphereGeometryPos
{

    private decimal xField;

    private decimal yField;

    private decimal zField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal z
    {
        get
        {
            return this.zField;
        }
        set
        {
            this.zField = value;
        }
    }
}

