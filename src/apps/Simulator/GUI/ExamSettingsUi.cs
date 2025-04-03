using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shared;
using Shared.Models;

namespace Simulator.GUI
{
    public partial class ExamSettingsUi : Form
    {
        private readonly Exam _exam;
        private Settings _settings;

        public ExamSettingsUi(Exam exam)
        {
            InitializeComponent();

            _exam = exam;

            // Add all sections to the checklist box
            clb_section_options.Items.AddRange(_exam.Sections.ToArray());

            // Limit numeric up/down to total number of questions
            num_questions.Maximum = _exam.NumberOfQuestions;

            // By default, select ALL sections
            SelectAll(null, null);
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomTimer(object sender, EventArgs e)
        {
            // If "Enable Timer" is checked, allow editing num_time_limit
            num_time_limit.Enabled = chk_enable_timer.Checked;
        }

        private void ChooseNumOfQuestions(object sender, EventArgs e)
        {
            // If "Fixed Number" is chosen, allow editing num_questions
            num_questions.Enabled = rdb_fixed_number_questions.Checked;
        }

        private void ChooseSections(object sender, EventArgs e)
        {
            // If "Selected Sections" is chosen, allow checking them
            clb_section_options.Enabled = rdb_selected_sections.Checked;
        }

        private void SelectAll(object sender, EventArgs e)
        {
            for (var i = 0; i < clb_section_options.Items.Count; i++)
            {
                clb_section_options.SetItemChecked(i, true);
            }
        }

        private void DeselectAll(object sender, EventArgs e)
        {
            for (var i = 0; i < clb_section_options.Items.Count; i++)
            {
                clb_section_options.SetItemChecked(i, false);
            }
        }

        private void Proceed(object sender, EventArgs e)
        {
            // Create new settings object
            _settings = new Settings { CandidateName = txt_candidate_name.Text };

            // Timer logic
            if (chk_enable_timer.Checked)
                _settings.TimeLimit = (int)num_time_limit.Value;
            else
                _settings.TimeLimit = _exam.Properties.TimeLimit;

            // Gather questions based on radio buttons
            if (rdb_selected_sections.Checked)
            {
                // 1) Only from selected sections
                _settings.Sections = clb_section_options
                                     .CheckedItems
                                     .Cast<Section>()
                                     .ToList();

                foreach (var section in _settings.Sections)
                    _settings.Questions.AddRange(section.Questions);
            }
            else if (rdb_fixed_number_questions.Checked)
            {
                // 2) Fixed number from the exam, in order
                var numOfQuestions = (int)num_questions.Value;
                var sum = 0;

                foreach (var section in _exam.Sections)
                {
                    if (sum + section.Questions.Count < numOfQuestions)
                    {
                        _settings.Sections.Add(section);
                        _settings.Questions.AddRange(section.Questions);
                        sum += section.Questions.Count;
                    }
                    else if (sum + section.Questions.Count == numOfQuestions)
                    {
                        _settings.Sections.Add(section);
                        _settings.Questions.AddRange(section.Questions);
                        break;
                    }
                    else
                    {
                        var difference = numOfQuestions - sum;
                        _settings.Sections.Add(section);
                        _settings.Questions.AddRange(section.Questions.GetRange(0, difference));
                        break;
                    }
                }
            }
            else
            {
                // 3) If neither radio is chosen, you might default to entire exam
                //    (Up to you: or you can require the user to choose a radio)
                _settings.Sections = _exam.Sections.ToList();
                foreach (var section in _settings.Sections)
                    _settings.Questions.AddRange(section.Questions);
            }

            // *** If "Randomize" is checked, shuffle the final question list
            if (chk_randomize_questions.Checked && _settings.Questions.Count > 0)
            {
                var random = new Random();
                _settings.Questions = _settings.Questions
                                              .OrderBy(q => random.Next())
                                              .ToList();
            }

            // Make sure we have questions
            if (_settings.Questions.Count == 0)
            {
                MessageBox.Show(
                    "There are no questions to display based on your selection. " +
                    "Please try a different selection.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //launch the Assessment
            var ui = new AssessmentUi(_exam, _settings);
            Hide();
            ui.ShowDialog();
            Close();
        }

        private void rdb_randomize_questions_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
