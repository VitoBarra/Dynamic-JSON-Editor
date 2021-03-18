using MvvmCross.ViewModels;
using Mxv_Dynamic_JSON_Editor.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mxv_Dynamic_JSON_Editor.Core
{
    public class App : MvxApplication
    {

        public override void Initialize()
        {
            RegisterAppStart<MockUpViewModel>();
        }
    }
}
