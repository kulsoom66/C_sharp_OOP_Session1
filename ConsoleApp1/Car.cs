using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Car
    {
		//attributes
        private int id;
        private string name;
        private double speed;

       //Properties
        public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public double Speed
		{
			get { return speed; }
			set { speed = value; }
		}

        //override the toString
        public override string ToString()
        {
            return $"Car id: {id} \n Car Name: {name} \nCar Speed: {speed}";		
        }

        public Car(int _id, string _model, double _speed)
        {  
            id= _id;
            name= _model;
            speed= _speed;
        } // do nothing


        //Constructor chain
        public Car(int _id, string _model):this(_id, _model, 190)
        {
        }


    }
}
