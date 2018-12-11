using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mShutdown
{
    public partial class Form1 : Form
    {
        private string _Option;
        private string _Parameter;
        private decimal _Timeshutdown;
        private int _OptionTime;
        
        public Form1()
        {
            InitializeComponent();
            this._Option = "";
            this._Parameter = "";
            lableCurrentTime.Text = DateTime.Now.ToString("h:mm tt");
            radShutdown.Checked = true;
            radAfter.Checked = true;
        }

        private void radShutdown_CheckedChanged(object sender, EventArgs e)
        {
            this._Option = "shutdown";

        }

        private void radRestart_CheckedChanged(object sender, EventArgs e)
        {
            this._Option = "restart";
        }

        private void btn_Shutdown_Click(object sender, EventArgs e)
        {
            
            
            if (radAfter.Checked)
            {
                this._Timeshutdown = nudPhut.Value * 60;
                this._Parameter = string.Format("/s/t {0}", this._Timeshutdown);
            }
            else
            {
                this._Timeshutdown = (nudHour.Value * 3600) + nudHMinute.Value*60;
                this._Parameter = string.Format("/s/t {0}", this._Timeshutdown);
            }
            
            //"shutdown", "/s /t 0"
            //var psi = new ProcessStartInfo(this._Option,this._Parameter);
            //psi.CreateNoWindow = true;
            //psi.UseShellExecute = false;
            //Process.Start(psi);
        
                
                var psi = new ProcessStartInfo(this._Option, this._Parameter);
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            
            

        }

        private void btn_Shutdown_MouseHover(object sender, EventArgs e)
        {
            btn_Shutdown.BackColor = Color.Yellow;
        }

        private void btn_Shutdown_MouseLeave(object sender, EventArgs e)
        {
            btn_Shutdown.BackColor = Color.White;
        }

        private void radAfter_CheckedChanged(object sender, EventArgs e)
        {
            this._OptionTime = 1;
        }
    }
}
