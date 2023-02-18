using System.Collections.ObjectModel;
using System.Diagnostics;

namespace SysProg_Lesson_1_Hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            Processes = new(Process.GetProcesses());
            

        }

        public ObservableCollection<Process> Processes { get; set; }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}