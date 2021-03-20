using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_JSON_Editor.JSONInterpreter
{
    static public class JsonInterpreter
    {
        static public void Sarter(dynamic jsonInput)
        {
            dynamic resObj = new ExpandoObject();

            FormatObject(resObj, jsonInput);

            string resultingString = Newtonsoft.Json.JsonConvert.SerializeObject(resObj);

            File.WriteAllText(@"D:\Dynamic-JSON-Editor\Dynamic-JSON-Editor\TestJsonToIgnore\done.txt", resultingString);
        }

        static private void FormatObject(dynamic resObj, dynamic el)
        {

            if (el.GetType() == typeof(JArray))
            {
                resObj.start = new ExpandoObject();
                resObj.start.nome = "";
                resObj.start.type = "Array";
                IterArray(resObj.start, el);
            }
            else
            {
                resObj.start = new ExpandoObject();
                resObj.start.nome = "";
                resObj.start.type = "Object";
                IterObj(resObj.start, el);
            }
        }

        static private void IterObj(dynamic resObj, JObject obj)
        {
            foreach (var k in obj)
            {
                if (k.Value.GetType() == typeof(JValue))
                {
                    
                    AddProperty(resObj, k.Key, new { nome = k.Key, type = k.Value.Type });
                    //$"{k.Key}: {k.Value.Type}\n";
                }
                else if (k.Value.GetType() == typeof(JObject))
                {
                    AddProperty(resObj, k.Key, new { nome = k.Key, type = k.Value.Type });
                    IterObj(FirstOrDefault<ExpandoObject>(resObj, k.Key), (JObject)k.Value);
                }
                else
                {
                    AddProperty(resObj, k.Key, new { nome = k.Key, type = k.Value.Type });
                    IterArray(FirstOrDefault(resObj, k.Key), (JArray)k.Value);
                }
            }
        }

        static private void IterArray(dynamic resObj, JArray a)
        {
            string currType = "";
            dynamic currentComplexType = new ExpandoObject();
            dynamic currentArrayType = new ExpandoObject();
            IList<dynamic> complexTypes = new List<dynamic>();
            IList<dynamic> arrayTypes = new List<dynamic>();

            resObj.acceptedTypes = "";

            foreach (var k in a)
            {
                if (k.GetType() == typeof(JValue))
                {
                    currType = k.GetType().ToString().Split('.')[1];
                    if (!resObj.acceptedTypes.Contains(currType))
                        resObj.acceptedTypes += " currType ";
                }
                else if (k.GetType() == typeof(JObject))
                {
                    IterObj(currentComplexType, (JObject)k);
                    if (!complexTypes.Contains(currentComplexType))
                        complexTypes.Add(currentComplexType);
                }
                else
                {
                    IterArray(currentArrayType, (JArray)k);
                    if (!arrayTypes.Contains(currentArrayType))
                        arrayTypes.Add(currentArrayType);
                }

                resObj.acceptedComplexTypes = complexTypes;
                resObj.acceptedComplexTypes = arrayTypes;
            }
        }

        static bool AddProperty(ExpandoObject obj, string key, object value)
        {
            if (obj == null) return false;
            var dynamicDict = obj as IDictionary<string, object>;
            if (dynamicDict.ContainsKey(key))
                return false;
            else
                dynamicDict.Add(key, value);
            return true;
        }

        static T FirstOrDefault<T>(ExpandoObject eo, string key)
        {
            object r = eo.FirstOrDefault(x => x.Key == key).Value;
            return (r is T) ? (T)r : default(T);
        }
    }
}