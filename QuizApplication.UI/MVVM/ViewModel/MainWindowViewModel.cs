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
        public InformationSectionViewModel InformationSectionViewModel { get; set; }

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
            InformationSectionViewModel = new InformationSectionViewModel();

            ContentSectionVM = new ContentSectionViewModel();
            ContentSectionView = ContentSectionVM;

            DetailSectionVM = new DetailSectionViewModel();
            DetailSectionView = DetailSectionVM;
        }
    }
}
