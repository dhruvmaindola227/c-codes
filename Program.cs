using System;


     class Program
    {
        String? firstName;
        String? lastName;
        String? age;
        int salary;

        void display(){
                Console.WriteLine(this.firstName + " " + this.lastName + " " + this.age + " " + this.salary);
        }

        Program(){

        }

        Program(Program pro){
            firstName = pro.firstName;
            lastName = pro.lastName;
            age = pro.age;
            salary = pro.salary;
        }

        static void Main(string[] args)
        {
            Program pr = new Program();
            Program pr1 = new Program(pr);
            pr1.display();
        }
    }

