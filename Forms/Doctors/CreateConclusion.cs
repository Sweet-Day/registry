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

namespace Registry.Forms.Doctors
{
    public partial class CreateConclusion : Form
    {
        private ConclusionService conclusionService;
        public Guid OutpatientCardId { get; set; }
        public CreateConclusion(ConclusionService conclusionService)
        {
            this.conclusionService = conclusionService;
            InitializeComponent();
        }

        private void CreateConclusion_Load(object sender, EventArgs e)
        {

        }

        private async void Create_btn_Click(object sender, EventArgs e)
        {
            ConclusionDTO newConclusion = new ConclusionDTO();
            newConclusion.Diagnosis=Diagnosis_textBox.Text;
            newConclusion.Treatment=Treatment_textBox.Text;
            newConclusion.OutpatientCardId = OutpatientCardId;


            await conclusionService.AddAsync(newConclusion);
            DialogResult=DialogResult.OK;
            this.Close();
        }
    }
}
