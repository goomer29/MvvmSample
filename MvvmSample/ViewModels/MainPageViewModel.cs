using BindingToObject.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmSample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region מימוש ממשק עדכון שינויים
        public event PropertyChangedEventHandler PropertyChanged;                        
        
        private  void OnPropertyChanged([CallerMemberName] string propertyName="")
        {
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));         
        }
        #endregion


        public ObservableCollection<Student> Students { get; set; }

        public ICommand LoadDataCommand { get; private set; } 

        public ICommand ClearDataCommand { get; private set; }

        public MainPageViewModel()
        {
            Students = new ObservableCollection<Student>(); 
            LoadDataCommand=new Command(LoadData);
            ClearDataCommand = new Command(() => Students.Clear());
        }

        public void LoadData()
        {
            Students.Clear();
           Students.Add(new Student() { BirthDate = DateTime.Now, Name = "ג'ופיר", Image = "jofir.jpg" });
            
        }
    }
}
