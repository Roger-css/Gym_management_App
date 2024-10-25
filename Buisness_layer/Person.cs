using System.ComponentModel.DataAnnotations;
namespace GymBussniesLayer
{
    public class Person
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(14)]
        public string Phone { get; set; }
        public string Photo { get; set; }

        protected Person(int id, string name, string phone, string photo)
        {
            this.ID = id;
            this.Name = name;
            this.Phone = phone;
            this.Photo = photo;
        }

    }
}
