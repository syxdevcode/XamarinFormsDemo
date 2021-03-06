﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CarouselPage.CarouselPageTest());
        }

        public void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MasterDetailPage.MasterDetailPageTest());
        }

        public void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TabbedPage.TabbedPageTest());
        }
        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LayoutPage.StackLayoutPage());
        }
        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LayoutPage.AbsoluteLayoutPage());
        }
        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LayoutPage.RelativeLayoutPage());
        }
        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LayoutPage.GridPage());
        }

        private void Button_Clicked_7(object sender,EventArgs e)
        {
            Navigation.PushAsync(new ViewDemoPage());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MVVM.MVVMPage1());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MVVM.MVVMPage2());
        }

        int add = 0;
        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DisplayingAlertsPages());
            if (add == 0)
            {
                MessagingCenter.Send<MainPage, string>(this, "Hello", "消息~~~");
            }
            else
            {
                MessagingCenter.Send<MainPage, string>(this, "Hello", "消息2~~~");
            }
            add++;
        }
    }
}
