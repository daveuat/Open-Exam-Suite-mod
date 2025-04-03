namespace Simulator.GUI
{
    partial class ExamSettingsUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamSettingsUi));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_candidate_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_randomize_questions = new System.Windows.Forms.CheckBox();
            this.clb_section_options = new System.Windows.Forms.CheckedListBox();
            this.num_questions = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_deselect_all = new System.Windows.Forms.Button();
            this.btn_select_all = new System.Windows.Forms.Button();
            this.rdb_fixed_number_questions = new System.Windows.Forms.RadioButton();
            this.rdb_selected_sections = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_time_limit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_enable_timer = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_questions)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_time_limit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Candidate Name:";
            // 
            // txt_candidate_name
            // 
            this.txt_candidate_name.Location = new System.Drawing.Point(144, 12);
            this.txt_candidate_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_candidate_name.Name = "txt_candidate_name";
            this.txt_candidate_name.Size = new System.Drawing.Size(289, 22);
            this.txt_candidate_name.TabIndex = 1;
            this.txt_candidate_name.Text = "Candidate Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_randomize_questions);
            this.groupBox1.Controls.Add(this.clb_section_options);
            this.groupBox1.Controls.Add(this.num_questions);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_deselect_all);
            this.groupBox1.Controls.Add(this.btn_select_all);
            this.groupBox1.Controls.Add(this.rdb_fixed_number_questions);
            this.groupBox1.Controls.Add(this.rdb_selected_sections);
            this.groupBox1.Location = new System.Drawing.Point(17, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(687, 370);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exam";
            // 
            // chk_randomize_questions
            // 
            this.chk_randomize_questions.AutoSize = true;
            this.chk_randomize_questions.Location = new System.Drawing.Point(28, 296);
            this.chk_randomize_questions.Margin = new System.Windows.Forms.Padding(4);
            this.chk_randomize_questions.Name = "chk_randomize_questions";
            this.chk_randomize_questions.Size = new System.Drawing.Size(253, 21);
            this.chk_randomize_questions.TabIndex = 4;
            this.chk_randomize_questions.Text = "Randomize question display order?";
            this.chk_randomize_questions.UseVisualStyleBackColor = true;
            this.chk_randomize_questions.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // clb_section_options
            // 
            this.clb_section_options.BackColor = System.Drawing.SystemColors.Control;
            this.clb_section_options.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clb_section_options.CheckOnClick = true;
            this.clb_section_options.FormattingEnabled = true;
            this.clb_section_options.Location = new System.Drawing.Point(51, 63);
            this.clb_section_options.Margin = new System.Windows.Forms.Padding(4);
            this.clb_section_options.Name = "clb_section_options";
            this.clb_section_options.Size = new System.Drawing.Size(602, 189);
            this.clb_section_options.TabIndex = 7;
            // 
            // num_questions
            // 
            this.num_questions.Enabled = false;
            this.num_questions.Location = new System.Drawing.Point(99, 326);
            this.num_questions.Margin = new System.Windows.Forms.Padding(4);
            this.num_questions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_questions.Name = "num_questions";
            this.num_questions.Size = new System.Drawing.Size(71, 22);
            this.num_questions.TabIndex = 6;
            this.num_questions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_questions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "questions from entire exam file";
            // 
            // btn_deselect_all
            // 
            this.btn_deselect_all.Location = new System.Drawing.Point(160, 260);
            this.btn_deselect_all.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deselect_all.Name = "btn_deselect_all";
            this.btn_deselect_all.Size = new System.Drawing.Size(100, 28);
            this.btn_deselect_all.TabIndex = 4;
            this.btn_deselect_all.Text = "Deselect All";
            this.btn_deselect_all.UseVisualStyleBackColor = true;
            this.btn_deselect_all.Click += new System.EventHandler(this.DeselectAll);
            // 
            // btn_select_all
            // 
            this.btn_select_all.Location = new System.Drawing.Point(52, 260);
            this.btn_select_all.Margin = new System.Windows.Forms.Padding(4);
            this.btn_select_all.Name = "btn_select_all";
            this.btn_select_all.Size = new System.Drawing.Size(100, 28);
            this.btn_select_all.TabIndex = 3;
            this.btn_select_all.Text = "Select All";
            this.btn_select_all.UseVisualStyleBackColor = true;
            this.btn_select_all.Click += new System.EventHandler(this.SelectAll);
            // 
            // rdb_fixed_number_questions
            // 
            this.rdb_fixed_number_questions.AutoSize = true;
            this.rdb_fixed_number_questions.Location = new System.Drawing.Point(28, 329);
            this.rdb_fixed_number_questions.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_fixed_number_questions.Name = "rdb_fixed_number_questions";
            this.rdb_fixed_number_questions.Size = new System.Drawing.Size(61, 21);
            this.rdb_fixed_number_questions.TabIndex = 1;
            this.rdb_fixed_number_questions.Text = "Take";
            this.rdb_fixed_number_questions.UseVisualStyleBackColor = true;
            this.rdb_fixed_number_questions.CheckedChanged += new System.EventHandler(this.ChooseNumOfQuestions);
            // 
            // rdb_selected_sections
            // 
            this.rdb_selected_sections.AutoSize = true;
            this.rdb_selected_sections.Checked = true;
            this.rdb_selected_sections.Location = new System.Drawing.Point(28, 34);
            this.rdb_selected_sections.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_selected_sections.Name = "rdb_selected_sections";
            this.rdb_selected_sections.Size = new System.Drawing.Size(305, 21);
            this.rdb_selected_sections.TabIndex = 0;
            this.rdb_selected_sections.TabStop = true;
            this.rdb_selected_sections.Text = "Take questions from selected sections only:";
            this.rdb_selected_sections.UseVisualStyleBackColor = true;
            this.rdb_selected_sections.CheckedChanged += new System.EventHandler(this.ChooseSections);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_time_limit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chk_enable_timer);
            this.groupBox2.Location = new System.Drawing.Point(17, 431);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(687, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timer";
            // 
            // num_time_limit
            // 
            this.num_time_limit.Enabled = false;
            this.num_time_limit.Location = new System.Drawing.Point(307, 21);
            this.num_time_limit.Margin = new System.Windows.Forms.Padding(4);
            this.num_time_limit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_time_limit.Name = "num_time_limit";
            this.num_time_limit.Size = new System.Drawing.Size(71, 22);
            this.num_time_limit.TabIndex = 3;
            this.num_time_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_time_limit.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "minute(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time limit";
            // 
            // chk_enable_timer
            // 
            this.chk_enable_timer.AutoSize = true;
            this.chk_enable_timer.Location = new System.Drawing.Point(23, 25);
            this.chk_enable_timer.Margin = new System.Windows.Forms.Padding(4);
            this.chk_enable_timer.Name = "chk_enable_timer";
            this.chk_enable_timer.Size = new System.Drawing.Size(154, 21);
            this.chk_enable_timer.TabIndex = 0;
            this.chk_enable_timer.Text = "Set exam time limit?";
            this.chk_enable_timer.UseVisualStyleBackColor = true;
            this.chk_enable_timer.CheckedChanged += new System.EventHandler(this.CustomTimer);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(495, 507);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 28);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Proceed);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(604, 507);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Close);
            // 
            // ExamSettingsUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 553);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_candidate_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExamSettingsUi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_questions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_time_limit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_candidate_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_deselect_all;
        private System.Windows.Forms.Button btn_select_all;
        private System.Windows.Forms.RadioButton rdb_fixed_number_questions;
        private System.Windows.Forms.RadioButton rdb_selected_sections;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_enable_timer;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_questions;
        private System.Windows.Forms.NumericUpDown num_time_limit;
        private System.Windows.Forms.CheckedListBox clb_section_options;
        private System.Windows.Forms.CheckBox chk_randomize_questions;
    }
}