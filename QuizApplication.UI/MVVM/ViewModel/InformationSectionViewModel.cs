using QuizApplication.UI.Core;
using QuizApplication.UI.MVVM.ViewModel.InformationSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuizApplication.UI.MVVM.ViewModel
{
    public class InformationSectionViewModel : ObservableObject
    {
        public RelayCommand CourseViewComand { get; set; }
        public RelayCommand AchievementViewComand { get; set; }



        public CourseViewModel CourseViewModel { get; set; }
        public AchievementViewModel AchievementViewModel { get; set; }



        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }



        public InformationSectionViewModel()
        {
            CourseViewModel = new CourseViewModel();

            AchievementViewModel = new AchievementViewModel();

            CurrentView = CourseViewModel;
            //CurrentView = AchievementViewModel;

            CourseViewComand = new RelayCommand(o =>
            {
                CurrentView = CourseViewModel;
            });

            //AchievementViewComand = new RelayCommand(o =>
            //{
            //    CurrentView = AchievementViewModel;
            //});

            AchievementViewComand = new RelayCommand(ExecuteMethod, canExecuteMethod);
        }

        private bool canExecuteMethod(object parameter)
        {
            return true;
        }

        private void ExecuteMethod(object parameter)
        {
            CurrentView = AchievementViewModel;
            MessageBox.Show("iiiei");
        }
    }
}
