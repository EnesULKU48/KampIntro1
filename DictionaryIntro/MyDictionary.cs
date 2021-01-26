using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DictionaryIntro
{
    class MyDictionary<T1, T2>
    {
        T1[] students;
        T2[] studentNumbers;
        
 

        public MyDictionary()
        {
            students = new T1[0];
            studentNumbers = new T2[0];
        }

        public void Add(T1 items, T2 items2)
        {
            T1[] tempStudents = students;
            T2[] tempStudentNumbers = studentNumbers;

            students = new T1[students.Length + 1];
            studentNumbers = new T2[studentNumbers.Length + 1];

            for (int i = 0; i < tempStudents.Length; i++)
            {
                students[i] = tempStudents[i];
            }

            for (int i = 0; i < tempStudentNumbers.Length; i++)
            {
                studentNumbers[i] = tempStudentNumbers[i];
            }

            students[students.Length - 1] = items;
            studentNumbers[studentNumbers.Length - 1] = items2;
        }


        public T1[] student1
        {
            get { return students; }
        }

        public  T2[] studentNumber1
        {
            get { return studentNumbers; }
        }

        public int CountS
        {
            get { return students.Length; }
        }

        public int CountN
        {
            get { return studentNumbers.Length; }
        }

    }
}

