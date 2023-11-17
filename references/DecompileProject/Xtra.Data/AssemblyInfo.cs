using SmartAssembly.Attributes;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Reflection;
using System.Runtime.InteropServices;
using Xtra.Data;

[assembly: PoweredBy("Powered by SmartAssembly 6.7.2.44")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyTitle("Xtra.Data")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("Xtra.Data")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2013")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("53f55995-f724-4f0f-bdb0-4f93821effee")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: EdmSchema]
[assembly: EdmRelationship("CanDienTuModel", "FK_HangHoaXeHang", "HangHoa", RelationshipMultiplicity.One, typeof (HangHoa), "XeHang", RelationshipMultiplicity.Many, typeof (XeHang), true)]
[assembly: AssemblyVersion("1.0.0.0")]
