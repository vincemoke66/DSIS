using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSIS
{
    public partial class AddStudent : UserControl
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void GunaButton1_Click(object sender, EventArgs e)
        {
            if (correctInput())
            {
                DBGetter xl = new DBGetter("");
                xl.setRowData(tbID.Text.ToString(), tbPassword.Text.ToString());
                MessageBox.Show("Student added successfully!");
                tbID.Text = "";
                tbPassword.Text = "";
                tbRePassword.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
            
        }

        Boolean correctInput()
        {
            if (tbID.Text.ToString().Length == 8 && tbPassword.Text.ToString().Equals(tbRePassword.Text.ToString()) && tbPassword.Text.ToString().Length > 6)
            {
                return true;
            }
            return false;
        }
    }
}
