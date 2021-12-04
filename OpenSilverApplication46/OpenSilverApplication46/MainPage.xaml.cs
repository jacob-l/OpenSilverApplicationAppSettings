using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Extensions.Configuration;

namespace OpenSilverApplication46
{
    public partial class MainPage : Page
    {
        public MainPage(IConfiguration configuration)
        {
            this.InitializeComponent();

            // Enter construction logic here...

            DataContext = this;
            Message = configuration["message"];
        }

        public string Message { get; set; }
    }
}
