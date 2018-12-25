using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cinema_2.db.persistence;
using cinema_2.models;
using cinema_2.services;
using cinema_2.forms;

namespace cinema_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FindAllFilms(object sender, EventArgs e)
        {
            RoomPersistence fp = new RoomPersistence();
            List<Room> rooms = fp.FindAll();
            foreach (Room room in rooms)
            {
                Console.WriteLine(room);
                foreach (var row in room.Rows)
                {
                    Console.WriteLine(row);
                }
            }
        }

        private void Save(object sender, EventArgs e)
        {
            Room film = new Room();
            film.Name = "Blue";
            for (int i = 0; i < 10; i++)
            {
                film.AddRow(new Row()
                {
                    Seats = 10,
                    Number = i + 1
                });
            }
            new RoomPersistence().Save(film);
        }

        private void FilmManagement(object sender, EventArgs e)
        {
            FilmManagementModal fmm = new FilmManagementModal();
            fmm.Show();
        }

        private void SessionManagement(object sender, EventArgs e)
        {
            
            /*try
            {
                new BookingService().Book(1, 1, 12, 12);
            } catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Important Note",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }*/
        }
    }
}
