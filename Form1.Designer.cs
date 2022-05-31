
namespace DistanceTravelled
{
    partial class DistanceTravelled
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enter_txtbox = new System.Windows.Forms.TextBox();
            this.result_txtbox = new System.Windows.Forms.TextBox();
            this.eight_btn = new System.Windows.Forms.Button();
            this.twelve_btn = new System.Windows.Forms.Button();
            this.five_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Car Speed (mph):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance in:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result (miles):";
            // 
            // enter_txtbox
            // 
            this.enter_txtbox.Location = new System.Drawing.Point(182, 36);
            this.enter_txtbox.Name = "enter_txtbox";
            this.enter_txtbox.Size = new System.Drawing.Size(100, 20);
            this.enter_txtbox.TabIndex = 3;
            // 
            // result_txtbox
            // 
            this.result_txtbox.Location = new System.Drawing.Point(182, 228);
            this.result_txtbox.Name = "result_txtbox";
            this.result_txtbox.Size = new System.Drawing.Size(100, 20);
            this.result_txtbox.TabIndex = 4;
            // 
            // eight_btn
            // 
            this.eight_btn.Location = new System.Drawing.Point(182, 131);
            this.eight_btn.Name = "eight_btn";
            this.eight_btn.Size = new System.Drawing.Size(100, 23);
            this.eight_btn.TabIndex = 5;
            this.eight_btn.Text = "8 hours";
            this.eight_btn.UseVisualStyleBackColor = true;
            this.eight_btn.Click += new System.EventHandler(this.eight_btn_Click);
            // 
            // twelve_btn
            // 
            this.twelve_btn.Location = new System.Drawing.Point(182, 160);
            this.twelve_btn.Name = "twelve_btn";
            this.twelve_btn.Size = new System.Drawing.Size(100, 23);
            this.twelve_btn.TabIndex = 6;
            this.twelve_btn.Text = "12 hours";
            this.twelve_btn.UseVisualStyleBackColor = true;
            this.twelve_btn.Click += new System.EventHandler(this.twelve_btn_Click);
            // 
            // five_btn
            // 
            this.five_btn.Location = new System.Drawing.Point(182, 102);
            this.five_btn.Name = "five_btn";
            this.five_btn.Size = new System.Drawing.Size(100, 23);
            this.five_btn.TabIndex = 7;
            this.five_btn.Text = "5 hours";
            this.five_btn.UseVisualStyleBackColor = true;
            this.five_btn.Click += new System.EventHandler(this.five_btn_Click);
            // 
            // DistanceTravelled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(321, 292);
            this.Controls.Add(this.five_btn);
            this.Controls.Add(this.twelve_btn);
            this.Controls.Add(this.eight_btn);
            this.Controls.Add(this.result_txtbox);
            this.Controls.Add(this.enter_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DistanceTravelled";
            this.Text = "Distance Travelled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enter_txtbox;
        private System.Windows.Forms.TextBox result_txtbox;
        private System.Windows.Forms.Button eight_btn;
        private System.Windows.Forms.Button twelve_btn;
        private System.Windows.Forms.Button five_btn;
    }
}

