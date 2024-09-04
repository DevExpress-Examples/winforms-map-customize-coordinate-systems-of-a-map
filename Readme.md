<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576316/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T202055)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Chart for WinForms - How to Customize Coordinate Systems of a Map

<p>This example demonstrates how to customize coordinate systems of the map and data source.

![Map](./images/Map.png)

Assign a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapMapCoordinateSystemtopic">MapCoordinateSystem</a> class descendant object to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapControl_CoordinateSystemtopic">MapControl.CoordinateSystem</a> property and a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapSourceCoordinateSystemtopic">SourceCoordinateSystem</a> class descendant object to the <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapCoordinateSystemDataAdapterBasetopic">CoordinateSystemDataAdapterBase.SourceCoordinateSystem</a> property.

To display geographic data, a map should have a geo coordinate system. To display Cartesian data, the map should have a Cartesian coordinate system or <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSourceCoordinateSystem_CoordinateConvertertopic">SourceCoordinateSystem.CoordinateConverter</a> should be specified to convert Cartesian point to a geographic point.</p>

## Files to Review

* [Form1.cs](./CS/CoordinateSystems/Form1.cs) (VB: [Form1.vb](./VB/CoordinateSystems/Form1.vb))

## Documentation

* [Map Coordinate Systems](https://docs.devexpress.com/WindowsForms/17867/controls-and-libraries/map-control/coordinate-systems/map-coordinate-systems)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-customize-coordinate-systems-of-a-map&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-customize-coordinate-systems-of-a-map&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
