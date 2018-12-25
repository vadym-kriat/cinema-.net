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

namespace cinema_2.forms
{
    public partial class FilmManagementModal : Form
    {
        private EditFilmModal _editFilmModal;

        public FilmManagementModal()
        {
            InitializeComponent();
            _editFilmModal = new EditFilmModal();
        }

        private void CreateFilm(object sender, EventArgs e)
        {
            _editFilmModal.SaveFilm(new Film());
            _editFilmModal.ShowDialog();
        }
    }
}
