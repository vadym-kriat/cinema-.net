using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using cinema_2.models;
using cinema_2.db.persistence;
using cinema_2.exceptions;

namespace cinema_2
{
    public partial class EditFilmModal : Form
    {
        private FilmPersistence _filmPersistence;
        private long id;

        public EditFilmModal()
        {
            InitializeComponent();
            _filmPersistence = new FilmPersistence();
        }

        public void SaveFilm(Film film)
        {
            id = film.Id;
            FillFields(film);
        }

        private void Save(object sender, EventArgs e)
        {
            try
            {
                Film film = new Film()
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Duration = (int)numDuration.Value,
                    FirstPerformance = dateFirstPerformance.Value,
                    Country = txtCountry.Text,
                    Genre = txtGenre.Text,
                    Cost = float.Parse(txtCost.Text),
                    Type = txtFormat.Text
                };
                if (id != 0)
                {
                    film.Id = id;
                }
                _filmPersistence.Save(film);
                this.Cancel(sender, e);
            } catch (UpdateExceptions ex)
            {
                MessageBox.Show(
                   ex.Message,
                   "Save film error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            } catch (FormatException ex)
            {
                MessageBox.Show(
                   ex.Message,
                   "Invalid data",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation,
                   MessageBoxDefaultButton.Button1);
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Hide();
            id = 0;
            ClearFields();
        }

        private void FormVisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                id = 0;
                ClearFields();
            }
        }

        private void FillFields(Film film)
        {
            if (film != null)
            {
                txtName.Text = film.Name;
                txtDescription.Text = film.Description;
                numDuration.Value = film.Duration;
                dateFirstPerformance.Value = film.FirstPerformance;
                txtCountry.Text = film.Country;
                txtGenre.Text = film.Genre;
                txtCost.Text = film.Cost.ToString();
                txtFormat.Text = film.Type;
            }
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
