using App1.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.MVVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MVVMPage1 : ContentPage
    {
        TimeViewModel viewModel;

        public MVVMPage1()
        {
            InitializeComponent();

            BindingContext = viewModel = new TimeViewModel();
        }
    }
}