using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilverApplication46
{
    public sealed partial class App : Application
    {
        public App(Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            this.InitializeComponent();

            // Enter construction logic here...

            var mainPage = new MainPage(configuration);
            Window.Current.Content = mainPage;
        }
    }
}
