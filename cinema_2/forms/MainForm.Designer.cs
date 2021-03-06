﻿namespace cinema_2
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newFilm = new System.Windows.Forms.Button();
            this.newSession = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pFilmContainer = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 50);
            this.panel1.TabIndex = 0;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(691, 11);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 26);
            this.search.TabIndex = 2;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(93, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(592, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.WordWrap = false;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchByEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // newFilm
            // 
            this.newFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newFilm.Location = new System.Drawing.Point(16, 0);
            this.newFilm.Name = "newFilm";
            this.newFilm.Size = new System.Drawing.Size(100, 26);
            this.newFilm.TabIndex = 2;
            this.newFilm.Text = "Фильмы";
            this.newFilm.UseVisualStyleBackColor = true;
            this.newFilm.Click += new System.EventHandler(this.OpenFilmManagementModal);
            // 
            // newSession
            // 
            this.newSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newSession.Location = new System.Drawing.Point(16, 38);
            this.newSession.Name = "newSession";
            this.newSession.Size = new System.Drawing.Size(100, 26);
            this.newSession.TabIndex = 2;
            this.newSession.Text = "Сеансы";
            this.newSession.UseVisualStyleBackColor = true;
            this.newSession.Click += new System.EventHandler(this.OpenSessionManagementModal);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.newSession);
            this.panel2.Controls.Add(this.newFilm);
            this.panel2.Location = new System.Drawing.Point(781, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 391);
            this.panel2.TabIndex = 1;
            // 
            // pFilmContainer
            // 
            this.pFilmContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFilmContainer.AutoScroll = true;
            this.pFilmContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pFilmContainer.Location = new System.Drawing.Point(0, 50);
            this.pFilmContainer.Name = "pFilmContainer";
            this.pFilmContainer.Padding = new System.Windows.Forms.Padding(5, 3, 0, 5);
            this.pFilmContainer.Size = new System.Drawing.Size(781, 391);
            this.pFilmContainer.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(797, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 26);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 441);
            this.Controls.Add(this.pFilmContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(580, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кинотеатр";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button newSession;
        private System.Windows.Forms.Button newFilm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pFilmContainer;
        private System.Windows.Forms.Button btnClear;
    }
}