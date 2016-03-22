using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrenerManager.Windows.Common;
using TrenerManager.Windows.Interfaces;

namespace TrenerManager.Windows.TrainingUnits
{
    /// <summary>
    /// Interaction logic for TrainingUnitsToolbox.xaml
    /// </summary>
    public partial class TrainingUnitsToolbox : PropertyChangeUserControl, IViewModel
    {
        public TrainingUnitsToolbox()
        {
            InitializeComponent();
        }

        public string Header
        {
            get
            {
                return "Toolbox";
            }
        }
    }
}
