using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TrenerManager.Common;
using TrenerManager.Common.Enums;
using TrenerManager.Windows;
using System.Windows.Controls.Ribbon;

namespace TrenerManager.AppClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //base.OnStartup(e);
            StateManager.LoginState = LoginState.LoggedIn;
            while (StateManager.LoginState == LoginState.LoggedIn)
            {
                var mainWindow = new MainWindow();
                mainWindow.Show();

                StateManager.LoginState = LoginState.Logout;
            }
        }
    }
}
