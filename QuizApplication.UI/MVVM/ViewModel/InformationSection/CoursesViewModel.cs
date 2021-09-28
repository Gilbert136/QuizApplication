using QuizApplication.UI.Core;
using QuizApplication.UI.MVVM.Model;
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

        }

        public void LoadCourses(IEnumerable<Course> courses)
        {
            Courses = new ObservableCollection<Course>(courses);
            OnPropertyChanged("Courses");
        }
    }
}
