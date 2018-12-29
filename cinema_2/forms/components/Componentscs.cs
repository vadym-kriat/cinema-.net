using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cinema_2.models;
using cinema_2.forms;

namespace cinema_2.forms.components
{
    public class FilmView : Panel
    {
        public FilmView(Film film, int i) : base()
        {
            Size = new System.Drawing.Size(500, 236);
            BackColor = System.Drawing.SystemColors.Control;
            Dock = DockStyle.Top;
            BorderStyle = BorderStyle.FixedSingle;
            Padding = new System.Windows.Forms.Padding(10);
            if (film != null)
            {
                Controls.Add(GetBookButton());
                Controls.Add(GetNameLabel(film.Name));
                Controls.Add(GetGenreLabel(film.Genre));
                Controls.Add(GetDescriprionTextBox(film.Description));
            }
        }

        private Label GetNameLabel(string name)
        {
            Label label = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(5, 5),
                Name = "lblName",
                TabIndex = 0,
                Text = name
            };
            return label;
        }

        private Label GetGenreLabel(string genre)
        {
            Label label = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(5, 40),
                Name = "lblGenre",
                TabIndex = 0,
                Text = "Genre: " + genre
            };
            return label;
        }

        private TextBox GetDescriprionTextBox(string descriprion)
        {
            TextBox tbDescription = new TextBox
            {
                Anchor = (AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom)),
                BorderStyle = BorderStyle.None,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(8, 70),
                Multiline = true,
                Enabled = false,
                Name = "txtDescription",
                ForeColor = System.Drawing.SystemColors.ControlDarkDark,
                ReadOnly = true,
                Size = new System.Drawing.Size(480, 120),
                TabIndex = 1,
                Text = descriprion
            };
            return tbDescription;
        }

        private Button GetBookButton()
        {
            Button button = new Button
            {
                Anchor = (AnchorStyles)((AnchorStyles.Right | AnchorStyles.Bottom)),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(390, 200),
                Name = "btnBook",
                Size = new System.Drawing.Size(100, 26),
                TabIndex = 2,
                Text = "Book",
                UseVisualStyleBackColor = true
            };
            button.Click += new EventHandler(Book);
            return button;
        }

        private void Book(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.ShowDialog();
        }
    }
}
