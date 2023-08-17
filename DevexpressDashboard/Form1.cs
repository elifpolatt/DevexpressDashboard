using DevExpress.DashboardWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevexpressDashboard
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void simpleButtonViewer_Click(object sender, EventArgs e)
        {

            openFileDialogForm.ShowDialog();
            FormViewer frm = new FormViewer();
            frm.Show();
            frm.loadDashboard(openFileDialogForm.FileName);


        }

        private void simpleButtonDesigner_Click(object sender, EventArgs e)
        {
            FormDesigner frm = new FormDesigner();
            frm.ShowDialog();
        }

     
    }
}
