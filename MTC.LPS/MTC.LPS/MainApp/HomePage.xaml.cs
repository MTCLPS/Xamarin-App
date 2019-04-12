using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTC.LPS.MainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage (string Name)
        {
            InitializeComponent();
            this.Children.Insert(1, new Profile(Name));
        }
    }
}