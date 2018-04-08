using System.IO;
using System.Xml.Serialization;

namespace GoFootball
{
    public static class RideDtoHelper
    {
        private static readonly XmlSerializer Xs = new XmlSerializer(typeof(RideApplicationDto));
        public static void WriteToFile(string fileName, RideApplicationDto data)
        {
            using (var fileStream = File.Create(fileName))
            {
                Xs.Serialize(fileStream, data);
            }
        }

        public static RideApplicationDto LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (RideApplicationDto)Xs.Deserialize(fileStream);
            }
        }
    }
}
