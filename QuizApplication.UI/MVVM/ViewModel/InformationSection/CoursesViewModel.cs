using QuizApplication.UI.Core;
using QuizApplication.UI.MVVM.Model;
using QuizApplication.UI.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication.UI.MVVM.ViewModel.InformationSection
{
    public class CoursesViewModel : ObservableObject
    {
        private Course _selectedCourse;
        public Course SelectedCourse
        {
            get { return _selectedCourse; }
            set { 
                _selectedCourse = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Course> Courses { get; private set; }

        public CoursesViewModel()
        {
            var courses = new MockService();
            Courses = new ObservableCollection<Course>(courses.GetCourses());
            OnPropertyChanged("Courses");
        }

        public void LoadCourses(IEnumerable<Course> courses)
        {
            Courses = new ObservableCollection<Course>(courses);
            OnPropertyChanged("Courses");
        }
    }
}
