using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mxv_Dynamic_JSON_Editor.Core.ViewModels.Uc
{
    public class FieldBoolViewModel :StandardUCViewModel<bool>
    {
        public FieldBoolViewModel() : this("FieldPlaceHolder") { }


        public FieldBoolViewModel(string _FieldName) : base(_FieldName) { }

    }
}
