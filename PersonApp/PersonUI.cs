using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApp
{
    public partial class PersonUI : Form
    {
        Person p = new Person();

        public PersonUI()
        {
            InitializeComponent();
        }

        private void getFullNameButton_Click(object sender, EventArgs e)
        {
            p.firstName = firstNameTextBox.Text;
            p.middleName = middleNameTextBox.Text;
            p.lastName = lastNameTextBox.Text;

            MessageBox.Show(p.GetFullName());
        }

        private void getReverseNameButton_Click(object sender, EventArgs e)
        {
            p.firstName = firstNameTextBox.Text;
            p.middleName = middleNameTextBox.Text;
            p.lastName = lastNameTextBox.Text;

            MessageBox.Show(p.GetReverseName());
        }
    }
}
