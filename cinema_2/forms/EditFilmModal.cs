using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cinema_2.models;
using cinema_2.db.persistence;

namespace cinema_2
{
    public partial class EditFilmModal : Form
    {
        private Film _film;

        public EditFilmModal()
        {
            InitializeComponent();
            _film = new Film();
            FillFields();
        }

        public void SaveFilm(Film film)
        {
            if (film != null)
            {
                _film = film;
            }
            FillFields();
        }

        private void Save(object sender, EventArgs e)
        {

        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Hide();
            ClearFields();
        }

        private void FillFields()
        {
            txtName.Text = _film.Name;
            txtDescription.Text = _film.Description;
            numDuration.Value = _film.Duration;
            dateFirstPerformance.Value = _film.FirstPerformance;
            txtCountry.Text = _film.Country;
            txtGenre.Text = _film.Genre;
            txtCost.Text = _film.Cost.ToString();
            txtFormat.Text = _film.Type;
        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            numDuration.Value = 0;
            dateFirstPerformance.Value = DateTime.Now;
            txtCountry.Text = "";
            txtGenre.Text = "";
            txtCost.Text = "";
            txtFormat.Text = "";
        }
    }
}
