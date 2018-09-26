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
    public partial class formTaskManager : Form
    {
        bool flag = false; // flag for stop process
        FormSetTimeStopProc formStopProc;
        FormSetTimeProc formSetTime;
        Thread thread; // thread
        Process[] process; // mass of Process
        //int count = 0; // counter for Process
        string Proc1 { get; set; } = null; // Name of selected process
        internal Process SelectedProc1 { get; set; } // Selected process

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
            ThreadStart threadstart = new ThreadStart(GetAllProcessInSystem); // add method GetAllProcessInSystem for ThreadStart
            thread = new Thread(threadstart); // initial thread
            thread.Start(); // run thread
        }


        private void FormTaskManager_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            listViewProcesses.ItemSelectionChanged += ListViewProcesses_ItemSelectionChanged;
            this.Name = "mainForm"; // set name for this form
            SetSettingsListView(); // run method SetSettingsListView
            ThreadGetAllProcess(); // run method ThreadGetAllProcess
        }

        /// <summary>
        /// GETer and SETer for flag
        /// </summary>
        public bool GetFlag
        {
            get { return flag; }
            set { flag = value; }
        }


        /// <summary>
        /// Handler on select item in ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewProcesses_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (flag)
                {
                    var selectedItem = listViewProcesses.SelectedItems; // get selected item
                    Proc1 = selectedItem[0].SubItems[0].Text; // get name of selected item
                    SelectedProc1 = Process.GetProcessesByName(Proc1)[0]; // get process
                    formStopProc.Proc = selectedItem[0].SubItems[0].Text;
                    //formStopProc.SelectedProc = Process.GetProcessesByName(Proc1)[0];
                    formStopProc.GetLabel.Text = Proc1;
                    formStopProc.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception ex)
            {
                // write data to file
                StreamWriter sw = new StreamWriter(@"LogThreads.txt", true, Encoding.UTF8);
                sw.WriteLineAsync(ex.Message);
                if (sw != null)
                    sw.Close();
            }
            flag = false;
        }

        /// <summary>
        /// GETer for ListView
        /// </summary>
        public ListView getListviewitem
        {
            get { return listViewProcesses; }
        }

        /// <summary>
        /// Set settings for ListView
        /// </summary>
        private void SetSettingsListView()
        {
            listViewProcesses.View = View.Details; // set type Details for ListView
            listViewProcesses.Columns.Add("Name process", 250, HorizontalAlignment.Left); // add column Name process
            listViewProcesses.Columns.Add("Id", 50, HorizontalAlignment.Left); // add column Id
            listViewProcesses.Columns.Add("Threads", 65, HorizontalAlignment.Left); // add column Threads
            listViewProcesses.Columns.Add("HandleCount", 85, HorizontalAlignment.Left); // add column HandleCount
        }

        /// <summary>
        /// Get All process in system and restore to ListView
        /// </summary>
        private void GetAllProcessInSystem()
        {
            List<ListViewItem> Collection = new List<ListViewItem>(); // create list of ListViewItems
            ListViewItem[] CollectionMas; // mass of ListViewItems
            process = GetProcess(); // invoke method GetProcess(get all process)
            foreach (var proc in process)
            {
                ListViewItem lstvit = new ListViewItem(proc.ProcessName); // add process name
                lstvit.SubItems.Add($"{proc.Id}"); // add process id
                lstvit.SubItems.Add($"{proc.Threads.Count.ToString()}"); // add count of threads
                lstvit.SubItems.Add($"{proc.HandleCount.ToString()}"); // add handle count
                Collection.Add(lstvit);
                //count++; // increase count on 1
            }
            CollectionMas = new ListViewItem[Collection.Count];
            CollectionMas = Collection.ToArray(); // add list Collection to mass CollectionMas

            listViewProcesses.Invoke(new Action(() => listViewProcesses.Items.AddRange(CollectionMas)));
            var countProc = Process.GetProcesses();
            label2.Invoke(new Action(() => label2.Text = countProc.Count().ToString()));
            countProc = null;
        }

        /// <summary>
        /// Get all process in system
        /// </summary>
        /// <returns></returns>
        private Process[] GetProcess()
        {
            return Process.GetProcesses(); // get all process
        }

        /// <summary>
        /// Handler for button Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            listViewProcesses.Invoke(new Action(() => listViewProcesses.Clear())); // clear ListView
            this.Invoke(new Action(() => this.SetSettingsListView())); // invoke method SetSettingsListView
            ThreadGetAllProcess(); // invoke method ThreadGetAllProcess
        }


        /// <summary>
        /// Handler for click on menu Run Process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSetTime = new FormSetTimeProc(); // create form FormSetTimeProc
            formSetTime.StartPosition = FormStartPosition.CenterScreen; // set position at center
            formSetTime.Owner = this; // set owner for FormSetTimeProc
            formSetTime.SetFlagForIsRun = true;
            formSetTime.Show(); // show form FormSetTimeProc
        }

        /// <summary>
        /// Handler for click on menu Stop Process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formStopProc = new FormSetTimeStopProc(); // create form FormSetTimeStopProc
            formStopProc.StartPosition = FormStartPosition.CenterScreen; // set position at center
            formStopProc.Owner = this; // set owner for FormSetTimeStopProc
            formStopProc.Show(); // show form FormSetTimeStopProc
        }
    }
}
