namespace Zadanie3
{
    partial class OknoGlowneForm
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
            this.studenciDataGridView = new System.Windows.Forms.DataGridView();
            this.ImieCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwiskoCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerIndeksuCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usunButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.imieLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studenciDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studenciDataGridView
            // 
            this.studenciDataGridView.AllowUserToAddRows = false;
            this.studenciDataGridView.AllowUserToDeleteRows = false;
            this.studenciDataGridView.AllowUserToOrderColumns = true;
            this.studenciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studenciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImieCol1,
            this.NazwiskoCol2,
            this.NumerIndeksuCol3});
            this.studenciDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studenciDataGridView.Location = new System.Drawing.Point(0, 0);
            this.studenciDataGridView.Name = "studenciDataGridView";
            this.studenciDataGridView.ReadOnly = true;
            this.studenciDataGridView.RowTemplate.Height = 25;
            this.studenciDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studenciDataGridView.Size = new System.Drawing.Size(845, 533);
            this.studenciDataGridView.TabIndex = 0;
            this.studenciDataGridView.SelectionChanged += new System.EventHandler(this.studenciDataGridView_SelectionChanged);
            // 
            // ImieCol1
            // 
            this.ImieCol1.DataPropertyName = "Imie";
            this.ImieCol1.HeaderText = "Imię";
            this.ImieCol1.Name = "ImieCol1";
            this.ImieCol1.ReadOnly = true;
            // 
            // NazwiskoCol2
            // 
            this.NazwiskoCol2.DataPropertyName = "Nazwisko";
            this.NazwiskoCol2.HeaderText = "Nazwisko";
            this.NazwiskoCol2.Name = "NazwiskoCol2";
            this.NazwiskoCol2.ReadOnly = true;
            // 
            // NumerIndeksuCol3
            // 
            this.NumerIndeksuCol3.DataPropertyName = "IndexNumber";
            this.NumerIndeksuCol3.HeaderText = "Numer Indeksu";
            this.NumerIndeksuCol3.Name = "NumerIndeksuCol3";
            this.NumerIndeksuCol3.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.usunButton);
            this.panel1.Controls.Add(this.dodajButton);
            this.panel1.Controls.Add(this.nazwiskoTextBox);
            this.panel1.Controls.Add(this.imieTextBox);
            this.panel1.Controls.Add(this.nazwiskoLabel);
            this.panel1.Controls.Add(this.imieLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 124);
            this.panel1.TabIndex = 1;
            // 
            // usunButton
            // 
            this.usunButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usunButton.Location = new System.Drawing.Point(516, 19);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(142, 47);
            this.usunButton.TabIndex = 5;
            this.usunButton.Text = "Usuń";
            this.usunButton.UseVisualStyleBackColor = true;
            this.usunButton.Click += new System.EventHandler(this.usunButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dodajButton.Location = new System.Drawing.Point(673, 16);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(141, 50);
            this.dodajButton.TabIndex = 4;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Enabled = false;
            this.nazwiskoTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nazwiskoTextBox.Location = new System.Drawing.Point(146, 68);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(228, 35);
            this.nazwiskoTextBox.TabIndex = 3;
            // 
            // imieTextBox
            // 
            this.imieTextBox.Enabled = false;
            this.imieTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imieTextBox.Location = new System.Drawing.Point(146, 16);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(228, 35);
            this.imieTextBox.TabIndex = 2;
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nazwiskoLabel.Location = new System.Drawing.Point(21, 68);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(106, 30);
            this.nazwiskoLabel.TabIndex = 1;
            this.nazwiskoLabel.Text = "Nazwisko:";
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imieLabel.Location = new System.Drawing.Point(69, 16);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(58, 30);
            this.imieLabel.TabIndex = 0;
            this.imieLabel.Text = "Imię:";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(588, 68);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(152, 48);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edytuj";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // OknoGlowneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studenciDataGridView);
            this.Name = "OknoGlowneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno główne";
            ((System.ComponentModel.ISupportInitialize)(this.studenciDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView studenciDataGridView;
        private Panel panel1;
        private DataGridViewTextBoxColumn ImieCol1;
        private DataGridViewTextBoxColumn NazwiskoCol2;
        private DataGridViewTextBoxColumn NumerIndeksuCol3;
        private TextBox nazwiskoTextBox;
        private TextBox imieTextBox;
        private Label nazwiskoLabel;
        private Label imieLabel;
        private Button dodajButton;
        private Button usunButton;
        private Button editButton;
    }
}