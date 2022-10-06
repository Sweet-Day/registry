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

namespace Registry.Forms.Doctors
{
    public partial class Schedule : Form
    {  
        //форма для перегляду розклдау лікаря
        private readonly ScheduleService scheduleService;
        private readonly AppointmentService appointmentService;

        private DoctorDTO doctor;

        public Schedule(ScheduleService scheduleService, AppointmentService appointmentService)
        {
            this.scheduleService= scheduleService;
            this.appointmentService= appointmentService;
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {   //подія завантаження форми
            daysOfweek_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            DoctorsName_label.Text = doctor.FullName;
            Speciality_label.Text = doctor.Speciality;
            Time_label.Text += "\n";

            string[] days = doctor.Schedules
                .OrderBy(x=>x.DayOfWeek)
                .Select(x => DateTimeFormatInfo.CurrentInfo.GetDayName(x.DayOfWeek))
                .Distinct()
                .ToArray();
            daysOfweek_cmb.Items.AddRange(days);
        }
        public void SetDoctor(DoctorDTO doctor)
        {
            this.doctor = doctor;
        }
        private async void daysOfweek_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //подія зміни дня тижня
            if (daysOfweek_cmb.SelectedIndex >= 0)
            {
                Time_label.Text = "Години прийому\n";
                FreeTime_label.Text = "Вільно\n";

                int index = daysOfweek_cmb.SelectedIndex;
                ScheduleDTO[] currentSchedule = doctor.Schedules
                .Where(x => DateTimeFormatInfo.CurrentInfo.GetDayName(x.DayOfWeek) == daysOfweek_cmb.Items[index].ToString())
                .OrderBy(x=>x.Time)
                .ToArray();
                foreach (var item in currentSchedule)
                {
                    Time_label.Text += item.Time + "\n";
                }
                AppointmentDTO[] appointments = (await appointmentService.GetAllAsync())
                    .Where(x=>x.DoctorId==doctor.Id)
                    .ToArray();
                currentSchedule = currentSchedule.Where(x => appointments.FirstOrDefault(k =>
                {
                    if (k.AppointmentDate.DayOfWeek == x.DayOfWeek&&k.AppointmentDate.ToString("t",DateTimeFormatInfo.InvariantInfo)==x.Time)
                    {
                        return true;
                    }
                    return false;

                })==null).ToArray();

                foreach (var item in currentSchedule)
                {
                    FreeTime_label.Text += item.Time + "\n";
                }

            }
        }
    }
}
