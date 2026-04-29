using System;
using StudentNamespace;
using TeacherNamespace;

    namespace StudentNamespace {
        public class Student {
            private string studentID;
            private string studentFirstName;
            private string studentLastName;
            
            public Student() {
                this.studentID = "___";
                this.studentFirstName = "___";
                this.studentLastName = "___";
            }

            public Student(string Tid) {
                this.studentID = Tid;
                this.studentFirstName = "___";
                this.studentLastName = "___";
            }

            public Student(string studID, string studFname, string studLname) {
                this.studentID = studID;
                this.studentFirstName = studFname;
                this.studentLastName = studLname;
            }

            public void displayInfo() {
                Console.WriteLine(" ");
                Console.WriteLine($"Student name: {this.studentFirstName} {this.studentLastName}");
                Console.WriteLine($"Student ID: {this.studentID}");
            }
        }
    }

    namespace TeacherNamespace {
        public class Teacher {
            private string teacherID;
            private string teacherFirstName;
            private string teacherLastName;

            public Teacher() {
                this.teacherID = "___";
                this.teacherFirstName = "___";
                this.teacherLastName = "___";
            }

            public Teacher(string Tid) {
                this.teacherID = Tid;
                this.teacherFirstName = "___";
                this.teacherLastName = "___";
            }   
            
            public Teacher(string Tid, string Tfirstname, string Tlastname) {
                this.teacherID = Tid;
                this.teacherFirstName = Tfirstname;
                this.teacherLastName = Tlastname;
            }

            public void displayInfo() {
                Console.WriteLine(" ");
                Console.WriteLine($"Teacher name: {this.teacherFirstName} {this.teacherLastName}");
                Console.WriteLine($"Teacher ID: {this.teacherID}");
            }
        }
    }

    public class Display {
            static void Main(string[] args) {
                Student s1 = new Student();
                s1.displayInfo();
                Teacher t1 = new Teacher();
                t1.displayInfo();

                Student s2 = new Student("02000395273");
                s2.displayInfo();
                Teacher t2 = new Teacher("02000395269");
                t2.displayInfo();

                Student s3 = new Student("02000395273", "Lebron", "Kalimot");
                s3.displayInfo();
                Teacher t3 = new Teacher("02000395269", "Kai", "Sotto");
                t3.displayInfo();
            }
    }
