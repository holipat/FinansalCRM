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

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıf Katılım").Select(y => y.BankBalance).FirstOrDefault();
            var kuveytturkBankBalance = db.Banks.Where(x => x.BankTitle == "KuveytTürk").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";
            lblVakifbankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblKuveytTurkBalance.Text = kuveytturkBankBalance.ToString() + " ₺";

            //Banka Hareketleri
            var bankProcess1 = db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).FirstOrDefault();
            DateTime? process1Date = bankProcess1.ProcessDate;
            lblBankProcess1.Text = bankProcess1.Description + " | " + bankProcess1.Amount + " ₺ | " + process1Date?.ToString("dd.MM.yyyy");

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            DateTime? process2Date = bankProcess2.ProcessDate;
            lblBankProcess2.Text = bankProcess2.Description + " | " + bankProcess2.Amount + " ₺ | " + process2Date?.ToString("dd.MM.yyyy");

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            DateTime? process3Date = bankProcess3.ProcessDate;
            lblBankProcess3.Text = bankProcess3.Description + " | " + bankProcess3.Amount + " ₺ | " + process3Date?.ToString("dd.MM.yyyy");

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            DateTime? process4Date = bankProcess4.ProcessDate;
            lblBankProcess4.Text = bankProcess4.Description + " | " + bankProcess4.Amount + " ₺ | " + process4Date?.ToString("dd.MM.yyyy");

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            DateTime? process5Date = bankProcess5.ProcessDate;
            lblBankProcess5.Text = bankProcess5.Description + " | " + bankProcess5.Amount + " ₺ | " + process5Date?.ToString("dd.MM.yyyy");
        }
    }
}
