using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace Library
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        LibraryEntities lB = new LibraryEntities();
        public Page1()
        {
            InitializeComponent();
            datagridd.ItemsSource = lB.Authors.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Author author = new Author();
            author.AuthorID = int.Parse(idt.Text);
            author.AuthorName = namet.Text;
            lB.Authors.Add(author);
            lB.SaveChanges();
            datagridd.ItemsSource = lB.Authors.ToList();
            MessageBox.Show("add data done ");

        }

        private void updet_Click(object sender, RoutedEventArgs e)
        {
            Author rec = new Author();
            int id = int.Parse(idt.Text);
            rec = lB.Authors.First(x => x.AuthorID == id);
            rec.AuthorName = namet.Text;

            lB.Authors.AddOrUpdate(rec);
            lB.SaveChanges();
            MessageBox.Show("data updated!");

            datagridd.ItemsSource = lB.Authors.ToList();

        }

        private void deleted_Click(object sender, RoutedEventArgs e)
        {
            Author author = new Author();
            int id = int.Parse(idt.Text);
            author = lB.Authors.Remove(lB.Authors.First(x => x.AuthorID == id));
            lB.Authors.Remove(author);
            lB.SaveChanges();
            datagridd.ItemsSource = lB.Authors.ToList();
            MessageBox.Show($"data for ID:{id} is deleted");
        }
    }
}
