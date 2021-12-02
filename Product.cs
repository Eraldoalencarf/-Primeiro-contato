﻿
namespace Cap6
{
    internal class Product
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Product(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
