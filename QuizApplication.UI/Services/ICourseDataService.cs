using QuizApplication.UI.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication.UI.Services
{
    public interface ICourseDataService
    {
        IEnumerable<Course> GetCourses();
        void Save(IEnumerable<Course> courses);
    }
}
