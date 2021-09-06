
namespace nnelson1e2
{
    partial class frmAverageTestGrades
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
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Test 1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(112, 45);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(47, 22);
            this.txtTest1.TabIndex = 0;
            this.txtTest1.Text = "0";
            this.txtTest1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(112, 182);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(47, 22);
            this.txtAverage.TabIndex = 6;
            this.txtAverage.Text = "0";
            this.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Average:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTest3
            // 
            this.txtTest3.Location = new System.Drawing.Point(112, 116);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(47, 22);
            this.txtTest3.TabIndex = 2;
            this.txtTest3.Text = "0";
            this.txtTest3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Test 3:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(112, 82);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(47, 22);
            this.txtTest2.TabIndex = 1;
            this.txtTest2.Text = "0";
            this.txtTest2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Test 2:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(202, 44);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(81, 30);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "&Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(202, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 28);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(202, 114);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAverageTestGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 243);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.label1);
            this.Name = "frmAverageTestGrades";
            this.Text = "nnelson1e2 Average Test Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

