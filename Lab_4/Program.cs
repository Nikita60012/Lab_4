using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student bob = new Student("Bob", 15, 4, 5, 3, 5, 4);//4.2
            Student ben = new Student("Ben", 16, 3, 4, 4, 4, 4);//3.8
            Student sam = new Student("Sam", 15, 5, 3, 2, 3, 4);//3.4
            Student tom = new Student("Tom", 16, 4, 3, 3, 3, 3);//3.2
            Student van = new Student("Van", 15, 4, 5, 5, 5, 4);//4.6
            Student billy = new Student("Billy", 17, 3, 3, 3, 3, 3);//3
            Student izya = new Student("Izya", 18, 5, 5, 5, 5, 5);//5
            Student[] pupils = new Student[] { bob, ben, sam, tom, van, billy, izya };
            double[] marks = new double[7];
            for(int j = 0; j < 7; j++)
            {
                Student student = pupils[j];
                double mark = 0;
                for (int i = 0; i < 5; i++) {
                    mark += student.academic_performance[i];
                }
                mark /= 5.0;
                 marks[j] = mark;
            }
            
            for (int i = 0; i < 7; i++)
            {
                double correctMark = marks[i];
                Student correctStudent = pupils[i];
                int j = i - 1;

                while(j >= 0)
                {
                    if (marks[j] > correctMark){
                        marks[j + 1] = marks[j];
                        marks[j] = correctMark;
                        pupils[j + 1] = pupils[j];
                        pupils[j] = correctStudent;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
               
            }
            Console.WriteLine("Отсортированные оценки и ученики");
            foreach(double i in marks)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (Student pup in pupils)
            {
                Console.WriteLine(pup.fio);

            }
        }
    }
    struct Student
    {
        public string fio;
        public int id;
        public int[] academic_performance;
        public Student(string fio = "null", int id = 0, params int[] academic_performance)
        {
            this.fio = fio;
            this.id = id;
            this.academic_performance = academic_performance;
        }
    }
}
