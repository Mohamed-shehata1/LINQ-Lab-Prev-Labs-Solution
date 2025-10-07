namespace WinFormsApp1
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
            viewBtn = new Button();
            listDepartments = new ListBox();
            DepartmentNameTxt = new TextBox();
            DepartmentNameLabel = new Label();
            AddDepartmentBtn = new Button();
            ClearDepartmentsBtn = new Button();
            DepartmentCapacityLabel = new Label();
            DepartmentCapacityTxt = new TextBox();
            ViewDepartmentsLabel = new Label();
            AddDepartmentLabel = new Label();
            UpdateDepartmentLabel = new Label();
            DeleteDepartmentLabel = new Label();
            UpdateDepartmentCapacityLabel = new Label();
            UpdateDepartmentCapacityTxt = new TextBox();
            UpdateDepartmentBtn = new Button();
            UpdateDepartmentNameLabel = new Label();
            UpdateDepartmentNameTxt = new TextBox();
            DeleteDepartmentBtn = new Button();
            DeleteDepartmentNameLabel = new Label();
            DeleteDepartmentNameTxt = new TextBox();
            SuspendLayout();
            // 
            // viewBtn
            // 
            viewBtn.Location = new Point(59, 295);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(120, 23);
            viewBtn.TabIndex = 0;
            viewBtn.Text = "View Departments";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // listDepartments
            // 
            listDepartments.FormattingEnabled = true;
            listDepartments.ItemHeight = 15;
            listDepartments.Location = new Point(31, 90);
            listDepartments.Name = "listDepartments";
            listDepartments.Size = new Size(188, 184);
            listDepartments.TabIndex = 1;
            // 
            // DepartmentNameTxt
            // 
            DepartmentNameTxt.Location = new Point(387, 90);
            DepartmentNameTxt.Name = "DepartmentNameTxt";
            DepartmentNameTxt.Size = new Size(174, 23);
            DepartmentNameTxt.TabIndex = 2;
            // 
            // DepartmentNameLabel
            // 
            DepartmentNameLabel.AutoSize = true;
            DepartmentNameLabel.Location = new Point(264, 93);
            DepartmentNameLabel.Name = "DepartmentNameLabel";
            DepartmentNameLabel.Size = new Size(105, 15);
            DepartmentNameLabel.TabIndex = 3;
            DepartmentNameLabel.Text = "Department Name";
            // 
            // AddDepartmentBtn
            // 
            AddDepartmentBtn.Location = new Point(387, 181);
            AddDepartmentBtn.Name = "AddDepartmentBtn";
            AddDepartmentBtn.Size = new Size(130, 23);
            AddDepartmentBtn.TabIndex = 4;
            AddDepartmentBtn.Text = "Add Department";
            AddDepartmentBtn.UseVisualStyleBackColor = true;
            AddDepartmentBtn.Click += AddDepartmentBtn_Click;
            // 
            // ClearDepartmentsBtn
            // 
            ClearDepartmentsBtn.Location = new Point(59, 342);
            ClearDepartmentsBtn.Name = "ClearDepartmentsBtn";
            ClearDepartmentsBtn.Size = new Size(120, 23);
            ClearDepartmentsBtn.TabIndex = 5;
            ClearDepartmentsBtn.Text = "Clear Departments";
            ClearDepartmentsBtn.UseVisualStyleBackColor = true;
            ClearDepartmentsBtn.Click += ClearDepartmentsBtn_Click;
            // 
            // DepartmentCapacityLabel
            // 
            DepartmentCapacityLabel.AutoSize = true;
            DepartmentCapacityLabel.Location = new Point(264, 138);
            DepartmentCapacityLabel.Name = "DepartmentCapacityLabel";
            DepartmentCapacityLabel.Size = new Size(119, 15);
            DepartmentCapacityLabel.TabIndex = 9;
            DepartmentCapacityLabel.Text = "Department Capacity";
            // 
            // DepartmentCapacityTxt
            // 
            DepartmentCapacityTxt.Location = new Point(387, 138);
            DepartmentCapacityTxt.Name = "DepartmentCapacityTxt";
            DepartmentCapacityTxt.Size = new Size(174, 23);
            DepartmentCapacityTxt.TabIndex = 8;
            // 
            // ViewDepartmentsLabel
            // 
            ViewDepartmentsLabel.AutoSize = true;
            ViewDepartmentsLabel.Location = new Point(76, 37);
            ViewDepartmentsLabel.Name = "ViewDepartmentsLabel";
            ViewDepartmentsLabel.Size = new Size(103, 15);
            ViewDepartmentsLabel.TabIndex = 10;
            ViewDepartmentsLabel.Text = "View Departments";
            // 
            // AddDepartmentLabel
            // 
            AddDepartmentLabel.AutoSize = true;
            AddDepartmentLabel.Location = new Point(387, 37);
            AddDepartmentLabel.Name = "AddDepartmentLabel";
            AddDepartmentLabel.Size = new Size(95, 15);
            AddDepartmentLabel.TabIndex = 11;
            AddDepartmentLabel.Text = "Add Department";
            // 
            // UpdateDepartmentLabel
            // 
            UpdateDepartmentLabel.AutoSize = true;
            UpdateDepartmentLabel.Location = new Point(689, 37);
            UpdateDepartmentLabel.Name = "UpdateDepartmentLabel";
            UpdateDepartmentLabel.Size = new Size(111, 15);
            UpdateDepartmentLabel.TabIndex = 12;
            UpdateDepartmentLabel.Text = "Update Department";
            // 
            // DeleteDepartmentLabel
            // 
            DeleteDepartmentLabel.AutoSize = true;
            DeleteDepartmentLabel.Location = new Point(1083, 37);
            DeleteDepartmentLabel.Name = "DeleteDepartmentLabel";
            DeleteDepartmentLabel.Size = new Size(106, 15);
            DeleteDepartmentLabel.TabIndex = 13;
            DeleteDepartmentLabel.Text = "Delete Department";
            // 
            // UpdateDepartmentCapacityLabel
            // 
            UpdateDepartmentCapacityLabel.AutoSize = true;
            UpdateDepartmentCapacityLabel.Location = new Point(594, 141);
            UpdateDepartmentCapacityLabel.Name = "UpdateDepartmentCapacityLabel";
            UpdateDepartmentCapacityLabel.Size = new Size(119, 15);
            UpdateDepartmentCapacityLabel.TabIndex = 20;
            UpdateDepartmentCapacityLabel.Text = "Department Capacity";
            // 
            // UpdateDepartmentCapacityTxt
            // 
            UpdateDepartmentCapacityTxt.Location = new Point(717, 141);
            UpdateDepartmentCapacityTxt.Name = "UpdateDepartmentCapacityTxt";
            UpdateDepartmentCapacityTxt.Size = new Size(174, 23);
            UpdateDepartmentCapacityTxt.TabIndex = 19;
            // 
            // UpdateDepartmentBtn
            // 
            UpdateDepartmentBtn.Location = new Point(717, 181);
            UpdateDepartmentBtn.Name = "UpdateDepartmentBtn";
            UpdateDepartmentBtn.Size = new Size(130, 23);
            UpdateDepartmentBtn.TabIndex = 16;
            UpdateDepartmentBtn.Text = "Update Department";
            UpdateDepartmentBtn.UseVisualStyleBackColor = true;
            UpdateDepartmentBtn.Click += UpdateDepartmentBtn_Click;
            // 
            // UpdateDepartmentNameLabel
            // 
            UpdateDepartmentNameLabel.AutoSize = true;
            UpdateDepartmentNameLabel.Location = new Point(594, 96);
            UpdateDepartmentNameLabel.Name = "UpdateDepartmentNameLabel";
            UpdateDepartmentNameLabel.Size = new Size(105, 15);
            UpdateDepartmentNameLabel.TabIndex = 15;
            UpdateDepartmentNameLabel.Text = "Department Name";
            // 
            // UpdateDepartmentNameTxt
            // 
            UpdateDepartmentNameTxt.Location = new Point(717, 93);
            UpdateDepartmentNameTxt.Name = "UpdateDepartmentNameTxt";
            UpdateDepartmentNameTxt.Size = new Size(174, 23);
            UpdateDepartmentNameTxt.TabIndex = 14;
            // 
            // DeleteDepartmentBtn
            // 
            DeleteDepartmentBtn.Location = new Point(1102, 181);
            DeleteDepartmentBtn.Name = "DeleteDepartmentBtn";
            DeleteDepartmentBtn.Size = new Size(130, 23);
            DeleteDepartmentBtn.TabIndex = 23;
            DeleteDepartmentBtn.Text = "Delete Department";
            DeleteDepartmentBtn.UseVisualStyleBackColor = true;
            DeleteDepartmentBtn.Click += DeleteDepartmentBtn_Click;
            // 
            // DeleteDepartmentNameLabel
            // 
            DeleteDepartmentNameLabel.AutoSize = true;
            DeleteDepartmentNameLabel.Location = new Point(979, 96);
            DeleteDepartmentNameLabel.Name = "DeleteDepartmentNameLabel";
            DeleteDepartmentNameLabel.Size = new Size(105, 15);
            DeleteDepartmentNameLabel.TabIndex = 22;
            DeleteDepartmentNameLabel.Text = "Department Name";
            // 
            // DeleteDepartmentNameTxt
            // 
            DeleteDepartmentNameTxt.Location = new Point(1102, 93);
            DeleteDepartmentNameTxt.Name = "DeleteDepartmentNameTxt";
            DeleteDepartmentNameTxt.Size = new Size(174, 23);
            DeleteDepartmentNameTxt.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 450);
            Controls.Add(DeleteDepartmentBtn);
            Controls.Add(DeleteDepartmentNameLabel);
            Controls.Add(DeleteDepartmentNameTxt);
            Controls.Add(UpdateDepartmentCapacityLabel);
            Controls.Add(UpdateDepartmentCapacityTxt);
            Controls.Add(UpdateDepartmentBtn);
            Controls.Add(UpdateDepartmentNameLabel);
            Controls.Add(UpdateDepartmentNameTxt);
            Controls.Add(DeleteDepartmentLabel);
            Controls.Add(UpdateDepartmentLabel);
            Controls.Add(AddDepartmentLabel);
            Controls.Add(ViewDepartmentsLabel);
            Controls.Add(DepartmentCapacityLabel);
            Controls.Add(DepartmentCapacityTxt);
            Controls.Add(ClearDepartmentsBtn);
            Controls.Add(AddDepartmentBtn);
            Controls.Add(DepartmentNameLabel);
            Controls.Add(DepartmentNameTxt);
            Controls.Add(listDepartments);
            Controls.Add(viewBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button viewBtn;
        private ListBox listDepartments;
        private TextBox DepartmentNameTxt;
        private Label DepartmentNameLabel;
        private Button AddDepartmentBtn;
        private Button ClearDepartmentsBtn;
        private Label DepartmentCapacityLabel;
        private TextBox DepartmentCapacityTxt;
        private Label ViewDepartmentsLabel;
        private Label AddDepartmentLabel;
        private Label UpdateDepartmentLabel;
        private Label DeleteDepartmentLabel;
        private Label UpdateDepartmentCapacityLabel;
        private TextBox UpdateDepartmentCapacityTxt;
        private Button UpdateDepartmentBtn;
        private Label UpdateDepartmentNameLabel;
        private TextBox UpdateDepartmentNameTxt;
        private Button DeleteDepartmentBtn;
        private Label DeleteDepartmentNameLabel;
        private TextBox DeleteDepartmentNameTxt;
    }
}
