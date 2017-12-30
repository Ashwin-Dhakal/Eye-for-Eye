using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Eye_for_Eye
{
    public partial class Inquiry : PhoneApplicationPage
    {
        public Inquiry()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var mailto1 = new Uri("mailto:?to=bispoul181@gmail.com&subject=" + textBoxEmail.Text );
            await Windows.System.Launcher.LaunchUriAsync(mailto1);
        }
    }
}