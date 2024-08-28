namespace PatikaWeek7Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Class> classList = new List<Class>()
            {
                new Class() { ClassId=1, ClassName="Matematik"},
                new Class() { ClassId=2, ClassName="Türkçe"},
                new Class() { ClassId=3, ClassName="Kimya"}
            };

            List<Student> studentList = new List<Student>()
            { 
                new Student { StudentId=1, StudentName="Ali",ClassId=1},
                new Student { StudentId=2, StudentName="Ayşe",ClassId=2},
                new Student { StudentId=3, StudentName="Mehmet",ClassId=1},
                new Student { StudentId=4, StudentName="Fatma",ClassId=3},
                new Student { StudentId=5, StudentName="Ahmet",ClassId=2}

            };

            //Groupjoin metodu ile herbir ClassName için grup oluşturuluyor.
            var classGroup=classList.GroupJoin(studentList,clas=>clas.ClassId,student=>student.ClassId,
                                               (clas,studentGroup) => new
                                               {
                                                   ClassName=clas.ClassName,
                                                   StudentGroup=studentGroup
                                               }    
                                               );                                          


            Console.WriteLine("---Sınıf Öğrenci Listesi---------");

            foreach(var group in classGroup)
            {
                Console.WriteLine("\n"+group.ClassName);
                foreach(var student in group.StudentGroup)
                {
                    Console.WriteLine(student.StudentName);
                }
            }
        }
    }
}
