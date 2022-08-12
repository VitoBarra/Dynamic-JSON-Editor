using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mxv_Dynamic_JSON_Editor.Core.ViewModels.Uc
{
    public class StandardUCViewModel<T> : MvxViewModel
    {
        public StandardUCViewModel<T> Self { get; init; }


        private T _FieldValue;

        public T FieldValue
        {
            get { return _FieldValue; }
            set { SetProperty(ref _FieldValue, value); }
        }


        private string _FieldName = "FieldPlaceHolder";

        public string FieldName 
        {
            get { return _FieldName; }
            init { SetProperty(ref _FieldName, value); }
        }



        public StandardUCViewModel() : this("FieldPlaceHolder"){}

        public StandardUCViewModel(string _FieldName = "FieldPlaceHolder")
        {
            Self = this;
            FieldName = _FieldName;
        }

    }
}
