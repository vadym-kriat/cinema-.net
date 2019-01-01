using System;
using System.Windows.Forms;
using cinema_2.models;
using cinema_2.services;

namespace cinema_2.forms.components
{
    public class FilmView : TableLayoutPanel
    {
        public FilmView(Film film) : base()
        {
            ColumnCount = 1;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            RowCount = 5;
            RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));

            Dock = DockStyle.Fill;
            if (film != null)
            {
                Controls.Add(GetNameLabel(film.Name), 0, 0);
                Controls.Add(GetGenreLabel(film.Genre), 0, 1);
                Controls.Add(GetFirstPerformanceLabel(film.FirstPerformance), 0, 2);
                Controls.Add(GetDescriprionTextBox(film.Description), 0, 3);
                Controls.Add(GetBookButton(), 0, 4);
            }
        }

        private Label GetNameLabel(string name)
        {
            Label label = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(0, 0),
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
                Location = new System.Drawing.Point(0, 30),
                Text = "Жанр: " + genre
            };
            return label;
        }

        private Label GetFirstPerformanceLabel(DateTime date)
        {
            Label label = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(0, 30),
                Text = "Премьера: " + date.ToString("dd MMMM yyyy")
            };
            return label;
        }

        private TextBox GetDescriprionTextBox(string descriprion)
        {
            TextBox tbDescription = new TextBox
            {
                Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
                | AnchorStyles.Left) | AnchorStyles.Right))),
                BorderStyle = BorderStyle.None,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Margin = new Padding(7, 0, 0, 0),
                Multiline = true,
                Enabled = false,
                ForeColor = System.Drawing.SystemColors.ControlDarkDark,
                Height = 200,
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
                Location = new System.Drawing.Point(360, 200),
                Size = new System.Drawing.Size(130, 26),
                TabIndex = 2,
                Text = "Забронировать",
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

    public class ImageFilmViewer : TableLayoutPanel
    {
        public ImageFilmViewer(Film film) : base()
        {
            BorderStyle = BorderStyle.Fixed3D;
            ColumnCount = 2;
            ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            RowCount = 1;
            RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Height = 300;
            Dock = DockStyle.Top;

            PictureBox picture = new PictureBox() {
                BackColor = System.Drawing.SystemColors.Control,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = ImageService.ByteArrayToImage(film.Image),
                TabStop = false
            };

            Controls.Add(picture, 0, 0);
            Controls.Add(new FilmView(film), 1, 0);
        }
    }

    public class NotFoundPanelComponent : Panel
    {
        public NotFoundPanelComponent() : base()
        {
            Dock = DockStyle.Fill;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(GetNotFoundLabel());
        }

        private Label GetNotFoundLabel()
        {
            Label label = new Label()
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Name = "lbl",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                TabIndex = 0,
                Text = "Ничего не найдено."
            };
            return label;
        }
    }
}
