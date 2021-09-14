using QuizApplication.UI.Core;
using QuizApplication.UI.MVVM.ViewModel.InformationSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication.UI.MVVM.ViewModel
{
    class InformationSectionViewModel: ObservableObject
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



            CourseViewComand = new RelayCommand(o =>
            {
                CurrentView = CourseViewModel;
            });

            AchievementViewComand = new RelayCommand(o =>
            {
                CurrentView = AchievementViewModel;
            });


            CurrentView = CourseViewModel;
        }
    }
}
