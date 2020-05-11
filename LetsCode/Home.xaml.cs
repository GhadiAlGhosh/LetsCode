using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LetsCode
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            List<Category> CategoryList = new List<Category> 
            {
            new Category("Web Developer",GetWebDev()),
            new Category("Mobile App Developer",GetMobileAppDev()),
            new Category("Software Developer",GetSoftDev()),
            new Category("Data Science",GetDataScience()),
            };
            OuterRepeater.ItemsSource = CategoryList;
           
        }
        private ObservableCollection<string> GetWebDev()
        {
            return new ObservableCollection<string> { "HTML", "Python", "JavaScript", "PHP", "Java", "Ruby" };
        }
        private ObservableCollection<string> GetMobileAppDev()
        {
            return new ObservableCollection<string> { "Python", "React", "Flutter", "Swift","Scala","GoLang" };
        }
        private ObservableCollection<string> GetSoftDev()
        {
            return new ObservableCollection<string> { "C#", "C++", "Java" };
        }
        private ObservableCollection<string> GetDataScience()
        {
            return new ObservableCollection<string> { "Python", "MatLab" };
        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            TeachingTip.IsOpen = true;
        }

        private void TeachingTip_ActionButtonClick(Microsoft.UI.Xaml.Controls.TeachingTip sender, object args)
        {
           
        }
    }
}
