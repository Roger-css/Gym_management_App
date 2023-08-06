using System;
using System.Data;


namespace GymBussniesLayer
{
    public class Person
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set;}
        public string Photo { get; set;}

        protected Person(int id , string name, string phone , string photo)
        {
            this.ID = id;
            this.Name = name;
            this.Phone = phone;
            this.Photo = photo;
        } 

    }
}
