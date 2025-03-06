using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SupervisorioTrafego
{
    public partial class Form1 : Form
    {
        int timerAvenue = 0;

        public Form1()
        {
            InitializeComponent();
            pbRoadRed.Visible = true;
            pbAvenueGreen.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatePage.Text = DateTime.Now.ToLongDateString();
        }

        private void clockDateTime_Tick(object sender, EventArgs e)
        {
            HoursPage.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnIconFiremen_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.corpodebombeiros.sp.gov.br/#/");
        }

        private void btnIconPolice_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.policiamilitar.sp.gov.br/");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult mb;
            MessageBoxButtons menssageBtn = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2;

            mb = MessageBox.Show("Do you want to exit the application ?", "LogOut", menssageBtn, icon, defaultButton);

            if (mb != DialogResult.OK) { 
                return;
            } else
            {
              Application.Exit();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerAvenueGreen.Enabled = true;
        }

        private void timerAvenueGreen_Tick(object sender, EventArgs e)
        {
            timerAvenue++;

            if (timerAvenue == 3) {
                timerAvenue = 0;
                timerAvenueGreen.Enabled = false;
                pbAvenueGreen.Visible = false;
                pbAvenueYellow.Visible = true;
                timerAvenueYellow.Enabled = true;
            }

        }

        private void timerAvenueYellow_Tick(object sender, EventArgs e)
        {
            timerAvenue++;

            if (timerAvenue == 1)
            {
                timerAvenue = 0;
                timerAvenueYellow.Enabled = false;
                pbAvenueYellow.Visible = false;
                pbRoadRed.Visible = true;
                timerAvenueRed.Enabled = true;
            }

        }

        private void timerAvenueRed_Tick(object sender, EventArgs e)
        {
            timerAvenue++;

            if (timerAvenue == 2)
            {
                timerAvenue = 0;
                timerAvenueRed.Enabled = false;
                pbAvenueRed.Visible = false;
                pbAvenueGreen.Visible = true;
                timerAvenueGreen.Enabled = true;
            }

        }

        private void timerRoadRead_Tick(object sender, EventArgs e)
        {

        }

        private void timerRoadYellow_Tick(object sender, EventArgs e)
        {

        }

        private void timerRoadGreen_Tick(object sender, EventArgs e)
        {

        }
    }
}
