using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPage : ContentPage
    {
        string dato2;
        string dato1;
        SQLiteConnection database;
        public SelectPage(object SelectedItem)
        {
            InitializeComponent();
            var dato = SelectedItem as Formulario;
            BindingContext = dato;
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("SQLite.db3");
            database = new SQLiteConnection(db);
        }

        private void Button_Actualizar_Clicked(object sender, EventArgs e)
        {
            var datos = new Formulario
            {
                Id = Entry_Matricula.Text,
                Nombre = Entry_Nombre.Text,
                Apellidos = Entry_Apellido.Text,
                Direccion = Entry_Direccion.Text,
                Telefono = Entry_Telefono.Text,
                Carrera = dato1,
                Semestre = dato2,
                Correo = Entry_Correo.Text,
                Github = Entry_GitHub.Text
            };
            database.Update(datos);
            Navigation.PushModalAsync(new MainPage());
        }

        private void Button_Eliminar_Clicked(object sender, EventArgs e)
        {
            var datos = new Formulario
            {
                Id = Entry_Matricula.Text,
                Nombre = Entry_Nombre.Text,
                Apellidos = Entry_Apellido.Text,
                Direccion = Entry_Direccion.Text,
                Telefono = Entry_Telefono.Text,
                Carrera = dato1,
                Semestre = dato2,
                Correo = Entry_Correo.Text,
                Github = Entry_GitHub.Text
            };
            database.Delete(datos);
            Navigation.PushModalAsync(new MainPage());

        }

        private void piker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectIndex = picker.SelectedIndex;
            if (selectIndex != -1)
            {
                dato1 = (string)picker.ItemsSource[selectIndex];
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {

            var picker = (Picker)sender;
            int selectIndex = picker.SelectedIndex;
            if (selectIndex != -1)
            {
                dato2 = (string)picker.ItemsSource[selectIndex];
            }

        }
    }
}