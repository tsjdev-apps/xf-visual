using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFVisual.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgressBarPage : ContentPage
    {
        private bool _isRunning = false;

        private double _percentage = 0.0;
        public double PercentageCounter
        {
            get => _percentage;
            set { _percentage = value; OnPropertyChanged(); }
        }

        public ProgressBarPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _isRunning = true;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                var progress = _percentage + 0.1;
                if (progress > 1)
                    progress = 0;

                PercentageCounter = progress;

                return _isRunning;
            });
        }

        protected override void OnDisappearing()
        {
            _isRunning = false;

            base.OnDisappearing();
        }
    }
}