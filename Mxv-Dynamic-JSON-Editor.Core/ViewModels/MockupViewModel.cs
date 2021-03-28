using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mxv_Dynamic_JSON_Editor.Core.ViewModels
{
    public class MockUpViewModel : MvxViewModel
    {

        #region Property


        private int _myVar;

        public int MyProperty
        {
            get { return _myVar; }
            set { SetProperty(ref _myVar, value); }
        }


        #endregion



        #region Command

        public IMvxCommand Mycommand { get; set; }

        #endregion


        public MockUpViewModel()
        {
            Mycommand = new MvxCommand(() => { });
        }


    }
}
