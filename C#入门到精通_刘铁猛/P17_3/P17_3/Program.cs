using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_3
{
    class Program
    {

        static void Main(string[] args)
        {

            try
            {
                //  Student stu1 = new Student();
                //  stu1.SetAge(20);
                //
                //  Student stu2 = new Student();
                //  stu2.SetAge(20);
                //
                //  Student stu3 = new Student();
                //  stu3.SetAge(200);
                //
                //  int avgAge = (stu1.GetAge() + stu2.GetAge() + stu3.GetAge()) / 3;
                //  Console.WriteLine(avgAge);

                Student stu1 = new Student();
                stu1.Age = 20;

                Console.WriteLine(stu1.CanWork);

                Student stu2 = new Student();
                stu2.Age = 20;

                Student stu3 = new Student();
                stu3.Age = 200;

                int avgAge = (stu1.Age + stu2.Age + stu3.Age) / 3;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            

        }
    }

    //  class Student
    //  {
    //      private int age;
    //      public int GetAge()
    //      {
    //          return this.age;
    //
    //      }
    //
    //      public void SetAge(int value)
    //      {
    //          if (value>=0 && value<=120)
    //          {
    //              this.age = value;
    //          }
    //          else
    //          {
    //              throw new Exception("Age value has error");
    //          }
    //      }
    //  }

    class Student
    {
        private int age;

        public int Age
        {
            //  get
            //  {
            //      return this.age;
            //  }
            //
            //  set
            //  {
            //      if (value >= 0 && value <= 120)
            //      {
            //          this.age = value;
            //      }
            //      else
            //      {
            //          throw new Exception("Age value has error");
            //      }
            //  }
            get { return age;
                
            }
            set { age = value;
                CalcumateCanWork();
            }
        }

      // public bool CanWork
      // {
      //     get
      //     {
      //         if (this.age>=16)
      //         {
      //             return true;
      //
      //         }
      //         else
      //         {
      //             return false;
      //         }
      //     }
      // }

        private bool canWork;
        public bool CanWork
        {
            get { return canWork; }
        }

        private void CalcumateCanWork()
        {
            if (this.age >= 16)
            {
                this.canWork = true;

            }
            else
            {
                this.canWork= false;
            }
        }
    }
}
