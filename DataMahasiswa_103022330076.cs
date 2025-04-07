using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

public class DataMahasiswa_103022330076
{
	public Nama nama {  get; set; }
	public long nim {  get; set; }
	public string fakultas {  get; set; }

	public class Nama()
	{
        public string depan { get; set; }
        public string belakang { get; set; }
    }

	public void ReadJSON()
	{
		// Read JSON data from a file
		string jsonData = File.ReadAllText("tp7_1_103022330076.json");
        // Parse JSON data to create objects
        var data = JsonConvert.DeserializeObject<DataMahasiswa_103022330076>(jsonData);
        // Print result of deserialization from JSON
        if (data != null)
        {
            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");

        }
        else
        {
            Console.WriteLine("Data tidak ada di dalam file JSON.");
        }
    }
}

public class ProgRAM
{
	public static void Main(string[] args)
    {
        DataMahasiswa_103022330076 dataMahasiswa = new DataMahasiswa_103022330076();
        dataMahasiswa.ReadJSON();
    }
}
