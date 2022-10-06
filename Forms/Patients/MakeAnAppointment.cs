using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry.Forms.Patients
{
    public partial class MakeAnAppointment : Form
    {   //форма для створення запису до лікаря
        private AppointmentService appointmentService { get; set; }
        public DoctorDTO Doctor { get; set; }   //лікар
        public PatientDTO Patient { get; set; } //обраний пацієнт


        public MakeAnAppointment(AppointmentService appointmentService)
        {
            InitializeComponent();
            this.appointmentService = appointmentService;
        }

        private async void ok_btn_Click(object sender, EventArgs e)
        {   //подія натискання на кнопку створення запису
            DateTime val = SelectDate_picker.Value;
            string[]time=SelectTime_cmb.SelectedItem.ToString().Split(new char[] {':'},StringSplitOptions.RemoveEmptyEntries);
            TimeSpan ts = new TimeSpan(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), 0);
            val = val.Date + ts;
            AppointmentDTO appointment = new AppointmentDTO
            {
                DoctorId = Doctor.Id,
                PatientId = Patient.Id,
                AppointmentDate = val,
                Id = Guid.NewGuid()
            };
            await appointmentService.AddAsync(appointment);
            MessageBox.Show("Ви успішно записалися на прийом до лікаря","Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private async void SelectDate_picker_ValueChanged(object sender, EventArgs e)
        {   //подія зміни дати прийому
            DateTime val = SelectDate_picker.Value;
            if (val >= DateTime.Now)
            {
                ScheduleDTO[] currentDaySchedule = Doctor.Schedules.Where(x => x.DayOfWeek == val.DayOfWeek).ToArray();

                AppointmentDTO[] appointments = (await appointmentService.GetAllAsync())
                      .Where(x => x.DoctorId == Doctor.Id)
                      .ToArray();
                currentDaySchedule = currentDaySchedule.Where(x => appointments.FirstOrDefault(k =>
                {
                    if (k.AppointmentDate.DayOfWeek == x.DayOfWeek && k.AppointmentDate.ToString("t", DateTimeFormatInfo.InvariantInfo) == x.Time)
                    {
                        return true;
                    }
                    return false;

                }) == null).ToArray();
                foreach (var item in currentDaySchedule)
                {
                    SelectTime_cmb.Items.Add(item.Time);
                }
                if (currentDaySchedule.Length != 0)
                {
                    SelectTime_cmb.SelectedIndex = 0;
                    selectTime_label.Visible = true;
                    SelectTime_cmb.Visible = true;
                    ok_btn.Visible = true;
                }
                else
                {
                    selectTime_label.Visible = false;
                    SelectTime_cmb.Visible = false;
                    ok_btn.Visible = false;
                    MessageBox.Show("На цей день немає вільних місць", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("На цю дату неможливо записатися", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void MakeAnAppointment_Load(object sender, EventArgs e)
        {   //подія завантаження форми
            DoctorsName_label.Text = Doctor.FullName;
            Speciality_label.Text = Doctor.Speciality;

            SelectTime_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            selectTime_label.Visible = false;
            SelectTime_cmb.Visible = false;
            ok_btn.Visible = false;
        }
    }
}
