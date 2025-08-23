namespace Proyecto_de_catedra_POO
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnregistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btncajero = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnregistro
            // 
            this.btnregistro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnregistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistro.BackgroundImage")));
            this.btnregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistro.Location = new System.Drawing.Point(44, 110);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(176, 191);
            this.btnregistro.TabIndex = 0;
            this.btnregistro.UseVisualStyleBackColor = false;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "B I E N V E N I D O S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registro de Productos";
            // 
            // btnlista
            // 
            this.btnlista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnlista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlista.BackgroundImage")));
            this.btnlista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlista.Location = new System.Drawing.Point(339, 110);
            this.btnlista.Name = "btnlista";
            this.btnlista.Size = new System.Drawing.Size(176, 191);
            this.btnlista.TabIndex = 3;
            this.btnlista.UseVisualStyleBackColor = false;
            this.btnlista.Click += new System.EventHandler(this.btnlista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Listado de Productos";
            // 
            // btncajero
            // 
            this.btncajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btncajero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncajero.BackgroundImage")));
            this.btncajero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncajero.Location = new System.Drawing.Point(612, 110);
            this.btncajero.Name = "btncajero";
            this.btncajero.Size = new System.Drawing.Size(176, 191);
            this.btncajero.TabIndex = 5;
            this.btncajero.UseVisualStyleBackColor = false;
            this.btncajero.Click += new System.EventHandler(this.btncajero_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(663, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cajero";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(700, 379);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(134, 59);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir del Programa";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncajero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S U P E R M E R C A D O ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncajero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsalir;
    }
}

