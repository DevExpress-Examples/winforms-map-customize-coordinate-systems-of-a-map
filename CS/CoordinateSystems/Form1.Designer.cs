namespace CoordinateSystems {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.imageLayer = new DevExpress.XtraMap.ImageLayer();
            this.openStreetMapDataProvider1 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            this.vectorLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbDataType = new System.Windows.Forms.ComboBox();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMap = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCoordinateSystem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoordinateSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLayer
            // 
            this.imageLayer.DataProvider = this.openStreetMapDataProvider1;
            this.imageLayer.Name = "MapLayer";
            // 
            // vectorLayer
            // 
            this.vectorLayer.Name = "DataLayer";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbDataType);
            this.layoutControl1.Controls.Add(this.mapControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(784, 561);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbDataType
            // 
            this.cbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataType.FormattingEnabled = true;
            this.cbDataType.Items.AddRange(new object[] {
            "Geo Data, Geo Map",
            "Cartesian Data, Cartesian Map",
            "Cartesian Data, Geo Map"});
            this.cbDataType.Location = new System.Drawing.Point(114, 12);
            this.cbDataType.Name = "cbDataType";
            this.cbDataType.Size = new System.Drawing.Size(658, 21);
            this.cbDataType.TabIndex = 1;
            this.cbDataType.SelectedIndexChanged += new System.EventHandler(this.cbDataType_SelectedIndexChanged);
            // 
            // mapControl
            // 
            this.mapControl.Layers.Add(this.imageLayer);
            this.mapControl.Layers.Add(this.vectorLayer);
            this.mapControl.Location = new System.Drawing.Point(12, 37);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(760, 512);
            this.mapControl.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMap,
            this.lciCoordinateSystem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(784, 561);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciMap
            // 
            this.lciMap.Control = this.mapControl;
            this.lciMap.Location = new System.Drawing.Point(0, 25);
            this.lciMap.Name = "lciMap";
            this.lciMap.Size = new System.Drawing.Size(764, 516);
            this.lciMap.TextSize = new System.Drawing.Size(0, 0);
            this.lciMap.TextVisible = false;
            // 
            // lciCoordinateSystem
            // 
            this.lciCoordinateSystem.Control = this.cbDataType;
            this.lciCoordinateSystem.Location = new System.Drawing.Point(0, 0);
            this.lciCoordinateSystem.Name = "lciCoordinateSystem";
            this.lciCoordinateSystem.Size = new System.Drawing.Size(764, 25);
            this.lciCoordinateSystem.Text = "Data and Map Types";
            this.lciCoordinateSystem.TextSize = new System.Drawing.Size(99, 13);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoordinateSystem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.ComboBox cbDataType;
        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.XtraLayout.LayoutControlItem lciMap;
        private DevExpress.XtraLayout.LayoutControlItem lciCoordinateSystem;
        private DevExpress.XtraMap.ImageLayer imageLayer;
        private DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider1;
        private DevExpress.XtraMap.VectorItemsLayer vectorLayer;
    }
}

