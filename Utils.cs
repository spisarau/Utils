using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
namespace Utils
{
    public static class JsonUtils {

        public static Dictionary<string,string> DeserializeJSON (string json)
        {
            json=json.Replace("}", "");
            json=json.Replace("{", "");
            json = json.Replace("\"", "");
            var splittedJson = json.ToString().Split(',');
            Dictionary<String, String> result = new Dictionary<string, string>();
            foreach (var item in splittedJson)
            {
                var elements = item.Split(':');
                result.Add(elements[0], elements[1]);
            }
            return result;
        }

    }
}