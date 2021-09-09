using QuizApplication.UI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication.UI.MVVM.ViewModel
{
    class MainWindowViewModel: ObservableObject
    {
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
            InformationSectionVM = new InformationSectionViewModel();
            InformationSectionView = InformationSectionVM;

            ContentSectionVM = new ContentSectionViewModel();
            ContentSectionView = ContentSectionVM;

            DetailSectionVM = new DetailSectionViewModel();
            DetailSectionView = DetailSectionVM;
        }
    }
}
