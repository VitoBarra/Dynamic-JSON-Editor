using Mxv_Dynamic_JSON_Editor.Core.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Dynamic_JSON_Editor.JSONInterpreter
{
    static public class JsonInterpreter
    {
        static public void WriteInterOnFile(dynamic jsonInput, string path)
        {
            string resultingString = JsonConvert.SerializeObject(FormatObject(jsonInput), Formatting.Indented);
            File.WriteAllText(path, resultingString);
        }

        static public IInterpreterObject FormatObject(dynamic el)
        {
            IInterpreterObject interpreterObject;

            if (el.GetType() == typeof(JArray))
                interpreterObject = IterArray(el);
            else //JObject
                interpreterObject =  IterObj(el);

            return interpreterObject;
        }

        static private JsonObjectType IterObj(JObject obj)
        {
            JsonObjectType resObj = new();

            foreach (var k in obj)
            {
                if (k.Value.GetType() == typeof(JValue))
                    resObj.Property.Add(new(k.Key, k.Value.Type.JTokenTypeToType()));
                else
                {
                    if (k.Value.GetType() == typeof(JObject))
                    {
                        JObject NestObj = k.Value as JObject;
                        resObj.Object.Add(new(k.Key, IterObj(NestObj)));
                    }
                    else // Jarray
                    {
                        JArray NestArray = k.Value as JArray;
                        resObj.Array.Add(new(k.Key, IterArray(NestArray)));
                    }
                }
            }

            return resObj;
        }

        static private JsonArrayType IterArray( JArray a)
        {
            JsonArrayType resObj = new();
            foreach (var k in a)
            {
                if (k.GetType() == typeof(JValue))
                {
                    var Vel = k as JValue;

                    if (!resObj.ArTypes.Contains(Vel.Type.JTokenTypeToType()))
                        resObj.ArTypes.Add(Vel.Type.JTokenTypeToType());
                }
                else
                {
                    if (k.GetType() == typeof(JObject))
                    {

                        var Vel = k as JObject;
                        var e = IterObj(Vel);

                        if (!resObj.ArObjects.Contains(e))
                            resObj.ArObjects.Add(e);

                    }
                    else
                    {
                        var Vel = k as JArray;
                        var e = IterArray(Vel);

                        if (!resObj.ArArrays.Contains(e))
                            resObj.ArArrays.Add(e);
                    }
                }
            }
            return resObj;
        }




        public static Type JTokenTypeToType(this JTokenType jTokenType)
        {
            switch (jTokenType)
            {
                case JTokenType.Integer:
                    return typeof(int);
                case JTokenType.Float:
                    return typeof(float);
                case JTokenType.String:
                    return typeof(string);
                case JTokenType.Boolean:
                    return typeof(bool);
                case JTokenType.Date:
                    return typeof(DateTime);
                case JTokenType.Raw:
                    return typeof(JRaw);
                case JTokenType.Bytes:
                    return typeof(byte);
                case JTokenType.Guid:
                    return typeof(Guid);
                case JTokenType.Uri:
                    return typeof(Uri);
                case JTokenType.TimeSpan:
                    return typeof(TimeSpan);
                case JTokenType.None:
                case JTokenType.Object:
                case JTokenType.Array:
                case JTokenType.Constructor:
                case JTokenType.Property:
                case JTokenType.Comment:
                case JTokenType.Null:
                case JTokenType.Undefined:
                default:
                    return null;
            }
        }   
    }
}