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
    public class MainPageViewModel : ViewModel
    {
        public ObservableCollection<Student> Students { get; set; }

        public ICommand LoadDataCommand { get; private set; } 

        public ICommand ClearDataCommand { get; private set; }

        public ICommand RefreshCommand {  get; private set; }
        public ICommand AddStudentCommand { get; private set; }



        public string Name { get; set; }
        public DateTime BirthDate { get; set; }


        private bool isRefreshing;

        public bool IsRefreshing { get { return isRefreshing; } set { if (isRefreshing != value) { isRefreshing = value; OnPropertyChanged(); }; } }

        public MainPageViewModel()
        {
            Students = new ObservableCollection<Student>();
            LoadDataCommand = new Command(LoadData);
            ClearDataCommand = new Command(() => Students.Clear());
            RefreshCommand = new Command(LoadData);
            AddStudentCommand = new Command(async () =>
            {
                Students.Add(new Student() { BirthDate = BirthDate, Name = Name, Image = $"{Name}.jpg" });  await AppShell.Current.DisplayAlert("הוספת תלמיד", $"התלמיד.ה {Name}  נוספ.ה בהצלחה", "אישור"); Name = await AppShell.Current.DisplayPromptAsync("כמה אתה שמח?", " ?כמה את.ה שבע רצון מציון ההגשה שלך", "אישור", "ביטול", "הזן ציון", 2, Keyboard.Numeric);         });
           
        }

        public void LoadData( )
        {
            Students.Clear();
           Students.Add(new Student() { BirthDate = new DateTime(2006,5,28), Name = "ג'ופיר", Image = "jofir.jpg" });
            IsRefreshing = false;
            
            
        }
    }
}
