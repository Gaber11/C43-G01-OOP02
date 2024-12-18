using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
		#region Attributes
		private int id =default;
		private string? model=default;
		private double speed = default  ;
        #endregion


        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string? Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        #endregion

        #region Constructor OverLoading
        public Car(int _id, string? _model, double _speed)
        {
            id = _id;
            model = _model;
            speed = _speed;
        }
        public Car(int _id, string? _model) : this(_id, _model, 180)

        {

            //    id= _id;    
            //model = _model;
            //speed = 180;
        }

        public Car(int _id)
        {
            id = _id;
            model = "Kia";
            speed = 170;
        }


        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id: {this.id} \nSpeed: {this.speed}\nModel: {this.model}";

        }

        #endregion



    }
}
