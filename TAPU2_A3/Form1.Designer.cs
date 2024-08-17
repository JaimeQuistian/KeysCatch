namespace TAPU2_A3
{
    partial class frmAtraparLetras
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
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblNumeroPuntaje = new System.Windows.Forms.Label();
            this.lblInformación = new System.Windows.Forms.Label();
            this.lblLetra = new System.Windows.Forms.Label();
            this.tmrMostrarLetras = new System.Windows.Forms.Timer(this.components);
            this.lblTeclaUsuario = new System.Windows.Forms.Label();
            this.tmrEvaluacion = new System.Windows.Forms.Timer(this.components);
            this.lblInformacion2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(12, 370);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(55, 17);
            this.lblPuntos.TabIndex = 0;
            this.lblPuntos.Text = "Puntos:";
            // 
            // lblNumeroPuntaje
            // 
            this.lblNumeroPuntaje.AutoSize = true;
            this.lblNumeroPuntaje.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPuntaje.ForeColor = System.Drawing.Color.Blue;
            this.lblNumeroPuntaje.Location = new System.Drawing.Point(73, 370);
            this.lblNumeroPuntaje.Name = "lblNumeroPuntaje";
            this.lblNumeroPuntaje.Size = new System.Drawing.Size(17, 17);
            this.lblNumeroPuntaje.TabIndex = 1;
            this.lblNumeroPuntaje.Text = "0";
            // 
            // lblInformación
            // 
            this.lblInformación.AutoSize = true;
            this.lblInformación.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformación.Location = new System.Drawing.Point(-3, 112);
            this.lblInformación.Name = "lblInformación";
            this.lblInformación.Size = new System.Drawing.Size(203, 23);
            this.lblInformación.TabIndex = 2;
            this.lblInformación.Text = "Presiona la siguiente tecla:";
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetra.ForeColor = System.Drawing.Color.Red;
            this.lblLetra.Location = new System.Drawing.Point(-5, 177);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(0, 34);
            this.lblLetra.TabIndex = 3;
            // 
            // tmrMostrarLetras
            // 
            this.tmrMostrarLetras.Enabled = true;
            this.tmrMostrarLetras.Interval = 2000;
            this.tmrMostrarLetras.Tick += new System.EventHandler(this.tmrMostrarLetras_Tick);
            // 
            // lblTeclaUsuario
            // 
            this.lblTeclaUsuario.AutoSize = true;
            this.lblTeclaUsuario.ForeColor = System.Drawing.Color.Blue;
            this.lblTeclaUsuario.Location = new System.Drawing.Point(533, 374);
            this.lblTeclaUsuario.Name = "lblTeclaUsuario";
            this.lblTeclaUsuario.Size = new System.Drawing.Size(10, 13);
            this.lblTeclaUsuario.TabIndex = 4;
            this.lblTeclaUsuario.Text = "-";
            // 
            // tmrEvaluacion
            // 
            this.tmrEvaluacion.Enabled = true;
            this.tmrEvaluacion.Interval = 2000;
            this.tmrEvaluacion.Tick += new System.EventHandler(this.tmrEvaluacion_Tick);
            // 
            // lblInformacion2
            // 
            this.lblInformacion2.AutoSize = true;
            this.lblInformacion2.Location = new System.Drawing.Point(443, 374);
            this.lblInformacion2.Name = "lblInformacion2";
            this.lblInformacion2.Size = new System.Drawing.Size(84, 13);
            this.lblInformacion2.TabIndex = 5;
            this.lblInformacion2.Text = "Haz presionado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 92);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instrucciones: Precionar la tecla que aparece en pantalla para que no llegue \r\nha" +
    "sta el final de la linea.\r\n\r\nSuerte . . .\r\n";
            // 
            // frmAtraparLetras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(559, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInformacion2);
            this.Controls.Add(this.lblTeclaUsuario);
            this.Controls.Add(this.lblLetra);
            this.Controls.Add(this.lblInformación);
            this.Controls.Add(this.lblNumeroPuntaje);
            this.Controls.Add(this.lblPuntos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(575, 439);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(575, 439);
            this.Name = "frmAtraparLetras";
            this.ShowIcon = false;
            this.Text = "KeysCatch()";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAtraparLetras_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblNumeroPuntaje;
        private System.Windows.Forms.Label lblInformación;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.Timer tmrMostrarLetras;
        private System.Windows.Forms.Label lblTeclaUsuario;
        private System.Windows.Forms.Timer tmrEvaluacion;
        private System.Windows.Forms.Label lblInformacion2;
        private System.Windows.Forms.Label label1;
    }
}

