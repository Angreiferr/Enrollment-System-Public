using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enrollment_System.Data;
using Enrollment_System.Util;

namespace Enrollment_System.Menus
{
    public partial class SubjectsFrm : Form
    {
        private ApplicationForm application;
        public SubjectsFrm(ApplicationForm application)
        {
            this.application = application;
            InitializeComponent();
        }

        private void SubjectsFrm_Load(object sender, EventArgs e)
        {
            SubjectList.ReadOnly = true;
            SubjectList.DataSource = DatabaseHelper.getApplicationSubjec(application.ID).Tables[0];
            CenterToScreen();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationConfrimationFrm frm = new ApplicationConfrimationFrm();
            frm.ShowDialog();
            this.Close();
        }
    }
}
