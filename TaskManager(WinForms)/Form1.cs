using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager_WinForms_
{
    public partial class formTaskManager : Form
    {
        Thread thread; 
        Process[] process;
        int count = 0;
        public formTaskManager()
        {
            InitializeComponent();
            Load += FormTaskManager_Load;
        }


        /// <summary>
        /// Get all process
        /// </summary>
        private void ThreadGetAllProcess()
        {
            ThreadStart threadstart = new ThreadStart(GetAllProcessInSystem);
            thread = new Thread(threadstart);
            thread.Start();
        }

        private void FormTaskManager_Load(object sender, EventArgs e)
        {
            this.Name = "mainForm";
            SetSettingsListView();
            //ThreadStart threadstart = new ThreadStart(GetAllProcessInSystem);
            //thread = new Thread(threadstart);
            //thread.Start();
            ThreadGetAllProcess();

            //TimerCallback timerCallback = new TimerCallback(TimerMethod);
            //System.Threading.Timer timer = new System.Threading.Timer(timerCallback);
            //timer.Change(0, 3000);
        }

        private void SetSettingsListView()
        {
            listViewProcesses.View = View.Details;
            listViewProcesses.Columns.Add("Name process", 250, HorizontalAlignment.Left);
            listViewProcesses.Columns.Add("Id", 50, HorizontalAlignment.Left);
            listViewProcesses.Columns.Add("Threads", 65, HorizontalAlignment.Left);
            listViewProcesses.Columns.Add("HandleCount", 85, HorizontalAlignment.Left);
        }

        private void GetAllProcessInSystem()
        {
            //Task<Process[]> process = await Process.GetProcesses();
            //listViewProcesses.Invoke(new Action(() => listViewProcesses.Clear()));
            List<ListViewItem> Collection = new List<ListViewItem>();
            ListViewItem[] CollectionMas;
            process = GetProcess();
            foreach (var proc in process)
            {
                ListViewItem lstvit = new ListViewItem(proc.ProcessName);
                lstvit.SubItems.Add($"{proc.Id}");
                lstvit.SubItems.Add($"{proc.Threads.Count.ToString()}");
                lstvit.SubItems.Add($"{proc.HandleCount.ToString()}");
                Collection.Add(lstvit);
                //listViewProcesses.Invoke(new Action(() => listViewProcesses.Items.Add(lstvit)));
                //listViewProcesses.Items.Add(lstvit);
                count++;
            }
            CollectionMas = new ListViewItem[Collection.Count];
            CollectionMas = Collection.ToArray();
            
            listViewProcesses.Invoke(new Action(() => listViewProcesses.Items.AddRange(CollectionMas)));
            var countProc = Process.GetProcesses();
            label2.Invoke(new Action(() => label2.Text = countProc.Count().ToString()));
            countProc = null;
        }


        private void TimerMethod(object timer)
        {
            listViewProcesses.Invoke(new Action(() => listViewProcesses.Clear()));
            this.Invoke(new Action(() => this.SetSettingsListView()));
            GetAllProcessInSystem();
        }

        private Process[] GetProcess()
        {
            //listViewProcesses.Invoke(new Action(() => listViewProcesses.Clear()));
            return Process.GetProcesses();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            listViewProcesses.Invoke(new Action(() => listViewProcesses.Clear()));
            this.Invoke(new Action(() => this.SetSettingsListView()));
            ThreadGetAllProcess();
            //GetAllProcessInSystem();
        }

        private void runProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetTimeProc formSetTime = new FormSetTimeProc();
            formSetTime.Owner = this;
            formSetTime.SetFlagForIsRun = true;
            formSetTime.ShowDialog();

            ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = 
            
            //Thread runNewProc = new Thread();
        }
    }
}
