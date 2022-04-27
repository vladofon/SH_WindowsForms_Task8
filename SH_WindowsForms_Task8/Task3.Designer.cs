namespace SH_WindowsForms_Task8
{
    partial class Task3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 16;
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(219, 64);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(75, 25);
            this.btnWork.TabIndex = 15;
            this.btnWork.Text = "Work";
            this.btnWork.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(11, 64);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 25);
            this.btnRun.TabIndex = 14;
            this.btnRun.Text = "Sum";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(216, 24);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(44, 13);
            this.lblB.TabIndex = 13;
            this.lblB.Text = "Value B";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(8, 24);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(44, 13);
            this.lblA.TabIndex = 12;
            this.lblA.Text = "Value A";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 20);
            this.textBox2.TabIndex = 18;
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Task3";
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox textBox2;
    }
}