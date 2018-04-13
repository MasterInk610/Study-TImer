using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Timer
{
    public partial class frmStdyTmr : Form
    {
        private bool study = true;
        private bool testing = false;

        public frmStdyTmr()
        {
            InitializeComponent();
        }

        private void tmrStdy_Tick(object sender, EventArgs e)
        {
            prgbr1.Increment(1);
            if(prgbr1.Value == prgbr1.Maximum)
            {
                prgbr1.Value = 0;
                StudyValues();
            }
        }

        private void frmStdyTmr_Load(object sender, EventArgs e)
        {
            //initialize buttons
            rdbtnStdy2.Select();
            rdbtnBrk2.Select();

            prgbr1.ForeColor = Color.Brown;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            prgbr1.Value = 0;
            study = true;
            StudyValues();
            tmrStdy.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrStdy.Stop();
            prgbr1.ForeColor = Color.Red;
        }

        private void StudyValues()
        {
            if (testing)
            {
                prgbr1.Maximum = 10;
            }
            else
            {
                if (study)
                {
                    prgbr1.ForeColor = Color.BlueViolet;
                    //study timer
                    if (rdbtnStdy1.Checked == true)
                    {
                        prgbr1.Maximum = 60 * 30;
                    }
                    else if (rdbtnStdy2.Checked == true)
                    {
                        prgbr1.Maximum = 60 * 60;
                    }
                    else if (rdbtnStdy3.Checked == true)
                    {
                        prgbr1.Maximum = 60 * 60 * 2;
                    }
                    study = false;
                }
                else
                {
                    prgbr1.ForeColor = Color.Blue;
                    //break timer
                    if (rdbtnBrk1.Checked == true)
                    {
                        prgbr1.Maximum = 60 * 10;
                    }
                    else if (rdbtnBrk2.Checked == true)
                    {
                        prgbr1.Maximum = 60 * 15;
                    }
                    else if (rdbtnBrk3.Checked == true)
                    {
                        prgbr1.Maximum = 60 * 30;
                    }
                    study = true;
                }
            }
        }
    }
}
