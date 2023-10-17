using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListWindowsForm
{
    public class Tasks
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        public Tasks(string TaskName, string TaskDescripition)
        {
            this.TaskName = TaskName;
            this.TaskDescription = TaskDescripition;
        }

        public virtual string TaskDetails()
        { 

            string text = $"The task name --> {TaskName} \n Descripition : {TaskDescription}";

            return text;
        }
    }



    public class ITaskList : Tasks
    {
        public string TaskBy { get; set; }
        public DateTime DateSet { get; set; }

        public ITaskList(string TaskName, string TaskDescription, string TaskBy, DateTime DateSet) : base(TaskName, TaskDescription)
        {
            this.TaskBy = TaskBy;
            this.DateSet = DateSet;
        }

        public override string TaskDetails()
        {
            string Text = $" Task : {TaskName} \n Description : {TaskDescription} \n To do by : {TaskBy} \n Date set : {DateSet.ToString()}";


            return Text;
        }


    }
}
