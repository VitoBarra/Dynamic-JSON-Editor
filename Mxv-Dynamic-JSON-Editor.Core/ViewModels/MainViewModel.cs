using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Mxv_Dynamic_JSON_Editor.Core.ViewModels.Uc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mxv_Dynamic_JSON_Editor.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {

        #region Property




        private IList<FieldNumberViewModel> _FieldNumber;

        public IList<FieldNumberViewModel> FieldNumber
        {
            get { return _FieldNumber; }
            set { SetProperty(ref _FieldNumber, value); }
        }



        #endregion



        #region Command

        public IMvxCommand Mycommand { get; set; }

        #endregion


        public MainViewModel()
        {
            Mycommand = new MvxCommand(() => { });
            FieldNumber = new List<FieldNumberViewModel>();
            FieldNumber.Add(new("sucarello"));
            FieldNumber.Add(new("cucciarello"));

        }


    }
}
