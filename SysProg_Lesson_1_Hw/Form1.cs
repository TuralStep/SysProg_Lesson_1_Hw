using System.Collections.ObjectModel;
using System.Diagnostics;

namespace SysProg_Lesson_1_Hw
{
    public partial class Form1 : Form
    {


        public ObservableCollection<Process> Processes { get; set; }
        Process selectedProc;


        public Form1()
        {
            InitializeComponent();

            listView.View = View.Details;
            listView.GridLines = true;
            listView.Columns.Add("Name");
            listView.Columns.Add("Id");
            listView.Columns.Add("Machine Name");

            Processes = new(Process.GetProcesses());


            var timer = new System.Timers.Timer();
            timer.Interval = 5000;
            timer.Elapsed += TaskReload_Elapsed;
            timer.Start();

            btn_endProc.Click += Btn_endProc_Click;
            btn_createProc.Click += Btn_createProc_Click;
             

        }

        private void Btn_createProc_Click(object? sender, EventArgs e)
        {
            Process.Start(txt_proc.Text);
        }
        
        private void Btn_endProc_Click(object? sender, EventArgs e)
        {
            
        }

        private void TaskReload_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            listView.Items.Clear();

            foreach (var task in Process.GetProcesses())
            {
                listView.Items.Add(new ListViewItem(
                                        new string[]
                                        {
                                            task.ProcessName,
                                            task.Id.ToString(),
                                            task.MachineName
                                        }
                                                    ));
            }

        }


        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}