using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mxv_Dynamic_JSON_Editor.Core.ViewModels
{
    public class FieldNumberViewModel : MvxViewModel
    {
        #region Property
        private decimal _fieldvalue =0;
        private decimal _deltaValue=1;




        public decimal DeltaValue
        {
            get { return _deltaValue; }
            set { SetProperty(ref _deltaValue, value); }
        }

        public decimal FieldValue
        {
            get { return _fieldvalue; }
            set { SetProperty(ref _fieldvalue, value); }
        }
        #endregion

        #region Command
        public IMvxCommand Button_Click_Up { get; set; }
        public IMvxCommand Button_Click_Down { get; set; }

        public FieldNumberViewModel()
        {

            Button_Click_Up = new MvxCommand(() =>FieldValue += DeltaValue, ()=>DeltaValue!= 0 ); 

            Button_Click_Down = new MvxCommand(() =>FieldValue -= DeltaValue, () => DeltaValue != 0); ;
        }
        #endregion




    }
}
