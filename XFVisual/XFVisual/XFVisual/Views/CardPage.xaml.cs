﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFVisual.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardPage : TabbedPage
    {
        public CardPage()
        {
            InitializeComponent();
        }
    }
}