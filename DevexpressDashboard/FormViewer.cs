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
    public partial class FormViewer : Form
    {
        public FormViewer()
        {
            InitializeComponent();
        }

        public void loadDashboard(String filePath)
        {
            dashboardViewer1.LoadDashboard(filePath);
        }
       
    }
}
