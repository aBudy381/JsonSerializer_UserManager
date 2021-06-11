using System;
using System.Collections.Generic;
using System.Text;
using projettp3console.model;
namespace projettp3console.service
{
    public interface Idaouser
    {
         void SaveList(List<user> users);
        List<user> LoadList();

    }
}
