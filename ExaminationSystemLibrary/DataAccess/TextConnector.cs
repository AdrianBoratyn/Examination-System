﻿using ExaminationSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystemLibrary.DataAccess.TextHelpers;

namespace ExaminationSystemLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string STUDENTS_ACCOUNT_FILE = "StudentAccount.csv";
        private const string TEACHERS_ACCOUNT_FILE = "TeacherAccount.csv";
        private const string ADMINS_ACCOUNT_FILE = "AdminAccount.csv";
        private const string QUESTIONS_LIST_FILE = "QuestionsList.csv";
        private const string EXAMS_LIST_FILE = "ExamsList.csv";

        public bool CreateStudentAccount(StudentModel model)
        {
            //extension method
            //load the text file and convert the text to List<StudentModel>
            List<StudentModel> models = STUDENTS_ACCOUNT_FILE.FullFilePath().LoadFile().ConvertToStudentModels();
            //add new record 
            models.Add(model);
            //save the List<string> to the text file (overwritten text file)
            models.SaveToStudentFile(STUDENTS_ACCOUNT_FILE);
            return true;
        }

        public bool StudentLogin(string userName, string password)
        {
            return true;
        }
        public bool EditStudentAccount(StudentModel model, string oldUserName)
        {
            return true;
        }

        public bool CreateTeacherAccount(TeacherModel model)
        {
            //extension method
            //load the text file and convert the text to List<TeacherModel>
            List<TeacherModel> models = TEACHERS_ACCOUNT_FILE.FullFilePath().LoadFile().ConvertToTeacherModels();
            //add new record 
            models.Add(model);
            //save the List<string> to the text file (overwritten text file)
            models.SaveToTeacherFile(TEACHERS_ACCOUNT_FILE);
            return true;
        }

        public bool TeacherLogin(string userName, string password)
        {
            return true;
        }
        public bool EditTeacherAccount(TeacherModel model, string oldUserName)
        {
            return true;
        }

        public bool CreateAdminAccount(AdminModel model)
        {
            //extension method
            //load the text file and convert the text to List<AdminModel>
            List<AdminModel> models = ADMINS_ACCOUNT_FILE.FullFilePath().LoadFile().ConvertToAdminModels();
            //add new record 
            models.Add(model);
            //save the List<string> to the text file (overwritten text file)
            models.SaveToAdminFile(ADMINS_ACCOUNT_FILE);
            return true;
        }

        public bool AdminLogin(string userName, string password)
        {
            return true;
        }
        public bool EditAdminAccount(AdminModel model, string oldUserName)
        {
            return true;
        }

        public void CreateQuestion(QuestionModel model)
        {
            //extension method
            //load the text file and convert the text to List<QuestionModel>
            List<QuestionModel> models = QUESTIONS_LIST_FILE.FullFilePath().LoadFile().ConvertToQuestionModels();
            //add new record 
            models.Add(model);
            //save the List<string> to the text file (overwritten text file)
            models.SaveToQuestionFile(QUESTIONS_LIST_FILE);
        }

        public void CreateExam(ExamModel model)
        {
            //extension method
            //load the text file and convert the text to List<ExamModel>
            List<ExamModel> models = EXAMS_LIST_FILE.FullFilePath().LoadFile().ConvertToExamModels();
            //add new record 
            models.Add(model);
            //save the List<string> to the text file (overwritten text file)
            models.SaveToExamFile(EXAMS_LIST_FILE);
        }

        public List<ExamModel> GetExams()
        {
            List<ExamModel> output = new List<ExamModel>();
            return output;
        }

        public List<QuestionModel> GetQuestions()
        {
            List<QuestionModel> output;
            return output = new List<QuestionModel>();
        }

        public void UpdateExam(ExamModel model1, ExamModel model2)
        {
        }
        public void UpdateQuestion(QuestionModel model1, ExamModel model2)
        {
        }
        public void CreateResult(ResultModel model)
        {
        }
        public List<ResultModel> GetResults()
        {
            List<ResultModel> output = new List<ResultModel>();
            return output;
        }
        public List<ResultModel> GetStudentCourses()
        {
            List<ResultModel> output = new List<ResultModel>();
            return output;
        }
    }
}
 