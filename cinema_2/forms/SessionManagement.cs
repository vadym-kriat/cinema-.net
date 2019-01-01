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

namespace cinema_2.forms
{
    public partial class SessionManagement : Form
    {
        private SessionPersistance sessionPersistance;
        private FilmPersistence filmPersistance;
        private RoomPersistence roomPersistence;

        public SessionManagement()
        {
            InitializeComponent();
            sessionPersistance = new SessionPersistance();
            filmPersistance = new FilmPersistence();
            roomPersistence = new RoomPersistence();
            LoadAllSessions();
            LoadRoomList();
            LoadFilmList();
        }

        private void LoadRoomList()
        {
            cbRoom.Items.Clear();
            cbRoom.Items.AddRange(roomPersistence.FindAll().ToArray());
        }

        private void LoadFilmList()
        {
            cbFilm.Items.Clear();
            cbFilm.Items.AddRange(filmPersistance.FindAll().ToArray());
        }

        private void AddSession(object sender, EventArgs e)
        {
            LoadAllSessions();
        }

        private void LoadAllSessions()
        {
            List<Session> sessions = sessionPersistance.FindAll();
            dgvSessions.DataSource = sessions.Select(s => new SessionRow
            {
                Id = s.Id,
                FilmName = s.Film.Name,
                RoomName = s.Room.Name,
                DateTime = s.DateTime
            }).OrderBy(sr => sr.FilmName).ToList();
        }
    }

    class SessionRow
    {
        public long Id { get; set; }
        public string FilmName { get; set; }
        public string RoomName { get; set; }
        public DateTime DateTime { get; set; }
    }
}
