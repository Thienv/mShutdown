namespace mShutdown
{
    partial class Form1
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
            this.panelContain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lableCurrentTime = new System.Windows.Forms.Label();
            this.btn_Shutdown = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radRestart = new System.Windows.Forms.RadioButton();
            this.radShutdown = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudHMinute = new System.Windows.Forms.NumericUpDown();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.nudPhut = new System.Windows.Forms.NumericUpDown();
            this.radSince = new System.Windows.Forms.RadioButton();
            this.radAfter = new System.Windows.Forms.RadioButton();
            this.panelContain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhut)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContain
            // 
            this.panelContain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContain.Controls.Add(this.panel3);
            this.panelContain.Controls.Add(this.panel2);
            this.panelContain.Location = new System.Drawing.Point(156, 62);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(477, 301);
            this.panelContain.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lableCurrentTime);
            this.panel3.Controls.Add(this.btn_Shutdown);
            this.panel3.Location = new System.Drawing.Point(19, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 70);
            this.panel3.TabIndex = 1;
            // 
            // lableCurrentTime
            // 
            this.lableCurrentTime.AutoSize = true;
            this.lableCurrentTime.Location = new System.Drawing.Point(26, 43);
            this.lableCurrentTime.Name = "lableCurrentTime";
            this.lableCurrentTime.Size = new System.Drawing.Size(0, 13);
            this.lableCurrentTime.TabIndex = 1;
            // 
            // btn_Shutdown
            // 
            this.btn_Shutdown.Location = new System.Drawing.Point(301, 13);
            this.btn_Shutdown.Name = "btn_Shutdown";
            this.btn_Shutdown.Size = new System.Drawing.Size(75, 44);
            this.btn_Shutdown.TabIndex = 0;
            this.btn_Shutdown.Text = "Start";
            this.btn_Shutdown.UseVisualStyleBackColor = true;
            this.btn_Shutdown.Click += new System.EventHandler(this.btn_Shutdown_Click);
            this.btn_Shutdown.MouseLeave += new System.EventHandler(this.btn_Shutdown_MouseLeave);
            this.btn_Shutdown.MouseHover += new System.EventHandler(this.btn_Shutdown_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(19, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 200);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.radRestart);
            this.panel6.Controls.Add(this.radShutdown);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(25, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(385, 50);
            this.panel6.TabIndex = 2;
            // 
            // radRestart
            // 
            this.radRestart.AutoSize = true;
            this.radRestart.Location = new System.Drawing.Point(191, 17);
            this.radRestart.Name = "radRestart";
            this.radRestart.Size = new System.Drawing.Size(59, 17);
            this.radRestart.TabIndex = 2;
            this.radRestart.TabStop = true;
            this.radRestart.Text = "Restart";
            this.radRestart.UseVisualStyleBackColor = true;
            this.radRestart.CheckedChanged += new System.EventHandler(this.radRestart_CheckedChanged);
            // 
            // radShutdown
            // 
            this.radShutdown.AutoSize = true;
            this.radShutdown.Location = new System.Drawing.Point(99, 17);
            this.radShutdown.Name = "radShutdown";
            this.radShutdown.Size = new System.Drawing.Size(76, 17);
            this.radShutdown.TabIndex = 1;
            this.radShutdown.TabStop = true;
            this.radShutdown.Text = "Shut down";
            this.radShutdown.UseVisualStyleBackColor = true;
            this.radShutdown.CheckedChanged += new System.EventHandler(this.radShutdown_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Option:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.nudHMinute);
            this.panel4.Controls.Add(this.nudHour);
            this.panel4.Controls.Add(this.nudPhut);
            this.panel4.Controls.Add(this.radSince);
            this.panel4.Controls.Add(this.radAfter);
            this.panel4.Location = new System.Drawing.Point(25, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(385, 114);
            this.panel4.TabIndex = 0;
            // 
            // nudHMinute
            // 
            this.nudHMinute.Location = new System.Drawing.Point(235, 66);
            this.nudHMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudHMinute.Name = "nudHMinute";
            this.nudHMinute.Size = new System.Drawing.Size(51, 20);
            this.nudHMinute.TabIndex = 6;
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(178, 66);
            this.nudHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(51, 20);
            this.nudHour.TabIndex = 5;
            // 
            // nudPhut
            // 
            this.nudPhut.Location = new System.Drawing.Point(178, 12);
            this.nudPhut.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudPhut.Name = "nudPhut";
            this.nudPhut.Size = new System.Drawing.Size(51, 20);
            this.nudPhut.TabIndex = 4;
            // 
            // radSince
            // 
            this.radSince.AutoSize = true;
            this.radSince.Location = new System.Drawing.Point(8, 69);
            this.radSince.Name = "radSince";
            this.radSince.Size = new System.Drawing.Size(144, 17);
            this.radSince.TabIndex = 3;
            this.radSince.TabStop = true;
            this.radSince.Text = "Shut down Or Restart lúc";
            this.radSince.UseVisualStyleBackColor = true;
            // 
            // radAfter
            // 
            this.radAfter.AutoSize = true;
            this.radAfter.Location = new System.Drawing.Point(3, 12);
            this.radAfter.Name = "radAfter";
            this.radAfter.Size = new System.Drawing.Size(147, 17);
            this.radAfter.TabIndex = 2;
            this.radAfter.TabStop = true;
            this.radAfter.Text = "Shut down Or Restart sau";
            this.radAfter.UseVisualStyleBackColor = true;
            this.radAfter.CheckedChanged += new System.EventHandler(this.radAfter_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContain);
            this.Name = "Form1";
            this.Text = "mShutdown";
            this.panelContain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radRestart;
        private System.Windows.Forms.RadioButton radShutdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radSince;
        private System.Windows.Forms.RadioButton radAfter;
        private System.Windows.Forms.Button btn_Shutdown;
        private System.Windows.Forms.NumericUpDown nudHMinute;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.NumericUpDown nudPhut;
        private System.Windows.Forms.Label lableCurrentTime;
    }
}

