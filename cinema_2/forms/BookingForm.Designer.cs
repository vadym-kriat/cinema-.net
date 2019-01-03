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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOneTicketCost = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGeneralCost = new System.Windows.Forms.Label();
            this.tblContainer.SuspendLayout();
            this.pSubDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilmName
            // 
            this.lblFilmName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilmName.Location = new System.Drawing.Point(0, 0);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(923, 40);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.Text = "Фильм";
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblContainer
            // 
            this.tblContainer.BackColor = System.Drawing.SystemColors.Control;
            this.tblContainer.ColumnCount = 3;
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblContainer.Controls.Add(this.pSubDgv, 0, 0);
            this.tblContainer.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tblContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContainer.Location = new System.Drawing.Point(10, 0);
            this.tblContainer.Name = "tblContainer";
            this.tblContainer.RowCount = 1;
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblContainer.Size = new System.Drawing.Size(903, 363);
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
            this.pSubDgv.Size = new System.Drawing.Size(219, 357);
            this.pSubDgv.TabIndex = 1;
            // 
            // dgvSessions
            // 
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
            this.dgvSessions.Size = new System.Drawing.Size(217, 355);
            this.dgvSessions.TabIndex = 0;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblGeneralCost, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOneTicketCost, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(634, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(266, 357);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblOneTicketCost
            // 
            this.lblOneTicketCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOneTicketCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOneTicketCost.Location = new System.Drawing.Point(3, 0);
            this.lblOneTicketCost.Name = "lblOneTicketCost";
            this.lblOneTicketCost.Size = new System.Drawing.Size(260, 40);
            this.lblOneTicketCost.TabIndex = 0;
            this.lblOneTicketCost.Text = "Стоимость одного билета";
            this.lblOneTicketCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel1.Size = new System.Drawing.Size(923, 373);
            this.panel1.TabIndex = 2;
            // 
            // lblGeneralCost
            // 
            this.lblGeneralCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneralCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGeneralCost.Location = new System.Drawing.Point(3, 40);
            this.lblGeneralCost.Name = "lblGeneralCost";
            this.lblGeneralCost.Size = new System.Drawing.Size(260, 40);
            this.lblGeneralCost.TabIndex = 1;
            this.lblGeneralCost.Text = "Сумма";
            this.lblGeneralCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFilmName);
            this.Name = "BookingForm";
            this.Text = "Бронирование";
            this.tblContainer.ResumeLayout(false);
            this.pSubDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblOneTicketCost;
        private System.Windows.Forms.Label lblGeneralCost;
    }
}