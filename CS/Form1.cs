using System;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;
// ...

namespace PrintDevExControls {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // Create printing components.
        PrintingSystem printingSystem1 = new PrintingSystem();
        PrintableComponentLink printableComponentLink1 = new PrintableComponentLink();
        // ...

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);

            // Add the link to the printing system's collection of links.
            printingSystem1.Links.AddRange(new object[] { printableComponentLink1 });

            // Clear the document created by the GridControl's view.
            ((GridView)gridControl1.MainView).ClearDocument();

            // Assign a control to be printed by this link.
            printableComponentLink1.Component = gridControl1;

            // Set the paper orientation to Landscape.
            printableComponentLink1.Landscape = true;

            // Handle the Click event of printing buttons.
            btnPrintPreview.Click += new System.EventHandler(btnPrintPreview_Click);
            btnPrint.Click += new System.EventHandler(btnPrint_Click);
        }

        private void btnPrintPreview_Click(object sender, EventArgs e) {
            // Show the Print Preview for the gridControl1.
             printableComponentLink1.ShowPreview();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Print the gridControl1.
              printableComponentLink1.PrintDlg();
        }

    }
}