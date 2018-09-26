using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Win32;

namespace TaskManager_WinForms_
{
    public partial class FormSetTimeProc : Form
    {
        private string PathToFile { get; set; } = null; // path to application
        private bool IsRunTask { get; set; } = false; // flag to Run or Stop process
        StreamWriter sw; 
        //private List<string> ListRunProcess = new List<string>();

        public FormSetTimeProc()
        {
            InitializeComponent();
            Load += FormSetTimeProc_Load;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormSetTimeProc_Load(object sender, EventArgs e)
        {
            btnSetTime.Enabled = false;
        }

        /// <summary>
        /// GETer and SETer for IsRunTask
        /// </summary>
        public bool SetFlagForIsRun
        {
            get { return IsRunTask; }
            set { IsRunTask = value; }
        }


        /// <summary>
        /// Handler for button Run process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsRunTask) // if IsRunTask == true => RunProc()
                RunProc();
            this.Close();
        }

        /// <summary>
        /// Find checked radiobutton and go to method StartProc with some parametr
        /// </summary>
        private void RunProc()
        {
            if (radioBtnTime.Checked)
                StartProc("time");
            if (radioBtnDaily.Checked)
                StartProc("daily");
            if (radioBtnWeekend.Checked)
                StartProc("weekend");
            if (radioBtnMonth.Checked)
                StartProc("month");
        }


        /// <summary>
        /// Start process
        /// </summary>
        /// <param name="valueRadioBtn"></param>
        private void StartProc(string valueRadioBtn)
        {
            Trigger tr = null;
            try
            {
                if (valueRadioBtn == "daily")
                    tr = ReturnDailyTr();
                if (valueRadioBtn == "weekend")
                    tr = ReturnWeeklyTr();
                if (valueRadioBtn == "month")
                    tr = ReturnMonthlyTr();
                if (valueRadioBtn == "time")
                    tr = ReturnTimeTr();
            }
            catch(Exception ex)
            {
                sw = new StreamWriter(@"LogThreads.txt", true, Encoding.UTF8);
                sw.WriteLineAsync(ex.Message);
                if (sw != null)
                    sw.Close();
            }
            if (label5.Text != null || label5.Text != string.Empty)
            {
                try
                {
                    string tem = (PathToFile.Substring(PathToFile.LastIndexOf('\\') + 1));
                    tem = tem.Substring(0, tem.LastIndexOf('.'));
                    tem = tem[0].ToString().ToUpper() + tem.Substring(1,tem.Length - 1);
                    TaskService.Instance.AddTask(tem, tr, new ExecAction(tem));
                }
                catch(Exception ex2)
                {
                    sw = new StreamWriter(@"LogThreads.txt", true, Encoding.UTF8);
                    sw.WriteLineAsync(ex2.Message);
                    if (sw != null)
                        sw.Close();
                }
                #region Alternatively you can use TaskDefinition
                //using (TaskService ts = new TaskService())
                //{
                //    TaskDefinition td = ts.NewTask();
                //    td.RegistrationInfo.Description = "Run" + PathToFile.Substring(PathToFile.LastIndexOf('\\') + 1, PathToFile.LastIndexOf('.'));
                //    td.Triggers.Add(tr);
                //    td.Actions.Add(new ExecAction(t, PathToFile, null));
                //    ts.RootFolder.RegisterTaskDefinition(PathToFile.Substring(PathToFile.LastIndexOf('\\') + 1, PathToFile.LastIndexOf('.')), td);
                //    ts.RootFolder.DeleteTask(PathToFile.Substring(PathToFile.LastIndexOf('\\') + 1, PathToFile.LastIndexOf('.')));
                //}
                #endregion
                WriteDataToLog(tr.StartBoundary);
            }
        }

        /// <summary>
        /// Write data to file
        /// </summary>
        private void WriteDataToLog(DateTime date)
        {
            try
            {
                string temp1 = PathToFile.Substring(PathToFile.LastIndexOf('\\') + 1) + "Task in queque" + " " + DateTime.Now;
                string temp2 = PathToFile.Substring(PathToFile.LastIndexOf('\\') + 1) + "Task run" + " " + date;
                sw = new StreamWriter(@"LogThreads.txt", true, Encoding.UTF8);
                sw.WriteLineAsync(temp1);
                sw.WriteLineAsync(temp2);
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
        /// Create DailyTrigger
        /// </summary>
        /// <returns>DailyTrigger</returns>
        private DailyTrigger ReturnDailyTr()
        {
            DailyTrigger dt = new DailyTrigger();
            dt.StartBoundary = DateTime.Today;
            dt.DaysInterval = 1;
            return dt;
        }

        /// <summary>
        /// Create WeeklyTrigger
        /// </summary>
        /// <returns>WeeklyTrigger</returns>
        private WeeklyTrigger ReturnWeeklyTr()
        {
            WeeklyTrigger wTrigger = new WeeklyTrigger();
            wTrigger.StartBoundary = DateTime.Today;
            wTrigger.DaysOfWeek = (DaysOfTheWeek)DateTime.Now.DayOfWeek;
            wTrigger.WeeksInterval = 1;
            return wTrigger;
        }

        /// <summary>
        /// Create MonthlyTrigger
        /// </summary>
        /// <returns>MonthlyTrigger</returns>
        private MonthlyTrigger ReturnMonthlyTr()
        {
            MonthlyTrigger mt = new MonthlyTrigger();
            mt.StartBoundary = DateTime.Today;
            mt.DaysOfMonth = new int[1] { 1};
            return mt;
        }

        /// <summary>
        /// Create TimeTrigger
        /// </summary>
        /// <returns>TimeTrigger</returns>
        private TimeTrigger ReturnTimeTr()
        {
            TimeTrigger tm = new TimeTrigger();
            int y = Convert.ToInt32(tbYear.Text);
            int m = Convert.ToInt32(tbMonth.Text);
            int d = Convert.ToInt32(tbDay.Text);
            int h = Convert.ToInt32(tbHour.Text);
            int mt = Convert.ToInt32(tbMinute.Text);
            tm.StartBoundary = new DateTime(y, m, d, h, mt, 0);
            return tm;
        }

        /// <summary>
        /// Check Application for manipulation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetProcess_Click(object sender, EventArgs e)
        {
            CheckFileWithOpenD();
            if (label5.Text != null || label5.Text != string.Empty)
                btnSetTime.Enabled = true;
        }

        /// <summary>
        /// Check File from OpenFileDialog
        /// </summary>
        private void CheckFileWithOpenD()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Check file";
            file.Filter = "Application |*.exe";
            if (file.ShowDialog() == DialogResult.OK)
            {
                PathToFile = file.FileName;
                label5.Text = PathToFile.Substring(PathToFile.LastIndexOf('\\')+1);
            }
        }

    }
}
