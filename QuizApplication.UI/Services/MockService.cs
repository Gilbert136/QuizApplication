using QuizApplication.UI.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication.UI.Services
{
    public class MockService : ICourseDataService
    {
        private IEnumerable<Course> _courses;

        public MockService()
        {
            _courses = new List<Course>()
            {
                new Course
                {
                    Id = 1,
                    Name = "English"
                },
                new Course
                {
                    Id = 2,
                    Name = "Mathematics"
                }
            };
        }
        public IEnumerable<Course> GetCourses()
        {
            return _courses;
        }

        public void Save(IEnumerable<Course> courses)
        {
            _courses = courses;
        }
    }
}
