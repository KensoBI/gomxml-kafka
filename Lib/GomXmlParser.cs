using System.IO.Compression;
using System.Xml.Serialization;
using Kenso.Loaders.Gom.Model;
using Microsoft.Extensions.Logging;

namespace Kenso.Loaders.Gom
{
    public class GomXmlParser
    {
        private readonly ILogger<GomXmlParser> _logger;

        public GomXmlParser(ILogger<GomXmlParser> logger)
        {
            _logger = logger;
        }

        public List<GomElements> GetGomElements(string pathToXmlDir)
        {
            if (string.IsNullOrEmpty(pathToXmlDir) || !Directory.Exists(pathToXmlDir))
            {
                throw new ArgumentException("'pathToXmlDir' not provided or does not exist.");
            }

            var gomElementsList = new List<GomElements>();
            _logger.LogInformation("Reading XML files in {pathToXmlDir}", pathToXmlDir);
            var filePaths = Directory.GetFiles(pathToXmlDir, "*.xml");

            if (!filePaths.Any())
            {
                _logger.LogInformation("No xml files found.");
                return gomElementsList;
            }

            foreach (var filePath in filePaths)
            {
                _logger.LogInformation("Reading file {filePath}.", filePath);
                try
                {
                    var gomXml = ReadXml(filePath);
                    if (gomXml == null)
                    {
                        _logger.LogWarning("Unable to deserialize {filePath}.", filePath);
                        continue;
                    }

                    var fileElements = ParseGomXml(gomXml, Path.GetFileName(filePath));
                    gomElementsList.Add(fileElements);
                }
                catch (Exception exception)
                {
                    _logger.LogError("Error while processing {filePath}: {errorMessage}\nStack:{stagTrace}",
                        filePath, exception.Message, exception.StackTrace);
                }

            }
            return gomElementsList;
        }

        public Model.Gom? ReadXml(string path)
        {
            _logger.LogInformation("Reading XML file ");
            
            var reader = new XmlSerializer(typeof(Model.Gom));
            var file = new StreamReader(path);
            var gomXml = reader.Deserialize(file) as Model.Gom;
            file.Close();
            return gomXml;
        }

        public GomElements ParseGomXml(Model.Gom xml, string fileName)
        {
            var elements = new GomElements
            {
                ImportDate = DateTime.UtcNow,
                FileName = fileName,
                AngleUnit = xml.Header.AngleUnit,
                GomVersion = xml.Header.Version,
                LengthUnit = xml.Header.LengthUnit
            };

            if (xml.Nominal != null)
            {
                elements.Nominal = xml.Nominal.Items.Select(ParseElement).ToList();
            }

            if (xml.Measured != null)
            {
                elements.Actual = xml.Measured.Items.Select(ParseElement).ToList();
            }

            return elements;
        }

        public Feature ParseElement(Element element)
        {
            var feature = new Feature();
            feature.Name = element.Name;
            feature.Type = element.ElementType.ToString();
            feature.GomId = element.Id;
            feature.Actual = element.Actual;
            feature.Comment = element.Comment;

            if (element.Result != null)
            {
                var measured = ParseMeasured(element.Result);
                feature.Characteristics.AddRange(measured);
            }

            if (element.Geometry == null) return feature;

            var geometryCharacteristics = ParseGeometry(element.Geometry);
            foreach (var gc in geometryCharacteristics)
            {
                var resultChar = feature.Characteristics.FirstOrDefault(p => p.Name == gc.Name);
                    
                if(resultChar == null){
                    feature.Characteristics.Add(gc);
                }
                else
                {
                    resultChar.Nominal = gc.Nominal;
                }
            }
            return feature;
        }

        public Characteristic ParseElementResult(ElementResult result, string name)
        {
            var c = new Characteristic();
            var meas = new Measurement();

            c.Name = name;
            c.Measurements.Add(meas);
            c.Unit = result.UnitName;
            if (result.Tolerance != null)
            {
                c.Lsl = result.Tolerance.LowerLimit;
                c.Usl = result.Tolerance.UpperLimit;
            }

            if (result.NominalScalar != null)
            {
                c.Nominal = result.NominalScalar.Value;
                meas.Nominal = c.Nominal;
            }

            if (decimal.TryParse(result.Deviation?.Value, out var deviation))
            {
                meas.Deviation = deviation;
            }

            if (decimal.TryParse(result.Measured?.Value, out var measValue))
            {
                meas.Value = measValue;
            }

            meas.X = result.Measured?.X;
            meas.Y = result.Measured?.Y;
            meas.Z = result.Measured?.Z;

            return c;
        }

        public List<Characteristic> ParseMeasured(Result result)
        {
            var crs = new List<Characteristic>();
            if (result.All != null)
            {
                crs.Add(ParseElementResult(result.All,"all"));
            }

            if (result.X != null)
            {
                crs.Add(ParseElementResult(result.X, "x"));
            }

            if (result.Y != null)
            {
                crs.Add(ParseElementResult(result.Y,"y"));
            }

            if (result.Z != null)
            {
                crs.Add(ParseElementResult(result.Z, "z"));
            }

            if (result.Radius != null)
            {
                crs.Add(ParseElementResult(result.Radius, "radius"));
            }

            if (result.InnerRadius != null)
            {
                crs.Add(ParseElementResult(result.InnerRadius, "inner_radius"));
            }

            if (result.OuterRadius != null)
            {
                crs.Add(ParseElementResult(result.OuterRadius, "outer_radius"));
            }

            if (result.Diameter != null)
            {
                crs.Add(ParseElementResult(result.Diameter, "diameter"));
            }

            if (result.OuterDiameter != null)
            {
                crs.Add(ParseElementResult(result.OuterDiameter, "outer_diameter"));
            }

            if (result.InnerDiameter != null)
            {
                crs.Add(ParseElementResult(result.InnerDiameter, "inner_diameter"));
            }

            if (result.Width != null)
            {
                crs.Add(ParseElementResult(result.Width, "width"));
            }

            if (result.Normal != null)
            {
                crs.Add(ParseElementResult(result.Normal, "normal"));
            }

            if (result.Trim != null)
            {
                crs.Add(ParseElementResult(result.Trim, "trim"));
            }

            if (result.Inplane != null)
            {
                crs.Add(ParseElementResult(result.Inplane, "inplane"));
            }

            if (result.Length != null)
            {
                crs.Add(ParseElementResult(result.Length, "length"));
            }

            if (result.Angle != null)
            {
                crs.Add(ParseElementResult(result.Angle, "angle"));
            }

            if (result.TolSize != null)
            {
                crs.Add(ParseElementResult(result.TolSize, "tol_size"));
            }

            if (result.Direction1 != null)
            {
                crs.Add(ParseElementResult(result.Direction1, "direction1"));
            }

            if (result.Direction2 != null)
            {
                crs.Add(ParseElementResult(result.Direction2, "direction2"));
            }

            if (result.Direction3 != null)
            {
                crs.Add(ParseElementResult(result.Direction3, "direction3"));
            }

            if (result.LinearSize != null)
            {
                crs.Add(ParseElementResult(result.LinearSize, "linear_size"));
            }

            if (result.Acceleration != null)
            {
                crs.Add(ParseElementResult(result.Acceleration, "acceleration"));
            }

            if (result.Velocity != null)
            {
                crs.Add(ParseElementResult(result.Velocity, "velocity"));
            }

            if (result.Displacement != null)
            {
                crs.Add(ParseElementResult(result.Displacement, "displacement"));
            }

            return crs;
        }

        public List<Characteristic> ParseGeometry(Geometry geometry)
        {
            var crs = new List<Characteristic>();

            if (geometry.Position != null)
            {
                crs.AddRange(ParsePosition(geometry.Position));
            }
            if (geometry.Normal != null)
            {
                crs.AddRange(ParsePosition(geometry.Normal, "normal"));
            }
            if (geometry.Position1 != null)
            {
                crs.AddRange(ParsePosition(geometry.Position1, "","1"));
            }
            if (geometry.Position2 != null)
            {
                crs.AddRange(ParsePosition(geometry.Position2, "", "2"));
            }
            if (geometry.Direction != null)
            {
                crs.AddRange(ParsePosition(geometry.Direction, "direction"));
            }
            if (geometry.Origin != null)
            {
                crs.AddRange(ParsePosition(geometry.Origin, "origin"));
            }
            if (geometry.Trim != null)
            {
                crs.AddRange(ParsePosition(geometry.Trim, "trim"));
            }
            if (geometry.ActualPos1 != null)
            {
                crs.AddRange(ParsePosition(geometry.ActualPos1, "actual", "1"));
            }
            if (geometry.ActualPos2 != null)
            {
                crs.AddRange(ParsePosition(geometry.ActualPos2, "actual", "2"));
            }

            if (geometry.Radius != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "radius",
                    Nominal = geometry.Radius.Value
                });
            }
            if (geometry.Radius1 != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "radius1",
                    Nominal = geometry.Radius1.Value
                });
            }
            if (geometry.Radius2 != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "radius2",
                    Nominal = geometry.Radius2.Value
                });
            }
            if (geometry.OuterRadius != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "outer_radius",
                    Nominal = geometry.OuterRadius.Value
                });
            }
            if (geometry.InnerRadius != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "inner_radius",
                    Nominal = geometry.InnerRadius.Value
                });
            }
            if (geometry.Angle != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "angle",
                    Nominal = geometry.Angle.Value
                });
            }
            if (geometry.Height1 != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "height1",
                    Nominal = geometry.Height1.Value
                });
            }
            if (geometry.Height2 != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "height2",
                    Nominal = geometry.Height2.Value
                });
            }
            if (geometry.Length != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "length",
                    Nominal = geometry.Length.Value
                });
            }
            if (geometry.Width != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "width",
                    Nominal = geometry.Width.Value
                });
            }
            if (geometry.Orientation != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "orientation",
                    Nominal = geometry.Orientation.Value
                });
            }
            if (geometry.Distance != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "distance",
                    Nominal = geometry.Distance.Value
                });
            }
            if (geometry.EdgeRadius != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "edge_radius",
                    Nominal = geometry.EdgeRadius.Value
                });
            }
            if (geometry.Restriction != null)
            {
                crs.Add(new Characteristic
                {
                    Name = "restriction",
                    Nominal = geometry.Restriction.Value
                });
            }
            return crs;
        }

        public List<Characteristic> ParsePosition(GeometryPosition position, string prefix = "", string postfix = "")
        {
            var crs = new List<Characteristic>();

            var x = new Characteristic
            {
                Name = $"{prefix}x{postfix}",
                Nominal = position.X
            };
            crs.Add(x);

            var y = new Characteristic
            {
                Name = $"{prefix}y{postfix}",
                Nominal = position.Y
            };
            crs.Add(y);

            var z = new Characteristic
            {
                Name = $"{prefix}z{postfix}",
                Nominal = position.Z
            };
            crs.Add(z);

            return crs;
        }

        public void Archive(IEnumerable<string> fileNames,string sourceDir, string destinationDir)
        {
            foreach (var fileName in fileNames)
            {
                var sourceFileFullPath = Path.Combine(sourceDir, fileName);
                if (!File.Exists(sourceFileFullPath))
                {
                    continue;
                }

                if (string.IsNullOrEmpty(destinationDir))
                {
                    File.Delete(sourceFileFullPath);
                    continue;
                }

                var fileToBeGZipped = new FileInfo(sourceFileFullPath);
                var gzipFileName = new FileInfo(Path.Combine(destinationDir, string.Concat(fileName, ".gz")));

                using var fileToBeZippedAsStream = fileToBeGZipped.OpenRead();
                using var gzipTargetAsStream = gzipFileName.Create();
                using var gzipStream = new GZipStream(gzipTargetAsStream, CompressionMode.Compress);
                try
                {
                    fileToBeZippedAsStream.CopyTo(gzipStream);
                    fileToBeZippedAsStream.Dispose();
                    File.Delete(sourceFileFullPath);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Unable to archive file.");
                }
            }
        }
    }
}
