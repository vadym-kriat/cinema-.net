using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cinema_2.db.persistence;
using cinema_2.models;
using cinema_2.services;
using cinema_2.forms;
using cinema_2.forms.components;

namespace cinema_2
{
    public partial class MainForm : Form
    {
        private FilmPersistence filmPersistance;

        public MainForm()
        {
            InitializeComponent();
            filmPersistance = new FilmPersistence();
            UpdateFilmList(filmPersistance.FindAll());
        }

        private void FindAllFilms(object sender, EventArgs e)
        {
            RoomPersistence fp = new RoomPersistence();
            List<Room> rooms = fp.FindAll();
            foreach (Room room in rooms)
            {
                Console.WriteLine(room);
                foreach (var row in room.Rows)
                {
                    Console.WriteLine(row);
                }
            }
        }

        private void Save(object sender, EventArgs e)
        {
            /*Room film = new Room();
            film.Name = "Blue";
            for (int i = 0; i < 10; i++)
            {
                film.AddRow(new Row()
                {
                    Seats = 10,
                    Number = i + 1
                });
            }
            new RoomPersistence().Save(film);*/
        }

        private void OpenFilmManagementWindow(object sender, EventArgs e)
        {
            FilmManagement fmm = new FilmManagement();
            fmm.ShowDialog();
            UpdateFilmList(filmPersistance.FindAll());
        }

        private void SessionManagement(object sender, EventArgs e)
        {
            
        }

        private void UpdateFilmList(List<Film> films)
        {
            pFilmContainer.Controls.Clear();

            if (films.Count == 0)
            {
                pFilmContainer.Controls.Add(new NotFoundPanelComponent());
            }

            for (int i = 0; i < films.Count; i++)
            {
                FilmView view = new FilmView(films[i], i);
                pFilmContainer.Controls.Add(view);
            }
        }

        private void Search(object sender, EventArgs e)
        {
            UpdateFilmList(filmPersistance.FindByName(txtSearch.Text));
        }

        private void SearchByEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Prevent 'Beep'
                e.Handled = true;
                Search(sender, e);
            }
        }
    }
}
