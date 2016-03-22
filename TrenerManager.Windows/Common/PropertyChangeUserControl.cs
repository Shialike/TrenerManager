using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TrenerManager.Windows.Common
{
    public class PropertyChangeUserControl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged<T>(Expression<Func<T>> property)
        {
            if (PropertyChanged != null)
            {
                var memberExpression = property.Body as MemberExpression;
                PropertyChanged(this, new PropertyChangedEventArgs(memberExpression.Member.Name));
            }
        }

        public PropertyChangeUserControl() : base()
        {
        }
    }
}
