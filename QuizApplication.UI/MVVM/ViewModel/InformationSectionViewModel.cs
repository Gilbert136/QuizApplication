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
    public class InformationSectionViewModel: ObservableObject
    {
        public RelayCommand CourseViewComand { get; set; }
        public RelayCommand AchievementViewComand { get; set; }


        public CourseViewModel CourseViewModel { get; set; }
        public AchievementViewModel AchievementViewModel { get; set; }


        private object _currentSectionView;

        public object CurrentView
        {
            get { return _currentSectionView; }
            set
            {
                _currentSectionView = value;
                OnPropertyChanged();
            }
        }


        public InformationSectionViewModel()
        {
            CourseViewModel = new CourseViewModel();
            AchievementViewModel = new AchievementViewModel();

            CurrentView = CourseViewModel;

            CourseViewComand = new RelayCommand(o =>
            {
                CurrentView = CourseViewModel;
            });

            AchievementViewComand = new RelayCommand(o =>
            {
                CurrentView = AchievementViewModel;
            });
        }
    }
}
