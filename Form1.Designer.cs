namespace PrimeNumber
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
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_num1
            // 
            this.tb_num1.Location = new System.Drawing.Point(93, 81);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(100, 20);
            this.tb_num1.TabIndex = 0;
            // 
            // tb_num2
            // 
            this.tb_num2.Location = new System.Drawing.Point(93, 127);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(100, 20);
            this.tb_num2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prime numbers between Number1, and Number2";
            // 
            // tb_sum
            // 
            this.tb_sum.Location = new System.Drawing.Point(240, 81);
            this.tb_sum.Multiline = true;
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_sum.Size = new System.Drawing.Size(260, 238);
            this.tb_sum.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 341);
            this.Controls.Add(this.tb_sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.tb_num1);
            this.Name = "Form1";
            this.Text = "Jethro\'s Prime Number Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_sum;
    }
}

