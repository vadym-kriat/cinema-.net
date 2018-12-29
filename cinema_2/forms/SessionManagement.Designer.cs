namespace cinema_2.forms
{
    partial class SessionManagement
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
            this.lblFilmName = new System.Windows.Forms.Label();
            this.pContainer = new System.Windows.Forms.Panel();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.dgvPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilmName
            // 
            this.lblFilmName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilmName.Location = new System.Drawing.Point(0, 0);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(776, 24);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.Text = "Название Фильма";
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.Controls.Add(this.lblFilmName);
            this.pContainer.Location = new System.Drawing.Point(12, 12);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(776, 426);
            this.pContainer.TabIndex = 1;
            // 
            // dgvSessions
            // 
            this.dgvSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSessions.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Room,
            this.Time});
            this.dgvSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSessions.Location = new System.Drawing.Point(1, 1);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.RowHeadersVisible = false;
            this.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessions.Size = new System.Drawing.Size(380, 382);
            this.dgvSessions.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Room
            // 
            this.Room.HeaderText = "Комната";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // dgvPanel
            // 
            this.dgvPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dgvPanel.Controls.Add(this.dgvSessions);
            this.dgvPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPanel.Location = new System.Drawing.Point(3, 3);
            this.dgvPanel.Name = "dgvPanel";
            this.dgvPanel.Padding = new System.Windows.Forms.Padding(1);
            this.dgvPanel.Size = new System.Drawing.Size(382, 384);
            this.dgvPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvPanel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 390);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SessionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pContainer);
            this.Name = "SessionManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сессии";
            this.pContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.dgvPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Panel dgvPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}