namespace MegaDesk_Stokes
{
    partial class MainMenu
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
            this.AddQteBtn = new System.Windows.Forms.Button();
            this.VwQteBtn = new System.Windows.Forms.Button();
            this.SrchQteBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQteBtn
            // 
            this.AddQteBtn.Location = new System.Drawing.Point(43, 61);
            this.AddQteBtn.Name = "AddQteBtn";
            this.AddQteBtn.Size = new System.Drawing.Size(249, 73);
            this.AddQteBtn.TabIndex = 0;
            this.AddQteBtn.Text = "&Add New Quote";
            this.AddQteBtn.UseVisualStyleBackColor = true;
            this.AddQteBtn.Click += new System.EventHandler(this.AddQteBtn_Click);
            // 
            // VwQteBtn
            // 
            this.VwQteBtn.Location = new System.Drawing.Point(41, 166);
            this.VwQteBtn.Name = "VwQteBtn";
            this.VwQteBtn.Size = new System.Drawing.Size(250, 53);
            this.VwQteBtn.TabIndex = 1;
            this.VwQteBtn.Text = "&View Quotes";
            this.VwQteBtn.UseVisualStyleBackColor = true;
            this.VwQteBtn.Click += new System.EventHandler(this.VwQteBtn_Click);
            // 
            // SrchQteBtn
            // 
            this.SrchQteBtn.Location = new System.Drawing.Point(43, 250);
            this.SrchQteBtn.Name = "SrchQteBtn";
            this.SrchQteBtn.Size = new System.Drawing.Size(248, 62);
            this.SrchQteBtn.TabIndex = 2;
            this.SrchQteBtn.Text = "&Search Quotes";
            this.SrchQteBtn.UseVisualStyleBackColor = true;
            this.SrchQteBtn.Click += new System.EventHandler(this.SrchQteBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(42, 345);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(249, 61);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SrchQteBtn);
            this.Controls.Add(this.VwQteBtn);
            this.Controls.Add(this.AddQteBtn);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQteBtn;
        private System.Windows.Forms.Button VwQteBtn;
        private System.Windows.Forms.Button SrchQteBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

