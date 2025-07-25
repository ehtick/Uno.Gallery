﻿using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Uno.Gallery.Views.NestedPages
{
    public sealed partial class MediaPlayerElementSample_NestedPage4 : Page
    {
        public MediaPlayerElementSample_NestedPage4()
        {
            this.InitializeComponent();
			Unloaded += MediaPlayerElementSample_NestedPage4_Unloaded;
        }

		private void NavigateBack(object sender, RoutedEventArgs e)
		{
			MediaPlayerElementSample4.MediaPlayer.Pause();
			Shell.GetForElement(this).BackNavigateFromNestedSample();
		}

		private void MediaPlayerElementSample_NestedPage4_Unloaded(object sender, RoutedEventArgs e)
		{
			MediaPlayerElementSample4.MediaPlayer.Pause();
		}
	}
}
