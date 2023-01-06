using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadanie3.Modele;

namespace Zadanie3
{
    public partial class OknoGlowneForm : Form
    {
        public List<Student> Studenci { get; set; } = new List<Student>();
        public OknoGlowneForm()
        {
            InitializeComponent();

            var s1 = new Student
            {
                Imie = "Wiktor",
                Nazwisko = "Owczarek",
                indexNumber = "pd3825"
            };

            var s2 = new Student
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                indexNumber = "pd1234"
            };

            Studenci.Add(s1);
            Studenci.Add(s2);

            studenciDataGridView.DataSource = Studenci;
        }

        private void studenciDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (studenciDataGridView.SelectedRows.Count == 0) {
                return;
            }

            var st = studenciDataGridView.SelectedRows[0].DataBoundItem as Student;
            imieTextBox.Text = st.Imie;
            nazwiskoTextBox.Text = st.Nazwisko;

        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            var dialog = new StudentDialog();
            dialog.ShowDialog();

            if(dialog.student != null)
            {
                Studenci.Add(dialog.student);
            }
            studenciDataGridView.DataSource = null;
            studenciDataGridView.DataSource = Studenci;
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            if (studenciDataGridView.SelectedRows.Count == 0) return;

            var student = studenciDataGridView.SelectedRows[0].DataBoundItem as Student;
            Studenci.Remove(student);
            studenciDataGridView.DataSource = null;
            studenciDataGridView.DataSource = Studenci;     
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (studenciDataGridView.SelectedRows.Count == 0) return;

            var student = studenciDataGridView.SelectedRows[0].DataBoundItem as Student;
            StudentDialog dlg = new StudentDialog(ref student);
            dlg.ShowDialog(this);

            if (dlg.student != null)
            {
                studenciDataGridView.DataSource = null;
                studenciDataGridView.DataSource = Studenci;
            }
        }
    }
}
