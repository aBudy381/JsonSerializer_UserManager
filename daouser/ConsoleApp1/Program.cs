using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using projettp3console.dao;
using projettp3console.model;
using projettp3console.business;

namespace ConsoleApp1
{
    class Program
    {


       
    static void Main(string[] args)
    {
            daouser u = new daouser(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\logfile.log");
            usermanager userm = new usermanager(u);
            userm.Load();
            var sortedlist=userm.SortByName();
            foreach (user selecteduser in sortedlist)
            {
                Console.WriteLine(" prenom: "+ selecteduser.Surname.ToString()+" nom: "+selecteduser.Name.ToString() + "age "+ selecteduser.Age.ToString()+"\n");
            }
            Console.WriteLine("filtered list");
            var filteredlist = userm.FilterByName("walid");
            foreach (user selecteduser in filteredlist)
            {
                Console.WriteLine(" prenom: " + selecteduser.Surname.ToString() + " nom: " + selecteduser.Name.ToString() + "age " + selecteduser.Age.ToString() + "\n");
            }
            string x = Console.ReadLine() ;


        }
    }
}
