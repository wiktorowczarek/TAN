namespace Zadanie3
{
    partial class StudentDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.okbutton = new System.Windows.Forms.Button();
            this.anulujButton = new System.Windows.Forms.Button();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskotextBox = new System.Windows.Forms.TextBox();
            this.numerindeksutextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(140, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numer indeksu:";
            // 
            // okbutton
            // 
            this.okbutton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.okbutton.Location = new System.Drawing.Point(96, 238);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(118, 52);
            this.okbutton.TabIndex = 3;
            this.okbutton.Text = "Ok";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click_1);
            // 
            // anulujButton
            // 
            this.anulujButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.anulujButton.Location = new System.Drawing.Point(311, 238);
            this.anulujButton.Name = "anulujButton";
            this.anulujButton.Size = new System.Drawing.Size(125, 52);
            this.anulujButton.TabIndex = 4;
            this.anulujButton.Text = "Anuluj";
            this.anulujButton.UseVisualStyleBackColor = true;
            this.anulujButton.Click += new System.EventHandler(this.anulujButton_Click_1);
            // 
            // imieTextBox
            // 
            this.imieTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imieTextBox.Location = new System.Drawing.Point(220, 36);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(287, 43);
            this.imieTextBox.TabIndex = 5;
            // 
            // nazwiskotextBox
            // 
            this.nazwiskotextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nazwiskotextBox.Location = new System.Drawing.Point(220, 94);
            this.nazwiskotextBox.Name = "nazwiskotextBox";
            this.nazwiskotextBox.Size = new System.Drawing.Size(287, 43);
            this.nazwiskotextBox.TabIndex = 6;
            // 
            // numerindeksutextBox
            // 
            this.numerindeksutextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numerindeksutextBox.Location = new System.Drawing.Point(220, 153);
            this.numerindeksutextBox.Name = "numerindeksutextBox";
            this.numerindeksutextBox.Size = new System.Drawing.Size(287, 43);
            this.numerindeksutextBox.TabIndex = 7;
            // 
            // StudentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 324);
            this.Controls.Add(this.numerindeksutextBox);
            this.Controls.Add(this.nazwiskotextBox);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(this.anulujButton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj studenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button okbutton;
        private Button anulujButton;
        private TextBox imieTextBox;
        private TextBox nazwiskotextBox;
        private TextBox numerindeksutextBox;
    }
}