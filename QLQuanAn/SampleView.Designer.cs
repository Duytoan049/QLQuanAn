namespace QLQuanAn
{
    partial class SampleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleView));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textSearch = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            label2 = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            SuspendLayout();
            // 
            // textSearch
            // 
            textSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSearch.CustomizableEdges = customizableEdges1;
            textSearch.DefaultText = "";
            textSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textSearch.Font = new Font("Segoe UI", 9F);
            textSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textSearch.IconLeft = (Image)resources.GetObject("textSearch.IconLeft");
            textSearch.Location = new Point(1104, 81);
            textSearch.Margin = new Padding(3, 4, 3, 4);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search Here";
            textSearch.SelectedText = "";
            textSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            textSearch.Size = new Size(312, 45);
            textSearch.TabIndex = 0;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1104, 54);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.HoverState.ImageSize = new Size(64, 64);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageOffset = new Point(0, 0);
            btnAdd.ImageRotate = 0F;
            btnAdd.Location = new Point(39, 58);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedState.ImageSize = new Size(64, 64);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnAdd.Size = new Size(71, 68);
            btnAdd.TabIndex = 2;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 18);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 3;
            label2.Text = "Header Text";
            // 
            // guna2Separator1
            // 
            guna2Separator1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Separator1.BackColor = Color.White;
            guna2Separator1.Location = new Point(41, 156);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1377, 10);
            guna2Separator1.TabIndex = 4;
            // 
            // SampleView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1444, 518);
            Controls.Add(guna2Separator1);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(textSearch);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "SampleView";
            Text = "SampleView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        public Guna.UI2.WinForms.Guna2TextBox textSearch;
        public Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        public Label label2;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Label label1;
    }
}