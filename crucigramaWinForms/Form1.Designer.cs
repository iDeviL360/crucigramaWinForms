namespace crucigramaWinForms
{
    partial class PantallaScrabble
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
            this.grpNumeros = new System.Windows.Forms.GroupBox();
            this.tlpTablero = new System.Windows.Forms.TableLayoutPanel();
            this.grpNumerosSide = new System.Windows.Forms.GroupBox();
            this.lblTextoPuntajeJ1 = new System.Windows.Forms.Label();
            this.lblTextoPuntajeJ2 = new System.Windows.Forms.Label();
            this.lblPuntajeJ1 = new System.Windows.Forms.Label();
            this.lblPuntajeJ2 = new System.Windows.Forms.Label();
            this.lblTurnoTexto = new System.Windows.Forms.Label();
            this.lblTurnoActual = new System.Windows.Forms.Label();
            this.tlpFichasJugadorActual = new System.Windows.Forms.TableLayoutPanel();
            this.cboFichas = new System.Windows.Forms.ComboBox();
            this.lblTxt = new System.Windows.Forms.Label();
            this.btnColocarFicha = new System.Windows.Forms.Button();
            this.cboColPosicion = new System.Windows.Forms.ComboBox();
            this.cboFilaPosicion = new System.Windows.Forms.ComboBox();
            this.lblFilaPosicion = new System.Windows.Forms.Label();
            this.lblColPosicion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grpNumeros
            // 
            this.grpNumeros.Location = new System.Drawing.Point(49, 49);
            this.grpNumeros.Name = "grpNumeros";
            this.grpNumeros.Size = new System.Drawing.Size(921, 56);
            this.grpNumeros.TabIndex = 0;
            this.grpNumeros.TabStop = false;
            // 
            // tlpTablero
            // 
            this.tlpTablero.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpTablero.ColumnCount = 15;
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpTablero.Location = new System.Drawing.Point(59, 111);
            this.tlpTablero.Name = "tlpTablero";
            this.tlpTablero.RowCount = 15;
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTablero.Size = new System.Drawing.Size(911, 694);
            this.tlpTablero.TabIndex = 0;
            // 
            // grpNumerosSide
            // 
            this.grpNumerosSide.Location = new System.Drawing.Point(976, 99);
            this.grpNumerosSide.Name = "grpNumerosSide";
            this.grpNumerosSide.Size = new System.Drawing.Size(59, 716);
            this.grpNumerosSide.TabIndex = 0;
            this.grpNumerosSide.TabStop = false;
            // 
            // lblTextoPuntajeJ1
            // 
            this.lblTextoPuntajeJ1.AutoSize = true;
            this.lblTextoPuntajeJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPuntajeJ1.Location = new System.Drawing.Point(1204, 49);
            this.lblTextoPuntajeJ1.Name = "lblTextoPuntajeJ1";
            this.lblTextoPuntajeJ1.Size = new System.Drawing.Size(160, 18);
            this.lblTextoPuntajeJ1.TabIndex = 0;
            this.lblTextoPuntajeJ1.Text = "Jugador 1 - Puntaje:";
            // 
            // lblTextoPuntajeJ2
            // 
            this.lblTextoPuntajeJ2.AutoSize = true;
            this.lblTextoPuntajeJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPuntajeJ2.Location = new System.Drawing.Point(1204, 78);
            this.lblTextoPuntajeJ2.Name = "lblTextoPuntajeJ2";
            this.lblTextoPuntajeJ2.Size = new System.Drawing.Size(160, 18);
            this.lblTextoPuntajeJ2.TabIndex = 0;
            this.lblTextoPuntajeJ2.Text = "Jugador 2 - Puntaje:";
            // 
            // lblPuntajeJ1
            // 
            this.lblPuntajeJ1.AutoSize = true;
            this.lblPuntajeJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntajeJ1.Location = new System.Drawing.Point(1360, 49);
            this.lblPuntajeJ1.Name = "lblPuntajeJ1";
            this.lblPuntajeJ1.Size = new System.Drawing.Size(80, 18);
            this.lblPuntajeJ1.TabIndex = 0;
            this.lblPuntajeJ1.Text = "puntajeJ1";
            // 
            // lblPuntajeJ2
            // 
            this.lblPuntajeJ2.AutoSize = true;
            this.lblPuntajeJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntajeJ2.Location = new System.Drawing.Point(1360, 78);
            this.lblPuntajeJ2.Name = "lblPuntajeJ2";
            this.lblPuntajeJ2.Size = new System.Drawing.Size(80, 18);
            this.lblPuntajeJ2.TabIndex = 0;
            this.lblPuntajeJ2.Text = "puntajeJ2";
            // 
            // lblTurnoTexto
            // 
            this.lblTurnoTexto.AutoSize = true;
            this.lblTurnoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoTexto.ForeColor = System.Drawing.Color.Red;
            this.lblTurnoTexto.Location = new System.Drawing.Point(1041, 111);
            this.lblTurnoTexto.Name = "lblTurnoTexto";
            this.lblTurnoTexto.Size = new System.Drawing.Size(113, 18);
            this.lblTurnoTexto.TabIndex = 0;
            this.lblTurnoTexto.Text = "Turno Actual: ";
            // 
            // lblTurnoActual
            // 
            this.lblTurnoActual.AutoSize = true;
            this.lblTurnoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoActual.Location = new System.Drawing.Point(1147, 111);
            this.lblTurnoActual.Name = "lblTurnoActual";
            this.lblTurnoActual.Size = new System.Drawing.Size(93, 18);
            this.lblTurnoActual.TabIndex = 0;
            this.lblTurnoActual.Text = "turnoActual";
            // 
            // tlpFichasJugadorActual
            // 
            this.tlpFichasJugadorActual.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpFichasJugadorActual.ColumnCount = 7;
            this.tlpFichasJugadorActual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpFichasJugadorActual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpFichasJugadorActual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpFichasJugadorActual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpFichasJugadorActual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpFichasJugadorActual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpFichasJugadorActual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpFichasJugadorActual.Location = new System.Drawing.Point(1041, 141);
            this.tlpFichasJugadorActual.Name = "tlpFichasJugadorActual";
            this.tlpFichasJugadorActual.RowCount = 1;
            this.tlpFichasJugadorActual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFichasJugadorActual.Size = new System.Drawing.Size(357, 37);
            this.tlpFichasJugadorActual.TabIndex = 0;
            // 
            // cboFichas
            // 
            this.cboFichas.FormattingEnabled = true;
            this.cboFichas.Location = new System.Drawing.Point(1241, 192);
            this.cboFichas.Name = "cboFichas";
            this.cboFichas.Size = new System.Drawing.Size(157, 21);
            this.cboFichas.TabIndex = 0;
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt.Location = new System.Drawing.Point(1039, 195);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(202, 16);
            this.lblTxt.TabIndex = 0;
            this.lblTxt.Text = "Escoja la ficha que desea jugar: ";
            // 
            // btnColocarFicha
            // 
            this.btnColocarFicha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocarFicha.Location = new System.Drawing.Point(1301, 222);
            this.btnColocarFicha.Name = "btnColocarFicha";
            this.btnColocarFicha.Size = new System.Drawing.Size(97, 45);
            this.btnColocarFicha.TabIndex = 0;
            this.btnColocarFicha.Text = "Colocar Ficha";
            this.btnColocarFicha.UseVisualStyleBackColor = true;
            this.btnColocarFicha.Click += new System.EventHandler(this.BtnColocarFicha_Click);
            // 
            // cboColPosicion
            // 
            this.cboColPosicion.FormattingEnabled = true;
            this.cboColPosicion.Location = new System.Drawing.Point(1241, 246);
            this.cboColPosicion.Name = "cboColPosicion";
            this.cboColPosicion.Size = new System.Drawing.Size(54, 21);
            this.cboColPosicion.TabIndex = 0;
            // 
            // cboFilaPosicion
            // 
            this.cboFilaPosicion.FormattingEnabled = true;
            this.cboFilaPosicion.Location = new System.Drawing.Point(1241, 219);
            this.cboFilaPosicion.Name = "cboFilaPosicion";
            this.cboFilaPosicion.Size = new System.Drawing.Size(54, 21);
            this.cboFilaPosicion.TabIndex = 0;
            // 
            // lblFilaPosicion
            // 
            this.lblFilaPosicion.AutoSize = true;
            this.lblFilaPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilaPosicion.Location = new System.Drawing.Point(1039, 221);
            this.lblFilaPosicion.Name = "lblFilaPosicion";
            this.lblFilaPosicion.Size = new System.Drawing.Size(166, 16);
            this.lblFilaPosicion.TabIndex = 1;
            this.lblFilaPosicion.Text = "Escoja la fila para la ficha: ";
            // 
            // lblColPosicion
            // 
            this.lblColPosicion.AutoSize = true;
            this.lblColPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColPosicion.Location = new System.Drawing.Point(1039, 248);
            this.lblColPosicion.Name = "lblColPosicion";
            this.lblColPosicion.Size = new System.Drawing.Size(197, 16);
            this.lblColPosicion.TabIndex = 2;
            this.lblColPosicion.Text = "Escoja la columna para la ficha:";
            // 
            // PantallaScrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 839);
            this.Controls.Add(this.lblColPosicion);
            this.Controls.Add(this.lblFilaPosicion);
            this.Controls.Add(this.cboFilaPosicion);
            this.Controls.Add(this.cboColPosicion);
            this.Controls.Add(this.btnColocarFicha);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.cboFichas);
            this.Controls.Add(this.tlpFichasJugadorActual);
            this.Controls.Add(this.lblTurnoActual);
            this.Controls.Add(this.lblTurnoTexto);
            this.Controls.Add(this.lblPuntajeJ2);
            this.Controls.Add(this.lblPuntajeJ1);
            this.Controls.Add(this.lblTextoPuntajeJ2);
            this.Controls.Add(this.lblTextoPuntajeJ1);
            this.Controls.Add(this.grpNumerosSide);
            this.Controls.Add(this.tlpTablero);
            this.Controls.Add(this.grpNumeros);
            this.Name = "PantallaScrabble";
            this.Text = "Crucigrama";
            this.Load += new System.EventHandler(this.PantallaScrabble_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNumeros;
        private System.Windows.Forms.TableLayoutPanel tlpTablero;
        private System.Windows.Forms.GroupBox grpNumerosSide;
        private System.Windows.Forms.Label lblTextoPuntajeJ1;
        private System.Windows.Forms.Label lblTextoPuntajeJ2;
        private System.Windows.Forms.Label lblPuntajeJ1;
        private System.Windows.Forms.Label lblPuntajeJ2;
        private System.Windows.Forms.Label lblTurnoTexto;
        private System.Windows.Forms.Label lblTurnoActual;
        private System.Windows.Forms.TableLayoutPanel tlpFichasJugadorActual;
        private System.Windows.Forms.ComboBox cboFichas;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.Button btnColocarFicha;
        private System.Windows.Forms.ComboBox cboColPosicion;
        private System.Windows.Forms.ComboBox cboFilaPosicion;
        private System.Windows.Forms.Label lblFilaPosicion;
        private System.Windows.Forms.Label lblColPosicion;
    }
}

