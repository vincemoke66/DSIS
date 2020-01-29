using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSIS
{
    public partial class MainForm : Form
    {
        OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\DSIS\\DB.xlsx;Extended Properties=\"Excel 12.0;HDR=Yes;\";");

        Scores scoresPanel = new Scores();
        Classroom crPanel = new Classroom();
        School schlPanel = new School();

        String id = Login.studentID;

        AddStudent adstdnt = new AddStudent();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            pageLabel.Text = "Scores";            
            lblID.Text = id;
            if (Login.isTeacher)
                lblAddStudent.Visible = true;
            else
            {
                setAllLB();
                Cursor.Current = Cursors.WaitCursor;                
                Cursor.Current = Cursors.Default;
            }
                
        }

        void setAllLB()
        {
            setLBValues("quiz", scoresPanel.lbQuiz);
            setLBValues("test", scoresPanel.lbTest);
            setLBValues("exam", scoresPanel.lbMExam);
            setLBValues("ass", scoresPanel.lbAssignment);
            setLBValues("perf", scoresPanel.lbPerformance);
            setLBValues("proj", scoresPanel.lbProjects);
            setLBValues("semgrd", scoresPanel.lbSemGrades);
            setLBValues("att", crPanel.lbClsrmAttendance);
            setLBValues("clsact", crPanel.lbClsrmActivities);
            setLBValues("schlact", schlPanel.lbschlAct);
            setLBValues("schlatt", schlPanel.lbActAtt);
            setLBValues("fees", schlPanel.lbschlfees);
            setLBValues("ann", schlPanel.lbschann);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(scoresPanel);
            mainPanel.Controls.Add(crPanel);
            mainPanel.Controls.Add(schlPanel);
            dbConnection.Close();
        }

        void setLBValues(String sheetName, ListBox lb)
        {
            OleDbDataAdapter adptr = new OleDbDataAdapter("select * from [" + sheetName + "$]", dbConnection);
            DataTable dt = new DataTable();
            adptr.Fill(dt);

            int rowCount = dt.Rows.Count;
            int colCount = dt.Columns.Count;

            for (int r = 0; r < rowCount; r++)
            {
                if (dt.Rows[r][0].ToString().Equals(id))
                {
                    for (int c = 1; c < colCount; c++)
                    {
                        if (!dt.Rows[r][c].ToString().Equals(""))
                        {
                            lb.Items.Add(dt.Rows[r][c]);
                        }
                    }
                    break;
                }
            }
        }

        void setClickedBtn(int index)
        {
            resetBtnColors();
            if (index == 1)
                btnScores.BaseColor = Color.FromArgb(128, 128, 255);
            if (index == 2)
                btnClassroom.BaseColor = Color.FromArgb(128, 128, 255);
            if (index == 3)
                btnSchool.BaseColor = Color.FromArgb(128, 128, 255);

        }

        void resetBtnColors()
        {
            btnScores.BaseColor = Color.FromArgb(100, 88, 255);
            btnClassroom.BaseColor = Color.FromArgb(100, 88, 255);
            btnSchool.BaseColor = Color.FromArgb(100, 88, 255);
        }

        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Scores";
            setClickedBtn(1);
            mainPanel.Controls.Clear();            
            mainPanel.Controls.Add(scoresPanel);
        }

        private void BtnClassroom_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Classroom";
            setClickedBtn(2);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(crPanel);
        }

        private void BtnSchool_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "School";
            setClickedBtn(3);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(schlPanel);
        }

        private void LblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            id = "";
            Login.isTeacher = false;
            this.Hide();
            var loginform = new Login();
            loginform.Closed += (s, args) => this.Dispose();
            loginform.Show();
        }

        private void ControlClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void LblAddStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageLabel.Text = "Add Student";
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(adstdnt);
        }
    }
}
