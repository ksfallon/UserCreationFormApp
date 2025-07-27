namespace UserCreationFormApp
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
            label1 = new Label();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            userTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)userTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 16);
            label1.Name = "label1";
            label1.Size = new Size(1096, 38);
            label1.TabIndex = 0;
            label1.Text = "List of Users";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(12, 64);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(112, 34);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteUser.Location = new Point(979, 64);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(112, 34);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditUser.Location = new Point(861, 64);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(112, 34);
            btnEditUser.TabIndex = 3;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // userTable
            // 
            userTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTable.Location = new Point(12, 116);
            userTable.MultiSelect = false;
            userTable.Name = "userTable";
            userTable.RowHeadersVisible = false;
            userTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            userTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userTable.Size = new Size(1079, 519);
            userTable.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 647);
            Controls.Add(userTable);
            Controls.Add(btnEditUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnAddUser);
            Controls.Add(label1);
            Name = "Form1";
            Text = "User Manager";
            ((System.ComponentModel.ISupportInitialize)userTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAddUser;
        private Button btnDeleteUser;
        private Button btnEditUser;
        private DataGridView userTable;
    }
}
