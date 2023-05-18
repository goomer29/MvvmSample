using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmSample.ViewModels
{
    public class TeacherPageViewModel:ViewModel
    {
     public   ICommand GotoPage { get; private set; }

        public TeacherPageViewModel()
        {
            GotoPage = new Command(async () => { await AppShell.Current.GoToAsync("DetailsPage"); }) ; 
        }
    }
}
