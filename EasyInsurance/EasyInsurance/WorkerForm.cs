using Neo4jClient;
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
        private GraphClient client;
        public WorkerForm(GraphClient client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void btnAddInsured_Click(object sender, EventArgs e)
        {
            RegisterInsuredForm registerInsuredForm = new RegisterInsuredForm(client);
            registerInsuredForm.Show();
        }

        private void tbFindInsured_Click(object sender, EventArgs e)
        {
            FindInsuredForm insured = new FindInsuredForm(client);
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
