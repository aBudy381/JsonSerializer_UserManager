using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using projettp3console.model;
using projettp3console.service;
namespace projettp3console.business
{
    public class usermanager:Iusermanager
    {


        private List<user> users = new List<user>();

        public List<user> Users { get => users; set => users = value; }
        public Idaouser Idao { get => idao; set => idao = value; }

        private Idaouser idao;
        public usermanager(Idaouser idao)
        {
            this.Idao = idao;
        }
        public void Load()
        {
            users= Idao.LoadList();
        }
        public void Save()
        {
            Idao.SaveList(this.users);
        }
        public List<user> FilterByName(string name)
        {

            var filtered = users.Where(
                 (x) => x.Surname == name).ToList();
           
            return filtered;
        }
        public List<user> SortByName()
        {
            return users.OrderBy(p => p.Surname).ToList();
        }
    }
}
