
using FairyTalesDemo.Models;
using Microsoft.Maui.Handlers;
using System.Collections.ObjectModel;

namespace FairyTalesDemo
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<FairyTale> FairyTales { get; set; } // Create a property to hold the FairyTales
        public ObservableCollection<FairyTale> FairyTales2 { get; set; }


        public MainPage()
        {
            InitializeComponent();
            ModifySearchBar();
            InitalizeTles();
            BindingContext = this;
        }

        private void InitalizeTles()
        {
            FairyTales = new ObservableCollection<FairyTale>
            {
                new FairyTale { Name = "Cindrella", ReadTime = new TimeSpan(0, 30, 0), Image = "cindrella.jpg"},
                new FairyTale { Name = "Snow White", ReadTime = new TimeSpan(0, 25, 0), Image = "snow.jpg"},
                new FairyTale { Name = "Rapunzel", ReadTime = new TimeSpan(0, 20, 0), Image = "rapunzel.jpg"},
                new FairyTale { Name = "Little Red Riding Hood", ReadTime = new TimeSpan(0, 15, 0), Image = "hood.jpg"},
                new FairyTale { Name = "Beauty and the Beast", ReadTime = new TimeSpan(0, 35, 0), Image = "beauty.jpg"},
            };

            FairyTales2 = new ObservableCollection<FairyTale>
            {
                new FairyTale { Name = "Cindrella", ReadTime = new TimeSpan(0, 30, 0), Image = "cindrella.jpg"},
                new FairyTale { Name = "Snow White", ReadTime = new TimeSpan(0, 25, 0), Image = "snow.jpg"},
                new FairyTale { Name = "Rapunzel", ReadTime = new TimeSpan(0, 20, 0), Image = "rapunzel.jpg"},
                new FairyTale { Name = "Little Red Riding Hood", ReadTime = new TimeSpan(0, 15, 0), Image = "hood.jpg"},
                new FairyTale { Name = "Beauty and the Beast", ReadTime = new TimeSpan(0, 35, 0), Image = "beauty.jpg"},
            };
        }

        private void ModifySearchBar()
        {
            SearchBarHandler.Mapper.AppendToMapping("CustomSearchIconColor", (handler, view) =>
            {
#if ANDROID
                    var context = handler.PlatformView.Context;
                    var searchIconId = context.Resources.GetIdentifier("search_mag_icon", "id", context.PackageName);
                    if (searchIconId != 0)
                    {
                        var searchIcon = handler.PlatformView.FindViewById<Android.Widget.ImageView>(searchIconId);
                        searchIcon.SetColorFilter(Android.Graphics.Color.Rgb(172, 157, 185), Android.Graphics.PorterDuff.Mode.SrcIn);
                    }
#endif
            });
        }
    }

}
