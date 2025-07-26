
namespace UserCreationFormApp
{
    partial class CreateEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new Label();
            label2 = new Label();
            lbID = new Label();
            lbFirstName = new Label();
            tbFirstName = new TextBox();
            lbLastName = new Label();
            lbEmail = new Label();
            lbPhone = new Label();
            lbAddress = new Label();
            tbLastName = new TextBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbAddress = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(336, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(161, 38);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Create User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 52);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "Client ID";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(146, 56);
            lbID.Name = "lbID";
            lbID.Size = new Size(0, 25);
            lbID.TabIndex = 2;
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(28, 91);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(97, 25);
            lbFirstName.TabIndex = 3;
            lbFirstName.Text = "First Name";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(157, 91);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(536, 31);
            tbFirstName.TabIndex = 4;
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(28, 140);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(95, 25);
            lbLastName.TabIndex = 5;
            lbLastName.Text = "Last Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(28, 183);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(54, 25);
            lbEmail.TabIndex = 6;
            lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(28, 229);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(78, 25);
            lbPhone.TabIndex = 7;
            lbPhone.Text = "Phone #";
            lbPhone.Click += label4_Click;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(28, 275);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(77, 25);
            lbAddress.TabIndex = 8;
            lbAddress.Text = "Address";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(157, 134);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(536, 31);
            tbLastName.TabIndex = 9;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(157, 177);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(536, 31);
            tbEmail.TabIndex = 10;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(157, 223);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(536, 31);
            tbPhone.TabIndex = 11;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(157, 269);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(536, 31);
            tbAddress.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(157, 320);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(290, 320);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 382);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbAddress);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbLastName);
            Controls.Add(lbAddress);
            Controls.Add(lbPhone);
            Controls.Add(lbEmail);
            Controls.Add(lbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(lbFirstName);
            Controls.Add(lbID);
            Controls.Add(label2);
            Controls.Add(lbTitle);
            Name = "CreateEditForm";
            Text = "Create Client";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lbTitle;
        private Label label2;
        private Label lbID;
        private Label lbFirstName;
        private TextBox tbFirstName;
        private Label lbLastName;
        private Label lbEmail;
        private Label lbPhone;
        private Label lbAddress;
        private TextBox tbLastName;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbAddress;
        private Button btnSave;
        private Button btnCancel;
    }
}