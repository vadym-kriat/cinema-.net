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
using cinema_2.forms.components;

namespace cinema_2.forms
{
    public partial class BookingForm : Form
    {
        private Film film;
        private SessionPersistance sessionPersistance;
        private BookingPersistance bookingPersistance;
        private List<Session> sessions;
        private Session currentSession;

        private readonly static Dictionary<Label, string> lableMap = new Dictionary<Label, string>();

        public BookingForm()
        {
            InitializeComponent();
            sessionPersistance = new SessionPersistance();
            bookingPersistance = new BookingPersistance();
            sessions = new List<Session>();

            lableMap.Add(lblOneTicketCost, "Стоимость одного билета");
            lableMap.Add(lblAllTicketsCost, "Сумма");
            lableMap.Add(lblDateTime, "Сеанс");
            lableMap.Add(lblType, "Тип");
        }

        public void SaveFilm(Film film)
        {
            this.film = film;
            lblFilmName.Text = this.film.Name;

            SetOneTicketCost(film.Cost);
            SetAllTicketsCost(0.0F);
            SetType(film.Type);

            LoadAllFilmSessions();
        }

        private void LoadAllFilmSessions()
        {
            sessions = sessionPersistance.FindAllByFilmId(film.Id);

            if (sessions.Count != 0)
            {
                dgvSessions.DataSource = sessions.Select(s => new SessionRow
                {
                    Id = s.Id,
                    RoomName = s.Room.Name,
                    DateTime = s.DateTime
                }).OrderBy(sr => sr.DateTime).ToList();

                currentSession = sessions.First();
                LoadRoomView(currentSession.Room);
            }
        }

        private void LoadRoomView(Room room)
        {
            RoomView roomView = new RoomView(room);
            roomView.SetBookedSeats(bookingPersistance.FindAllBySessionId(currentSession.Id));

            pSeats.Controls.Clear();
            pSeats.Controls.Add(roomView);
        }

        private void SetOneTicketCost(float cost)
        {
            lblOneTicketCost.Text = lableMap[lblOneTicketCost] + $" {cost}";
        }

        private void SetAllTicketsCost(float sum)
        {
            lblAllTicketsCost.Text = lableMap[lblAllTicketsCost] + $" {sum}";
        }

        private void SetDateTimeSession(DateTime date)
        {
            lblDateTime.Text = lableMap[lblDateTime] + $" {date}";
        }

        private void SetType(string type)
        {
            lblType.Text = lableMap[lblType] + $" {type}";
        }
        
        private void ChangeSelectedItem(object sender, EventArgs e)
        {
            if (dgvSessions.CurrentRow != null)
            {
                SessionRow sessionRow = (SessionRow)dgvSessions.CurrentRow.DataBoundItem;
                Session session = sessions.Find(s => s.Id == sessionRow.Id);

                currentSession = session;
                LoadRoomView(session.Room);
            }
        }

        private class SessionRow
        {
            public long Id { get; set; }
            public string RoomName { get; set; }
            public DateTime DateTime { get; set; }
        }
    }
}
