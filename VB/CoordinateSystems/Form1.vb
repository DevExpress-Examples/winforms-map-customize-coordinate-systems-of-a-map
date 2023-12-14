Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace CoordinateSystems

    Public Partial Class Form1
        Inherits Form

        Const geoMapGeoDataFile As String = "../../Data/Countries.shp"

        Const cartesianMapCartesianDataFile As String = "../../Data/Hotel1.shp"

        Const geoMapCartesianDataShpFile As String = "../../Data/Sweden_county07.shp"

        Const geoMapCartesianDataPrjFile As String = "../../Data/Sweden_county07.prj"

        Private Property Adapter As ShapefileDataAdapter

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Overloads Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs)
            Adapter = New ShapefileDataAdapter()
            vectorLayer.Data = Adapter
            AddHandler vectorLayer.DataLoaded, AddressOf DataLayer_DataLoaded
        End Sub

'#Region "#GeoMapGeoData"
        Private Sub SetGeoMapGeoData()
            imageLayer.Visible = False
            Dim baseUri As Uri = New Uri(Reflection.Assembly.GetEntryAssembly().Location)
            Adapter.FileUri = New Uri(baseUri, geoMapGeoDataFile)
            Adapter.SourceCoordinateSystem = New GeoSourceCoordinateSystem()
            mapControl.CoordinateSystem = New GeoMapCoordinateSystem()
        End Sub

'#End Region  ' #GeoMapGeoData
'#Region "#CartesianMapCartesianData"
        Private Sub SetCartesianMapCartesianData()
            imageLayer.Visible = False
            Dim baseUri As Uri = New Uri(Reflection.Assembly.GetEntryAssembly().Location)
            Adapter.FileUri = New Uri(baseUri, cartesianMapCartesianDataFile)
            Adapter.SourceCoordinateSystem = New CartesianSourceCoordinateSystem()
            mapControl.CoordinateSystem = New CartesianMapCoordinateSystem()
        End Sub

'#End Region  ' #CartesianMapCartesianData
'#Region "#GeoMapCartesianData"
        Private Sub SetGeoMapCartesianData()
            imageLayer.Visible = True
            Dim baseUri As Uri = New Uri(Reflection.Assembly.GetEntryAssembly().Location)
            Adapter.FileUri = New Uri(baseUri, geoMapCartesianDataShpFile)
            Adapter.SourceCoordinateSystem = ShapefileDataAdapter.LoadPrjFile(New Uri(baseUri, geoMapCartesianDataPrjFile))
            mapControl.CoordinateSystem = New GeoMapCoordinateSystem()
        End Sub

'#End Region  ' #GeoMapCartesianData
        Private Sub DataLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            mapControl.ZoomToFitLayerItems(0.4)
        End Sub

        Private Sub cbDataType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Select Case cbDataType.SelectedIndex
                Case 0
                    SetGeoMapGeoData()
                Case 1
                    SetCartesianMapCartesianData()
                Case 2
                    SetGeoMapCartesianData()
                Case Else
                    SetGeoMapGeoData()
            End Select
        End Sub
    End Class
End Namespace
