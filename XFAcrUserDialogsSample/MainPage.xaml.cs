using Acr.UserDialogs;
using Xamarin.Forms;

namespace XFAcrUserDialogsSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            UserDialogs.Instance.Alert(new AlertConfig
            {
                Message = "You're now subscribed to Gerald's channel",
                OkText = "OK, thank you",
                Title = "Subscribed",
                OnAction = () => { UserDialogs.Instance.Alert("Dismissed"); }
            });
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            UserDialogs.Instance.Confirm(new ConfirmConfig
            {
                Message = "Do you want to subscribe to Gerald's channel?",
                OkText = "Yes, please",
                CancelText = "No, thank you",
                Title = "Subscribe?",
                OnAction = (confirmed) => {
                    if (confirmed)
                        UserDialogs.Instance.Alert("Dismissed");
                },
            });
        }

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            UserDialogs.Instance.Prompt(new PromptConfig
            {
                Message = "Please input something",
                CancelText = "Cancel",
                Placeholder = "Input text here",
                Title = "This is a prompt"
            });
        }

        void Button_Clicked_3(System.Object sender, System.EventArgs e)
        {
            UserDialogs.Instance.Loading("Loading data...", () =>
            {
                UserDialogs.Instance.HideLoading();
            }, "Cancel", true, MaskType.Gradient);
        }
    }
}
