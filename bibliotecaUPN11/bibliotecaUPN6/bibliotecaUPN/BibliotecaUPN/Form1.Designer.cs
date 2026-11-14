using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaUPN
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombrestudi = new System.Windows.Forms.TextBox();
            this.txtCodigoEstudiante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtpPrestamo = new System.Windows.Forms.DateTimePicker();
            this.btnVerLibros = new System.Windows.Forms.Button();
            this.btnActualizarestado = new System.Windows.Forms.Button();
            this.btnverestado = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoprestamo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigolibro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 103);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.ImageIndex = 0;
            this.label1.Location = new System.Drawing.Point(286, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIBLIOTECA UPN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnombrestudi);
            this.groupBox1.Controls.Add(this.txtCodigoEstudiante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(24, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(478, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.ImageIndex = 5;
            this.label10.ImageList = this.imageList1;
            this.label10.Location = new System.Drawing.Point(-5, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(169, 27);
            this.label10.TabIndex = 21;
            this.label10.Text = "      Estudiante";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "refresh.png");
            this.imageList1.Images.SetKeyName(1, "filter-2-search.png");
            this.imageList1.Images.SetKeyName(2, "device-floppy.png");
            this.imageList1.Images.SetKeyName(3, "books.png");
            this.imageList1.Images.SetKeyName(4, "book.png");
            this.imageList1.Images.SetKeyName(5, "user.png");
            this.imageList1.Images.SetKeyName(6, "device-laptop.png");
            this.imageList1.Images.SetKeyName(7, "logo_upn_negro-1-1024x723.jpg");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(27, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del estudiante:";
            // 
            // txtnombrestudi
            // 
            this.txtnombrestudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrestudi.Location = new System.Drawing.Point(29, 195);
            this.txtnombrestudi.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombrestudi.Name = "txtnombrestudi";
            this.txtnombrestudi.Size = new System.Drawing.Size(434, 30);
            this.txtnombrestudi.TabIndex = 3;
            // 
            // txtCodigoEstudiante
            // 
            this.txtCodigoEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEstudiante.Location = new System.Drawing.Point(29, 117);
            this.txtCodigoEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoEstudiante.MaxLength = 9;
            this.txtCodigoEstudiante.Name = "txtCodigoEstudiante";
            this.txtCodigoEstudiante.Size = new System.Drawing.Size(434, 30);
            this.txtCodigoEstudiante.TabIndex = 1;
            this.txtCodigoEstudiante.TextChanged += new System.EventHandler(this.txtCodigoEstudiante_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código del estudiante:";
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucion.Location = new System.Drawing.Point(17, 265);
            this.dtpDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(374, 30);
            this.dtpDevolucion.TabIndex = 21;
            // 
            // dtpPrestamo
            // 
            this.dtpPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrestamo.Location = new System.Drawing.Point(17, 187);
            this.dtpPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPrestamo.Name = "dtpPrestamo";
            this.dtpPrestamo.Size = new System.Drawing.Size(374, 30);
            this.dtpPrestamo.TabIndex = 20;
            // 
            // btnVerLibros
            // 
            this.btnVerLibros.BackColor = System.Drawing.Color.Orange;
            this.btnVerLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerLibros.ImageIndex = 3;
            this.btnVerLibros.ImageList = this.imageList1;
            this.btnVerLibros.Location = new System.Drawing.Point(273, 84);
            this.btnVerLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerLibros.Name = "btnVerLibros";
            this.btnVerLibros.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVerLibros.Size = new System.Drawing.Size(190, 34);
            this.btnVerLibros.TabIndex = 19;
            this.btnVerLibros.Text = "Ver Libros";
            this.btnVerLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerLibros.UseVisualStyleBackColor = false;
            this.btnVerLibros.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizarestado
            // 
            this.btnActualizarestado.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizarestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarestado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizarestado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarestado.ImageIndex = 0;
            this.btnActualizarestado.ImageList = this.imageList1;
            this.btnActualizarestado.Location = new System.Drawing.Point(234, 547);
            this.btnActualizarestado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarestado.Name = "btnActualizarestado";
            this.btnActualizarestado.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnActualizarestado.Size = new System.Drawing.Size(262, 49);
            this.btnActualizarestado.TabIndex = 18;
            this.btnActualizarestado.Text = "Actualizar Estado";
            this.btnActualizarestado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarestado.UseVisualStyleBackColor = false;
            this.btnActualizarestado.Click += new System.EventHandler(this.btnActualizarestado_Click);
            // 
            // btnverestado
            // 
            this.btnverestado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnverestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverestado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnverestado.ImageIndex = 1;
            this.btnverestado.ImageList = this.imageList1;
            this.btnverestado.Location = new System.Drawing.Point(502, 547);
            this.btnverestado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnverestado.Name = "btnverestado";
            this.btnverestado.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnverestado.Size = new System.Drawing.Size(239, 49);
            this.btnverestado.TabIndex = 17;
            this.btnverestado.Text = "Ver Prestamo";
            this.btnverestado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnverestado.UseVisualStyleBackColor = false;
            this.btnverestado.Click += new System.EventHandler(this.btnverestado_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Orange;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.ImageIndex = 2;
            this.btnRegistrar.ImageList = this.imageList1;
            this.btnRegistrar.Location = new System.Drawing.Point(747, 547);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRegistrar.Size = new System.Drawing.Size(185, 46);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(18, 307);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Pendiente",
            "Devuelto"});
            this.cboEstado.Location = new System.Drawing.Point(17, 334);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(385, 33);
            this.cboEstado.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(18, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha de devolución:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(18, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de préstamo:";
            // 
            // txtCodigoprestamo
            // 
            this.txtCodigoprestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoprestamo.Location = new System.Drawing.Point(17, 112);
            this.txtCodigoprestamo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoprestamo.Name = "txtCodigoprestamo";
            this.txtCodigoprestamo.Size = new System.Drawing.Size(374, 28);
            this.txtCodigoprestamo.TabIndex = 7;
            this.txtCodigoprestamo.TextChanged += new System.EventHandler(this.txtCodigoprestamo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(18, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Código de préstamo:";
            // 
            // txtCodigolibro
            // 
            this.txtCodigolibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigolibro.Location = new System.Drawing.Point(29, 85);
            this.txtCodigolibro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigolibro.Name = "txtCodigolibro";
            this.txtCodigolibro.Size = new System.Drawing.Size(235, 30);
            this.txtCodigolibro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(32, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código del libro";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnVerLibros);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCodigolibro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 140);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.NavajoWhite;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.ImageIndex = 4;
            this.label8.ImageList = this.imageList1;
            this.label8.Location = new System.Drawing.Point(-5, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(114, 27);
            this.label8.TabIndex = 20;
            this.label8.Text = "      Libro";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cboEstado);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtpDevolucion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtpPrestamo);
            this.groupBox3.Controls.Add(this.txtCodigoprestamo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(523, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 405);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.ImageIndex = 6;
            this.label11.ImageList = this.imageList1;
            this.label11.Location = new System.Drawing.Point(-5, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(159, 27);
            this.label11.TabIndex = 22;
            this.label11.Text = "      Préstamo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 617);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnverestado);
            this.Controls.Add(this.btnActualizarestado);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Biblioteca UPN";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }


        private void txtCodigoprestamo_TextChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException(); <-- Elimina o comenta esta línea
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoEstudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigolibro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombrestudi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizarestado;
        private System.Windows.Forms.Button btnverestado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVerLibros;


        private System.Windows.Forms.Button btnlibros;
        private DateTimePicker dtpDevolucion;
        private DateTimePicker dtpPrestamo;
        private TextBox txtCodigoprestamo;
        private ImageList imageList1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label8;
        private Label label10;
        private Label label11;
    }
}

