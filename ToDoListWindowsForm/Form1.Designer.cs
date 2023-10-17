namespace ToDoListWindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TaskNameTB = new TextBox();
            DescriptionTB = new TextBox();
            TodobyTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddTaskBTN = new Button();
            TaskListR = new RichTextBox();
            label4 = new Label();
            RefreshBTN = new Button();
            SuspendLayout();
            // 
            // TaskNameTB
            // 
            TaskNameTB.Location = new Point(116, 122);
            TaskNameTB.Name = "TaskNameTB";
            TaskNameTB.Size = new Size(100, 23);
            TaskNameTB.TabIndex = 0;
            // 
            // DescriptionTB
            // 
            DescriptionTB.Location = new Point(116, 176);
            DescriptionTB.Name = "DescriptionTB";
            DescriptionTB.Size = new Size(100, 23);
            DescriptionTB.TabIndex = 1;
            // 
            // TodobyTB
            // 
            TodobyTB.Location = new Point(116, 232);
            TodobyTB.Name = "TodobyTB";
            TodobyTB.Size = new Size(100, 23);
            TodobyTB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 125);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "Task name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 179);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Description :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 235);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "To do by :";
            // 
            // AddTaskBTN
            // 
            AddTaskBTN.Cursor = Cursors.Hand;
            AddTaskBTN.Location = new Point(65, 272);
            AddTaskBTN.Name = "AddTaskBTN";
            AddTaskBTN.Size = new Size(132, 23);
            AddTaskBTN.TabIndex = 7;
            AddTaskBTN.Text = "Add task";
            AddTaskBTN.UseVisualStyleBackColor = true;
            AddTaskBTN.Click += AddTaskBTN_Click;
            // 
            // TaskListR
            // 
            TaskListR.Location = new Point(354, 122);
            TaskListR.Name = "TaskListR";
            TaskListR.Size = new Size(241, 206);
            TaskListR.TabIndex = 8;
            TaskListR.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 90);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "Task list";
            // 
            // RefreshBTN
            // 
            RefreshBTN.Location = new Point(550, 398);
            RefreshBTN.Name = "RefreshBTN";
            RefreshBTN.Size = new Size(75, 23);
            RefreshBTN.TabIndex = 10;
            RefreshBTN.Text = "Load Tasks";
            RefreshBTN.UseVisualStyleBackColor = true;
            RefreshBTN.Click += RefreshBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 433);
            Controls.Add(RefreshBTN);
            Controls.Add(label4);
            Controls.Add(TaskListR);
            Controls.Add(AddTaskBTN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TodobyTB);
            Controls.Add(DescriptionTB);
            Controls.Add(TaskNameTB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TaskNameTB;
        private TextBox DescriptionTB;
        private TextBox TodobyTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddTaskBTN;
        private RichTextBox TaskListR;
        private Label label4;
        private Button RefreshBTN;
    }
}