using ClassLibrary_Session1_F;
using ConsoleApp1.oop; // to import class from this library

namespace ConsoleApp1
{
    public class Program
    {   
        static void Main(string[] args)
        {
            // Declare for Object from type "struct1"
            // CLR will allocate 8 unintialized bytes at stack
            struct1 s = new struct1(10, 12); //new: here new is just for Constructor selection that
                                             //will initialize the attributes of teh object
            Console.WriteLine("x is: " + s.x);
            Console.WriteLine("y is: " + s.y);
            Console.WriteLine(s.ToString());

            int X = 10;
            Console.WriteLine(X.ToString()); // System.Int32
            Console.WriteLine(s); //same as ToString()


            Employee employee1 = new Employee();
            employee1.Name = "Kulthoom";
            employee1.Id = 1;
            employee1.salary = 10000;
            Console.WriteLine(employee1.ToString());

            Employee employee2 = new Employee(2, "Ali", 30000,23);
            Console.WriteLine(employee2.ToString());

            employee2.Id = 10;


            Months month =  Months.jan;
            Console.WriteLine((int)month); //index of the first value in the enum
            Console.WriteLine(month); //the first value in the enum
                                      //  MyFlags flags = MyFlags.Read | MyFlags.Write;
                                      //  Console.WriteLine(flags);



            Employee[] emps = new Employee[]
            {
                new Employee{Id = 3,Name = "Ahmed", salary=1000},
                new Employee{Id = 4,Name = "Ali", salary=3000},
                new Employee{Id = 5, Name = "Muna", salary=4000},
            };


            employee2.setName("Saba");// using setter
            employee1.getName(); //using getter

            employee1.salary = 1000; //changing the value of the salary directly
            employee1.Salary = 20_000; //set salary using property
            Console.WriteLine(employee1.Salary); //get salary using getter

            //INDEXERS
            // working with two arryes at the same time (in one package)
            PhoneBook phoneBook = new PhoneBook(3);
            phoneBook.AddPerson(0, "Ahmed", 123);
            phoneBook.AddPerson(1, "Muna", 456);
            phoneBook.AddPerson(2, "Omar", 789);
            phoneBook.SetPersonNumber("Ahmed", 6666);
            Console.WriteLine(phoneBook.GetPersonNumber("Omar"));
            phoneBook["Ahmed"] = 999;
            Console.WriteLine(phoneBook.GetPersonNumber("Ahmed"));

            for (int i = 0; i< phoneBook.Size; i++)
            {
                Console.WriteLine(phoneBook[i]);
            }
            /////////////////////////////////////////////////////////////
            /// Class car
            /// 
            Car C1; //Declare for reference from type "Car"
            // Can refer to an object from type "Car" or an object from another class that is inherting from Car
            // CLR will alocate 4 bytes for the reference C1 at STACK
            // CLR will allocate 0 bytes at HEAP

            // ⇒ if you write user-defined constructor, the compiler will no longer generate empty paramterless constructor
            C1 = new Car(1, "Camery", 240);  //it is the default (empty) constructor
            // new 
            // 1, allocate required number of bytes at HEAP
            // 2. initialize [croos out the allocated bytes] at HEAP with the default value of attributes data types
            // 3. call user-defined constructor [if exit]
            // 4. assign the reference "C1" to the allocated object at HEAP
           
            Console.Write(C1);

            ////////////////////////////////////////
            ///inheritience
             Child child1 = new Child(1,2,3);
             Console.Write(child1);



                
        }
        enum Months
        {
            jan,
            feb,
            mar,
            april,
            may,
            june,
            july,
            aug,
            sep,
            oct,
            nov,
            dec
        }
        // enums
        /* [Flags]
        public enum MyFlags
        {
            None = 0, // 0b_0000_0000 -> 0
            Read = 1, // 0b_0000_0001 -> 1
            Write = 2, // 0b_0000_0010 -> 2
            Delete = 4, // 0b_0000_0100 -> 4
            Execute = 8, //0b_0000_1000 -> 8
        }
        */

    }
}
