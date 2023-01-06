using System.Xml.Linq;
using Zadanie3.Modele;

namespace Zadanie3
{
    public partial class StudentDialog : Form
    {
        public Student student { get; set; }
        public StudentDialog()
        {
            InitializeComponent();
        }

        public StudentDialog(ref Student s) : this()
        {
            student = s;
            imieTextBox.Text = student.Imie;
            nazwiskotextBox.Text = student.Nazwisko;
            numerindeksutextBox.Text = student.indexNumber;
        }

        private void okbutton_Click_1(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            if (student == null)
            {
                student = new Student();
            }
            student.Imie = imieTextBox.Text;
            student.Nazwisko = nazwiskotextBox.Text;
            student.indexNumber = numerindeksutextBox.Text;
            Close();
        }

        private void anulujButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(imieTextBox.Text) || string.IsNullOrEmpty(nazwiskotextBox.Text) || string.IsNullOrEmpty(numerindeksutextBox.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie dane - imie, nazwisko, numer indeksu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numerindeksutextBox.Text.Length != 6)
            {
                MessageBox.Show("Zła długość numeru indeksu, numer indeksu powinien wygladac: pdxxxx", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
