
using Microsoft.Maui.Handlers;

namespace FairyTalesDemo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            ModifySearchBar();

        }

        private void ModifySearchBar()
        {
            SearchBarHandler.Mapper.AppendToMapping("CustomSearchIconColor", (handler, view) =>
            {
#if ANDROID
             var context = handler.PlatformView.Context;
             var searchIconId = context.Resources.GetIdentifier("search_mag_icon", "id", context);
             if (searchIconId != 0) {
             }
            });
        }
    }

}
