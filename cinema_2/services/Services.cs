﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cinema_2.db.persistence;
using cinema_2.models;

namespace cinema_2.services
{
    class BookingService
    {
        private BookingPersistance _bookingPersistance;
        private SessionPersistance _sessionPersistance;
        private CustomerPersistance _customerPersistance;

        public BookingService()
        {
            _sessionPersistance = new SessionPersistance();
            _customerPersistance = new CustomerPersistance();
            _bookingPersistance = new BookingPersistance();
        }

        public Booking Book(long sessionId, long customerId, int row, int seat)
        {
            Session session = _sessionPersistance.FindById(sessionId);
            Customer customer = _customerPersistance.FindById(customerId);

            if (session == null)
            {
                throw new Exception("Session doesn't exist");
            }
            if (customer == null)
            {
                throw new Exception("Customer doesn't exist");
            }

            Booking booking = _bookingPersistance.FindBySessionAndSeats(sessionId, row, seat);

            if (booking != null)
            {
                throw new Exception("This seat is already booked!");
            }

            Row targetRow = session.Room.GetRowByNumber(row);
            if (targetRow == null || targetRow.Seats < seat)
            {
                throw new Exception("This seat doesn't exist!");
            }

            Booking b = new Booking() {
                SessionId = session.Id,
                Session = session,
                CustomerId = customer.Id,
                Customer = customer,
                Row = row,
                Seat = seat
            };

            return _bookingPersistance.Save(b);
        }
    }
}