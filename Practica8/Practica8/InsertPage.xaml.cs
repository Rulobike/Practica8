using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace Practica8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertPage : ContentPage
    {
        SQLiteConnection database;
        string piker;
        string piker1;
        public InsertPage()
        {

            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("SQLite.db3");
            database = new SQLiteConnection(db);
        }

        private void Button_Insertar_Clicked(object sender, EventArgs e)
        {
            var datos = new Formulario
            {
                Id = Entry_Matricula.Text,
                Nombre = Entry_Nombre.Text,
                Apellidos = Entry_Apellido.Text,
                Direccion = Entry_Direccion.Text,
                Telefono = Entry_Telefono.Text,
                Carrera = piker,
                Semestre = piker1,
                Correo = Entry_Correo.Text,
                Github = Entry_GitHub.Text
            };
            database.Insert(datos);
            Navigation.PushModalAsync(new MainPage());
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectIndex = picker.SelectedIndex;
            if (selectIndex != -1)
            {
                piker = (string)picker.ItemsSource[selectIndex];
            }
        }

        private void Picker_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectIndex = picker.SelectedIndex;
            if (selectIndex != -1)
            {
                piker1 = (string)picker.ItemsSource[selectIndex];
            }

        }
    }
}