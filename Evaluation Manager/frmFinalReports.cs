using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluation_Manager.Repositories;
namespace Evaluation_Manager {
    public partial class frmFinalReports : Form {
        public frmFinalReports() {
            InitializeComponent();
        }
        private List<StudentReportView> GenerateStudentReport() {
            var allStudents = StudentRepository.GetStudents();
            var examReports = new List<StudentReportView>();
            foreach(var student in allStudents) {
                if (student.HasSignature() == true) {
                    var examReport = new StudentReportView(student);

                    examReports.Add(examReport);
                }
            }
            return examReports;

        }
        private void frmFinalReports_Load(object sender, EventArgs e) {
            var results = GenerateStudentReport();
            dgvResults.DataSource = results; // odaklen ce vuc rezultate

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
