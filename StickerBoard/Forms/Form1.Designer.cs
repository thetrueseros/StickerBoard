using System.Windows.Forms;
using StickerBoard.Factory;
using StickerBoard.Entities;
namespace StickerBoard.Forms
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
            this.cmbSticker = new System.Windows.Forms.ComboBox();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pbLienzo = new System.Windows.Forms.PictureBox();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.lblTipoFigura = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblPosicionLienzo = new System.Windows.Forms.Label();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCantFiguras = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblLienzo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSticker
            // 
            this.cmbSticker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSticker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSticker.FormattingEnabled = true;
            this.cmbSticker.Items.AddRange(new object[] {
            "Circulo",
            "Rectangulo",
            "Estrella",
            "Nube"});
            this.cmbSticker.Location = new System.Drawing.Point(46, 90);
            this.cmbSticker.Name = "cmbSticker";
            this.cmbSticker.Size = new System.Drawing.Size(121, 21);
            this.cmbSticker.TabIndex = 0;
            this.cmbSticker.Tag = "(Seleccione)";
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(117, 226);
            this.nudY.Maximum = new decimal(new int[] {
            487,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(50, 20);
            this.nudY.TabIndex = 2;
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(46, 226);
            this.nudX.Maximum = new decimal(new int[] {
            858,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(50, 20);
            this.nudX.TabIndex = 3;
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(47, 306);
            this.nudSize.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(120, 20);
            this.nudSize.TabIndex = 4;
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Red;
            this.pbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbColor.Location = new System.Drawing.Point(47, 399);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(120, 32);
            this.pbColor.TabIndex = 5;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(86, 535);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(45, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // pbLienzo
            // 
            this.pbLienzo.BackColor = System.Drawing.Color.White;
            this.pbLienzo.Location = new System.Drawing.Point(275, 71);
            this.pbLienzo.Name = "pbLienzo";
            this.pbLienzo.Size = new System.Drawing.Size(858, 487);
            this.pbLienzo.TabIndex = 7;
            this.pbLienzo.TabStop = false;
            this.pbLienzo.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLienzo_Paint);
            // 
            // txtContador
            // 
            this.txtContador.BackColor = System.Drawing.Color.White;
            this.txtContador.Location = new System.Drawing.Point(432, 583);
            this.txtContador.Name = "txtContador";
            this.txtContador.ReadOnly = true;
            this.txtContador.Size = new System.Drawing.Size(100, 20);
            this.txtContador.TabIndex = 8;
            this.txtContador.Text = "0";
            // 
            // lblTipoFigura
            // 
            this.lblTipoFigura.AutoSize = true;
            this.lblTipoFigura.Location = new System.Drawing.Point(47, 71);
            this.lblTipoFigura.Name = "lblTipoFigura";
            this.lblTipoFigura.Size = new System.Drawing.Size(72, 13);
            this.lblTipoFigura.TabIndex = 9;
            this.lblTipoFigura.Text = "Tipo de figura";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(46, 207);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(117, 206);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 11;
            this.lblY.Text = "Y";
            // 
            // lblPosicionLienzo
            // 
            this.lblPosicionLienzo.AutoSize = true;
            this.lblPosicionLienzo.Location = new System.Drawing.Point(47, 178);
            this.lblPosicionLienzo.Name = "lblPosicionLienzo";
            this.lblPosicionLienzo.Size = new System.Drawing.Size(103, 13);
            this.lblPosicionLienzo.TabIndex = 12;
            this.lblPosicionLienzo.Text = "Posición en el lienzo";
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Location = new System.Drawing.Point(44, 279);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(46, 13);
            this.lblTamaño.TabIndex = 13;
            this.lblTamaño.Text = "Tamaño";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(47, 362);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 14;
            this.lblColor.Text = "Color";
            // 
            // lblCantFiguras
            // 
            this.lblCantFiguras.AutoSize = true;
            this.lblCantFiguras.Location = new System.Drawing.Point(325, 586);
            this.lblCantFiguras.Name = "lblCantFiguras";
            this.lblCantFiguras.Size = new System.Drawing.Size(106, 13);
            this.lblCantFiguras.TabIndex = 15;
            this.lblCantFiguras.Text = "Cantidad de stickers:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1077, 580);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(56, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblLienzo
            // 
            this.lblLienzo.AutoSize = true;
            this.lblLienzo.Location = new System.Drawing.Point(695, 55);
            this.lblLienzo.Name = "lblLienzo";
            this.lblLienzo.Size = new System.Drawing.Size(38, 13);
            this.lblLienzo.TabIndex = 17;
            this.lblLienzo.Text = "Lienzo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblLienzo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblCantFiguras);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.lblPosicionLienzo);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblTipoFigura);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.pbLienzo);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.cmbSticker);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.Text = "StickerBoard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSticker;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.PictureBox pbLienzo;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label lblTipoFigura;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblPosicionLienzo;
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCantFiguras;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Label lblLienzo;
    }
}
