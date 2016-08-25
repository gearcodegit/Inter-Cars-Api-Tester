using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API.Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateToDTP.Value = DateTime.Now;
            dateFromDTP.Value = DateTime.Now.AddDays(-14);
        }

        private void getDocumentBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(documentIdTB.Text))
            {
                try
                {
                    var serverUrl = "https://katalog.intercars.com.pl/api/v2/External/GetInvoice?id=" + documentIdTB.Text;

                    var client = new System.Net.WebClient();
                    client.Headers["kh_kod"] = "000000";
                    client.Headers["token"] = "2cc60d6b-18e1-47cf-b86d-faa4fbd64dc0";
                    servideResultRTB.Text = client.DownloadString(serverUrl);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Podaj id dokumentu");
            }
        }

        private void getDocumentsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var serverUrl = "https://katalog.intercars.com.pl/api/v2/External/GetInvoices?from=" + dateFromDTP.Value.ToString("yyyyMMdd") + "&to=" + dateToDTP.Value.ToString("yyyyMMdd");

                var client = new System.Net.WebClient();
                client.Headers["kh_kod"] = "000000";
                client.Headers["token"] = "2cc60d6b-18e1-47cf-b86d-faa4fbd64dc0";
                servideResultRTB.Text = client.DownloadString(serverUrl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
