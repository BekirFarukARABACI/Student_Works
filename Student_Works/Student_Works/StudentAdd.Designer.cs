
namespace Student_Works
{
    partial class StudentAdd
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
            this.SaveStudent = new System.Windows.Forms.Button();
            this.nameArea = new System.Windows.Forms.TextBox();
            this.surnameArea = new System.Windows.Forms.TextBox();
            this.schoolNumberArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student School Number";
            // 
            // SaveStudent
            // 
            this.SaveStudent.Location = new System.Drawing.Point(566, 231);
            this.SaveStudent.Name = "SaveStudent";
            this.SaveStudent.Size = new System.Drawing.Size(136, 51);
            this.SaveStudent.TabIndex = 4;
            this.SaveStudent.Text = "Save Student";
            this.SaveStudent.UseVisualStyleBackColor = true;
            this.SaveStudent.Click += new System.EventHandler(this.SaveStudent_Click);
            // 
            // nameArea
            // 
            this.nameArea.Location = new System.Drawing.Point(362, 202);
            this.nameArea.Name = "nameArea";
            this.nameArea.Size = new System.Drawing.Size(100, 22);
            this.nameArea.TabIndex = 1;
            // 
            // surnameArea
            // 
            this.surnameArea.Location = new System.Drawing.Point(362, 245);
            this.surnameArea.Name = "surnameArea";
            this.surnameArea.Size = new System.Drawing.Size(100, 22);
            this.surnameArea.TabIndex = 2;
            // 
            // schoolNumberArea
            // 
            this.schoolNumberArea.Location = new System.Drawing.Point(362, 285);
            this.schoolNumberArea.Name = "schoolNumberArea";
            this.schoolNumberArea.Size = new System.Drawing.Size(100, 22);
            this.schoolNumberArea.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(260, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 42);
            this.label6.TabIndex = 12;
            this.label6.Text = "Student Add";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(184, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(433, 56);
            this.label5.TabIndex = 11;
            this.label5.Text = "Student Works Application";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(713, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 13;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(12, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bekir Faruk ARABACI ";
            // 
            // StudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.schoolNumberArea);
            this.Controls.Add(this.surnameArea);
            this.Controls.Add(this.nameArea);
            this.Controls.Add(this.SaveStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentAdd";
            this.Text = "StudentAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveStudent;
        private System.Windows.Forms.TextBox nameArea;
        private System.Windows.Forms.TextBox surnameArea;
        private System.Windows.Forms.TextBox schoolNumberArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label7;
    }
}