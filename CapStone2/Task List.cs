using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapStone2
{
    class Task_List
    {

        private string name;
        private string discription;
        private DateTime dueDate;
        private bool complete;

        #region properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Discription
        {
            get { return discription; }
            set { discription = value; }
        }
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        

        public bool Complete
        {
            get { return complete; }
            set { complete = value; }
        }



        #endregion

        #region constructors   
        public Task_List()
        {

        }
        public Task_List(string _name, string _discription, DateTime _dueDate, bool _complete = false)
        {
            Name = _name;
            Discription = _discription;
            DueDate = _dueDate;
            Complete = _complete;

        }
        public Task_List(string _name, string _discription)
        {
            Name = _name;
            Discription = _discription;
           
        }

        #endregion



        public static List<string> AddTask()
        {
            
            Console.WriteLine("Give me a person!");
            string _name = Console.ReadLine();
            Console.WriteLine("Give me a discription!");
            string _discription = Console.ReadLine();
          

            List<string> newList = new List<string> { _name, _discription };
            return newList;

            

        }


    }

 }