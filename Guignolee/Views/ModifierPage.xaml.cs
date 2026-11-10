using Guignolee.Data;
using Guignolee.ViewModels;
using Guignolee.ViewModels.Pages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Guignolee.Views
{
    public sealed partial class ModifierPage : Page
    {
        public ModifierDonViewModel ViewModel { get; }

        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.Enregistrer())
            {
                if (Frame.CanGoBack)
                {
                    Frame.GoBack();
                }
                else
                {
                    Frame.Navigate(typeof(RegistrePage));
                }
            }
        }
        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
            else
            {
                Frame.Navigate(typeof(RegistrePage));
            }
        }

    }
}
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

