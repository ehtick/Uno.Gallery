﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Uno.Gallery.Views.NestedPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NavigationBarSample_NestedPage1 : Page
    {
        public NavigationBarSample_NestedPage1()
        {
            this.InitializeComponent();
        }

        private void NavigateToNextPage(object sender, RoutedEventArgs e) => Frame.Navigate(typeof(NavigationBarSample_NestedPage2));

        private void NavigateBack(object sender, RoutedEventArgs e) => Shell.GetForElement(this).BackNavigateFromNestedSample();
    }
}
