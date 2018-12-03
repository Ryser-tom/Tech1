using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIV2
{
    class databaseLinq
    {
        private DataClassesDataContext DB = new DataClassesDataContext();

        public student[] GetAvaibleStudent()
        {
            var requeteStudentAvaible = from student in DB.student
                                        where student.idSubject == null
                                        select student;
            return requeteStudentAvaible.ToArray();
        }
        public student[] GetNotAvaibleStudent()
        {
            var requeteStudentNotAvaible = from student in DB.student
                                           where student.idSubject != null
                                           select student;
            return requeteStudentNotAvaible.ToArray();
        }
        public subject[] GetAvaibleSubject()
        {
            var requeteSubject = from subject in DB.subject
                                 where !DB.student.Any(student => (subject.IdSubject == student.idSubject))
                                 select subject;
            return requeteSubject.ToArray();
        }
        public teacher[] GetAllTeacher()
        {
            var requeteTeacher = from teacher in DB.teacher
                                 select teacher;
            return requeteTeacher.ToArray();
        }

        public void SetSubjectToStudentAndTeacher(int selectedStudent, int selectedSubject, int selectedTeacher)
        {
            var requete = from student in DB.student
                          where student.IdStudent == selectedStudent
                          select student;

            foreach (var student in requete) {
                student.idSubject = selectedSubject;
                student.idTeacher = selectedTeacher;

                try {
                    DB.SubmitChanges();
                } catch (Exception) {
                    throw;
                }
            }
        }
        public void DeleteSubject(int index)
        {
            var requete = from subject in DB.subject
                          where subject.IdSubject == index
                          select subject;

            foreach (var subject in requete) DB.subject.DeleteOnSubmit(subject);
            try { DB.SubmitChanges(); } catch (Exception) {
                throw;
            }
        }
        public void DeleteStudent(int index)
        {
            var requete = from student in DB.student
                          where student.IdStudent == index
                          select student;


            foreach (var student in requete) DB.student.DeleteOnSubmit(student);
            try { DB.SubmitChanges(); } catch (Exception) {
                throw;
            }
        }
        public void DeleteTeacher(int index)
        {
            var requete = from teacher in DB.teacher
                          where teacher.IdTeacher == index
                          select teacher;

            foreach (var teacher in requete) DB.teacher.DeleteOnSubmit(teacher);
            try { DB.SubmitChanges(); } catch (Exception) {
                throw;
            }
        }
        public IEnumerable<student> GetStudent(int index)
        {
            var requete = from student in DB.student
                          where student.IdStudent == index
                          select student;
            return requete;
        }
        public void UpdateStudent(int index, string name, string firstName, string phone, string mail)
        {
            var requete = from student in DB.student
                          where student.IdStudent == index
                          select student;

            foreach (var student in requete) {
                student.nameStudent = name;
                student.firstNameStudent = firstName;
                student.telStudent = phone;
                student.emailStudent = mail;
                try {
                    DB.SubmitChanges();
                } catch (Exception) {
                    throw;
                }
            }
        }
        public void CreateStudent(int index, string name, string firstName, string phone, string mail)
        {
            student cl = new student();

            cl.IdStudent = index;
            cl.nameStudent = name;
            cl.firstNameStudent = firstName;
            cl.telStudent = phone;
            cl.emailStudent = mail;
            DB.student.InsertOnSubmit(cl);
            try {
                DB.SubmitChanges();
            } catch (Exception) {
                throw;
            }
        }
    }
}
