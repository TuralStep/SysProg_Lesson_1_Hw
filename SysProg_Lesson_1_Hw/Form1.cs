using System.Collections.ObjectModel;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SysProg_Lesson_1_Hw
{
    public partial class Form1 : Form
    {


        public ObservableCollection<Process> Processes { get; set; }
        public List<string> BlackListNames { get; set; }
        string selectedProc;


        public Form1()
        {
            InitializeComponent();

            listView.View = View.Details;
            listView.GridLines = true;
            listView.Columns.Add("Name", 150);
            listView.Columns.Add("Id", 75);
            listView.Columns.Add("Handle Count", 100);
            listView.Columns.Add("Thread Count", 100);
            listView.Columns.Add("Machine Name", 200);

            Processes = new(Process.GetProcesses());
            BlackListNames = new();
            TaskReload_Elapsed(null, null);

            var timer = new System.Timers.Timer();
            timer.Interval = 10000;
            timer.Elapsed += TaskReload_Elapsed;
            timer.Start();

            var timer2 = new System.Timers.Timer();
            timer2.Interval = 3000;
            timer2.Elapsed += BlackListTimer_Elapsed;
            timer2.Start();

            btn_endProc.Click += Btn_endProc_Click;
            btn_createProc.Click += Btn_createProc_Click;

        }

        private void BlackListTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            foreach (var p in Processes)
            {
                if (BlackListNames.Any(s => s.Equals(p.ProcessName)))
                {
                    p.Kill();
                    Processes.Remove(p);
                }
            }
        }

        private void Btn_createProc_Click(object? sender, EventArgs e)
        {
            Process.Start(txt_proc.Text);
        }

        private void Btn_endProc_Click(object? sender, EventArgs e)
        {
            Process? p = Process.GetProcesses().FirstOrDefault(o => o.ProcessName.Equals(selectedProc));

            if (p != null)
                p.Kill();
        }

        private void TaskReload_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            listView.Items.Clear();
            Processes = new(Process.GetProcesses());

            foreach (var task in Processes)
            {
                listView.Items.Add(new ListViewItem(
                                        new string[]
                                        {
                                            task.ProcessName,
                                            task.Id.ToString(),
                                            task.HandleCount.ToString(),
                                            task.Threads.Count.ToString(),
                                            task.MachineName
                                        }));
            }

        }


        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListView lw)
                if (lw.SelectedItems.Count > 0)
                    selectedProc = lw.SelectedItems[0].Text;
        }

        private void btn_blackList_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedProc))
                if (!BlackListNames.Contains(selectedProc))
                    BlackListNames.Add(selectedProc);
        }
    }
}