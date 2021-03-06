﻿using ExaminationSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.DataAccess
{
    public interface IDataConnection
    {
        bool CreateStudentAccount(StudentModel model);
        bool StudentLogin(string userName, string password);
        bool EditStudentAccount(StudentModel model, string oldUserName);
        bool CreateTeacherAccount(TeacherModel model);
        bool TeacherLogin(string userName, string password);
        bool EditTeacherAccount(TeacherModel model, string oldUserName);
        bool CreateAdminAccount(AdminModel model);
        bool AdminLogin(string userName, string password);
        bool EditAdminAccount(AdminModel model, string oldUserName);
        void CreateQuestion(QuestionModel model);
        void CreateExam(ExamModel model);
        List<ExamModel> GetExams();
        List<QuestionModel> GetQuestions();
        void UpdateExam(ExamModel model1, ExamModel model2);
        void UpdateQuestion(QuestionModel model1, ExamModel model2);
        void CreateResult(ResultModel model);
        List<ResultModel> GetResults();
        List<ResultModel> GetStudentCourses();
    }
}
