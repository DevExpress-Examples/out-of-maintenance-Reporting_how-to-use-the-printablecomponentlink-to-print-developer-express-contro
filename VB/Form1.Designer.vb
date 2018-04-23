Imports Microsoft.VisualBasic
Imports System
Namespace PrintDevExControls
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New PrintDevExControls.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSupplierID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.btnPrintPreview = New System.Windows.Forms.Button()
			Me.btnPrint = New System.Windows.Forms.Button()
			Me.productsTableAdapter = New PrintDevExControls.nwindDataSetTableAdapters.ProductsTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridControl1.DataSource = Me.productsBindingSource
			Me.gridControl1.Location = New System.Drawing.Point(12, 68)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(490, 263)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSetBindingSource
			' 
			' nwindDataSetBindingSource
			' 
			Me.nwindDataSetBindingSource.DataSource = Me.nwindDataSet
			Me.nwindDataSetBindingSource.Position = 0
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID, Me.colProductName, Me.colSupplierID, Me.colQuantityPerUnit, Me.colUnitPrice})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colProductID
			' 
			Me.colProductID.Caption = "ProductID"
			Me.colProductID.FieldName = "ProductID"
			Me.colProductID.Name = "colProductID"
			Me.colProductID.Visible = True
			Me.colProductID.VisibleIndex = 0
			' 
			' colProductName
			' 
			Me.colProductName.Caption = "ProductName"
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 1
			' 
			' colSupplierID
			' 
			Me.colSupplierID.Caption = "SupplierID"
			Me.colSupplierID.FieldName = "SupplierID"
			Me.colSupplierID.Name = "colSupplierID"
			Me.colSupplierID.Visible = True
			Me.colSupplierID.VisibleIndex = 2
			' 
			' colQuantityPerUnit
			' 
			Me.colQuantityPerUnit.Caption = "QuantityPerUnit"
			Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
			Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
			Me.colQuantityPerUnit.Visible = True
			Me.colQuantityPerUnit.VisibleIndex = 3
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.Caption = "UnitPrice"
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 4
			' 
			' btnPrintPreview
			' 
			Me.btnPrintPreview.Location = New System.Drawing.Point(12, 12)
			Me.btnPrintPreview.Name = "btnPrintPreview"
			Me.btnPrintPreview.Size = New System.Drawing.Size(151, 45)
			Me.btnPrintPreview.TabIndex = 1
			Me.btnPrintPreview.Text = "Print Preview"
			Me.btnPrintPreview.UseVisualStyleBackColor = True
'			Me.btnPrintPreview.Click += New System.EventHandler(Me.btnPrintPreview_Click);
			' 
			' btnPrint
			' 
			Me.btnPrint.Location = New System.Drawing.Point(169, 12)
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.Size = New System.Drawing.Size(151, 45)
			Me.btnPrint.TabIndex = 2
			Me.btnPrint.Text = "Print"
			Me.btnPrint.UseVisualStyleBackColor = True
'			Me.btnPrint.Click += New System.EventHandler(Me.btnPrint_Click);
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(514, 343)
			Me.Controls.Add(Me.btnPrint)
			Me.Controls.Add(Me.btnPrintPreview)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents btnPrintPreview As System.Windows.Forms.Button
		Private WithEvents btnPrint As System.Windows.Forms.Button
		Private nwindDataSetBindingSource As System.Windows.Forms.BindingSource
		Private nwindDataSet As nwindDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As PrintDevExControls.nwindDataSetTableAdapters.ProductsTableAdapter
		Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colSupplierID As DevExpress.XtraGrid.Columns.GridColumn
		Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

