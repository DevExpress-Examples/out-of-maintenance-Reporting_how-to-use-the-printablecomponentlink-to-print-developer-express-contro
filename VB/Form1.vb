Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Views.Grid
' ...

Namespace PrintDevExControls
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		' Create printing components.
		Private printingSystem1 As New PrintingSystem()
		Private printableComponentLink1 As New PrintableComponentLink()
		' ...

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)

			' Add the link to the printing system's collection of links.
			printingSystem1.Links.AddRange(New Object() { printableComponentLink1 })

			' Clear the document created by the GridControl's view.
			CType(gridControl1.MainView, GridView).ClearDocument()

			' Assign a control to be printed by this link.
			printableComponentLink1.Component = gridControl1

			' Set the paper orientation to Landscape.
			printableComponentLink1.Landscape = True

			' Handle the Click event of printing buttons.
			AddHandler btnPrintPreview.Click, AddressOf btnPrintPreview_Click
			AddHandler btnPrint.Click, AddressOf btnPrint_Click
		End Sub

		Private Sub btnPrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintPreview.Click
			' Show the Print Preview for the gridControl1.
			 printableComponentLink1.ShowPreview()
		End Sub

		Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			' Print the gridControl1.
			  printableComponentLink1.PrintDlg()
		End Sub

	End Class
End Namespace