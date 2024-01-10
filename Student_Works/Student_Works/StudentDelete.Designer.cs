
namespace Student_Works
{
    partial class StudentDelete
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
            this.schoolNumberArea = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student number you want to delete";
            // 
            // schoolNumberArea
            // 
            this.schoolNumberArea.Location = new System.Drawing.Point(427, 183);
            this.schoolNumberArea.Name = "schoolNumberArea";
            this.schoolNumberArea.Size = new System.Drawing.Size(100, 22);
            this.schoolNumberArea.TabIndex = 1;
            this.schoolNumberArea.TextChanged += new System.EventHandler(this.schoolNumberArea_TextChanged);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(335, 275);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(147, 48);
            this.delete.TabIndex = 2;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 3;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(713, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(245, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 42);
            this.label6.TabIndex = 12;
            this.label6.Text = "Student Delete";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(169, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(433, 56);
            this.label5.TabIndex = 11;
            this.label5.Text = "Student Works Application";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(12, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bekir Faruk ARABACI ";
            // 
            // StudentDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.schoolNumberArea);
            this.Controls.Add(this.label1);
            this.Name = "StudentDelete";
            this.Text = "StudentDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox schoolNumberArea;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}