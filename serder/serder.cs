using Newtonsoft.Json;

namespace serder
{

    public class serder1
    {
        public static T Deserealize<T>()
        {
            string json = File.ReadAllText("C:\\Users\\Admin\\Desktop\\File.json");
            T list = JsonConvert.DeserializeObject<T>(json);
            return list;
        }
        public static void Serial<T>(T list)
        {
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText("C:\\Users\\Admin\\Desktop\\File.json", json);

        }

    }
}