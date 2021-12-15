using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretMyPhoneBook
{
    public partial class Form1 : Form
    {

        private Person[] People = new Person[0];

        public Form1()
        {
            InitializeComponent();
        }

        private void ListPeople(Person[] array)
        {
            lstPeople.Items.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                Person p = array[i];
                lstPeople.Items.Add(p.Name + " " + p.Surname + " - " + p.Phone);
            }
        }

        private void SaveToFile()
        {
            string[] lines = new string[People.Length];

            foreach (Person person in People)
            {
                lines[Array.IndexOf(People, person)] = $"{person.Name}|{person.Surname}|{person.Phone}|{person.CategoryIndex}|{person.IsFemale}|{person.IsFavorite}";
            }

            // c:\Users\murat\Desktop
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string path = Application.StartupPath + @"\data.txt";
            System.IO.File.WriteAllLines(path, lines);
        }

        private void LoadFromFile()
        {
            string path = Application.StartupPath + @"\data.txt";

            // dosya var mı kontrolü.
            if (System.IO.File.Exists(path) == false)
            {
                return;
            }


            string[] lines = System.IO.File.ReadAllLines(path);

            People = new Person[lines.Length];

            // lines
            // Tolga|Yazgı|(111) 111-1111|1|False|True
            // Dilay|Canıtez|(444) 444-4444|1|True|True

            foreach (string line in lines)
            {
                // line
                // Tolga|Yazgı|(111) 111-1111|1|False|True

                string[] parts = line.Split('|');

                Person person = new Person();
                person.Name = parts[0];
                person.Surname = parts[1];
                person.Phone = parts[2];
                person.CategoryIndex = int.Parse(parts[3]);
                person.IsFemale = bool.Parse(parts[4]);
                person.IsFavorite = bool.Parse(parts[5]);

                People[Array.IndexOf(lines, line)] = person;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnSave.Visible = false;
            btnDel.Visible = false;

            LoadFromFile(); //People dizisi dolacak bu noktada.
            ListPeople(People); // listbox doldurulacak.

            //lstPeople.Items.Add("Murat Başeren");
            //lstPeople.Items.Add("İrem Yurtlugil");
            //lstPeople.Items.Add("Enes Yıldız");
            //lstPeople.Items.Add("Şiir Turan");



            //string[] metinler = new string[3];
            //Random random = new Random();

            //foreach (string metin in metinler)
            //{
            //    metinler[Array.IndexOf(metinler, metin)] = random.Next(1, 50).ToString();
            //}

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //txtName.Text = "";
            //txtName.Text = string.Empty;

            //txtName.Clear();
            //txtSurname.Clear();
            //txtPhone.Clear();
            //rdbFemale.Checked = true;
            //chkFavorite.Checked = false;
            //cmbCategory.SelectedIndex = -1;

            btnAdd.Visible = true;
            btnSave.Visible = false;
            btnDel.Visible = false;
        }

        private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstPeople.SelectedIndex;

            //if (index == -1)
            //{
            //    return;
            //}

            if (index > -1)
            {
                Person person = People[index];

                txtName.Text = person.Name;
                txtSurname.Text = person.Surname;
                txtPhone.Text = person.Phone;
                cmbCategory.SelectedIndex = person.CategoryIndex;
                rdbFemale.Checked = person.IsFemale;
                rdbMale.Checked = !person.IsFemale;
                //rdbMale.Checked = (person.IsFemale == true) ? false : true;
                chkFavorite.Checked = person.IsFavorite;

                btnAdd.Visible = false;
                btnSave.Visible = true;
                btnDel.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();
            newPerson.Name = txtName.Text;
            newPerson.Surname = txtSurname.Text;
            newPerson.Phone = txtPhone.Text;
            newPerson.CategoryIndex = cmbCategory.SelectedIndex;
            newPerson.IsFemale = rdbFemale.Checked;
            newPerson.IsFavorite = chkFavorite.Checked;

            Array.Resize(ref People, People.Length + 1);
            People[People.Length - 1] = newPerson;
            
            ListPeople(People);
            SaveToFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Yöntem 1
            //Person newPerson = new Person();
            //newPerson.Name = txtName.Text;
            //newPerson.Surname = txtSurname.Text;
            //newPerson.Phone = txtPhone.Text;
            //newPerson.CategoryIndex = cmbCategory.SelectedIndex;
            //newPerson.IsFemale = rdbFemale.Checked;
            //newPerson.IsFavorite = chkFavorite.Checked;

            //int index = lstPeople.SelectedIndex;
            //People[index] = newPerson;

            // --------------------------------------------------------------

            // Yöntem 2
            int index = lstPeople.SelectedIndex;
            Person person = People[index];

            person.Name = txtName.Text;
            person.Surname = txtSurname.Text;
            person.Phone = txtPhone.Text;
            person.CategoryIndex = cmbCategory.SelectedIndex;
            person.IsFemale = rdbFemale.Checked;
            person.IsFavorite = chkFavorite.Checked;

            ListPeople(People);
            SaveToFile();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index = lstPeople.SelectedIndex;

            if (index > -1)
            {
                Person person = People[index];

                DialogResult result = MessageBox.Show($"{person.Name} {person.Surname} isimli telefon kaydını silmek istediğinize emin misiniz?", "Telefon Kaydı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Person[] newArray = new Person[People.Length - 1];
                    bool isSkip = false;

                    for (int i = 0; i < People.Length; i++)
                    {
                        if (i == index)
                        {
                            // bunu atla.
                            isSkip = true;
                            continue;
                        }

                        if (isSkip == false)
                        {
                            newArray[i] = People[i];
                        }
                        else
                        {
                            newArray[i - 1] = People[i];
                        }
                    }

                    //Array.Resize(ref People, People.Length - 1);
                    People = newArray;

                    ListPeople(People);
                    SaveToFile();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(txtSearch.Text);
            string search = txtSearch.Text.Trim();

            //if (search == "" || search == null)
            if (string.IsNullOrEmpty(search))
            {
                // tüm kayıtları listele..
                ListPeople(People);
            }
            else
            {
                // yazılana göre arama yaparak uygun kayıtları göstermemiz gerekiyor.

                Person[] filteredPeople = new Person[0];

                foreach (Person person in People)
                {
                    if (person.Name.Contains(search, StringComparison.CurrentCultureIgnoreCase) || person.Surname.Contains(search, StringComparison.CurrentCultureIgnoreCase) || person.Phone.Contains(search, StringComparison.CurrentCultureIgnoreCase))
                    {
                        Array.Resize(ref filteredPeople, filteredPeople.Length + 1);
                        filteredPeople[filteredPeople.Length - 1] = person;
                    }
                }

                ListPeople(filteredPeople);



                //for (int i = 0; i < People.Length; i++)
                //{
                //    Person person = People[i];
                //}

                //foreach (Person person in People)
                //{
                //    MessageBox.Show(person.Name + " " + person.Surname);
                //}

                //foreach (Person person in People)
                //{
                //    person.Name += "-xxx";
                //}


                //string[] metinler = new string[] { "Elma", "Armut", "Kiraz" };

                //foreach (string metin in metinler)
                //{
                //    int index = Array.IndexOf(metinler, metin);
                //    MessageBox.Show(metin);
                //}
            }
        }

        private void btnAtoZ_Click(object sender, EventArgs e)
        {
            // Ayrı bir dizi tanımlayın
            // People dizisindeki name ve Surname alanlarını birleştirin
            // Oluşan Name Surname ifadesine göre A-Z sıralama yapın.
            // Yeni diziyi listbox da listeleyin.
        }

        private void btnZtoA_Click(object sender, EventArgs e)
        {
            // Ayrı bir dizi tanımlayın
            // People dizisindeki name ve Surname alanlarını birleştirin
            // Oluşan Name Surname ifadesine göre Z-A sıralama yapın.
            // Yeni diziyi listbox da listeleyin.
        }
    }
}
