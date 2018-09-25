using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Win32;

namespace TaskManager_WinForms_
{
    public partial class FormSetTimeProc : Form
    {
        private string PathToFole { get; set; } = null; // path to application
        private bool IsRunTask { get; set; } = false; // flag to Run or Stop process
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsRunTask) // if IsRunTask == true => RunProc()
                RunProc();
            if (!IsRunTask) // if IsRunTask == false => StopProc()
                StopProc();
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


        private void StopProc()
        {

        }

        /// <summary>
        /// Start process
        /// </summary>
        /// <param name="valueRadioBtn"></param>
        private void StartProc(string valueRadioBtn)
        {
            Trigger tr = null;
            if (valueRadioBtn == "daily")
                tr = ReturnDailyTr();
            if (valueRadioBtn == "weekend")
                tr = ReturnWeeklyTr();
            if (valueRadioBtn == "month")
                tr = ReturnMonthlyTr();
            if (valueRadioBtn == "time")
                tr = ReturnTimeTr();
            string t = PathToFole.Substring(0, PathToFole.LastIndexOf('.'));
            if (label5.Text != null || label5.Text != string.Empty)
                TaskService.Instance.AddTask("NotePad", tr, new ExecAction(t, PathToFole, null));
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
            CheckFileWitOpenD();
            if (label5.Text != null || label5.Text != string.Empty)
                btnSetTime.Enabled = true;
        }

        /// <summary>
        /// Check File from OpenFileDialog
        /// </summary>
        private void CheckFileWitOpenD()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Check file";
            file.Filter = "Application |*.exe";
            if (file.ShowDialog() == DialogResult.OK)
            {
                PathToFole = file.FileName;
                label5.Text = PathToFole.Substring(PathToFole.LastIndexOf('\\')+1);
            }
        }

    }
}
