﻿namespace iCantina
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNomeFuncionarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerFormPrincipal = new System.Windows.Forms.Timer(this.components);
            this.dateTimePickerSessoesFormPrinc = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.buttonPratos = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonFuncionarios = new System.Windows.Forms.Button();
            this.buttonExtras = new System.Windows.Forms.Button();
            this.buttonMulta = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonReservas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(766, 382);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(688, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHora,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelNomeFuncionarioLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(897, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHora
            // 
            this.toolStripStatusLabelHora.Name = "toolStripStatusLabelHora";
            this.toolStripStatusLabelHora.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabelHora.Text = "00:00:00";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel1.Text = "Nome do Funcionario: ";
            // 
            // toolStripStatusLabelNomeFuncionarioLogado
            // 
            this.toolStripStatusLabelNomeFuncionarioLogado.Name = "toolStripStatusLabelNomeFuncionarioLogado";
            this.toolStripStatusLabelNomeFuncionarioLogado.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabelNomeFuncionarioLogado.Text = "FAÇA LOGIN";
            this.toolStripStatusLabelNomeFuncionarioLogado.Click += new System.EventHandler(this.toolStripStatusLabelNomeFuncionarioLogado_Click);
            // 
            // timerFormPrincipal
            // 
            this.timerFormPrincipal.Enabled = true;
            this.timerFormPrincipal.Tick += new System.EventHandler(this.timerFormPrincipal_Tick);
            // 
            // dateTimePickerSessoesFormPrinc
            // 
            this.dateTimePickerSessoesFormPrinc.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePickerSessoesFormPrinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSessoesFormPrinc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerSessoesFormPrinc.Location = new System.Drawing.Point(371, 149);
            this.dateTimePickerSessoesFormPrinc.MinDate = new System.DateTime(2023, 6, 3, 0, 0, 0, 0);
            this.dateTimePickerSessoesFormPrinc.Name = "dateTimePickerSessoesFormPrinc";
            this.dateTimePickerSessoesFormPrinc.Size = new System.Drawing.Size(162, 20);
            this.dateTimePickerSessoesFormPrinc.TabIndex = 16;
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.monthCalendar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar.Location = new System.Drawing.Point(338, 179);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 18;
            this.monthCalendar.TrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // buttonPratos
            // 
            this.buttonPratos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPratos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPratos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPratos.Location = new System.Drawing.Point(9, 10);
            this.buttonPratos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPratos.Name = "buttonPratos";
            this.buttonPratos.Size = new System.Drawing.Size(113, 36);
            this.buttonPratos.TabIndex = 19;
            this.buttonPratos.Text = "Pratos";
            this.buttonPratos.UseVisualStyleBackColor = false;
            this.buttonPratos.Click += new System.EventHandler(this.buttonPratos_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMenu.Location = new System.Drawing.Point(9, 50);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(113, 35);
            this.buttonMenu.TabIndex = 20;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonFuncionarios
            // 
            this.buttonFuncionarios.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonFuncionarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFuncionarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFuncionarios.Location = new System.Drawing.Point(243, 10);
            this.buttonFuncionarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFuncionarios.Name = "buttonFuncionarios";
            this.buttonFuncionarios.Size = new System.Drawing.Size(112, 36);
            this.buttonFuncionarios.TabIndex = 21;
            this.buttonFuncionarios.Text = "Funcionários";
            this.buttonFuncionarios.UseVisualStyleBackColor = false;
            this.buttonFuncionarios.Click += new System.EventHandler(this.buttonFuncionarios_Click);
            // 
            // buttonExtras
            // 
            this.buttonExtras.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonExtras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExtras.Location = new System.Drawing.Point(127, 50);
            this.buttonExtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExtras.Name = "buttonExtras";
            this.buttonExtras.Size = new System.Drawing.Size(113, 36);
            this.buttonExtras.TabIndex = 26;
            this.buttonExtras.Text = "Extras";
            this.buttonExtras.UseVisualStyleBackColor = false;
            this.buttonExtras.Click += new System.EventHandler(this.buttonExtras_Click);
            // 
            // buttonMulta
            // 
            this.buttonMulta.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonMulta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMulta.Location = new System.Drawing.Point(127, 10);
            this.buttonMulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMulta.Name = "buttonMulta";
            this.buttonMulta.Size = new System.Drawing.Size(113, 36);
            this.buttonMulta.TabIndex = 27;
            this.buttonMulta.Text = "Multa";
            this.buttonMulta.UseVisualStyleBackColor = false;
            this.buttonMulta.Click += new System.EventHandler(this.buttonMulta_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClientes.Location = new System.Drawing.Point(243, 50);
            this.buttonClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(112, 36);
            this.buttonClientes.TabIndex = 28;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = false;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonReservas
            // 
            this.buttonReservas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReservas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReservas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReservas.Location = new System.Drawing.Point(9, 90);
            this.buttonReservas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReservas.Name = "buttonReservas";
            this.buttonReservas.Size = new System.Drawing.Size(113, 36);
            this.buttonReservas.TabIndex = 29;
            this.buttonReservas.Text = "Reserva";
            this.buttonReservas.UseVisualStyleBackColor = false;
            this.buttonReservas.Click += new System.EventHandler(this.buttonReservas_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(897, 453);
            this.Controls.Add(this.buttonReservas);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonMulta);
            this.Controls.Add(this.buttonExtras);
            this.Controls.Add(this.buttonFuncionarios);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonPratos);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.dateTimePickerSessoesFormPrinc);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNomeFuncionarioLogado;
        private System.Windows.Forms.Timer timerFormPrincipal;
        private System.Windows.Forms.DateTimePicker dateTimePickerSessoesFormPrinc;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button buttonPratos;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonFuncionarios;
        private System.Windows.Forms.Button buttonExtras;
        private System.Windows.Forms.Button buttonMulta;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonReservas;
    }
}