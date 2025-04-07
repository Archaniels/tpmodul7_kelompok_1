using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Collections.Generic;
using static KuliahMahasiswa_103022330076;

public class KuliahMahasiswa_103022330076
{
	public KuliahMahasiswa_103022330076()
    {
    }

    public List<Course> courses { get; set; }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public void ReadJSON()
    {
        // Read JSON data from a file
        string jsonData = File.ReadAllText("tp7_2_103022330076.json");
        // Parse JSON data to create objects
        var data = JsonConvert.DeserializeObject<KuliahMahasiswa_103022330076>(jsonData);
        // Print result of deserialization from JSON
        if (data != null && data.courses != null)
        {
            for (int i = 0; i < data.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i+1) + data.courses[i].code + " - " + data.courses[i].name);
            }
        }
        else
        {
            Console.WriteLine("Data tidak ada di dalam file JSON.");
        }
    }
}

public class ProgRaM
{
    public static void Main(string[] args)
    {
        KuliahMahasiswa_103022330076 kuliahMahasiswa = new KuliahMahasiswa_103022330076();
        kuliahMahasiswa.ReadJSON();
    }
}
