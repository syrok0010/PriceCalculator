using System;
using System.Windows;
using PriceCalculator.Controller;
using PriceCalculator.Model;

namespace PriceCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generate(object sender, RoutedEventArgs e)
        {
            var generateController = new GenerateController(new Generator(int.Parse(NightsTextBox.Text), 
                                                                        int.Parse(DayPriceTextBox.Text),
                                                                        int.Parse(ComissionTextBox.Text),
                                                                        int.Parse(PeopleTextBox.Text),
                                                                        int.Parse(ExpencesTextBox.Text),
                                                                        ChildPlace.IsChecked != null && (bool) ChildPlace.IsChecked));
            generateController.Generate();
            generateController.Save();
        }


        private void AddRoomCategory_OnClick(object sender, RoutedEventArgs e)
        {
        }
    }
}
