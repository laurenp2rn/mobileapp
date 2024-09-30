﻿using Microsoft.Maui.Controls;

namespace MauiPlanets
{
	public partial class MainPage : ContentPage
	{
		private int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;
			CounterBtn.Text = $"Clicked {count} times";
		}
	}
}
