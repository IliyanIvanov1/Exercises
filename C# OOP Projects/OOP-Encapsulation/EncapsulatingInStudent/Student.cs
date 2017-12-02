using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulatingInStudent
{
    public class Student
    {
        private string userName;
        private Dictionary<string, Course> enrolledCourses;
        private Dictionary<string, double> marksByCourseName;

        public Student(string userName) 
        {
            this.UserName = userName;
            this.enrolledCourses = new Dictionary<string, Course>();
            this.marksByCourseName = new Dictionary<string, double>();
        }

        public string UserName
        {
            get
            {
                return this.userName;
            }
            private set
            {
                if (value == null || value.Length < 3)
                {
                    throw new ArgumentException($"{nameof(UserName)} cannot be empty or less than 3 symbols!");
                }
                this.userName = value;
            }
        }
        public IReadOnlyDictionary<string, Course> EnrolledCourses => enrolledCourses; 

        public IReadOnlyDictionary<string, decimal> MarksByCourseName
        {
            get
            {
                return marksByCourseName;
            }
        }

        
    }
}