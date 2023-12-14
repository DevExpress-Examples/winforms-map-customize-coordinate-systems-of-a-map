Namespace CoordinateSystems

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.imageLayer = New DevExpress.XtraMap.ImageLayer()
            Me.openStreetMapDataProvider1 = New DevExpress.XtraMap.OpenStreetMapDataProvider()
            Me.vectorLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbDataType = New System.Windows.Forms.ComboBox()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciMap = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCoordinateSystem = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciMap), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCoordinateSystem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' imageLayer
            ' 
            Me.imageLayer.DataProvider = Me.openStreetMapDataProvider1
            Me.imageLayer.Name = "MapLayer"
            ' 
            ' vectorLayer
            ' 
            Me.vectorLayer.Name = "DataLayer"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.cbDataType)
            Me.layoutControl1.Controls.Add(Me.mapControl)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(784, 561)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' cbDataType
            ' 
            Me.cbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbDataType.FormattingEnabled = True
            Me.cbDataType.Items.AddRange(New Object() {"Geo Data, Geo Map", "Cartesian Data, Cartesian Map", "Cartesian Data, Geo Map"})
            Me.cbDataType.Location = New System.Drawing.Point(114, 12)
            Me.cbDataType.Name = "cbDataType"
            Me.cbDataType.Size = New System.Drawing.Size(658, 21)
            Me.cbDataType.TabIndex = 1
            AddHandler Me.cbDataType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbDataType_SelectedIndexChanged)
            ' 
            ' mapControl
            ' 
            Me.mapControl.Layers.Add(Me.imageLayer)
            Me.mapControl.Layers.Add(Me.vectorLayer)
            Me.mapControl.Location = New System.Drawing.Point(12, 37)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(760, 512)
            Me.mapControl.TabIndex = 0
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciMap, Me.lciCoordinateSystem})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(784, 561)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lciMap
            ' 
            Me.lciMap.Control = Me.mapControl
            Me.lciMap.Location = New System.Drawing.Point(0, 25)
            Me.lciMap.Name = "lciMap"
            Me.lciMap.Size = New System.Drawing.Size(764, 516)
            Me.lciMap.TextSize = New System.Drawing.Size(0, 0)
            Me.lciMap.TextVisible = False
            ' 
            ' lciCoordinateSystem
            ' 
            Me.lciCoordinateSystem.Control = Me.cbDataType
            Me.lciCoordinateSystem.Location = New System.Drawing.Point(0, 0)
            Me.lciCoordinateSystem.Name = "lciCoordinateSystem"
            Me.lciCoordinateSystem.Size = New System.Drawing.Size(764, 25)
            Me.lciCoordinateSystem.Text = "Data and Map Types"
            Me.lciCoordinateSystem.TextSize = New System.Drawing.Size(99, 13)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OnLoad)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciMap), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCoordinateSystem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private cbDataType As System.Windows.Forms.ComboBox

        Private mapControl As DevExpress.XtraMap.MapControl

        Private lciMap As DevExpress.XtraLayout.LayoutControlItem

        Private lciCoordinateSystem As DevExpress.XtraLayout.LayoutControlItem

        Private imageLayer As DevExpress.XtraMap.ImageLayer

        Private openStreetMapDataProvider1 As DevExpress.XtraMap.OpenStreetMapDataProvider

        Private vectorLayer As DevExpress.XtraMap.VectorItemsLayer
    End Class
End Namespace
