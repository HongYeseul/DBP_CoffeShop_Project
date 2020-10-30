using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Singleton
{
    class StudentInfo
    {
        public string name;
        public string num;
        public string gender;
        public string major;

        public StudentInfo() { }
        public StudentInfo(string name, string num, string gender, string major)
        {
            this.name = name;
            this.num = num;
            this.gender = gender;
            this.major = major;
        }
        public string StudentSave()
        {
            string query;

            query = "INSERT INTO student (name, studentID, gender, major) VALUES ('"+name+"', '"+num+"', '"+gender+"', '"+major+"')";
            Console.WriteLine(query);
            return query;
        }

        public string StudentDelete(int id)
        {
            string query;

            query = "DELETE from student where id = " + id;

            return query;
        }
    }
}
