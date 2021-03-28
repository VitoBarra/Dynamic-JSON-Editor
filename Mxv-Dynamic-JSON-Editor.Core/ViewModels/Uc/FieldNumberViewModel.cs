using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mxv_Dynamic_JSON_Editor.Core.ViewModels.Uc
{
    public class FieldNumberViewModel : StandardUCViewModel<decimal>
    {



        #region Binding Property
        private decimal _deltaValue= 1;
        public decimal DeltaValue
        {
            get { return _deltaValue; }
            set { SetProperty(ref _deltaValue, value); }
        }

        #endregion

        #region Command
        public IMvxCommand Button_Click_Up { get; set; }
        public IMvxCommand Button_Click_Down { get; set; }

        #endregion



        public FieldNumberViewModel() : this("FieldPlaceHolder")
        {
        }
        public FieldNumberViewModel(string _FieldName) : base(_FieldName)
        {
            Button_Click_Up = new MvxCommand(() =>
            FieldValue += DeltaValue, ()=>DeltaValue!= 0 ); 

            Button_Click_Down = new MvxCommand(() =>
            FieldValue -= DeltaValue, () => DeltaValue != 0); ;
        }




    }
}
