using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace projettp3console.model
{
    public class user
    {
        private string name;  private string surname;private  int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }

        public user(string n, string u, int a)
        { this.Name = n; this.Surname = u; this.Age = a; }

        public user()
        {
        }

      
    }
}
