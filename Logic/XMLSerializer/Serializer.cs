using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Triangle.Logic.Triangle;
using tr = Triangle.Logic.Triangle;

namespace Triangle.Logic.XMLSerializer
{
    static class TrianglesSerializer
    {
        public static List<tr.Triangle> DeserializeTriangles(string filePath)
        {
            // Проверяем, существует ли файл
            if (File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<tr.Triangle>));

                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {

                     return (List<tr.Triangle>)serializer.Deserialize(fs);
                    
                    
                }
            }
            else
            {
                // Если файл не существует, возвращаем пустой список
                return new List<tr.Triangle>();
            }
        }

        public static void SerializeTriangles(string filePath, List<tr.Triangle> triangles)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<tr.Triangle>));

            using (StreamWriter  fs = new StreamWriter (filePath))
            {
                serializer.Serialize(fs, triangles);
            }
        }
    }
}
