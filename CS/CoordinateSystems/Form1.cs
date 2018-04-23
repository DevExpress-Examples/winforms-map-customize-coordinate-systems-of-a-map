using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace CoordinateSystems {
    public partial class Form1 : Form {
        const string geoMapGeoDataFile = "../../Data/Countries.shp";
        const string cartesianMapCartesianDataFile = "../../Data/Hotel1.shp";
        const string geoMapCartesianDataFile = "../../Data/Sweden_county07.shp";

        ImageTilesLayer MapLayer { get { return (ImageTilesLayer)mapControl.Layers["MapLayer"]; } }
        VectorItemsLayer DataLayer { get { return (VectorItemsLayer)mapControl.Layers["DataLayer"]; } }
        ShapefileDataAdapter Adapter { get { return (ShapefileDataAdapter)DataLayer.Data; } }

        public Form1() {
            InitializeComponent();
        }

        #region #GeoMapGeoData
        void SetGeoMapGeoData() {
            MapLayer.Visible = false;

            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            Adapter.FileUri = new Uri(baseUri, geoMapGeoDataFile);
            Adapter.SourceCoordinateSystem = new GeoSourceCoordinateSystem();

            mapControl.CoordinateSystem = new GeoMapCoordinateSystem();

            DataLayer.DataLoaded += DataLayer_DataLoaded;
        }
        #endregion #GeoMapGeoData

        #region #CartesianMapCartesianData
        void SetCartesianMapCartesianData() {
            MapLayer.Visible = false;

            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            Adapter.FileUri = new Uri(baseUri, cartesianMapCartesianDataFile);
            Adapter.SourceCoordinateSystem = new CartesianSourceCoordinateSystem();

            mapControl.CoordinateSystem = new CartesianMapCoordinateSystem();
            
            DataLayer.DataLoaded += DataLayer_DataLoaded;            
        }
        #endregion #CartesianMapCartesianData

        #region #GeoMapCartesianData
        void SetGeoMapCartesianData() {
            MapLayer.Visible = true;

            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            Adapter.FileUri = new Uri(baseUri, geoMapCartesianDataFile);
            Adapter.SourceCoordinateSystem = Adapter.LoadPrjFile();
            
            mapControl.CoordinateSystem = new GeoMapCoordinateSystem();

            DataLayer.DataLoaded += DataLayer_DataLoaded;
        }
        #endregion #GeoMapCartesianData

        void DataLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            mapControl.ZoomToFitLayerItems(0.4);
            DataLayer.DataLoaded -= DataLayer_DataLoaded;
        }

        private void cbDataType_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbDataType.SelectedIndex) {
                case 0:
                    SetGeoMapGeoData();
                    break;
                case 1:
                    SetCartesianMapCartesianData();
                    break;
                case 2:
                    SetGeoMapCartesianData();
                    break;
                default:
                    SetGeoMapGeoData();
                    break;
            }
        }
    }
}
