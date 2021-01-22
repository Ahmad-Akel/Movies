﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MoviesDataLayer.UWP.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Movies.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Favorite : Page
    {
        public List<Movie> FavoritesList { get; set; } = new List<Movie>();
        public Favorite()
        {
            this.InitializeComponent();
            FavoritesList.Add(new Movie { Title = "Avengers", Categories = "Action", Price = 25, image = "/Assets/Avengers.jpg" });
            FavoritesList.Add(new Movie { Title = "Joker", Categories = "Drama", Price = 40, image = "/Assets/Joker.jpg" });
            FavoritesList.Add(new Movie { Title = "Chess", Categories = "Fiction", Price = 30, image = "/Assets/Chess.jpg" });
            FavoritesList.Add(new Movie { Title = "Rick&Morty", Categories = "Cartoon", Price = 25, image = "/Assets/Rick&Morty.jpg" });
            FavoritesList.Add(new Movie { Title = "MrRobot", Categories = "Fiction", Price = 40, image = "/Assets/MrRobot.jpg" });
            FavoritesList.Add(new Movie { Title = "Avengers", Categories = "Action", Price = 30, image = "/Assets/Avengers.jpg" });
            FavoritesList.Add(new Movie { Title = "Chess", Categories = "Fiction", Price = 25, image = "/Assets/Chess.jpg" });
            FavoritesList.Add(new Movie { Title = "Joker", Categories = "Drama", Price = 40, image = "/Assets/Joker.jpg" });
            FavoritesList.Add(new Movie { Title = "Rick&Morty", Categories = "Cartoon", Price = 30, image = "/Assets/Rick&Morty.jpg" });
        }
        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var movie = (Movie)e.ClickedItem;
            InfoTextBlock.Text = "Name: " + movie.Title + "\n" + "Price: " + movie.Price + "\n" + "Category: " + movie.Categories;

        }
        
    }
}
