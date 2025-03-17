namespace QLQuanAn.Model
{
    partial class FormCategoryAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoryAdd));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtNameHeader = new Label();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnQuit
            // 
            btnQuit.DialogResult = DialogResult.None;
            btnQuit.DisabledState.BorderColor = Color.DarkGray;
            btnQuit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnQuit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnQuit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnQuit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            // 
            // guna2Panel1
            // 
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel1.Size = new Size(497, 125);
            guna2Panel1.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Location = new Point(0, 303);
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(497, 125);
            guna2Panel2.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            guna2PictureBox1.InitialImage = (Image)resources.GetObject("guna2PictureBox1.InitialImage");
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // label1
            // 
            label1.Size = new Size(101, 20);
            label1.Text = "Category Add";
            // 
            // txtNameHeader
            // 
            txtNameHeader.AutoSize = true;
            txtNameHeader.Location = new Point(78, 148);
            txtNameHeader.Name = "txtNameHeader";
            txtNameHeader.Size = new Size(49, 20);
            txtNameHeader.TabIndex = 1;
            txtNameHeader.Text = "Name";
            // 
            // txtName
            // 
            txtName.CustomizableEdges = customizableEdges6;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(78, 184);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Modified = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtName.Size = new Size(286, 42);
            txtName.TabIndex = 0;
            // 
            // FormCategoryAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 428);
            Controls.Add(txtName);
            Controls.Add(txtNameHeader);
            Name = "FormCategoryAdd";
            Text = "FormCategoryAdd";
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(txtNameHeader, 0);
            Controls.SetChildIndex(txtName, 0);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNameHeader;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
    }
}