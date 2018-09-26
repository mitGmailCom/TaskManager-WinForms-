using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager_WinForms_
{
    public partial class FormSetTimeStopProc : Form
    {
        internal string Proc { get; set; } = null; // Name of selected process
        internal Process SelectedProc { get; set; } // Selected process
        bool flagForStopProc = false; // Flag for stop process
        formTaskManager mainF; // main form


        public FormSetTimeStopProc()
        {
            InitializeComponent();
            Load += FormSetTimeStopProc_Load;
        }


        private void FormSetTimeStopProc_Load(object sender, EventArgs e)
        {
            btnSetTime.Enabled = false;
            flagForStopProc = true; // enable flag to stop selected process
            mainF = (formTaskManager)this.Owner; 
        }


        /// <summary>
        /// Handler for button Check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetProcess_Click(object sender, EventArgs e)
        {
            GetProc();
            if (label5.Text != null || label5.Text != string.Empty)
            {
                if (tbDay.Text != string.Empty && tbHour.Text != string.Empty && tbMinute.Text != string.Empty)
                    btnSetTime.Enabled = true; // enable button Stop
            }
                
        }

        /// <summary>
        /// Handler for button Stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetTime_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedProc = Process.GetProcessesByName(Proc)[0];
                //SelectedProc.Exited += SelectedProc_Exited1;
                SelectedProc.Exited += SelectedProc_Exited; // add handler for selected process
                // get date from textbox tbDay, tbHour, tbMinute
                DateTime timeStop = new DateTime(2018, 09, Convert.ToInt32(tbDay.Text), Convert.ToInt32(tbHour.Text), Convert.ToInt32(tbMinute.Text), 0);
                TimeSpan tsp = timeStop - DateTime.Now; // calculate total time
                int mss = (int)tsp.TotalMilliseconds; // convert to milliseconds
                // Run Timer for stop selected process
                System.Threading.Timer timer1 = new System.Threading.Timer(delegate { SelectedProc.CloseMainWindow(); SelectedProc.Close(); }, null, mss, Timeout.Infinite);
                System.Threading.Timer timer2 = new System.Threading.Timer(delegate { WriteToFile(); }, null, mss+5, Timeout.Infinite);
            }
            catch (Exception ex)
            {
                // write data to file
                StreamWriter sw = new StreamWriter(@"LogThreads.txt", true, Encoding.UTF8);
                sw.WriteLineAsync(ex.Message);
                if (sw != null)
                    sw.Close();
            }
            //this.Close();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
        }

        /// <summary>
        /// Write data to file
        /// </summary>
        private void WriteToFile()
        {
            Thread.Sleep(1000);
            var t = Process.GetProcessesByName(Proc);
            if (t.Count() == 0)
            {
                StreamWriter sw = new StreamWriter(@"LogThreads.txt", true, Encoding.UTF8);
                try
                {
                    string temp = Proc + "Process stoped" + " " + DateTime.Now.AddSeconds(1);
                    sw.WriteLine(temp);
                }
                catch (Exception ex)
                {
                    sw.WriteLine(ex.Message);
                }
                finally
                {
                    if (sw != null)
                        sw.Close();
                }
            }
        }

        /// <summary>
        /// Get selected process
        /// </summary>
        private void GetProc()
        {
            try
            {
                if (flagForStopProc)
                {
                    mainF.GetFlag = true;
                    this.WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = true;
                }
                flagForStopProc = false;
            }
            catch (Exception ex)
            {
                // write data to file
                StreamWriter sw = new StreamWriter(@"LogThreads.txt", true, Encoding.UTF8);
                sw.WriteLineAsync(ex.Message);
                if (sw != null)
                    sw.Close();
            }
        }

        /// <summary>
        /// Handler for selected process when it is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedProc_Exited(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"LogThreads.txt", true, Encoding.UTF8);
            try
            {
                string temp = SelectedProc.ProcessName + "Process stoped" + " " + DateTime.Now;
                sw.WriteLineAsync(temp);
            }
            catch(Exception ex)
            {
                sw.WriteLineAsync(ex.Message);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }

        /// <summary>
        /// GETer and SETer for label5
        /// </summary>
        public Label GetLabel
        {
            get { return label5; }
            set { label5 = value; }
        }

        /// <summary>
        /// Handler for change value in textboxes tbDay, tbHour, tbMinute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (label5.Text != null || label5.Text != string.Empty)
            {
                if (tbDay.Text != string.Empty && tbHour.Text != string.Empty && tbMinute.Text != string.Empty)
                    btnSetTime.Enabled = true; // enable button Stop
            }
        }
    }
}
