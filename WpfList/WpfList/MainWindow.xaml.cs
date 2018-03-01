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

namespace WpfList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //List<TodoItem> items = new List<TodoItem>();
            //items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 });
            //items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            //items.Add(new TodoItem() { Title = "Go to shop", Completion = 100 });
            //items.Add(new TodoItem() { Title = "Buy stuff", Completion = 10 });
            //TodoListBox.ItemsSource = items;
            List<NamesAndAges> people = new List<NamesAndAges>();
            people.Add(new NamesAndAges() { FirstName = "Jef", LastName = "Macaroni", Age = 12 });
            people.Add(new NamesAndAges() { FirstName = "Ron", LastName = "Weasly", Age = 65 });
            people.Add(new NamesAndAges() { FirstName = "Jeb", LastName = "Notsi", Age = 23 });
            people.Add(new NamesAndAges() { FirstName = "Svenski", LastName = "Fanne", Age = 16 });
            NamesAndAgesListBox.ItemsSource = people;
        }
    }
    public class TodoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }
    }
    public class NamesAndAges
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
