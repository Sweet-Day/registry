using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry.Forms.Registry
{
    public partial class CreateOutpatientCard : Form
    {   //форма для створення нової амбулаторної картки 
        //методи з закінченням на Validation це методи що перевіряють коректність даних
        private readonly PatientService patientService;
        private readonly OutpatientCardsService outpatientCardsService;
        PatientDTO patientDTO;
        public PatientDTO SelectedPatient 
        { 
            get=>patientDTO;
            set {
                patientDTO = value;
                dateOfBirth_picker.Value = patientDTO.DateOfBirth;
                Address_textBox.Text=patientDTO.Address;
                Contacts_textBox.Text=patientDTO.Contacts;
                FullName_textBox.Text=patientDTO.FullName;
                Gender_cmb.SelectedItem=patientDTO.Gender;
                Passport_textBox.Text=patientDTO.PassportNumber;
            } 
        }
        public CreateOutpatientCard(PatientService patientService,OutpatientCardsService outpatientCards)
        {
           

            this.patientService = patientService;
            this.outpatientCardsService = outpatientCards;
            InitializeComponent();
            Gender_cmb.Items.Add("Чоловік");
            Gender_cmb.Items.Add("Жінка");
            Gender_cmb.Items.Add("КПІшник");
        }
        private void CreateOutpatientCard_Load(object sender, EventArgs e)
        {
            
        }


        private async void Save_btn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (SelectedPatient == null)
                {
                    this.Save_btn.Enabled = false;
                    this.Cancel_btn.Enabled = false;
                    PatientDTO newPatient = new PatientDTO
                    {
                        Id = Guid.NewGuid(),
                        DateOfBirth = dateOfBirth_picker.Value,
                        Address = Address_textBox.Text,
                        Contacts = Contacts_textBox.Text,
                        FullName = FullName_textBox.Text,
                        Gender = Gender_cmb.SelectedItem.ToString(),
                        PassportNumber = Passport_textBox.Text
                    };
                    await patientService.AddAsync(newPatient);
                    OutpatientCardDTO newCard = new OutpatientCardDTO();
                    newCard.Id = Guid.NewGuid();
                    newCard.PatientId = newPatient.Id;
                    await outpatientCardsService.AddAsync(newCard);
                    MessageBox.Show("Нову амбулаторну картку успішно додано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    this.Save_btn.Enabled = false;
                    this.Cancel_btn.Enabled = false;
                    SelectedPatient.DateOfBirth = dateOfBirth_picker.Value;
                    SelectedPatient.Address = Address_textBox.Text;
                    SelectedPatient.Contacts = Contacts_textBox.Text;
                    SelectedPatient.FullName = FullName_textBox.Text;
                    SelectedPatient.Gender = Gender_cmb.SelectedItem.ToString();
                    SelectedPatient.PassportNumber = Passport_textBox.Text;
                    await patientService.UpdateAsync(SelectedPatient);
                    MessageBox.Show("Дані про пацієнта успішно редаговано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }
      





        #region Validate all fields
        private void FullName_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (FullName_textBox.Text.Length < 2)
            {
                e.Cancel=true;
                errorProvider1.SetError(FullName_textBox, "Це поле має містити більше 2 символів!");
            }
            else
            {
                Regex regex = new Regex("^((?!^Username$)[a-zA-Zа-яА-ЯіїЇІ '])+$");
                MatchCollection matches = regex.Matches(FullName_textBox.Text);
                if (matches.Count == 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(FullName_textBox, "Некоректне ім'я користувача!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(FullName_textBox, "");
                }
            }
        }
        private void Address_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Address_textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Address_textBox, "Введіть правильну адресу!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Address_textBox, "");
            }
        }
        private void Contacts_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^((\+?3)?8)?0\d{9}$");
            MatchCollection matches = regex.Matches(Contacts_textBox.Text);
            if (matches.Count == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(Contacts_textBox, "Некоректний номер телефону!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Contacts_textBox, "");
            }
        }
        private void Passport_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Passport_textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Passport_textBox, "Введіть правильну адресу!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Passport_textBox, "");
            }
        }
        private void Gender_cmb_Validating(object sender, CancelEventArgs e)
        {
            if (Gender_cmb.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(Gender_cmb, "Це обов'язкове поле!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Gender_cmb, "");
            }
        }
        #endregion

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
