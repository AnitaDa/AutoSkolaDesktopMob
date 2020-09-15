using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace AutoSkola.WinUI
{
    public partial class frmLogin : Form
    {
        APIService service = new APIService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }
       
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                var request = new AuthenticateRequest()
                {
                    Username =  APIService.Username,
                    Password =  APIService.Password
                };

                var user = await service.Authenticate(request);

                if (user == null)
                    throw new Exception("NE");
         
                frmPocetna pocetna = new frmPocetna();
                pocetna.Show();
                pocetna.FormClosed += new FormClosedEventHandler(frmLogin_FormClosed);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
