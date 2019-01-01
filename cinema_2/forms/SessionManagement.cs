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
using cinema_2.forms.messages;

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

        private void RemoveSession(object sender, EventArgs e)
        {
            SessionRow sessionRow = (SessionRow)dgvSessions.CurrentRow.DataBoundItem;
            Session session = sessionPersistance.FindById(sessionRow.Id);
            sessionPersistance.Remove(session);
            LoadAllSessions();
        }

        private void AddSession(object sender, EventArgs e)
        {
            Film film = (Film)cbFilm.SelectedItem;
            Room room = (Room)cbRoom.SelectedItem;
            DateTime date = dtpDate.Value;
            TimeSpan time = dtpTime.Value.TimeOfDay;

            if (film == null || room == null)
            {
                MessageBoxManager.Exclamation("Invalid data", "Chose film and room.");
                return;
            }

            sessionPersistance.Save(new Session() {
                FilmId = film.Id,
                RoomId = room.Id,
                DateTime = date.Date + time
            });
            LoadAllSessions();
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
