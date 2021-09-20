using QuizApplication.UI.Core;
using QuizApplication.UI.MVVM.ViewModel.InformationSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication.UI.MVVM.ViewModel
{
    class MainWindowViewModel: ObservableObject
    {
        public RelayCommand CourseViewComand { get; set; }
        public RelayCommand AchievementViewComand { get; set; }


        public CourseViewModel CourseViewModel { get; set; }
        public AchievementViewModel AchievementViewModel { get; set; }


        public InformationSectionViewModel InformationSectionVM { get; set; }

        private object _informationSectionView;

        public object InformationSectionView
        {
            get { return _informationSectionView; }
            set
            {
                _informationSectionView = value;
                OnPropertyChanged();
            }
        }


        public ContentSectionViewModel ContentSectionVM { get; set; }

        private object _contentSectionView;

        public object ContentSectionView
        {
            get { return _contentSectionView; }
            set
            {
                _contentSectionView = value;
                OnPropertyChanged();
            }
        }


        public DetailSectionViewModel DetailSectionVM { get; set; }

        private object _detailSectionView;

        public object DetailSectionView
        {
            get { return _detailSectionView; }
            set
            {
                _detailSectionView = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            //CourseViewModel = new CourseViewModel();
            //AchievementViewModel = new AchievementViewModel();

            //InformationSectionView = CourseViewModel;

            //CourseViewComand = new RelayCommand(o =>
            //{
            //    InformationSectionView = CourseViewModel;
            //});

            //AchievementViewComand = new RelayCommand(o =>
            //{
            //    InformationSectionView = AchievementViewModel;
            //});

            InformationSectionVM = new InformationSectionViewModel();
            InformationSectionView = InformationSectionVM;

            ContentSectionVM = new ContentSectionViewModel();
            ContentSectionView = ContentSectionVM;

            DetailSectionVM = new DetailSectionViewModel();
            DetailSectionView = DetailSectionVM;
        }
    }
}
