namespace Form1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonEstudiante = new System.Windows.Forms.Button();
            this.labelCarnet = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNota1 = new System.Windows.Forms.Label();
            this.labelNota2 = new System.Windows.Forms.Label();
            this.labelNota3 = new System.Windows.Forms.Label();
            this.labelNota4 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.textBoxNota3 = new System.Windows.Forms.TextBox();
            this.textBoxNota4 = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEstudiante
            // 
            this.buttonEstudiante.Location = new System.Drawing.Point(12, 12);
            this.buttonEstudiante.Name = "buttonEstudiante";
            this.buttonEstudiante.Size = new System.Drawing.Size(75, 23);
            this.buttonEstudiante.TabIndex = 0;
            this.buttonEstudiante.Text = "Estudiante";
            this.buttonEstudiante.UseVisualStyleBackColor = true;
            this.buttonEstudiante.Click += new System.EventHandler(this.buttonEstudiante_Click);
            // 
            // labelCarnet
            // 
            this.labelCarnet.AutoSize = true;
            this.labelCarnet.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarnet.Location = new System.Drawing.Point(49, 42);
            this.labelCarnet.Name = "labelCarnet";
            this.labelCarnet.Size = new System.Drawing.Size(49, 20);
            this.labelCarnet.TabIndex = 1;
            this.labelCarnet.Text = "Carnet";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(49, 91);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(22, 20);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            // 
            // labelNota1
            // 
            this.labelNota1.AutoSize = true;
            this.labelNota1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota1.Location = new System.Drawing.Point(49, 115);
            this.labelNota1.Name = "labelNota1";
            this.labelNota1.Size = new System.Drawing.Size(47, 20);
            this.labelNota1.TabIndex = 3;
            this.labelNota1.Text = "Nota 1";
            // 
            // labelNota2
            // 
            this.labelNota2.AutoSize = true;
            this.labelNota2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota2.Location = new System.Drawing.Point(49, 138);
            this.labelNota2.Name = "labelNota2";
            this.labelNota2.Size = new System.Drawing.Size(47, 20);
            this.labelNota2.TabIndex = 4;
            this.labelNota2.Text = "Nota 2";
            // 
            // labelNota3
            // 
            this.labelNota3.AutoSize = true;
            this.labelNota3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota3.Location = new System.Drawing.Point(48, 162);
            this.labelNota3.Name = "labelNota3";
            this.labelNota3.Size = new System.Drawing.Size(47, 20);
            this.labelNota3.TabIndex = 5;
            this.labelNota3.Text = "Nota 3";
            // 
            // labelNota4
            // 
            this.labelNota4.AutoSize = true;
            this.labelNota4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota4.Location = new System.Drawing.Point(48, 184);
            this.labelNota4.Name = "labelNota4";
            this.labelNota4.Size = new System.Drawing.Size(47, 20);
            this.labelNota4.TabIndex = 6;
            this.labelNota4.Text = "Nota 4";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(49, 68);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(57, 20);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(112, 42);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarnet.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Location = new System.Drawing.Point(112, 68);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(173, 20);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(112, 91);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(38, 20);
            this.textBoxID.TabIndex = 10;
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(112, 115);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(38, 20);
            this.textBoxNota1.TabIndex = 11;
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(112, 138);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(38, 20);
            this.textBoxNota2.TabIndex = 12;
            // 
            // textBoxNota3
            // 
            this.textBoxNota3.Location = new System.Drawing.Point(112, 162);
            this.textBoxNota3.Name = "textBoxNota3";
            this.textBoxNota3.Size = new System.Drawing.Size(38, 20);
            this.textBoxNota3.TabIndex = 13;
            // 
            // textBoxNota4
            // 
            this.textBoxNota4.Location = new System.Drawing.Point(112, 184);
            this.textBoxNota4.Name = "textBoxNota4";
            this.textBoxNota4.Size = new System.Drawing.Size(38, 20);
            this.textBoxNota4.TabIndex = 14;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(257, 343);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 15;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(168, 131);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(117, 51);
            this.buttonAgregar.TabIndex = 16;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(18, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 124);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Para buscar solo se requiere del carnet!!!!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxNota4);
            this.Controls.Add(this.textBoxNota3);
            this.Controls.Add(this.textBoxNota2);
            this.Controls.Add(this.textBoxNota1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNota4);
            this.Controls.Add(this.labelNota3);
            this.Controls.Add(this.labelNota2);
            this.Controls.Add(this.labelNota1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelCarnet);
            this.Controls.Add(this.buttonEstudiante);
            this.Name = "Form2";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEstudiante;
        private System.Windows.Forms.Label labelCarnet;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNota1;
        private System.Windows.Forms.Label labelNota2;
        private System.Windows.Forms.Label labelNota3;
        private System.Windows.Forms.Label labelNota4;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.TextBox textBoxNota3;
        private System.Windows.Forms.TextBox textBoxNota4;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}