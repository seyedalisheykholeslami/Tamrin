using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tamrin.service;

namespace Tamrin
{
    public partial class FrmLogin : Form
    {
        PersonService PersonService;
        public FrmLogin()
        {
            InitializeComponent();
            PersonService = new PersonService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           var result =  PersonService.Login(txtUserName.Text,txtPassword.Text);
            if (result.IsSuccess)
            {
                Hide();
                new FrmMain().ShowDialog();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
