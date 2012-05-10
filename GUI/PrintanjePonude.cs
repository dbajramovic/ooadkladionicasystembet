using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace GUI
{
    public partial class PrintanjePonude : Form
    {
        public PrintanjePonude()
        {
           
            InitializeComponent();
        }

        private void printajToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void PrintanjePonude_Load(object sender, EventArgs e)
        {
            printPreviewControl1.Document.DocumentName = "Ponuda.xml";
        }
    }
}
