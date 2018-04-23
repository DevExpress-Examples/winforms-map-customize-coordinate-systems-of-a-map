using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace CoordinateSystems {
    public partial class Form1 : Form {
        const string geoMapGeoDataFile = "../../Data/Countries.shp";
        const string cartesianMapCartesianDataFile = "../../Data/Hotel1.shp";
        const string geoMapCartesianDataShpFile = "../../Data/Sweden_county07.shp";
        const string geoMapCartesianDataPrjFile = "../../Data/Sweden_county07.prj";

        ShapefileDataAdapter Adapter { get; set; }

        public Form1() {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e) {
            Adapter = new ShapefileDataAdapter();
            vectorLayer.Data = Adapter;
            vectorLayer.DataLoaded += DataLayer_DataLoaded;
        }

        #region #GeoMapGeoData
        void SetGeoMapGeoData() {
            imageLayer.Visible = false;

            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            Adapter.FileUri = new Uri(baseUri, geoMapGeoDataFile);
            Adapter.SourceCoordinateSystem = new GeoSourceCoordinateSystem();

            mapControl.CoordinateSystem = new GeoMapCoordinateSystem();
        }
        #endregion #GeoMapGeoData

        #region #CartesianMapCartesianData
        void SetCartesianMapCartesianData() {
            imageLayer.Visible = false;

            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            Adapter.FileUri = new Uri(baseUri, cartesianMapCartesianDataFile);
            Adapter.SourceCoordinateSystem = new CartesianSourceCoordinateSystem();

            mapControl.CoordinateSystem = new CartesianMapCoordinateSystem();
        }
        #endregion #CartesianMapCartesianData

        #region #GeoMapCartesianData
        void SetGeoMapCartesianData() {
            imageLayer.Visible = true;

            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            Adapter.FileUri = new Uri(baseUri, geoMapCartesianDataShpFile);
            Adapter.SourceCoordinateSystem = ShapefileDataAdapter.LoadPrjFile(new Uri(baseUri, geoMapCartesianDataPrjFile));
            
            mapControl.CoordinateSystem = new GeoMapCoordinateSystem();
        }
        #endregion #GeoMapCartesianData

        void DataLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            mapControl.ZoomToFitLayerItems(0.4);
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
