using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSIS
{
    public partial class Login : Form
    {
        OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\DSIS\\DB.xlsx;Extended Properties=\"Excel 12.0;HDR=Yes;\";");

        public static String studentID;
        public static Boolean isTeacher;

        public Login()
        {
            InitializeComponent();
        }

        private void GunaLabel4_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void GunaButton1_Click(object sender, EventArgs e)
        {

            if (correctAccDetails() && correctPassword("acc"))
            {
                studentID = tbID.Text.ToString();
                if (tbID.Text.ToString().Contains("-t"))
                {
                    isTeacher = true;
                }
                dbConnection.Close();
                closeForm();
            }
            else
            {
                dbConnection.Close();
                MessageBox.Show("Incorrect input!");
            }
                
            

        }

        Boolean correctPassword(String sheet)
        {
            OleDbDataAdapter adptr = new OleDbDataAdapter("select * from [" + sheet + "$]", dbConnection);
            DataTable dt = new DataTable();
            adptr.Fill(dt);

            String id = tbID.Text.ToString();
            String password = tbPassword.Text.ToString();

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                if (dt.Rows[r][0].ToString().Equals(id) && dt.Rows[r][1].ToString().Equals(password))
                {
                    
                    return true;
                }
            }
            return false;
        }

        Boolean correctAccDetails()
        {
            String user = tbID.Text.ToString();
            String pass = tbPassword.Text.ToString();

            if (pass.Length >= 1 && user.Length >= 1)      
                return true;        
            
            return false;
        }

        void closeForm()
        {
            this.Hide();
            var mainform = new MainForm();
            mainform.Closed += (s, args) => this.Dispose();
            mainform.Show();

        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
