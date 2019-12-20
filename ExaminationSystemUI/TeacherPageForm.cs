﻿using ExaminationSystemLibrary;
using ExaminationSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystemUI
{
    public partial class TeacherPageForm : Form
    {
        public TeacherPageForm()
        {
            InitializeComponent();

            
        }

        
        private bool ValidateTeacherAddQuestion()
        {
            bool output = true;

            //exam name validation
            if (examNameTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }
            //access code validation
            if (accessCodeTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }
            int accessCode = 0;
            bool accessCodeIsValid = int.TryParse(accessCodeTextBox.Text, out accessCode);

            if (accessCodeIsValid == false)
            {
                //error message
                output = false;
            }
            //question name validation
            if (questionNameTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }

            //answer a validation
            if (answerATextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }

            //answer b validation
            if (answerBTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }

            //answer c validation
            if (answerCTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }

            //answer d validation
            if (answerDTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }

            //correct answer validation
            if (correctAnswerTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }
            //correct answer validation
            if (correctAnswerTextBox.Text.Length > 1)
            {
                //error message
                output = false;
            }
            return output;
        }

        List<QuestionModel> addedQuestion = new List<QuestionModel>(); // lista potrzebna do listboxa przycisk add exam -> addedQustion.Clear();
        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            
            if (ValidateTeacherAddQuestion() == true)
            {

                QuestionModel model = new QuestionModel(
                     examNameTextBox.Text,
                     questionNameTextBox.Text,
                     1,
                     answerATextBox.Text,
                     answerBTextBox.Text,
                     answerCTextBox.Text,
                     answerDTextBox.Text,
                     correctAnswerTextBox.Text) ;

                addedQuestion.Add(model);
                model.QuestionNumber = addedQuestion.IndexOf(model) + 1;

                createdQuestionListBox.DataSource = null;
                createdQuestionListBox.DataSource = addedQuestion;
                createdQuestionListBox.DisplayMember = "FullName";
                

                questionNameTextBox.Text = "";
                answerATextBox.Text = "";
                answerBTextBox.Text = "";
                answerCTextBox.Text = "";
                answerDTextBox.Text = "";
                correctAnswerTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid information. Try again.");
            }

        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            QuestionModel model = (QuestionModel)createdQuestionListBox.SelectedItem;

            if (model != null)
            {
                addedQuestion.Remove(model);
                foreach (QuestionModel item in addedQuestion)
                {
                    item.QuestionNumber = addedQuestion.IndexOf(item) + 1;

                }

                createdQuestionListBox.DataSource = null;
                createdQuestionListBox.DataSource = addedQuestion;
                createdQuestionListBox.DisplayMember = "FullName"; 
            }
        }





        private bool ValidateTeacherAddExam()
        {
            bool output = true;

            //exam name validation
            if (examNameTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }
            //access code validation
            if (accessCodeTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }
            int accessCode = 0;
            bool accessCodeIsValid = int.TryParse(accessCodeTextBox.Text, out accessCode);

            if (accessCodeIsValid == false)
            {
                //error message
                output = false;
            }
            //question name validation
            if (questionNameTextBox.Text.Length != 0)
            {
                //error message
                output = false;
            }

            //answer a validation
            if (answerATextBox.Text.Length != 0)
            {
                //error message
                output = false;
            }

            //answer b validation
            if (answerBTextBox.Text.Length != 0)
            {
                //error message
                output = false;
            }

            //answer c validation
            if (answerCTextBox.Text.Length != 0)
            {
                //error message
                output = false;
            }

            //answer d validation
            if (answerDTextBox.Text.Length != 0)
            {
                //error message
                output = false;
            }

            //correct answer validation
            if (correctAnswerTextBox.Text.Length != 0)
            {
                //error message
                output = false;
            }
            
            return output;
        }

        private void createExamButton_Click(object sender, EventArgs e)
        {
            if (ValidateTeacherAddExam() == true)
            {
                foreach (QuestionModel item in addedQuestion)
                {
                    GlobalConfig.Connection.CreateQuestion(item);

                }
                ExamModel model = new ExamModel();
                model.AccessCode = int.Parse(accessCodeTextBox.Text);
                model.Creator = teacherNameLabel.Text;
                model.Name = examNameTextBox.Text;
                model.QuestionAmount = addedQuestion.Count();

                GlobalConfig.Connection.CreateExam(model);

                addedQuestion.Clear();

                accessCodeTextBox.Text = "";
                examNameTextBox.Text = "";
                createdQuestionListBox.DataSource = null;
                createdQuestionListBox.DataSource = addedQuestion;

            }
        }

        //pobieranie z baz danych do combo box jest w filmiku lesson 13 minuta 14
    }
}
