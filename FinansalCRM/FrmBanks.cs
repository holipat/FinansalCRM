using FinansalCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinansalCRM
{
    public partial class FrmBanks: Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinansalCrmDbEntities1 db = new FinansalCrmDbEntities1();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıf Katılım").Select(y => y.BankBalance).FirstOrDefault();
            var kuveytturkBankBalance = db.Banks.Where(x => x.BankTitle == "KuveytTürk").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";
            lblVakifbankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblKuveytTurkBalance.Text = kuveytturkBankBalance.ToString() + " ₺";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }
    }
}
