using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tamrin.Entities;
using Tamrin.service;

namespace Tamrin
{
    public partial class FrmRegister : Form
    {
        PersonService personService;
        public FrmRegister()
        {
            InitializeComponent();
            personService = new PersonService();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            personService.Add(new Person
            {
            FirstName= txtFirstName.Text,
            LastName= txtLastName.Text,
            NationalCode = txtNationalCode.Text,
            Role = cbxRole.SelectedText,
            UserName = txtUserName.Text,
            Password = txtPassword.Text
            });
        }
    }
}
