using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cinema_2.models;
using cinema_2.services;
using cinema_2.db.persistence;
using cinema_2.forms.messages;

namespace cinema_2.forms
{
    public partial class BuyForm : Form
    {
        private List<Seat> seats;
        private Session session;
        private static readonly Regex PHONE_REGEX = new Regex(@"^\d{10}$");

        private CustomerPersistance customerPersistance;
        private BookingPersistance bookingPersistance;

        public BuyForm()
        {
            InitializeComponent();

            seats = new List<Seat>();
            customerPersistance = new CustomerPersistance();
            bookingPersistance = new BookingPersistance();

            UpdateInfo();
        }

        public void SetInfo(List<Seat> seats, Session session)
        {
            if (seats != null)
            {
                this.seats = seats;
            }
            this.session = session;
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            if (session != null)
            {
                lblSum.Text = (seats.Count * session.Film.Cost).ToString();
                lblTicketCount.Text = seats.Count.ToString();
            }
        }

        private bool ValidateFormFields()
        {
            if (tbFirstName.Text.Length == 0)
            {
                MessageBoxManager.Exclamation("Неверные данные", "Поле 'Имя' является обязятельным.");
                return false;
            }

            if (tbLastName.Text.Length == 0)
            {
                MessageBoxManager.Exclamation("Неверные данные", "Поле 'Фамилия' является обязятельным.");
                return false;
            }

            if (tbPhone.Text.Length < 10)
            {
                MessageBoxManager.Exclamation("Неверные данные", "Неверный номер телефона.");
                return false;
            }

            return true;
        }

        private void Buy(object sender, EventArgs e)
        {
            bool isValid = ValidateFormFields();

            if (isValid)
            {
                Customer customer = new Customer {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Phone = tbPhone.Text
                };
                customerPersistance.Save(customer);

                foreach (var seat in seats)
                {
                    Booking ticket = new Booking
                    {
                        CustomerId = customer.Id,
                        Customer = customer,
                        SessionId = session.Id,
                        Session = session,
                        Row = seat.Row,
                        Seat = seat.Number
                    };

                    bookingPersistance.Save(ticket);
                    PDFFileService.SaveTicketToPDF(ticket);
                }

                MessageBoxManager.Info("Бронирование", "Места успешно забронированы!");
                Close();
            }
        }
    }
}
