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
            dgvBar = new DataGridView();
            ColNombre = new DataGridViewTextBoxColumn();
            ColBebidasSAlchohol = new DataGridViewTextBoxColumn();
            ColBebidasCAlcohol = new DataGridViewTextBoxColumn();
            ColPostres = new DataGridViewTextBoxColumn();
            ColComidas = new DataGridViewTextBoxColumn();
            btnValidar = new Button();
            btnMozoDelDia = new Button();
            btnTotales = new Button();
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
            dgvBar.Location = new Point(370, 85);
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
            btnValidar.Location = new Point(565, 315);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnMozoDelDia
            // 
            btnMozoDelDia.Location = new Point(713, 315);
            btnMozoDelDia.Name = "btnMozoDelDia";
            btnMozoDelDia.Size = new Size(95, 23);
            btnMozoDelDia.TabIndex = 2;
            btnMozoDelDia.Text = "Mozo del día";
            btnMozoDelDia.UseVisualStyleBackColor = true;
            btnMozoDelDia.Click += btnMozoDelDia_Click;
            // 
            // btnTotales
            // 
            btnTotales.Location = new Point(855, 315);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(99, 23);
            btnTotales.TabIndex = 3;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            btnTotales.Click += btnTotales_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 641);
            Controls.Add(btnTotales);
            Controls.Add(btnMozoDelDia);
            Controls.Add(btnValidar);
            Controls.Add(dgvBar);
            Name = "Form1";
            Text = "La milanga; mozos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBar).EndInit();
            ResumeLayout(false);
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
    }
}
