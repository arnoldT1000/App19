using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using Xamarin.Essentials;
using SQLite;

namespace App19
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public MainPage()
        {
            InitializeComponent();
            var FilePath = Path.Combine(FileSystem.AppDataDirectory, "mydb.db");

            using (SQLiteConnection conn = new SQLiteConnection(FilePath))
            {
                conn.CreateTable<Contact>();
                //int rowsAdded = conn.Insert(contact); 
                var contacts = conn.Table<Contact>().ToList();
                contactsListView.ItemsSource = contacts;


            }
        }

        

        
    }
}
