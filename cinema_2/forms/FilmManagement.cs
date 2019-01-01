using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cinema_2.forms;
using cinema_2.models;
using cinema_2.db.persistence;

namespace cinema_2.forms
{
    public partial class FilmManagement : Form
    {
        private FilmPersistence _filmPersistence;

        public FilmManagement()
        {
            InitializeComponent();
            _filmPersistence = new FilmPersistence();
            UpdateTable();
        }

        private void CreateFilm(object sender, EventArgs e)
        {
            EditFilmModal modal = new EditFilmModal();
            modal.ShowDialog();
            UpdateTable();
        }

        private void RemoveFilm(object sender, EventArgs e)
        {
            Film film = (Film) dgvFilms.CurrentRow.DataBoundItem;
            _filmPersistence.Remove(film);
            UpdateTable();
        }

        private void EditFilm(object sender, EventArgs e)
        {
            EditFilmModal modal = new EditFilmModal();
            Film film = (Film)dgvFilms.CurrentRow.DataBoundItem;
            modal.SaveFilm(film);
            modal.ShowDialog();
            UpdateTable();
        }

        private void UpdateTable()
        {
            dgvFilms.DataSource = _filmPersistence.FindAll();
        }
    }
}
