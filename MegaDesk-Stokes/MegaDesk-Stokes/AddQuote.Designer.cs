namespace MegaDesk_Stokes
{
    partial class AddQuote
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.drawerLabel = new System.Windows.Forms.Label();
            this.dwrDropBx = new System.Windows.Forms.ComboBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.mtrlCmboBox = new System.Windows.Forms.ComboBox();
            this.rushLabel = new System.Windows.Forms.Label();
            this.rushCmboBox = new System.Windows.Forms.ComboBox();
            this.submitOrderBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(46, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(322, 32);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Please enter your name:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(50, 95);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(328, 38);
            this.nameInput.TabIndex = 1;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(44, 151);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(377, 32);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Please enter the desk width: ";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(50, 196);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(328, 38);
            this.widthInput.TabIndex = 3;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(46, 260);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(375, 32);
            this.depthLabel.TabIndex = 4;
            this.depthLabel.Text = "Please enter the desk depth:";
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(52, 317);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(326, 38);
            this.depthInput.TabIndex = 5;
            // 
            // drawerLabel
            // 
            this.drawerLabel.AutoSize = true;
            this.drawerLabel.Location = new System.Drawing.Point(46, 378);
            this.drawerLabel.Name = "drawerLabel";
            this.drawerLabel.Size = new System.Drawing.Size(450, 32);
            this.drawerLabel.TabIndex = 6;
            this.drawerLabel.Text = "Please choose number of drawers:";
            // 
            // dwrDropBx
            // 
            this.dwrDropBx.AllowDrop = true;
            this.dwrDropBx.FormattingEnabled = true;
            this.dwrDropBx.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.dwrDropBx.Location = new System.Drawing.Point(52, 432);
            this.dwrDropBx.Name = "dwrDropBx";
            this.dwrDropBx.Size = new System.Drawing.Size(329, 39);
            this.dwrDropBx.TabIndex = 7;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(46, 495);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(465, 32);
            this.materialLabel.TabIndex = 8;
            this.materialLabel.Text = "Please choose the surface material:";
            // 
            // mtrlCmboBox
            // 
            this.mtrlCmboBox.AllowDrop = true;
            this.mtrlCmboBox.FormattingEnabled = true;
            this.mtrlCmboBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.mtrlCmboBox.Location = new System.Drawing.Point(50, 550);
            this.mtrlCmboBox.Name = "mtrlCmboBox";
            this.mtrlCmboBox.Size = new System.Drawing.Size(339, 39);
            this.mtrlCmboBox.TabIndex = 9;
            // 
            // rushLabel
            // 
            this.rushLabel.AutoSize = true;
            this.rushLabel.Location = new System.Drawing.Point(46, 606);
            this.rushLabel.Name = "rushLabel";
            this.rushLabel.Size = new System.Drawing.Size(175, 32);
            this.rushLabel.TabIndex = 10;
            this.rushLabel.Text = "Rush Order?";
            // 
            // rushCmboBox
            // 
            this.rushCmboBox.AllowDrop = true;
            this.rushCmboBox.FormattingEnabled = true;
            this.rushCmboBox.Items.AddRange(new object[] {
            "3 Day",
            "5 Day",
            "7 Day",
            "14 Day (Standard)"});
            this.rushCmboBox.Location = new System.Drawing.Point(50, 663);
            this.rushCmboBox.Name = "rushCmboBox";
            this.rushCmboBox.Size = new System.Drawing.Size(322, 39);
            this.rushCmboBox.TabIndex = 11;
            // 
            // submitOrderBtn
            // 
            this.submitOrderBtn.Location = new System.Drawing.Point(249, 739);
            this.submitOrderBtn.Name = "submitOrderBtn";
            this.submitOrderBtn.Size = new System.Drawing.Size(247, 65);
            this.submitOrderBtn.TabIndex = 12;
            this.submitOrderBtn.Text = "&Submit Order";
            this.submitOrderBtn.UseVisualStyleBackColor = true;
            this.submitOrderBtn.Click += new System.EventHandler(this.submitOrderBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnBtn.Location = new System.Drawing.Point(208, 835);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(343, 64);
            this.returnBtn.TabIndex = 13;
            this.returnBtn.Text = "&Return To Main";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.returnBtn;
            this.ClientSize = new System.Drawing.Size(800, 1112);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.submitOrderBtn);
            this.Controls.Add(this.rushCmboBox);
            this.Controls.Add(this.rushLabel);
            this.Controls.Add(this.mtrlCmboBox);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.dwrDropBx);
            this.Controls.Add(this.drawerLabel);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddQuote";
            this.ShowInTaskbar = false;
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.Label drawerLabel;
        private System.Windows.Forms.ComboBox dwrDropBx;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.ComboBox mtrlCmboBox;
        private System.Windows.Forms.Label rushLabel;
        private System.Windows.Forms.ComboBox rushCmboBox;
        private System.Windows.Forms.Button submitOrderBtn;
        private System.Windows.Forms.Button returnBtn;
    }
}