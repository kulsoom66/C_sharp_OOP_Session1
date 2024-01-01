using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal struct PhoneBook
    {

        string[] names;
        long[] numbers;
        int size;

        public int Size
        {
            get { return size; }
        }

        public PhoneBook(int _size)
        {
            this.size = _size;  
            names = new string[size];
            numbers = new long[size];
        }

        public void AddPerson(int Position, string Name, long Number)
        {
            if(Position>=0 && Position < size)
            {
                names[Position] = Name;
                numbers[Position] = Number;
            }

        }

        //Getter
        public long GetPersonNumber(string Name)
        {
            for (int i = 0; i< names.Length; i++)
            {
                if (Name == names[i])
                {
                    return numbers[i];
                }
            }
            return -1; //not found
        }

        //Setter
        public void SetPersonNumber(string Name, long NewNum)
        {
            if (names is not null){ //handling null problem
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i])
                    {
                        numbers[i] = NewNum;
                        break;
                    }
                }
            }
        }

        // indexer
        public long this[string Name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i])
                    {
                        return numbers[i];
                    }
                }
                return -1; //not found
            }
            set
            {
                if (names is not null)
                { //handling null problem
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                        {
                            numbers[i] = value;
                            break;
                        }
                    }
                }
            }
        }

        // indexer to get the index

        public string this[int index]
        {
            get { return $"{index} :: {names[index]} :: {numbers[index]}"; } 
        }

    }
}