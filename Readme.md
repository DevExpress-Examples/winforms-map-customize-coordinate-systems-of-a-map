# How to customize coordinate systems of a map and data source


<p>This example demonstrates how to customize coordinate systems of a map and data source.<br />For this ,assign a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapMapCoordinateSystemtopic">MapCoordinateSystem</a> class descendant object to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapControl_CoordinateSystemtopic">MapControl.CoordinateSystem</a> property and a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapSourceCoordinateSystemtopic">SourceCoordinateSystem</a> class descendant object to the <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapCoordinateSystemDataAdapterBasetopic">CoordinateSystemDataAdapterBase.SourceCoordinateSystem</a> property.<br />Note that to display geographic data, a map should have a geo coordinate system. To display Cartesian data, the map should have a Cartesian coordinate system or <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSourceCoordinateSystem_CoordinateConvertertopic">SourceCoordinateSystem.CoordinateConverter</a> should be specified to convert Cartesian point to a geographic point.</p>

<br/>


