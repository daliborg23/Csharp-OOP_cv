using System.Data;
using System.Text.Json;
using System.Windows.Forms;
using _2library;

namespace _3ui {
    public partial class Form1 : Form {
        public string fileContent;
        PeopleData[] People { get; set; }
        DataTable dt;
        public Form1() {
            InitializeComponent();
            fileContent = File.ReadAllText("people.json");
            People = JsonSerializer.Deserialize<PeopleData[]>(fileContent);

            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Email");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Language");
            dt.Columns.Add("University");
            dt.Columns.Add("Date of Birth", typeof(DateTime));
            dt.Columns.Add("Country");
            dt.Columns.Add("Company");
            dt.Columns.Add("Job title");
            foreach (PeopleData person in People) {
                dt.Rows.Add(person.Id, person.FirstName, person.LastName, person.Email,
                    person.Gender, person.Language, person.University, DateTime.ParseExact(person.DateOfBirth, "dd.MM.yyyy", null),
                    person.Country, person.Company, person.JobTitle);
            }
            //dataGridViewMain.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e) {
            dataGridViewMain.DataSource = dt;
            cbLanguage.Items.AddRange(LinqLib.GetLanguages(People));
        }
        private void rbLastName_CheckedChanged(object sender, EventArgs e) {
            List<PeopleData> orderedByLastName = new List<PeopleData>();
            if (rbLastName.Checked) {
                orderedByLastName = LinqLib.OrderByLastName(People);
                PopulateTheTable(orderedByLastName);
            }
        }
        private void rbLanguage_CheckedChanged(object sender, EventArgs e) {
            List<PeopleData> orderedByLanguage = new List<PeopleData>();
            if (rbLanguage.Checked) {
                orderedByLanguage = LinqLib.OrderByLanguage(People);
                PopulateTheTable(orderedByLanguage);
            }
        }
        private void rbCompany_CheckedChanged(object sender, EventArgs e) {
            List<PeopleData> orderedByCompany = new List<PeopleData>();
            if (rbCompany.Checked) {
                orderedByCompany = LinqLib.OrderByCompany(People);
                PopulateTheTable(orderedByCompany);
            }
        }
        private void PopulateTheTable(List<PeopleData> people) {
            dt.Clear();
            foreach (PeopleData person in people) {
                dt.Rows.Add(person.Id, person.FirstName, person.LastName, person.Email,
                    person.Gender, person.Language, person.University, DateTime.ParseExact(person.DateOfBirth, "dd.MM.yyyy", null),
                    person.Country, person.Company, person.JobTitle);
            }
            dataGridViewMain.DataSource = dt;
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e) {
            List<PeopleData> selectedLanguage = new List<PeopleData>();
            selectedLanguage = LinqLib.FilterLanguages(People, cbLanguage.SelectedItem.ToString());
            PopulateTheTable(selectedLanguage);
        }

        private void cbLanguage_TextUpdate(object sender, EventArgs e) {
            List<PeopleData> selectedLanguage = new List<PeopleData>();
            selectedLanguage = LinqLib.FilterLanguagesByText(People, cbLanguage.Text.ToString().ToLower());
            PopulateTheTable(selectedLanguage);
        }

        private void tbLastName_TextChanged(object sender, EventArgs e) {
            List<PeopleData> findLastName = new List<PeopleData>();
            findLastName = LinqLib.FindLastName(People, tbLastName.Text.ToString().ToLower());
            PopulateTheTable(findLastName);
        }
    }
}