namespace ToDoListWindowsForm
{
    public partial class Form1 : Form
    {
        public List<ITaskList> TL { get; set; } = new List<ITaskList>();



        public Form1()
        {
            InitializeComponent();
        }

        private void AddTaskBTN_Click(object sender, EventArgs e)
        {

            string Task = TaskNameTB.Text;
            string Description = DescriptionTB.Text;
            string ToDoBy = TodobyTB.Text;

            var CurrentDate = DateTime.Now;

            ITaskList TempTask = new ITaskList(Task, Description, ToDoBy, CurrentDate);

            TL.Add(TempTask);

            TaskListR.Clear();
            foreach (var task in TL)
            {
                var eeee = task.TaskDetails();
                TaskListR.AppendText("------------\n" + eeee + "\n------------ \n");

            }
            TaskNameTB.Text = "";
            DescriptionTB.Text = "";
            TodobyTB.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
        }
    }
}