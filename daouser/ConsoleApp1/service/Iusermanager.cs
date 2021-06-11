using System;
using System.Collections.Generic;
using System.Text;
using projettp3console.model;
using projettp3console.dao;
namespace projettp3console.service
{
    interface Iusermanager
    {
         void Load();
        void Save();
        List<user> FilterByName(string name);
        List<user> SortByName();


    }
}
