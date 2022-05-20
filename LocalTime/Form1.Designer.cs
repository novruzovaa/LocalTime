namespace LocalTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Baku = new System.Windows.Forms.Button();
            this.btn_London = new System.Windows.Forms.Button();
            this.lbl_baku = new System.Windows.Forms.Label();
            this.lbl_london = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Baku
            // 
            this.btn_Baku.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Baku.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Baku.ForeColor = System.Drawing.Color.Peru;
            this.btn_Baku.Location = new System.Drawing.Point(87, 52);
            this.btn_Baku.Name = "btn_Baku";
            this.btn_Baku.Size = new System.Drawing.Size(272, 98);
            this.btn_Baku.TabIndex = 0;
            this.btn_Baku.Text = "Baku";
            this.btn_Baku.UseVisualStyleBackColor = false;
            this.btn_Baku.Click += new System.EventHandler(this.btn_Baku_Click);
            // 
            // btn_London
            // 
            this.btn_London.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_London.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_London.ForeColor = System.Drawing.Color.Peru;
            this.btn_London.Location = new System.Drawing.Point(457, 52);
            this.btn_London.Name = "btn_London";
            this.btn_London.Size = new System.Drawing.Size(275, 98);
            this.btn_London.TabIndex = 1;
            this.btn_London.Text = "London";
            this.btn_London.UseVisualStyleBackColor = false;
            this.btn_London.Click += new System.EventHandler(this.btn_London_Click);
            // 
            // lbl_baku
            // 
            this.lbl_baku.AutoSize = true;
            this.lbl_baku.Location = new System.Drawing.Point(563, 95);
            this.lbl_baku.Name = "lbl_baku";
            this.lbl_baku.Size = new System.Drawing.Size(50, 20);
            this.lbl_baku.TabIndex = 2;
            this.lbl_baku.Text = "label1";
            this.lbl_baku.Visible = false;
            // 
            // lbl_london
            // 
            this.lbl_london.AutoSize = true;
            this.lbl_london.Location = new System.Drawing.Point(189, 95);
            this.lbl_london.Name = "lbl_london";
            this.lbl_london.Size = new System.Drawing.Size(50, 20);
            this.lbl_london.TabIndex = 3;
            this.lbl_london.Text = "label2";
            this.lbl_london.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LocalTime.Properties.Resources.baku;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.lbl_london);
            this.Controls.Add(this.lbl_baku);
            this.Controls.Add(this.btn_London);
            this.Controls.Add(this.btn_Baku);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Local Time";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Baku;
        private Button btn_London;
        private Label lbl_baku;
        private Label lbl_london;
    }
}