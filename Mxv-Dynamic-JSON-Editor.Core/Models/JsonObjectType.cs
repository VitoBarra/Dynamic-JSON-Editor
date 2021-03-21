using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mxv_Dynamic_JSON_Editor.Core.Models
{
    public interface IInterpreterObject
    { 
    }



    public class JsonObjectType : IInterpreterObject
    {
        public IDictionary<string, Type> Property { get; set; } = new Dictionary<string, Type>();
        public IDictionary<string, JsonObjectType> Object { get; set; } = new Dictionary<string, JsonObjectType>();
        public IDictionary<string, JsonArrayType> Array { get; set; } = new Dictionary<string, JsonArrayType>();

    }


    public class JsonArrayType : IInterpreterObject
    {
        public IList<Type> ArTypes { get; set; } = new List<Type>();
        public IList<JsonObjectType> ArObjects { get; set; } = new List<JsonObjectType>();
        public IList<JsonArrayType> ArArrays { get; set; } = new List<JsonArrayType>();
    }

}
