using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct PhoneBook
    {
        #region Attributes
        string[] names;
        long[] numbers;
        int size;

        #endregion

        #region Constructor
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        #endregion

        #region Properties
        public int Size
        {
            //read only Property
            get { return size; }
        }
        #endregion

        #region Methods
        public void AddPerson(uint Position, string? Name, long Number)
        {
            if (names is not null && numbers is not null)
            {
                if (Position < size)
                {
                    names[Position] = Name;
                    numbers[Position] = Number;

                }


            }

        }
        #endregion

        //Getter
        public long GetNumber(string Name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == Name)
                {
                    return numbers[i];
                }
            }
            return -1;
        }

        //Setter
        public void SetNumber(string Name, long NewNumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == Name)
                numbers[i] = NewNumber;
                return;
            }
           
        }
        public string this[int index]
        {
            get { return $"Position : {index} ,  Name : {names[index]}, Number : {numbers[index]}"; }
        }

        //Indexer: is a special property [Named always with keyword "this" and take parameters]

        public long this[string Name ]
        {
            get
            {
                if (names is not null && numbers is not null)
                {

                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == Name)
                        {
                            return numbers[i];
                        }
                    }
                
                }
                return -1;


            }
            set
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                        {
                            if (names[i] == Name)
                                numbers[i] = value;
                            return;
                        }
                }
             


            }
        }
    }
}
