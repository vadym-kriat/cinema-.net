using System;
using System.IO;
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
using cinema_2.forms.messages;
using cinema_2.services;

namespace cinema_2
{
    public partial class EditFilmModal : Form
    {
        private FilmPersistence _filmPersistence;
        private long id;
        private static readonly int MAX_HEIGHT = 500;

        public EditFilmModal()
        {
            InitializeComponent();
            _filmPersistence = new FilmPersistence();
            ShowNotImageLoadedLabel();
        }

        public void SaveFilm(Film film)
        {
            id = film.Id;
            Image test = ImageService.ByteArrayToImage(film.Image);
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
                    Type = txtFormat.Text,
                    Image = ImageService.ImageToByteArray(pbImage.Image)
                };
                if (id != 0)
                {
                    film.Id = id;
                }
                _filmPersistence.Save(film);
                this.Cancel(sender, e);
            } catch (UpdateExceptions ex)
            {
                MessageBoxManager.Error("Save film error", ex.Message);
            } catch (FormatException ex)
            {
                MessageBoxManager.Exclamation("Invalid data", ex.Message);
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
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
                pbImage.Image = ImageService.ByteArrayToImage(film.Image);
                ShowPictureBox();
            }
        }

        private void OpenFileExplorer(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Открыть изображение",
                Filter = "Image Files(*.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = OpenAndResize(ofd.FileName);
                ShowPictureBox();
            }
        }

        private void ClearPictureBox(object sender, EventArgs e)
        {
            pbImage.Image = null;
            ShowNotImageLoadedLabel();
        }

        private void ShowPictureBox()
        {
            tlpImage.Controls.Remove(tlpImage.GetControlFromPosition(0, 0));
            tlpImage.Controls.Add(pbImage, 0, 0);
        }

        private void ShowNotImageLoadedLabel()
        {
            Label label = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new Point(0, 14),
                ForeColor = Color.DarkGray,
                Name = "lblNotImageLoaded",
                TextAlign = ContentAlignment.MiddleCenter,
                TabIndex = 0,
                Text = "Изображение не выбрано"
            };
            tlpImage.Controls.Remove(tlpImage.GetControlFromPosition(0, 0));
            tlpImage.Controls.Add(label, 0, 0);
        }

        private Bitmap OpenAndResize(string fileName)
        {
            Bitmap source = new Bitmap(fileName);
            float ratio = MAX_HEIGHT / source.Height;
            if (ratio != 0)
            {
                return new Bitmap(source, (int) (source.Width * ratio), (int) (source.Height * ratio));
            }
            return source;
        }
    }
}
