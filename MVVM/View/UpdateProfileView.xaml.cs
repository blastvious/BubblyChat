using BubblyChat.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BubblyChat.MVVM.View
{
    /// <summary>
    /// Interaction logic for UpdateProfileView.xaml
    /// </summary>
    /// 


    public partial class UpdateProfileView : Window
    {
        public UpdateProfileView()
        {
            InitializeComponent();
            Loaded += UpdateProfileView_Loaded;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private async void UpdateProfileView_Loaded(object sender, RoutedEventArgs e)
        {
            if(DataContext is UpdateProfileVM viewModel)
            {
                await viewModel.InitAysnc();
            }
        }

    }
}
