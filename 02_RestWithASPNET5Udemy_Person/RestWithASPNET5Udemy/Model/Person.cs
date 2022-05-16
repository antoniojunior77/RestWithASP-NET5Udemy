using System;
namespace RestWithASPNET5Udemy.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Addres { get; set; }
        public string Gender { get; set; }
        public Person()
        {
        }
    }
}
