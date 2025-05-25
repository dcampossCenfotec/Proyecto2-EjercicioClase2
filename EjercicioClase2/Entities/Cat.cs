using System;

namespace EjercicioClase2.Entities
{
    public class Cat : Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Birth { get; set; }


        public Cat() { }    
    }
}
