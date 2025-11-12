namespace frmLaMilanga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvBar = new DataGridView();
            ColNombre = new DataGridViewTextBoxColumn();
            ColBebidasSAlchohol = new DataGridViewTextBoxColumn();
            ColBebidasCAlcohol = new DataGridViewTextBoxColumn();
            ColPostres = new DataGridViewTextBoxColumn();
            ColComidas = new DataGridViewTextBoxColumn();
            btnValidar = new Button();
            btnMozoDelDia = new Button();
            btnTotales = new Button();
            lblTitulo = new Label();
            lblFrase = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBar).BeginInit();
            SuspendLayout();
            // 
            // dgvBar
            // 
            dgvBar.AllowUserToAddRows = false;
            dgvBar.AllowUserToDeleteRows = false;
            dgvBar.AllowUserToResizeColumns = false;
            dgvBar.AllowUserToResizeRows = false;
            dgvBar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBar.Columns.AddRange(new DataGridViewColumn[] { ColNombre, ColBebidasSAlchohol, ColBebidasCAlcohol, ColPostres, ColComidas });
            dgvBar.Location = new Point(21, 97);
            dgvBar.Name = "dgvBar";
            dgvBar.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvBar.Size = new Size(610, 264);
            dgvBar.TabIndex = 0;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombres";
            ColNombre.Name = "ColNombre";
            // 
            // ColBebidasSAlchohol
            // 
            ColBebidasSAlchohol.HeaderText = "Bebidas sin alcohol";
            ColBebidasSAlchohol.Name = "ColBebidasSAlchohol";
            // 
            // ColBebidasCAlcohol
            // 
            ColBebidasCAlcohol.HeaderText = "Bebidas con alcohol";
            ColBebidasCAlcohol.Name = "ColBebidasCAlcohol";
            // 
            // ColPostres
            // 
            ColPostres.HeaderText = "Postres";
            ColPostres.Name = "ColPostres";
            // 
            // ColComidas
            // 
            ColComidas.HeaderText = "Comidas";
            ColComidas.Name = "ColComidas";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(218, 315);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnMozoDelDia
            // 
            btnMozoDelDia.Location = new Point(356, 315);
            btnMozoDelDia.Name = "btnMozoDelDia";
            btnMozoDelDia.Size = new Size(95, 23);
            btnMozoDelDia.TabIndex = 2;
            btnMozoDelDia.Text = "Mozo del día";
            btnMozoDelDia.UseVisualStyleBackColor = true;
            btnMozoDelDia.Click += btnMozoDelDia_Click;
            // 
            // btnTotales
            // 
            btnTotales.Location = new Point(499, 315);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(99, 23);
            btnTotales.TabIndex = 3;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            btnTotales.Click += btnTotales_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(494, 50);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Registro de ventas de mozos";
            // 
            // lblFrase
            // 
            lblFrase.AutoSize = true;
            lblFrase.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFrase.Location = new Point(12, 412);
            lblFrase.Name = "lblFrase";
            lblFrase.Size = new Size(717, 30);
            lblFrase.TabIndex = 5;
            lblFrase.Text = "“Cada venta cuenta, pero el verdadero éxito está en el trabajo en equipo.”";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(759, 543);
            Controls.Add(lblFrase);
            Controls.Add(lblTitulo);
            Controls.Add(btnTotales);
            Controls.Add(btnMozoDelDia);
            Controls.Add(btnValidar);
            Controls.Add(dgvBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "La milanga; mozos";
            Load += frmLaMilanga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBar;
        private Button btnValidar;
        private Button btnMozoDelDia;
        private Button btnTotales;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColBebidasSAlchohol;
        private DataGridViewTextBoxColumn ColBebidasCAlcohol;
        private DataGridViewTextBoxColumn ColPostres;
        private DataGridViewTextBoxColumn ColComidas;
        private Label lblTitulo;
        private Label lblFrase;
    }
}
