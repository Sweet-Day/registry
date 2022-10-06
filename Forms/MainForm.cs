using BLL.DTO;
using BLL.Modules;
using BLL.Services;
using Registry.Forms.Doctors;
using Registry.Forms.Patients;
using Registry.Forms.Registry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry.Forms
{
    public partial class MainForm : Form
    {   //головна форма

        DoctorsService doctorsService;
        OutpatientCardsService outpatientCardsService;
        PatientService patientService;
        AppointmentService appointmentService;

        DoctorDTO[] doctors;
        OutpatientCardDTO[] outpatientCards;
        AppointmentDTO[] appointments;

        public MainForm(
            DoctorsService doctorsService, 
            OutpatientCardsService outpatientCardsService, 
            PatientService patientService,
            AppointmentService appointmentService)
        {
            this.doctorsService = doctorsService;
            this.outpatientCardsService = outpatientCardsService;
            this.patientService = patientService;
            this.appointmentService = appointmentService;
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            Doctors_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            Doctors_cmb.Items.Clear();

            doctors = (await doctorsService.GetAllAsync())
                .OrderBy(x => x.CabinetNumber)
                .ToArray();
            SettingsDoctorsGrid();
            UploadDoctorsData();

            foreach(var item in doctors)
            {
                Doctors_cmb.Items.Add(item.FullName);
            }

            outpatientCards = (await outpatientCardsService.GetAllAsync())
                .OrderBy(x => patientService.Get(x.PatientId).FullName)
                .ToArray();
            SetOutpatientCardsGrid();
            UploadOutpatientCardsData();

            SettingAppointmentsGrid();
        }
        private void SettingsDoctorsGrid()
        {
            Doctors_grid.AllowUserToAddRows = false;
            Doctors_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Doctors_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Doctors_grid.ReadOnly = true;
            Doctors_grid.Columns.Add("FullName", "ПІБ");
            Doctors_grid.Columns.Add("Specialization", "");
            Doctors_grid.Columns.Add("Cabinet", "Кабінет");

            DataGridViewButtonColumn btnSchedule = new DataGridViewButtonColumn();
            btnSchedule.Name = "getSchedule";
            btnSchedule.HeaderText = "";
            Doctors_grid.Columns.Add(btnSchedule);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "createAppointment";
            btn.HeaderText = "";
            Doctors_grid.Columns.Add(btn);

            Doctors_grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Doctors_grid.MultiSelect = false;
            foreach (DataGridViewColumn item in Doctors_grid.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void SetOutpatientCardsGrid()
        {
            Outpatient_cards_grid.AllowUserToAddRows = false;
            Outpatient_cards_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Outpatient_cards_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Outpatient_cards_grid.ReadOnly = true;
            Outpatient_cards_grid.Columns.Add("OutpatientCardId", "Ідентифікатор картки");
            Outpatient_cards_grid.Columns.Add("Patient", "Пацієнт");
            Outpatient_cards_grid.Columns.Add("NumberPhone", "Номер телефону пацієнта");
            Outpatient_cards_grid.Columns.Add("Passport", "Номер паспорта");

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "editPatient";
            btn.HeaderText = "";
            Outpatient_cards_grid.Columns.Add(btn);


            Outpatient_cards_grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Outpatient_cards_grid.MultiSelect = false;
            foreach (DataGridViewColumn item in Outpatient_cards_grid.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void SettingAppointmentsGrid()
        {
            Appointments_grid.AllowUserToAddRows = false;
            Appointments_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Appointments_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Appointments_grid.ReadOnly = true;

            Appointments_grid.Columns.Add("Date", "Дата");
            Appointments_grid.Columns.Add("Time", "Час");
            Appointments_grid.Columns.Add("PatientFullName","ПІБ Пацієнта");
            Appointments_grid.Columns.Add("PatientPhoneNumber", "Номер телефону пацієнта");
            Appointments_grid.Columns.Add("DoctorFullName", "Лікар");
            Appointments_grid.Columns.Add("CabinetNumber", "Кабінет");

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "closeAppointment";
            btn.HeaderText = "";
            Appointments_grid.Columns.Add(btn);

            Appointments_grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Appointments_grid.MultiSelect = false;
            foreach (DataGridViewColumn item in Appointments_grid.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }





        private void UploadDoctorsData()
        {
            foreach (var doctor in doctors)
            {
                 Doctors_grid.Rows.Add(
                    doctor.FullName,
                    doctor.Speciality,
                    doctor.CabinetNumber,
                    "Розклад",
                    "Записатися"
                 );
            }
        }
        private void UploadOutpatientCardsData()
        {
            Outpatient_cards_grid.Rows.Clear();
            foreach (var card in outpatientCards)
            {
                PatientDTO patient = patientService.Get(card.PatientId);
                Outpatient_cards_grid.Rows.Add(
                    card.Id,
                    patient.FullName,
                    patient.Contacts,
                    patient.PassportNumber,
                    "Редагувати"
                    );
            }
        }
        private async void UploadAppointmentsData()
        {
            if (Doctors_cmb.SelectedIndex != -1) {
                Appointments_grid.Rows.Clear();
                appointments = (await appointmentService.GetAllAsync())
                    .Where(x => x.DoctorId == doctors[Doctors_cmb.SelectedIndex].Id)
                    .Where(x =>
                    {
                        if (Select_datePicker.Value.ToString("dd-MMMM-yyyy") == x.AppointmentDate.ToString("dd-MMMM-yyyy"))
                        {
                            return true;
                        }
                        return false;
                      
                    })
                    .OrderBy(x=>x.AppointmentDate)
                    .ToArray();
                foreach(var item in appointments)
                {
                    PatientDTO patient = patientService.Get(item.PatientId);
                    Appointments_grid.Rows.Add(
                         item.AppointmentDate.ToString("dd-MMMM-yyyy"),
                         item.AppointmentDate.ToString("t"),
                         patient.FullName,
                         patient.Contacts,
                         doctors[Doctors_cmb.SelectedIndex].FullName,
                         doctors[Doctors_cmb.SelectedIndex].CabinetNumber,
                         "Прийняти"
                        );
                }
                    
            }
        }



        private void Doctors_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Doctors_grid.Columns["getSchedule"].Index && e.RowIndex >= 0)
            {
                Schedule form = CompositionRoot.Resolve<Schedule>();
                form.SetDoctor(doctors[e.RowIndex]);
                form.ShowDialog();
            }
            else if (e.ColumnIndex == Doctors_grid.Columns["createAppointment"].Index && e.RowIndex >= 0)
            {
                SelectionPatients form=CompositionRoot.Resolve<SelectionPatients>();
                form.ShowDialog();
                if (form.SelectedPatient != null)
                {
                    MakeAnAppointment appointmentForm = CompositionRoot.Resolve<MakeAnAppointment>();
                    appointmentForm.Doctor = doctors[e.RowIndex];
                    appointmentForm.Patient = form.SelectedPatient;
                    appointmentForm.ShowDialog();
                    if (appointmentForm.DialogResult == DialogResult.OK)
                    {
                        UploadAppointmentsData();
                    }
                }
            }
        }

        private async void CreateCard_btn_Click(object sender, EventArgs e)
        {
            CreateOutpatientCard form = CompositionRoot.Resolve<CreateOutpatientCard>();
            form.ShowDialog();
            outpatientCards = (await outpatientCardsService.GetAllAsync())
                .OrderBy(x => patientService.Get(x.PatientId).FullName)
                .ToArray();
            UploadOutpatientCardsData();
        }

        private async void Outpatient_cards_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Outpatient_cards_grid.Columns["editPatient"].Index && e.RowIndex >= 0)
            {   
                PatientDTO patient = patientService.Get(outpatientCards[e.RowIndex].PatientId);
                CreateOutpatientCard form = CompositionRoot.Resolve<CreateOutpatientCard>();
                form.SelectedPatient = patient;
                form.ShowDialog();

                Outpatient_cards_grid.Rows[e.RowIndex].Cells["Patient"].Value = form.SelectedPatient.FullName;
                Outpatient_cards_grid.Rows[e.RowIndex].Cells["NumberPhone"].Value = form.SelectedPatient.Contacts;
                Outpatient_cards_grid.Rows[e.RowIndex].Cells["Passport"].Value = form.SelectedPatient.PassportNumber;
            }
        }

        private void Search_appointment_btn_Click(object sender, EventArgs e)
        {
            UploadAppointmentsData();
        }

        private async void Appointments_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Appointments_grid.Columns["closeAppointment"].Index && e.RowIndex >= 0)
            {
                CreateConclusion form = CompositionRoot.Resolve<CreateConclusion>();
                AppointmentDTO appointment = appointments[e.RowIndex];
                form.OutpatientCardId = (await outpatientCardsService.GetAllAsync()).FirstOrDefault(x => x.PatientId == appointment.PatientId).Id;
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    await appointmentService.DeleteAsync(appointment.Id);
                    UploadAppointmentsData();
                }
            }
        }
    }
}
