using QuizApplication.UI.Core;
using QuizApplication.UI.Services;
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
        private ICourseDataService _service;
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

        public CourseViewModel(ICourseDataService service) 
        {
            _service = service;
            CoursesViewModel = new CoursesViewModel();
            LoadCoursesCommand = new RelayCommand(o =>
            {
                //CurrentView = AchievementViewModel;
            });
        }

        private void LoadCourses()
        {
            CoursesViewModel.LoadCourses(_service.GetCourses());
        }
    }
}
