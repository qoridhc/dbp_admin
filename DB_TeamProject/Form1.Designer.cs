﻿
namespace DB_TeamProject
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teamBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addDepartmentBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addDepartmentPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.customInstaller2 = new MySql.Data.MySqlClient.CustomInstaller();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.addDepartmentPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(26, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(672, 332);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.teamBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.departmentBox);
            this.groupBox1.Location = new System.Drawing.Point(739, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "부서 조회";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "팀명";
            // 
            // teamBox
            // 
            this.teamBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamBox.FormattingEnabled = true;
            this.teamBox.Location = new System.Drawing.Point(82, 80);
            this.teamBox.Name = "teamBox";
            this.teamBox.Size = new System.Drawing.Size(95, 23);
            this.teamBox.TabIndex = 7;
            this.teamBox.SelectedIndexChanged += new System.EventHandler(this.teamBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "부서명";
            // 
            // departmentBox
            // 
            this.departmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Items.AddRange(new object[] {
            "인사부서",
            "개발부서"});
            this.departmentBox.Location = new System.Drawing.Point(82, 38);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(95, 23);
            this.departmentBox.TabIndex = 5;
            this.departmentBox.SelectedIndexChanged += new System.EventHandler(this.departmentBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 25);
            this.textBox1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addDepartmentBtn);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(739, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 151);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "관리자 기능";
            // 
            // addDepartmentBtn
            // 
            this.addDepartmentBtn.Location = new System.Drawing.Point(22, 28);
            this.addDepartmentBtn.Name = "addDepartmentBtn";
            this.addDepartmentBtn.Size = new System.Drawing.Size(150, 27);
            this.addDepartmentBtn.TabIndex = 9;
            this.addDepartmentBtn.Text = "부서추가";
            this.addDepartmentBtn.UseVisualStyleBackColor = true;
            this.addDepartmentBtn.Click += new System.EventHandler(this.addDepartmentBtnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "변경사항 저장";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(739, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 126);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "검색";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "부서명",
            "팀명",
            "로그인시간",
            "로그아웃시간"});
            this.comboBox1.Location = new System.Drawing.Point(22, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "검색 키워드";
            // 
            // addDepartmentPanel
            // 
            this.addDepartmentPanel.Controls.Add(this.button4);
            this.addDepartmentPanel.Controls.Add(this.button3);
            this.addDepartmentPanel.Controls.Add(this.textBox3);
            this.addDepartmentPanel.Controls.Add(this.label5);
            this.addDepartmentPanel.Controls.Add(this.textBox2);
            this.addDepartmentPanel.Controls.Add(this.label4);
            this.addDepartmentPanel.Location = new System.Drawing.Point(326, 160);
            this.addDepartmentPanel.Name = "addDepartmentPanel";
            this.addDepartmentPanel.Size = new System.Drawing.Size(274, 250);
            this.addDepartmentPanel.TabIndex = 12;
            this.addDepartmentPanel.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(227, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 24);
            this.button4.TabIndex = 5;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "추가";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(54, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 25);
            this.textBox3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "추가할 팀명";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 25);
            this.textBox2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "추가할 부서명";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Location = new System.Drawing.Point(26, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(595, 73);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "기간별 조회";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(485, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 25);
            this.button5.TabIndex = 13;
            this.button5.Text = "조회";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(16, 26);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "~";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1006, 510);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.addDepartmentPanel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.addDepartmentPanel.ResumeLayout(false);
            this.addDepartmentPanel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox teamBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addDepartmentBtn;
        private System.Windows.Forms.Panel addDepartmentPanel;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
    }
}

