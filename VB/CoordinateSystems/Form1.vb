Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace CoordinateSystems
    Partial Public Class Form1
        Inherits Form

        Private Const geoMapGeoDataFile As String = "../../Data/Countries.shp"
        Private Const cartesianMapCartesianDataFile As String = "../../Data/Hotel1.shp"
        Private Const geoMapCartesianDataFile As String = "../../Data/Sweden_county07.shp"

        Private ReadOnly Property MapLayer() As ImageTilesLayer
            Get
                Return CType(mapControl.Layers("MapLayer"), ImageTilesLayer)
            End Get
        End Property
        Private ReadOnly Property DataLayer() As VectorItemsLayer
            Get
                Return CType(mapControl.Layers("DataLayer"), VectorItemsLayer)
            End Get
        End Property
        Private ReadOnly Property Adapter() As ShapefileDataAdapter
            Get
                Return CType(DataLayer.Data, ShapefileDataAdapter)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#GeoMapGeoData"
        Private Sub SetGeoMapGeoData()
            MapLayer.Visible = False

            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
            Adapter.FileUri = New Uri(baseUri, geoMapGeoDataFile)
            Adapter.SourceCoordinateSystem = New GeoSourceCoordinateSystem()

            mapControl.CoordinateSystem = New GeoMapCoordinateSystem()

            AddHandler DataLayer.DataLoaded, AddressOf DataLayer_DataLoaded
        End Sub
        #End Region ' #GeoMapGeoData

        #Region "#CartesianMapCartesianData"
        Private Sub SetCartesianMapCartesianData()
            MapLayer.Visible = False

            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
            Adapter.FileUri = New Uri(baseUri, cartesianMapCartesianDataFile)
            Adapter.SourceCoordinateSystem = New CartesianSourceCoordinateSystem()

            mapControl.CoordinateSystem = New CartesianMapCoordinateSystem()

            AddHandler DataLayer.DataLoaded, AddressOf DataLayer_DataLoaded
        End Sub
        #End Region ' #CartesianMapCartesianData

        #Region "#GeoMapCartesianData"
        Private Sub SetGeoMapCartesianData()
            MapLayer.Visible = True

            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
            Adapter.FileUri = New Uri(baseUri, geoMapCartesianDataFile)
            Adapter.SourceCoordinateSystem = Adapter.LoadPrjFile()

            mapControl.CoordinateSystem = New GeoMapCoordinateSystem()

            AddHandler DataLayer.DataLoaded, AddressOf DataLayer_DataLoaded
        End Sub
        #End Region ' #GeoMapCartesianData

        Private Sub DataLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            mapControl.ZoomToFitLayerItems(0.4)
            RemoveHandler DataLayer.DataLoaded, AddressOf DataLayer_DataLoaded
        End Sub

        Private Sub cbDataType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDataType.SelectedIndexChanged
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
