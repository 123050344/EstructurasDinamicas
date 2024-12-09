namespace EstructurasDinamicas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPila = new TextBox();
            btnAgregarPila = new Button();
            btnEliminarPila = new Button();
            btnMostrarPila = new Button();
            lstPila = new ListView();
            lstCola = new ListView();
            lstLista = new ListView();
            btnAgregarLista = new Button();
            btnAgregarCola = new Button();
            btnEliminarCola = new Button();
            btnEliminarLista = new Button();
            btnMostrarCola = new Button();
            btnMostrarLista = new Button();
            txtCola = new TextBox();
            txtLista = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 25);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un número para la PILA";
            // 
            // txtPila
            // 
            txtPila.Location = new Point(53, 59);
            txtPila.Name = "txtPila";
            txtPila.Size = new Size(145, 23);
            txtPila.TabIndex = 1;
            // 
            // btnAgregarPila
            // 
            btnAgregarPila.Location = new Point(53, 99);
            btnAgregarPila.Name = "btnAgregarPila";
            btnAgregarPila.Size = new Size(145, 39);
            btnAgregarPila.TabIndex = 2;
            btnAgregarPila.Text = "Agregar";
            btnAgregarPila.UseVisualStyleBackColor = true;
            btnAgregarPila.Click += btnAgregarPila_Click;
            // 
            // btnEliminarPila
            // 
            btnEliminarPila.Location = new Point(53, 144);
            btnEliminarPila.Name = "btnEliminarPila";
            btnEliminarPila.Size = new Size(145, 39);
            btnEliminarPila.TabIndex = 3;
            btnEliminarPila.Text = "Eliminar";
            btnEliminarPila.UseVisualStyleBackColor = true;
            btnEliminarPila.Click += btnEliminarPila_Click;
            // 
            // btnMostrarPila
            // 
            btnMostrarPila.Location = new Point(53, 189);
            btnMostrarPila.Name = "btnMostrarPila";
            btnMostrarPila.Size = new Size(145, 39);
            btnMostrarPila.TabIndex = 4;
            btnMostrarPila.Text = "Mostrar";
            btnMostrarPila.UseVisualStyleBackColor = true;
            btnMostrarPila.Click += btnMostrarPila_Click;
            // 
            // lstPila
            // 
            lstPila.Location = new Point(31, 233);
            lstPila.Name = "lstPila";
            lstPila.Size = new Size(189, 205);
            lstPila.TabIndex = 5;
            lstPila.UseCompatibleStateImageBehavior = false;
            // 
            // lstCola
            // 
            lstCola.Location = new Point(237, 233);
            lstCola.Name = "lstCola";
            lstCola.Size = new Size(189, 205);
            lstCola.TabIndex = 6;
            lstCola.UseCompatibleStateImageBehavior = false;
            // 
            // lstLista
            // 
            lstLista.Location = new Point(446, 233);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(189, 205);
            lstLista.TabIndex = 7;
            lstLista.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregarLista
            // 
            btnAgregarLista.Location = new Point(476, 99);
            btnAgregarLista.Name = "btnAgregarLista";
            btnAgregarLista.Size = new Size(145, 39);
            btnAgregarLista.TabIndex = 8;
            btnAgregarLista.Text = "Agregar";
            btnAgregarLista.UseVisualStyleBackColor = true;
            btnAgregarLista.Click += btnAgregarLista_Click;
            // 
            // btnAgregarCola
            // 
            btnAgregarCola.Location = new Point(261, 99);
            btnAgregarCola.Name = "btnAgregarCola";
            btnAgregarCola.Size = new Size(145, 39);
            btnAgregarCola.TabIndex = 9;
            btnAgregarCola.Text = "Agregar";
            btnAgregarCola.UseVisualStyleBackColor = true;
            btnAgregarCola.Click += btnAgregarCola_Click;
            // 
            // btnEliminarCola
            // 
            btnEliminarCola.Location = new Point(261, 144);
            btnEliminarCola.Name = "btnEliminarCola";
            btnEliminarCola.Size = new Size(145, 39);
            btnEliminarCola.TabIndex = 10;
            btnEliminarCola.Text = "Eliminar";
            btnEliminarCola.UseVisualStyleBackColor = true;
            btnEliminarCola.Click += btnEliminarCola_Click;
            // 
            // btnEliminarLista
            // 
            btnEliminarLista.Location = new Point(476, 144);
            btnEliminarLista.Name = "btnEliminarLista";
            btnEliminarLista.Size = new Size(145, 39);
            btnEliminarLista.TabIndex = 11;
            btnEliminarLista.Text = "Eliminar";
            btnEliminarLista.UseVisualStyleBackColor = true;
            btnEliminarLista.Click += btnEliminarLista_Click;
            // 
            // btnMostrarCola
            // 
            btnMostrarCola.Location = new Point(261, 189);
            btnMostrarCola.Name = "btnMostrarCola";
            btnMostrarCola.Size = new Size(145, 39);
            btnMostrarCola.TabIndex = 12;
            btnMostrarCola.Text = "Mostrar";
            btnMostrarCola.UseVisualStyleBackColor = true;
            btnMostrarCola.Click += btnMostrarCola_Click;
            // 
            // btnMostrarLista
            // 
            btnMostrarLista.Location = new Point(476, 189);
            btnMostrarLista.Name = "btnMostrarLista";
            btnMostrarLista.Size = new Size(145, 39);
            btnMostrarLista.TabIndex = 13;
            btnMostrarLista.Text = "Mostrar";
            btnMostrarLista.UseVisualStyleBackColor = true;
            btnMostrarLista.Click += btnMostrarLista_Click;
            // 
            // txtCola
            // 
            txtCola.Location = new Point(261, 59);
            txtCola.Name = "txtCola";
            txtCola.Size = new Size(145, 23);
            txtCola.TabIndex = 14;
            // 
            // txtLista
            // 
            txtLista.Location = new Point(476, 59);
            txtLista.Name = "txtLista";
            txtLista.Size = new Size(145, 23);
            txtLista.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 25);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 16;
            label2.Text = "Ingrese un número para la COLA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 25);
            label3.Name = "label3";
            label3.Size = new Size(239, 15);
            label3.TabIndex = 17;
            label3.Text = "Ingrese un número para la LISTA ENLAZADA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLista);
            Controls.Add(txtCola);
            Controls.Add(btnMostrarLista);
            Controls.Add(btnMostrarCola);
            Controls.Add(btnEliminarLista);
            Controls.Add(btnEliminarCola);
            Controls.Add(btnAgregarCola);
            Controls.Add(btnAgregarLista);
            Controls.Add(lstLista);
            Controls.Add(lstCola);
            Controls.Add(lstPila);
            Controls.Add(btnMostrarPila);
            Controls.Add(btnEliminarPila);
            Controls.Add(btnAgregarPila);
            Controls.Add(txtPila);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPila;
        private Button btnAgregarPila;
        private Button btnEliminarPila;
        private Button btnMostrarPila;
        private ListView lstPila;
        private ListView lstCola;
        private ListView lstLista;
        private Button btnAgregarLista;
        private Button btnAgregarCola;
        private Button btnEliminarCola;
        private Button btnEliminarLista;
        private Button btnMostrarCola;
        private Button btnMostrarLista;
        private TextBox txtCola;
        private TextBox txtLista;
        private Label label2;
        private Label label3;
    }
}
