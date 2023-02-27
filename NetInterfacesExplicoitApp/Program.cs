namespace NetInterfacesExplicoitApp
{
    interface ISchool
    {
        void Study();
        void Oge();
    }
    interface IUniversity
    {
        void Study();
        void Diplome();
        protected void Exam();
    }
    class Student : ISchool, IUniversity
    {
        public void Study()
        {
            Console.WriteLine($"Student is study");
        }

        void ISchool.Study() => Console.WriteLine("Student study in school");
        void IUniversity.Study() => Console.WriteLine("Student study in university");

        public void Oge()
        {
            Console.WriteLine($"Student oge");
        }

        public void Diplome()
        {
            Console.WriteLine($"Student diplome");
        }

        public void Exam()
        {
            Console.WriteLine($"Student exam");
        }
    }
    abstract class Shape : IMovable
    {
        public abstract void Move();

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    class Line : Shape
    {
        public override void Move()
        {
            
        }
    }

    class BaseClass : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Base class move");
        }
        public void Stop()
        {
            Console.WriteLine("Base class stop");
        }
    }

    class SecondClass : BaseClass, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Second class move");
        }
        public void Stop()
        {
            Console.WriteLine("Second class stop");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.Study();

            //(student as ISchool).Study();
            //(student as IUniversity).Study();

            //ISchool school = new Student();
            //school.Study();

            //IUniversity university = new Student();
            //university.Study();

            IMovable movable = new SecondClass();
            movable.Move();
            movable.Stop();
        }
    }
}