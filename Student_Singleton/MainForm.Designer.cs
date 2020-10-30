namespace Student_Singleton
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadStudent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAutoLoad = new System.Windows.Forms.CheckBox();
            this.checkBoxLastLoad = new System.Windows.Forms.CheckBox();
            this.textBoxMajor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMajor = new System.Windows.Forms.ListBox();
            this.buttonAddMajor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStudentGender1 = new System.Windows.Forms.ComboBox();
            this.textBoxStudentName1 = new System.Windows.Forms.TextBox();
            this.textBoxStudentNum1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSaveStudent1 = new System.Windows.Forms.Button();
            this.buttonDeleteStudent1 = new System.Windows.Forms.Button();
            this.textBoxStudentNum2 = new System.Windows.Forms.TextBox();
            this.textBoxStudentName2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonStudentDelete2 = new System.Windows.Forms.Button();
            this.buttonStudentSave2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxStudentGender2 = new System.Windows.Forms.ComboBox();
            this.textBoxStudentNum3 = new System.Windows.Forms.TextBox();
            this.textBoxStudentName3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonStudentDelete3 = new System.Windows.Forms.Button();
            this.buttonStudentSave3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxStudentGender3 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadStudent
            // 
            this.buttonLoadStudent.Location = new System.Drawing.Point(36, 33);
            this.buttonLoadStudent.Name = "buttonLoadStudent";
            this.buttonLoadStudent.Size = new System.Drawing.Size(159, 43);
            this.buttonLoadStudent.TabIndex = 0;
            this.buttonLoadStudent.Text = "학생정보 불러오기";
            this.buttonLoadStudent.UseVisualStyleBackColor = true;
            this.buttonLoadStudent.Click += new System.EventHandler(this.buttonLoadStudent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAutoLoad);
            this.groupBox1.Controls.Add(this.checkBoxLastLoad);
            this.groupBox1.Location = new System.Drawing.Point(206, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "설정";
            // 
            // checkBoxAutoLoad
            // 
            this.checkBoxAutoLoad.AutoSize = true;
            this.checkBoxAutoLoad.Location = new System.Drawing.Point(11, 29);
            this.checkBoxAutoLoad.Name = "checkBoxAutoLoad";
            this.checkBoxAutoLoad.Size = new System.Drawing.Size(244, 16);
            this.checkBoxAutoLoad.TabIndex = 2;
            this.checkBoxAutoLoad.Text = "프로그램 시작시 자동으로 학생정보 로드";
            this.checkBoxAutoLoad.UseVisualStyleBackColor = true;
            this.checkBoxAutoLoad.CheckedChanged += new System.EventHandler(this.checkBoxAutoLoad_CheckedChanged);
            // 
            // checkBoxLastLoad
            // 
            this.checkBoxLastLoad.AutoSize = true;
            this.checkBoxLastLoad.Location = new System.Drawing.Point(261, 29);
            this.checkBoxLastLoad.Name = "checkBoxLastLoad";
            this.checkBoxLastLoad.Size = new System.Drawing.Size(276, 16);
            this.checkBoxLastLoad.TabIndex = 3;
            this.checkBoxLastLoad.Text = "프로그램 시작시 최근 사용 전공 정보부터 출력";
            this.checkBoxLastLoad.UseVisualStyleBackColor = true;
            this.checkBoxLastLoad.CheckedChanged += new System.EventHandler(this.checkBoxLastLoad_CheckedChanged);
            // 
            // textBoxMajor
            // 
            this.textBoxMajor.Location = new System.Drawing.Point(36, 257);
            this.textBoxMajor.Name = "textBoxMajor";
            this.textBoxMajor.Size = new System.Drawing.Size(122, 21);
            this.textBoxMajor.TabIndex = 4;
            this.textBoxMajor.Text = "신규전공입력하세요";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "전공리스트";
            // 
            // listBoxMajor
            // 
            this.listBoxMajor.FormattingEnabled = true;
            this.listBoxMajor.ItemHeight = 12;
            this.listBoxMajor.Location = new System.Drawing.Point(36, 158);
            this.listBoxMajor.Name = "listBoxMajor";
            this.listBoxMajor.Size = new System.Drawing.Size(122, 88);
            this.listBoxMajor.TabIndex = 6;
            // 
            // buttonAddMajor
            // 
            this.buttonAddMajor.Location = new System.Drawing.Point(36, 284);
            this.buttonAddMajor.Name = "buttonAddMajor";
            this.buttonAddMajor.Size = new System.Drawing.Size(122, 23);
            this.buttonAddMajor.TabIndex = 7;
            this.buttonAddMajor.Text = "전공추가";
            this.buttonAddMajor.UseVisualStyleBackColor = true;
            this.buttonAddMajor.Click += new System.EventHandler(this.buttonAddMajor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "학번";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "성별";
            // 
            // comboBoxStudentGender1
            // 
            this.comboBoxStudentGender1.FormattingEnabled = true;
            this.comboBoxStudentGender1.Items.AddRange(new object[] {
            "여자",
            "남자"});
            this.comboBoxStudentGender1.Location = new System.Drawing.Point(48, 82);
            this.comboBoxStudentGender1.Name = "comboBoxStudentGender1";
            this.comboBoxStudentGender1.Size = new System.Drawing.Size(84, 20);
            this.comboBoxStudentGender1.TabIndex = 9;
            // 
            // textBoxStudentName1
            // 
            this.textBoxStudentName1.Location = new System.Drawing.Point(239, 167);
            this.textBoxStudentName1.Name = "textBoxStudentName1";
            this.textBoxStudentName1.Size = new System.Drawing.Size(84, 21);
            this.textBoxStudentName1.TabIndex = 10;
            // 
            // textBoxStudentNum1
            // 
            this.textBoxStudentNum1.Location = new System.Drawing.Point(239, 192);
            this.textBoxStudentNum1.Name = "textBoxStudentNum1";
            this.textBoxStudentNum1.Size = new System.Drawing.Size(84, 21);
            this.textBoxStudentNum1.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxStudentGender1);
            this.groupBox2.Location = new System.Drawing.Point(191, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 135);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "학생1";
            // 
            // buttonSaveStudent1
            // 
            this.buttonSaveStudent1.Location = new System.Drawing.Point(191, 287);
            this.buttonSaveStudent1.Name = "buttonSaveStudent1";
            this.buttonSaveStudent1.Size = new System.Drawing.Size(67, 23);
            this.buttonSaveStudent1.TabIndex = 7;
            this.buttonSaveStudent1.Text = "저장";
            this.buttonSaveStudent1.UseVisualStyleBackColor = true;
            this.buttonSaveStudent1.Click += new System.EventHandler(this.buttonSaveStudent1_Click);
            // 
            // buttonDeleteStudent1
            // 
            this.buttonDeleteStudent1.Location = new System.Drawing.Point(264, 287);
            this.buttonDeleteStudent1.Name = "buttonDeleteStudent1";
            this.buttonDeleteStudent1.Size = new System.Drawing.Size(74, 23);
            this.buttonDeleteStudent1.TabIndex = 7;
            this.buttonDeleteStudent1.Text = "삭제";
            this.buttonDeleteStudent1.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent1.Click += new System.EventHandler(this.buttonDeleteStudent1_Click);
            // 
            // textBoxStudentNum2
            // 
            this.textBoxStudentNum2.Location = new System.Drawing.Point(416, 192);
            this.textBoxStudentNum2.Name = "textBoxStudentNum2";
            this.textBoxStudentNum2.Size = new System.Drawing.Size(84, 21);
            this.textBoxStudentNum2.TabIndex = 19;
            // 
            // textBoxStudentName2
            // 
            this.textBoxStudentName2.Location = new System.Drawing.Point(416, 167);
            this.textBoxStudentName2.Name = "textBoxStudentName2";
            this.textBoxStudentName2.Size = new System.Drawing.Size(84, 21);
            this.textBoxStudentName2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "성별";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "학번";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "이름";
            // 
            // buttonStudentDelete2
            // 
            this.buttonStudentDelete2.Location = new System.Drawing.Point(441, 287);
            this.buttonStudentDelete2.Name = "buttonStudentDelete2";
            this.buttonStudentDelete2.Size = new System.Drawing.Size(74, 23);
            this.buttonStudentDelete2.TabIndex = 13;
            this.buttonStudentDelete2.Text = "삭제";
            this.buttonStudentDelete2.UseVisualStyleBackColor = true;
            this.buttonStudentDelete2.Click += new System.EventHandler(this.buttonStudentDelete2_Click);
            // 
            // buttonStudentSave2
            // 
            this.buttonStudentSave2.Location = new System.Drawing.Point(368, 287);
            this.buttonStudentSave2.Name = "buttonStudentSave2";
            this.buttonStudentSave2.Size = new System.Drawing.Size(67, 23);
            this.buttonStudentSave2.TabIndex = 14;
            this.buttonStudentSave2.Text = "저장";
            this.buttonStudentSave2.UseVisualStyleBackColor = true;
            this.buttonStudentSave2.Click += new System.EventHandler(this.buttonStudentSave2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxStudentGender2);
            this.groupBox3.Location = new System.Drawing.Point(368, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 135);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "학생2";
            // 
            // comboBoxStudentGender2
            // 
            this.comboBoxStudentGender2.FormattingEnabled = true;
            this.comboBoxStudentGender2.Items.AddRange(new object[] {
            "여자",
            "남자"});
            this.comboBoxStudentGender2.Location = new System.Drawing.Point(48, 82);
            this.comboBoxStudentGender2.Name = "comboBoxStudentGender2";
            this.comboBoxStudentGender2.Size = new System.Drawing.Size(84, 20);
            this.comboBoxStudentGender2.TabIndex = 9;
            // 
            // textBoxStudentNum3
            // 
            this.textBoxStudentNum3.Location = new System.Drawing.Point(595, 192);
            this.textBoxStudentNum3.Name = "textBoxStudentNum3";
            this.textBoxStudentNum3.Size = new System.Drawing.Size(84, 21);
            this.textBoxStudentNum3.TabIndex = 19;
            // 
            // textBoxStudentName3
            // 
            this.textBoxStudentName3.Location = new System.Drawing.Point(595, 167);
            this.textBoxStudentName3.Name = "textBoxStudentName3";
            this.textBoxStudentName3.Size = new System.Drawing.Size(84, 21);
            this.textBoxStudentName3.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "성별";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(560, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "학번";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "이름";
            // 
            // buttonStudentDelete3
            // 
            this.buttonStudentDelete3.Location = new System.Drawing.Point(620, 287);
            this.buttonStudentDelete3.Name = "buttonStudentDelete3";
            this.buttonStudentDelete3.Size = new System.Drawing.Size(74, 23);
            this.buttonStudentDelete3.TabIndex = 13;
            this.buttonStudentDelete3.Text = "삭제";
            this.buttonStudentDelete3.UseVisualStyleBackColor = true;
            this.buttonStudentDelete3.Click += new System.EventHandler(this.buttonStudentDelete3_Click);
            // 
            // buttonStudentSave3
            // 
            this.buttonStudentSave3.Location = new System.Drawing.Point(547, 287);
            this.buttonStudentSave3.Name = "buttonStudentSave3";
            this.buttonStudentSave3.Size = new System.Drawing.Size(67, 23);
            this.buttonStudentSave3.TabIndex = 14;
            this.buttonStudentSave3.Text = "저장";
            this.buttonStudentSave3.UseVisualStyleBackColor = true;
            this.buttonStudentSave3.Click += new System.EventHandler(this.buttonStudentSave3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxStudentGender3);
            this.groupBox4.Location = new System.Drawing.Point(547, 137);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 135);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "학생3";
            // 
            // comboBoxStudentGender3
            // 
            this.comboBoxStudentGender3.FormattingEnabled = true;
            this.comboBoxStudentGender3.Items.AddRange(new object[] {
            "여자",
            "남자"});
            this.comboBoxStudentGender3.Location = new System.Drawing.Point(48, 82);
            this.comboBoxStudentGender3.Name = "comboBoxStudentGender3";
            this.comboBoxStudentGender3.Size = new System.Drawing.Size(84, 20);
            this.comboBoxStudentGender3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 383);
            this.Controls.Add(this.textBoxStudentNum3);
            this.Controls.Add(this.textBoxStudentNum2);
            this.Controls.Add(this.textBoxStudentName3);
            this.Controls.Add(this.textBoxStudentName2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonStudentDelete3);
            this.Controls.Add(this.buttonStudentDelete2);
            this.Controls.Add(this.buttonStudentSave3);
            this.Controls.Add(this.buttonStudentSave2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBoxStudentNum1);
            this.Controls.Add(this.textBoxStudentName1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDeleteStudent1);
            this.Controls.Add(this.buttonSaveStudent1);
            this.Controls.Add(this.buttonAddMajor);
            this.Controls.Add(this.listBoxMajor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMajor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLoadStudent);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "테이터베이스프로그래밍 실습3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxAutoLoad;
        private System.Windows.Forms.CheckBox checkBoxLastLoad;
        private System.Windows.Forms.TextBox textBoxMajor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMajor;
        private System.Windows.Forms.Button buttonAddMajor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStudentGender1;
        private System.Windows.Forms.TextBox textBoxStudentName1;
        private System.Windows.Forms.TextBox textBoxStudentNum1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSaveStudent1;
        private System.Windows.Forms.Button buttonDeleteStudent1;
        private System.Windows.Forms.TextBox textBoxStudentNum2;
        private System.Windows.Forms.TextBox textBoxStudentName2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonStudentDelete2;
        private System.Windows.Forms.Button buttonStudentSave2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxStudentGender2;
        private System.Windows.Forms.TextBox textBoxStudentNum3;
        private System.Windows.Forms.TextBox textBoxStudentName3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonStudentDelete3;
        private System.Windows.Forms.Button buttonStudentSave3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxStudentGender3;
    }
}

