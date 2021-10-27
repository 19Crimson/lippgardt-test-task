using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientsSort
{
    public partial class SearchPatientsForm : Form
    {    
        private class Patient
        {
            public String Name;
            public string Surname;
            public int age;
            public String status;

            public Patient(string name, string surname, int age, string status)
            {
                this.Name = name;
                this.Surname = surname;
                this.age = age;
                this.status = status;
            }
        }

        // Example data
        static Patient p1 = new("Alex", "Mitchel", 21, "critical");
        static Patient p2 = new("Kate", "Pupsvel", 18, "critical");
        static Patient p3 = new("Georgy", "Robinson", 42, "normal");
        static Patient p4 = new("LG", "Company", 120, "normal");
        static Patient p5 = new("Mikky", "Mouse", 30, "critical");

        // Array of existing Patients
        Patient[] patientsArr = new[] {p1, p2, p3, p4, p5};

        // This array will contain patients found after any query
        Patient[] foundPatients = { };

        public SearchPatientsForm()
        {
            InitializeComponent();
        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                listBoxByName.Items.Clear();
                listBoxByName.Items.Add("Введите фамилию");
                return;
            }
            foundPatients =  patientsArr.Where(c => c.Name.ToLower() == textBoxName.Text.ToLower()).ToArray();
            if (foundPatients.Length == 0)
            {
                listBoxByName.Items.Clear();
                listBoxByName.Items.Add("Пациенты не найдены..");
            }
            else
            {
                listBoxByName.Items.Clear();
                foreach (var p in foundPatients)
                {
                    listBoxByName.Items.Add(p.Name + " " + p.Surname + "\n");
                }
            }
        }

        private void btnFindBySurname_Click(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "")
            {
                listBoxBySurname.Items.Clear();
                listBoxBySurname.Items.Add("Введите фамилию");
                return;
            }
            foundPatients = patientsArr.Where(c => c.Surname.ToLower() == textBoxSurname.Text.ToLower()).ToArray();
            if (foundPatients.Length == 0)
            {
                listBoxBySurname.Items.Clear();
                listBoxBySurname.Items.Add("Пациенты не найдены..");
            }
            else
            {
                listBoxBySurname.Items.Clear();
                foreach (var p in foundPatients)
                {
                    listBoxBySurname.Items.Add(p.Name + " " + p.Surname + "\n");
                }
            }
        }

        private void btnCritical_Click(object sender, EventArgs e)
        {
            foundPatients = patientsArr.Where(c => c.status.ToLower() == "critical").ToArray();
            if (foundPatients.Length == 0)
            {
                listBoxByCritical.Items.Clear();
                listBoxByCritical.Items.Add("Пациенты не найдены..");
            }
            else
            {
                listBoxByCritical.Items.Clear();
                foreach (var p in foundPatients)
                {
                    listBoxByCritical.Items.Add(p.Name + " " + p.Surname + "\n");
                }
            }
        }

        private void btnLessThan_Click(object sender, EventArgs e)
        {
            try
            {
                foundPatients = patientsArr.Where(c => c.age < Convert.ToInt32(textBoxAge.Text)).ToArray();
            }
            catch
            {
                listBoxByAge.Items.Clear();
                listBoxByAge.Items.Add("Введите число");
                return;
            }
            if (foundPatients.Length == 0)
            {
                listBoxByAge.Items.Clear();
                listBoxByAge.Items.Add("Пациенты не найдены..");
            }
            else
            {
                listBoxByAge.Items.Clear();
                foreach (var p in foundPatients)
                {
                    listBoxByAge.Items.Add(p.Name + " " + p.Surname + "\n");
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxAge.Clear();
            listBoxByName.Items.Clear();
            listBoxBySurname.Items.Clear();
            listBoxByCritical.Items.Clear();
            listBoxByAge.Items.Clear();
        }
    }
}
