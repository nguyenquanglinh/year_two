namespace TestMay
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
            this.btn1 = new System.Windows.Forms.Button();
            this.txtCauNoi = new System.Windows.Forms.TextBox();
            this.lbCauNoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(157, 126);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Nói";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtCauNoi
            // 
            this.txtCauNoi.Location = new System.Drawing.Point(115, 68);
            this.txtCauNoi.Name = "txtCauNoi";
            this.txtCauNoi.Size = new System.Drawing.Size(117, 20);
            this.txtCauNoi.TabIndex = 1;
            // 
            // lbCauNoi
            // 
            this.lbCauNoi.Location = new System.Drawing.Point(28, 68);
            this.lbCauNoi.Name = "lbCauNoi";
            this.lbCauNoi.Size = new System.Drawing.Size(46, 20);
            this.lbCauNoi.TabIndex = 2;
            this.lbCauNoi.Text = "Câu nói";
            this.lbCauNoi.UseMnemonic = false;
            this.lbCauNoi.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbCauNoi);
            this.Controls.Add(this.txtCauNoi);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtCauNoi;
        private System.Windows.Forms.Label lbCauNoi;
    }
}

