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
        private List<Seat> bookedSeats;
        private Session currentSession;

        private readonly static Dictionary<Label, string> lableMap = new Dictionary<Label, string>();

        public BookingForm()
        {
            InitializeComponent();
            sessionPersistance = new SessionPersistance();
            bookingPersistance = new BookingPersistance();
            sessions = new List<Session>();
            bookedSeats = new List<Seat>();

            lableMap.Add(lblOneTicketCost, "Стоимость одного билета");
            lableMap.Add(lblAllTicketsCost, "Сумма");
            lableMap.Add(lblDateTime, "Сеанс");
            lableMap.Add(lblType, "Тип");
        }

        public void SaveFilm(Film film)
        {
            this.film = film;
            lblFilmName.Text = this.film.Name;
            
            LoadAllFilmSessions();
            UpdateAllInfo();
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
            RoomView roomView = new RoomView(room, new EventHandler(ClickOnSeat));
            roomView.SetBookedSeats(bookingPersistance.FindAllBySessionId(currentSession.Id));

            pSeats.Controls.Clear();
            pSeats.Controls.Add(roomView);
        }

        private void UpdateOneTicketCost()
        {
            float c = 0;
            if (currentSession != null)
            {
                c = currentSession.Film.Cost;
            }

            lblOneTicketCost.Text = lableMap[lblOneTicketCost] + $" {c}";
        }

        private void UpdateAllTicketsCost()
        {
            float c = 0;
            if (currentSession != null)
            {
                c = bookedSeats.Count * currentSession.Film.Cost;
            }

            lblAllTicketsCost.Text = lableMap[lblAllTicketsCost] + $" {c}";
        }

        private void UpdateDateTimeSession()
        {
            string date = "";
            if (currentSession != null)
            {
                date = currentSession.DateTime.ToString("dd.MM.yyyy HH:mm");
            }

            lblDateTime.Text = lableMap[lblDateTime] + $" {date}";
        }

        private void UpdateType()
        {
            string type = "";
            if (currentSession != null)
            {
                type = currentSession.Film.Type;
            }

            lblType.Text = lableMap[lblType] + $" {type}";
        }

        private void UpdateAllInfo()
        {
            bookedSeats.Clear();
            UpdateOneTicketCost();
            UpdateAllTicketsCost();
            UpdateDateTimeSession();
            UpdateType();
        }
        
        private void ChangeSelectedItem(object sender, EventArgs e)
        {
            if (dgvSessions.CurrentRow != null)
            {
                SessionRow sessionRow = (SessionRow)dgvSessions.CurrentRow.DataBoundItem;
                Session session = sessions.Find(s => s.Id == sessionRow.Id);

                currentSession = session;
                LoadRoomView(session.Room);

                UpdateAllInfo();
            }
        }

        private void ClickOnSeat(object sender, EventArgs e)
        {
            SeatView sw = (SeatView)sender;
            Seat seat = new Seat
            {
                Number = sw.Number(),
                Row = sw.Row()
            };
            
            if (bookedSeats.Contains(seat))
            {
                bookedSeats.Remove(seat);
            } else
            {
                bookedSeats.Add(seat);
            }

            UpdateAllTicketsCost();
        }

        private void Buy(object sender, EventArgs e)
        {
            messages.MessageBoxManager.Exclamation("Count", bookedSeats.Count.ToString());
        }

        private class SessionRow
        {
            public long Id { get; set; }
            public string RoomName { get; set; }
            public DateTime DateTime { get; set; }
        }

        private class Seat
        {
            public int Row { get; set;  }
            public int Number { get; set; }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (obj.GetType() != this.GetType())
                {
                    return false;
                }
                Seat o = (Seat)obj;

                return o.Row == Row && o.Number == Number;
            }

            public override int GetHashCode()
            {
                return Row + Number;
            }
        }
    }
}
