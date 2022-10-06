using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry.Forms.Patients
{
    public partial class SelectionPatients : Form
    {   //форма для вибору пацієнта 
        private readonly PatientService patientService;
        PatientDTO[] patients;  //усі пацієнти
        public PatientDTO SelectedPatient { get; set; }
        public SelectionPatients(PatientService patientService)
        {
            this.patientService = patientService;
            InitializeComponent();
        }

        private async void EditPatients_Load(object sender, EventArgs e)
        {   //подія завантаження форми
            patients = (await patientService.GetAllAsync())
                .OrderBy(x=>x.FullName)
                .ToArray();
            SettingPatientsGrid();
            UploadPatientsData();
        }
        private void SettingPatientsGrid()
        {   //метод для налаштування таблиці пацієнтів
            Patients_grid.AllowUserToAddRows = false;
            Patients_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Patients_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Patients_grid.ReadOnly = true;
            Patients_grid.Columns.Add("FullName", "ПІБ");
            Patients_grid.Columns.Add("Address", "Адреса проживання");
            Patients_grid.Columns.Add("NumberPhone", "Номер телефону");
            Patients_grid.Columns.Add("DateOfBirth", "Дата народження");
            Patients_grid.Columns.Add("Passport", "Номер паспорту");
            Patients_grid.Columns.Add("Gender", "Стать");
            Patients_grid.AutoResizeColumns();
            Patients_grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Patients_grid.MultiSelect = false;
            foreach (DataGridViewColumn item in Patients_grid.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void UploadPatientsData()
        {   //завантажуємо дані
            foreach(var patient in patients)
            {
                Patients_grid.Rows.Add(new[] 
                {
                    patient.FullName,
                    patient.Address,
                    patient.Contacts,
                    patient.DateOfBirth.ToString("dd-MM-yyyy"),
                    patient.PassportNumber,
                    patient.Gender
                });
            }         
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {   //натискаємо на кнопку вибору
            if (Patients_grid.CurrentRow.Index != -1)
            {
                SelectedPatient=patients[Patients_grid.CurrentRow.Index];
                this.Close();
            }
        }
    }
}
