using Syncfusion.Windows.Tools.Controls;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows;
using TrenerManager.Windows.Interfaces;
using TrenerManager.Windows.TrainingUnits;

namespace TrenerManager.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow, INotifyPropertyChanged
    {
        #region Fields and Events

        public event PropertyChangedEventHandler PropertyChanged;
        private IViewModel _leftPanelViewModel;
        private IViewModel _middlePanelViewModel;

        #endregion

        #region Properties


        public IViewModel LeftPanelViewModel
        {
            get
            {
                return _leftPanelViewModel;
            }

            set
            {
                _leftPanelViewModel = value;
                NotifyPropertyChanged(() => LeftPanelViewModel);
                NotifyPropertyChanged(() => LeftPanelHeader);
            }
        }

        public IViewModel MiddlePanelViewModel
        {
            get
            {
                return _middlePanelViewModel;
            }

            set
            {
                _middlePanelViewModel = value;
                NotifyPropertyChanged(() => MiddlePanelViewModel);
                NotifyPropertyChanged(() => MiddlePanelHeader);
            }
        }

        public string MiddlePanelHeader
        {
            get
            {
                return MiddlePanelViewModel == null ? "" : MiddlePanelViewModel.Header;
            }
        }

        public string LeftPanelHeader
        {
            get
            {
                return LeftPanelViewModel == null ? "" : LeftPanelViewModel.Header;
            }
        }


        #endregion

        #region Methods

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void NotifyPropertyChanged<T>(Expression<Func<T>> property)
        {
            if (PropertyChanged != null)
            {
                var memberExpression = property.Body as MemberExpression;
                PropertyChanged(this, new PropertyChangedEventArgs(memberExpression.Member.Name));
            }
        }

        public void OpenTrainingUnits(object sender, RoutedEventArgs e)
        {
            LeftPanelViewModel = new TrainingUnitsToolbox();
            MiddlePanelViewModel = new TrainingUnits.TrainingUnits();   
        }

        #endregion
    }
}
