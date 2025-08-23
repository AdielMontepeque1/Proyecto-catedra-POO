namespace Proyecto_de_catedra_POO
{
    partial class FormRegistro
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
            this.btnregresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.RegistrarProd = new System.Windows.Forms.Button();
            this.rbactivaroferta = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtoferta = new System.Windows.Forms.TextBox();
            this.txtprecioprod = new System.Windows.Forms.TextBox();
            this.txtnombreprod = new System.Windows.Forms.TextBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.White;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(800, 445);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(141, 57);
            this.btnregresar.TabIndex = 0;
            this.btnregresar.Text = "Regresar a Menu Principal";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnEliminarProd);
            this.groupBox1.Controls.Add(this.RegistrarProd);
            this.groupBox1.Controls.Add(this.rbactivaroferta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtoferta);
            this.groupBox1.Controls.Add(this.txtprecioprod);
            this.groupBox1.Controls.Add(this.txtnombreprod);
            this.groupBox1.Controls.Add(this.cbtipo);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(498, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 407);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.Location = new System.Drawing.Point(316, 350);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(121, 51);
            this.btnEliminarProd.TabIndex = 6;
            this.btnEliminarProd.Text = "Eliminar Producto";
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            // 
            // RegistrarProd
            // 
            this.RegistrarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RegistrarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarProd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarProd.Location = new System.Drawing.Point(27, 350);
            this.RegistrarProd.Name = "RegistrarProd";
            this.RegistrarProd.Size = new System.Drawing.Size(121, 51);
            this.RegistrarProd.TabIndex = 5;
            this.RegistrarProd.Text = "Registrar Producto";
            this.RegistrarProd.UseVisualStyleBackColor = false;
            // 
            // rbactivaroferta
            // 
            this.rbactivaroferta.AutoSize = true;
            this.rbactivaroferta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbactivaroferta.Location = new System.Drawing.Point(95, 219);
            this.rbactivaroferta.Name = "rbactivaroferta";
            this.rbactivaroferta.Size = new System.Drawing.Size(218, 23);
            this.rbactivaroferta.TabIndex = 4;
            this.rbactivaroferta.TabStop = true;
            this.rbactivaroferta.Text = "Activar Oferta/Promocion";
            this.rbactivaroferta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oferta/Promocion de Producto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Producto";
            // 
            // txtoferta
            // 
            this.txtoferta.Location = new System.Drawing.Point(251, 258);
            this.txtoferta.Name = "txtoferta";
            this.txtoferta.Size = new System.Drawing.Size(172, 29);
            this.txtoferta.TabIndex = 2;
            // 
            // txtprecioprod
            // 
            this.txtprecioprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecioprod.Location = new System.Drawing.Point(194, 170);
            this.txtprecioprod.Name = "txtprecioprod";
            this.txtprecioprod.Size = new System.Drawing.Size(153, 29);
            this.txtprecioprod.TabIndex = 2;
            // 
            // txtnombreprod
            // 
            this.txtnombreprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombreprod.Location = new System.Drawing.Point(194, 52);
            this.txtnombreprod.Name = "txtnombreprod";
            this.txtnombreprod.Size = new System.Drawing.Size(229, 29);
            this.txtnombreprod.TabIndex = 1;
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbtipo.Items.AddRange(new object[] {
            "Carnicos",
            "Limpieza",
            "Alimentos",
            "Electricos",
            "Lacteos"});
            this.cbtipo.Location = new System.Drawing.Point(194, 103);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(153, 30);
            this.cbtipo.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 481);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(173, 350);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(121, 51);
            this.btnmodificar.TabIndex = 7;
            this.btnmodificar.Text = "Modificar Producto";
            this.btnmodificar.UseVisualStyleBackColor = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(960, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnregresar);
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R E G I S T R O   D E   P R O D U C T O S";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RegistrarProd;
        private System.Windows.Forms.RadioButton rbactivaroferta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtoferta;
        private System.Windows.Forms.TextBox txtprecioprod;
        private System.Windows.Forms.TextBox txtnombreprod;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.Button btnmodificar;
    }
}