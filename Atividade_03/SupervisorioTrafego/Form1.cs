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
        int timerRoad = 0;
        int timerEmergence = 0;

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
            timerRoadRed.Enabled = true;
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            timerAvenueGreen.Enabled = false;
            timerAvenueYellow.Enabled = false;
            timerAvenueRed.Enabled = false;
            pbAvenueGreen.Visible = true;
            pbAvenueYellow.Visible = false;
            pbAvenueRed.Visible = false;

            timerRoadRed.Enabled = false;
            timerRoadYellow.Enabled = false;
            timerRoadGreen.Enabled = false;
            pbRoadRed.Visible = true;
            pbRoadYellow.Visible = false;
            pbRoadGreen.Visible = false;
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
                pbAvenueRed.Visible = true;
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
            timerRoad++;

            if (timerRoad == 3)
            {
                timerRoad = 0;
                timerRoadRed.Enabled = false;
                pbRoadRed.Visible = false;
                pbRoadYellow.Visible = true;
                timerRoadYellow.Enabled = true;
            }
        }

        private void timerRoadYellow_Tick(object sender, EventArgs e)
        {
            timerRoad++;

            if (timerRoad == 1)
            {
                timerRoad = 0;
                timerRoadYellow.Enabled = false;
                pbRoadYellow.Visible = false;
                pbRoadGreen.Visible = true;
                timerRoadGreen.Enabled = true;
            }
        }

        private void timerRoadGreen_Tick(object sender, EventArgs e)
        {
            timerRoad++;

            if (timerRoad == 2)
            {
                timerRoad = 0;
                pbRoadGreen.Visible = false;
                timerRoadGreen.Enabled = false;
                pbRoadRed.Visible = true;
                timerRoadRed.Enabled = true;
            }
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            timerEmergency.Enabled = true;
            pbAvenueYellow.Visible = true;
            pbRoadYellow.Visible = true;

            timerAvenue = 0;
            timerRoad = 0;

            timerAvenueGreen.Enabled = false;
            timerAvenueYellow.Enabled = false;
            timerAvenueRed.Enabled = false;
            pbAvenueGreen.Visible = false;
            pbAvenueRed.Visible = false;

            timerRoadRed.Enabled = false;
            timerRoadYellow.Enabled = false;
            timerRoadGreen.Enabled = false;
            pbRoadRed.Visible = false;
            pbRoadGreen.Visible = false;
        }

        private void timerEmergency_Tick(object sender, EventArgs e)
        {
            timerEmergence++;

            if (timerEmergence == 5)
            {
                timerEmergence = 0;
                timerEmergency.Enabled = false;
                pbAvenueYellow.Visible = false;
                pbRoadYellow.Visible = false;

                pbRoadRed.Visible = true;
                timerRoadRed.Enabled = true;
                pbAvenueGreen.Visible = true;
                timerAvenueGreen.Enabled = true;
            }

        }
    }
}
