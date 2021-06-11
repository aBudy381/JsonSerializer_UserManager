using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using projettp3console.model;
using projettp3console.service;
namespace projettp3console.dao
{
    public class daouser:Idaouser
    {
        private string path;

        public string Path { get => path; set => path = value; }

        public daouser(string path)
        {
            this.path = path;
        }

        public void SaveList(List<user> users)
        {
            byte[] jsonUtf8bytes = JsonSerializer.SerializeToUtf8Bytes(users, new JsonSerializerOptions { WriteIndented = true });
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                fs.Write(jsonUtf8bytes);
                fs.Close();
            }
        }
        public List<user> LoadList()
        {
            byte[] jsonUtf8bytes;
            using (FileStream fs = new FileStream(path, FileMode.Open))

            {
                jsonUtf8bytes = new byte[fs.Length];
                fs.Read(jsonUtf8bytes, 0, (int)fs.Length);
                List<user> ob = JsonSerializer.Deserialize<List<user>>(jsonUtf8bytes);


                fs.Close(); return ob;
            }

        }
    }
}
