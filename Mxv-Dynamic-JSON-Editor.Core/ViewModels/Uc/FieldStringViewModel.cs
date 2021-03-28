using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mxv_Dynamic_JSON_Editor.Core.ViewModels.Uc
{
    public class FieldStringViewModel : StandardUCViewModel<string>
    {

        public FieldStringViewModel() : this("FieldPlaceHolder") { }


        public FieldStringViewModel(string _FieldName) : base(_FieldName) { }
    }
}
