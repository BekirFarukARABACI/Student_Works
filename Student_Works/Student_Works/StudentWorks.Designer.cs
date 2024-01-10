
namespace Student_Works
{
    partial class StudentWorks
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentWorks));
            this.label1 = new System.Windows.Forms.Label();
            this.StudentAdd = new System.Windows.Forms.Button();
            this.studentUpdate = new System.Windows.Forms.Button();
            this.studentDelete = new System.Windows.Forms.Button();
            this.StudentList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // StudentAdd
            // 
            this.StudentAdd.BackColor = System.Drawing.Color.Lime;
            this.StudentAdd.Location = new System.Drawing.Point(91, 102);
            this.StudentAdd.Name = "StudentAdd";
            this.StudentAdd.Size = new System.Drawing.Size(160, 60);
            this.StudentAdd.TabIndex = 1;
            this.StudentAdd.Text = "Student Add";
            this.StudentAdd.UseVisualStyleBackColor = false;
            this.StudentAdd.Click += new System.EventHandler(this.StudentAdd_Click);
            // 
            // studentUpdate
            // 
            this.studentUpdate.BackColor = System.Drawing.Color.Yellow;
            this.studentUpdate.Location = new System.Drawing.Point(245, 179);
            this.studentUpdate.Name = "studentUpdate";
            this.studentUpdate.Size = new System.Drawing.Size(160, 60);
            this.studentUpdate.TabIndex = 2;
            this.studentUpdate.Text = "Student Update";
            this.studentUpdate.UseVisualStyleBackColor = false;
            this.studentUpdate.Click += new System.EventHandler(this.studentUpdate_Click);
            // 
            // studentDelete
            // 
            this.studentDelete.BackColor = System.Drawing.Color.Red;
            this.studentDelete.Location = new System.Drawing.Point(567, 331);
            this.studentDelete.Name = "studentDelete";
            this.studentDelete.Size = new System.Drawing.Size(160, 60);
            this.studentDelete.TabIndex = 3;
            this.studentDelete.Text = "Student Delete";
            this.studentDelete.UseVisualStyleBackColor = false;
            this.studentDelete.Click += new System.EventHandler(this.studentDelete_Click);
            // 
            // StudentList
            // 
            this.StudentList.BackColor = System.Drawing.Color.Blue;
            this.StudentList.Location = new System.Drawing.Point(407, 255);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(160, 60);
            this.StudentList.TabIndex = 4;
            this.StudentList.Text = "Student List";
            this.StudentList.UseVisualStyleBackColor = false;
            this.StudentList.Click += new System.EventHandler(this.StudentList_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(194, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 56);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student Works Application";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(3, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bekir Faruk ARABACI ";
            // 
            // StudentWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.studentDelete);
            this.Controls.Add(this.studentUpdate);
            this.Controls.Add(this.StudentAdd);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "StudentWorks";
            this.Text = "Student Works";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StudentAdd;
        private System.Windows.Forms.Button studentUpdate;
        private System.Windows.Forms.Button studentDelete;
        private System.Windows.Forms.Button StudentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

