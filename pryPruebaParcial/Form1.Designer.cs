
namespace pryPruebaParcial
{
    partial class Frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1));
            this.BtnMayor = new System.Windows.Forms.Button();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.BtnMenor = new System.Windows.Forms.Button();
            this.PctNum1 = new System.Windows.Forms.PictureBox();
            this.BtnJugar = new System.Windows.Forms.Button();
            this.PctNum2 = new System.Windows.Forms.PictureBox();
            this.PctResultados = new System.Windows.Forms.PictureBox();
            this.LblAciertos = new System.Windows.Forms.Label();
            this.LblErrores = new System.Windows.Forms.Label();
            this.LblPuntuacion = new System.Windows.Forms.Label();
            this.LblBienvenida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMayor
            // 
            this.BtnMayor.Image = global::pryPruebaParcial.Properties.Resources.Mayor;
            this.BtnMayor.Location = new System.Drawing.Point(122, 369);
            this.BtnMayor.Name = "BtnMayor";
            this.BtnMayor.Size = new System.Drawing.Size(147, 152);
            this.BtnMayor.TabIndex = 0;
            this.BtnMayor.UseVisualStyleBackColor = true;
            this.BtnMayor.Click += new System.EventHandler(this.BtnMayor_Click);
            // 
            // BtnIgual
            // 
            this.BtnIgual.Image = global::pryPruebaParcial.Properties.Resources.Igual;
            this.BtnIgual.Location = new System.Drawing.Point(373, 369);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(152, 152);
            this.BtnIgual.TabIndex = 1;
            this.BtnIgual.UseVisualStyleBackColor = true;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // BtnMenor
            // 
            this.BtnMenor.Image = global::pryPruebaParcial.Properties.Resources.Menor;
            this.BtnMenor.Location = new System.Drawing.Point(627, 369);
            this.BtnMenor.Name = "BtnMenor";
            this.BtnMenor.Size = new System.Drawing.Size(154, 152);
            this.BtnMenor.TabIndex = 2;
            this.BtnMenor.UseVisualStyleBackColor = true;
            this.BtnMenor.Click += new System.EventHandler(this.BtnMenor_Click);
            // 
            // PctNum1
            // 
            this.PctNum1.Location = new System.Drawing.Point(68, 23);
            this.PctNum1.Name = "PctNum1";
            this.PctNum1.Size = new System.Drawing.Size(201, 153);
            this.PctNum1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctNum1.TabIndex = 3;
            this.PctNum1.TabStop = false;
            // 
            // BtnJugar
            // 
            this.BtnJugar.BackColor = System.Drawing.Color.LightGreen;
            this.BtnJugar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJugar.Location = new System.Drawing.Point(382, 297);
            this.BtnJugar.Name = "BtnJugar";
            this.BtnJugar.Size = new System.Drawing.Size(130, 53);
            this.BtnJugar.TabIndex = 4;
            this.BtnJugar.Text = "Jugar";
            this.BtnJugar.UseVisualStyleBackColor = false;
            this.BtnJugar.Click += new System.EventHandler(this.BtnJugar_Click);
            // 
            // PctNum2
            // 
            this.PctNum2.Location = new System.Drawing.Point(627, 23);
            this.PctNum2.Name = "PctNum2";
            this.PctNum2.Size = new System.Drawing.Size(201, 153);
            this.PctNum2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctNum2.TabIndex = 5;
            this.PctNum2.TabStop = false;
            // 
            // PctResultados
            // 
            this.PctResultados.Location = new System.Drawing.Point(342, 23);
            this.PctResultados.Name = "PctResultados";
            this.PctResultados.Size = new System.Drawing.Size(201, 153);
            this.PctResultados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctResultados.TabIndex = 6;
            this.PctResultados.TabStop = false;
            // 
            // LblAciertos
            // 
            this.LblAciertos.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAciertos.Location = new System.Drawing.Point(12, 197);
            this.LblAciertos.Name = "LblAciertos";
            this.LblAciertos.Size = new System.Drawing.Size(266, 23);
            this.LblAciertos.TabIndex = 7;
            // 
            // LblErrores
            // 
            this.LblErrores.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrores.Location = new System.Drawing.Point(12, 229);
            this.LblErrores.Name = "LblErrores";
            this.LblErrores.Size = new System.Drawing.Size(266, 23);
            this.LblErrores.TabIndex = 8;
            // 
            // LblPuntuacion
            // 
            this.LblPuntuacion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntuacion.Location = new System.Drawing.Point(12, 262);
            this.LblPuntuacion.Name = "LblPuntuacion";
            this.LblPuntuacion.Size = new System.Drawing.Size(266, 23);
            this.LblPuntuacion.TabIndex = 9;
            // 
            // LblBienvenida
            // 
            this.LblBienvenida.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenida.Location = new System.Drawing.Point(252, 188);
            this.LblBienvenida.Name = "LblBienvenida";
            this.LblBienvenida.Size = new System.Drawing.Size(402, 106);
            this.LblBienvenida.TabIndex = 10;
            this.LblBienvenida.Text = resources.GetString("LblBienvenida.Text");
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 560);
            this.Controls.Add(this.LblBienvenida);
            this.Controls.Add(this.LblPuntuacion);
            this.Controls.Add(this.LblErrores);
            this.Controls.Add(this.LblAciertos);
            this.Controls.Add(this.PctResultados);
            this.Controls.Add(this.PctNum2);
            this.Controls.Add(this.BtnJugar);
            this.Controls.Add(this.PctNum1);
            this.Controls.Add(this.BtnMenor);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.BtnMayor);
            this.Name = "Frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayor, igual y menor";
            this.Load += new System.EventHandler(this.Frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMayor;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.Button BtnMenor;
        private System.Windows.Forms.PictureBox PctNum1;
        private System.Windows.Forms.Button BtnJugar;
        private System.Windows.Forms.PictureBox PctNum2;
        private System.Windows.Forms.PictureBox PctResultados;
        private System.Windows.Forms.Label LblAciertos;
        private System.Windows.Forms.Label LblErrores;
        private System.Windows.Forms.Label LblPuntuacion;
        private System.Windows.Forms.Label LblBienvenida;
    }
}

