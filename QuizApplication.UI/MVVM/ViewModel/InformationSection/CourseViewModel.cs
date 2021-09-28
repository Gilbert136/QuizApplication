using QuizApplication.UI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuizApplication.UI.MVVM.ViewModel.InformationSection
{
    public class CourseViewModel : ObservableObject
    {
        private CoursesViewModel _coursesViewModel;
        public CoursesViewModel CoursesViewModel
        {
            get { return _coursesViewModel;  }
            set
            {
                _coursesViewModel = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadCoursesCommand { get; private set; }

        public CourseViewModel() 
        {
            CoursesViewModel = new CoursesViewModel();
            LoadCoursesCommand = new RelayCommand(o =>
            {
                //CurrentView = AchievementViewModel;
            });
        }

        private void LoadCourses()
        {

        }
    }
}
