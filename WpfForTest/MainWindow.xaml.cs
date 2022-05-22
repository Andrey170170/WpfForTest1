﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfForTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> styles = new List<string> { "light", "dark" };
            styleList.SelectionChanged += ThemeChanged;
            styleList.ItemsSource = styles;
            styleList.SelectedItem = "light";

            List<Services> bookList = new List<Services>();

            bookList.Add(new Services(
                @"C:\Users\24122\Desktop\колледж\зачет\рпм\1макет.jpg",
                "Computer Networking"
            ));
            bookList.Add(new Services(
                @"C:\Users\24122\Desktop\колледж\зачет\рпм\1макет.jpg",
                "Computer Networking"
            )); 
            bookList.Add(new Services(
                @"C:\Users\24122\Desktop\колледж\зачет\рпм\1макет.jpg",
                "Computer Networking"
            )); 
            bookList.Add(new Services(
                @"C:\Users\24122\Desktop\колледж\зачет\рпм\1макет.jpg",
                "Computer Networking"
            ));
            bookList.Add(new Services(
                @"C:\Users\24122\Desktop\колледж\зачет\рпм\1макет.jpg",
                "Computer Networking"
            ));

            //Bind it with the ListBox
            this.serviceTemplate.ItemsSource = bookList;
        }

        private void ThemeChanged(object sender, SelectionChangedEventArgs e)
        {
            string? style = styleList.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri(style?.ToLower() + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary? resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Service_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Услуги");
        }
        private void AboutCompany_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"О компании");
        }
        private void OurWorks_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Наши работы");
        }
        private void FindUs_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Как найти нас ");
        }
    }
}