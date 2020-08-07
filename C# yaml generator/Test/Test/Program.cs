using System;
using System.IO;
using YamlDotNet.Serialization;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
     
            var Config_Data = new
            {
                new_base = true,
                new_time = true,
                new_base_path = "base_points_raw.csv",
                new_time_val = 120
            };

            var serializer = new Serializer();
            string Data = serializer.Serialize(Config_Data);

            TextWriter tw = new StreamWriter("C:\\Users\\Asus\\Desktop\\C#\\Data.yaml", false);
            tw.WriteLine("# YAML file - Goldfields - Windows a Ubuntu");
            tw.Write(Data);
            tw.Close();
        }
    }
}
