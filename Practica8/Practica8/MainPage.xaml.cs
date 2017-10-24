using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using System.Collections.ObjectModel;

namespace Practica8
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Formulario> Items { get; set; }
        SQLiteConnection database;

        public MainPage()
        {
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("SQLite.db3");
            database = new SQLiteConnection(db);
            database.CreateTable<Formulario>();
            Items = new ObservableCollection<Formulario>(database.Table<Formulario>());
            BindingContext = this;
        }

        private void Button_Insertar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new InsertPage());
        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushModalAsync(new SelectPage(e.SelectedItem as Formulario));
        }
    }
}
