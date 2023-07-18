
using System.Text.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

var squad = new Squad();


string path = "D:\\TestFile";
string nameFile = "Super hero squad.json";

string[] files = Directory.GetFiles(path);
if (files.Length == 0)
{
    Console.WriteLine("folder is empty");
}
string[] files2 = Directory.GetFiles(path,"*.json");
string[] files3 = Directory.GetFiles(path, nameFile);
if (files2.Length >1)
{
    Console.WriteLine("Please,delete another 'json' file");
}
else if (files3.Length==1)
{
    Console.WriteLine("file here");
}
string path2 = path+"\\"+ nameFile;

using (var sr = new StreamReader(path2)) 
{
   var text = sr.ReadToEnd();
    var squad2 = JsonSerializer.Deserialize<Squad>(text);
    using (var sr2 = new FileStream(path + @"\Squad.xml", FileMode.CreateNew))
    {
        new XmlSerializer(typeof(Squad)).Serialize(sr2, squad2);
    }
}










