using Neo4jClient;
using System;
using System.Threading;
using System.Windows.Forms;

namespace EasyInsurance
{
    public partial class WorkerForm : Form
    {
        private GraphClient client;
        private EasyInsurance easyInsurance;

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public WorkerForm(GraphClient client, EasyInsurance easyInsurance)
        {
            this.client = client;
            this.easyInsurance = easyInsurance;
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

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var t = new Thread(() => Application.Run(new EasyInsurance()));
            t.Start();
            this.Close();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
