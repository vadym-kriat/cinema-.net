namespace cinema_2.forms
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.tblContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pSubDgv = new System.Windows.Forms.Panel();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pInfo = new System.Windows.Forms.Panel();
            this.tblInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblAllTicketsCost = new System.Windows.Forms.Label();
            this.lblOneTicketCost = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pSeats = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblContainer.SuspendLayout();
            this.pSubDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.pInfo.SuspendLayout();
            this.tblInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilmName
            // 
            this.lblFilmName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilmName.Location = new System.Drawing.Point(0, 0);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(904, 40);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.Text = "Фильм";
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblContainer
            // 
            this.tblContainer.BackColor = System.Drawing.SystemColors.Control;
            this.tblContainer.ColumnCount = 3;
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblContainer.Controls.Add(this.pSubDgv, 0, 0);
            this.tblContainer.Controls.Add(this.pInfo, 2, 0);
            this.tblContainer.Controls.Add(this.panel3, 1, 0);
            this.tblContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContainer.Location = new System.Drawing.Point(10, 0);
            this.tblContainer.Name = "tblContainer";
            this.tblContainer.RowCount = 1;
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblContainer.Size = new System.Drawing.Size(884, 381);
            this.tblContainer.TabIndex = 1;
            // 
            // pSubDgv
            // 
            this.pSubDgv.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pSubDgv.Controls.Add(this.dgvSessions);
            this.pSubDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSubDgv.Location = new System.Drawing.Point(3, 3);
            this.pSubDgv.Name = "pSubDgv";
            this.pSubDgv.Padding = new System.Windows.Forms.Padding(1);
            this.pSubDgv.Size = new System.Drawing.Size(244, 375);
            this.pSubDgv.TabIndex = 1;
            // 
            // dgvSessions
            // 
            this.dgvSessions.AllowUserToAddRows = false;
            this.dgvSessions.AllowUserToDeleteRows = false;
            this.dgvSessions.AllowUserToOrderColumns = true;
            this.dgvSessions.AllowUserToResizeRows = false;
            this.dgvSessions.AutoGenerateColumns = false;
            this.dgvSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSessions.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Room,
            this.DateTime});
            this.dgvSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSessions.Location = new System.Drawing.Point(1, 1);
            this.dgvSessions.MultiSelect = false;
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvSessions.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessions.Size = new System.Drawing.Size(242, 373);
            this.dgvSessions.TabIndex = 0;
            this.dgvSessions.SelectionChanged += new System.EventHandler(this.ChangeSelectedItem);
            // 
            // Room
            // 
            this.Room.DataPropertyName = "RoomName";
            this.Room.HeaderText = "Комната";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.Width = 94;
            // 
            // DateTime
            // 
            this.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.HeaderText = "Время";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // pInfo
            // 
            this.pInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pInfo.Controls.Add(this.tblInfo);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfo.Location = new System.Drawing.Point(637, 3);
            this.pInfo.Name = "pInfo";
            this.pInfo.Padding = new System.Windows.Forms.Padding(1);
            this.pInfo.Size = new System.Drawing.Size(244, 375);
            this.pInfo.TabIndex = 3;
            // 
            // tblInfo
            // 
            this.tblInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tblInfo.ColumnCount = 1;
            this.tblInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInfo.Controls.Add(this.lblDateTime, 0, 2);
            this.tblInfo.Controls.Add(this.lblAllTicketsCost, 0, 1);
            this.tblInfo.Controls.Add(this.lblOneTicketCost, 0, 0);
            this.tblInfo.Controls.Add(this.lblType, 0, 3);
            this.tblInfo.Controls.Add(this.panel2, 0, 4);
            this.tblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInfo.Location = new System.Drawing.Point(1, 1);
            this.tblInfo.Name = "tblInfo";
            this.tblInfo.RowCount = 6;
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInfo.Size = new System.Drawing.Size(242, 373);
            this.tblInfo.TabIndex = 2;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateTime.Location = new System.Drawing.Point(3, 80);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(236, 40);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "Сеанс";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAllTicketsCost
            // 
            this.lblAllTicketsCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllTicketsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllTicketsCost.Location = new System.Drawing.Point(3, 40);
            this.lblAllTicketsCost.Name = "lblAllTicketsCost";
            this.lblAllTicketsCost.Size = new System.Drawing.Size(236, 40);
            this.lblAllTicketsCost.TabIndex = 2;
            this.lblAllTicketsCost.Text = "Сумма";
            this.lblAllTicketsCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOneTicketCost
            // 
            this.lblOneTicketCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOneTicketCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOneTicketCost.Location = new System.Drawing.Point(3, 0);
            this.lblOneTicketCost.Name = "lblOneTicketCost";
            this.lblOneTicketCost.Size = new System.Drawing.Size(236, 40);
            this.lblOneTicketCost.TabIndex = 0;
            this.lblOneTicketCost.Text = "Стоимость одного билета";
            this.lblOneTicketCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.Location = new System.Drawing.Point(3, 120);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(236, 40);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Тип";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBuy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 34);
            this.panel2.TabIndex = 6;
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(116, 3);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(120, 26);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "Купить";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.Buy);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.pSeats);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(253, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1);
            this.panel3.Size = new System.Drawing.Size(378, 375);
            this.panel3.TabIndex = 4;
            // 
            // pSeats
            // 
            this.pSeats.AutoScroll = true;
            this.pSeats.BackColor = System.Drawing.SystemColors.Control;
            this.pSeats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSeats.Location = new System.Drawing.Point(1, 1);
            this.pSeats.Name = "pSeats";
            this.pSeats.Padding = new System.Windows.Forms.Padding(10);
            this.pSeats.Size = new System.Drawing.Size(376, 373);
            this.pSeats.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel1.Size = new System.Drawing.Size(904, 391);
            this.panel1.TabIndex = 2;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFilmName);
            this.MinimumSize = new System.Drawing.Size(920, 470);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бронирование";
            this.tblContainer.ResumeLayout(false);
            this.pSubDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.pInfo.ResumeLayout(false);
            this.tblInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.TableLayoutPanel tblContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.Panel pSubDgv;
        private System.Windows.Forms.TableLayoutPanel tblInfo;
        private System.Windows.Forms.Label lblOneTicketCost;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblAllTicketsCost;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pSeats;
    }
}