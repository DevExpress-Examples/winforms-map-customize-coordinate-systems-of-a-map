<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576316/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T202055)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/CoordinateSystems/Form1.cs) (VB: [Form1.vb](./VB/CoordinateSystems/Form1.vb))**
<!-- default file list end -->
# How to customize coordinate systems of a map and data source


<p>This example demonstrates how to customize coordinate systems of a map and data source.<br />For this ,assign a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapMapCoordinateSystemtopic">MapCoordinateSystem</a> class descendant object to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapControl_CoordinateSystemtopic">MapControl.CoordinateSystem</a> property and a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapSourceCoordinateSystemtopic">SourceCoordinateSystem</a> class descendant object to the <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapCoordinateSystemDataAdapterBasetopic">CoordinateSystemDataAdapterBase.SourceCoordinateSystem</a> property.<br />Note that to display geographic data, a map should have a geo coordinate system. To display Cartesian data, the map should have a Cartesian coordinate system or <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSourceCoordinateSystem_CoordinateConvertertopic">SourceCoordinateSystem.CoordinateConverter</a> should be specified to convert Cartesian point to a geographic point.</p>

<br/>


