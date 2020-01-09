using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyInsurance
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void btnAddInsured_Click(object sender, EventArgs e)
        {
            RegisterInsuredForm registerInsuredForm = new RegisterInsuredForm();
            registerInsuredForm.Show();
        }

        private void tbFindInsured_Click(object sender, EventArgs e)
        {
            FindInsuredForm insured = new FindInsuredForm();
            insured.Show();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {

        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {

        }
    }
}
