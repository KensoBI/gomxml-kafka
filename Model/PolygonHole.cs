using System.Xml.Serialization;

namespace Kenso.Loaders.Gom.Model;

[Serializable]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class PolygonHole : Element
{
    public override FeatureType ElementType => FeatureType.PolygonHole;
}