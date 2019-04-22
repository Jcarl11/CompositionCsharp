using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_Composition
{
    public partial class Form1 : Form
    {
        List<Doctor> doctors = new List<Doctor>();
        Doctor doctor = null;
        string doctor_firstname = null;
        string doctor_lastname = null;
        public Form1()
        {
            InitializeComponent();
            Doctor doctor1 = new Doctor("Jon", "Snow");
            doctor1.addPatient( new Patient( "Joan", "Female", new MedRecord( 150, 100 ) ) );
            doctor1.addPatient( new Patient( "Joe", "Male", new MedRecord( 130, 90 ) ) );
            doctor1.addPatient( new Patient( "Jane", "Female", new MedRecord( 140, 85 ) ) );
            doctors.Add( doctor1 );

            Doctor doctor2 = new Doctor( "Sanza", "Stark" );
            doctor2.addPatient( new Patient( "Sarya", "Female", new MedRecord( 100, 70 ) ) );
            doctor2.addPatient( new Patient( "Sean", "Male", new MedRecord( 145, 80 ) ) );
            doctors.Add( doctor2 );

            Doctor doctor3 = new Doctor( "Tyrion", "Lanister" );
            doctor3.addPatient( new Patient( "Troy", "Male", new MedRecord( 100, 80 ) ) );
            doctor3.addPatient( new Patient( "Time", "Male", new MedRecord( 120, 85 ) ) );
            doctors.Add( doctor3 );
        }

        private void Button_add_Click( object sender, EventArgs e ) {
            
            if(!validateField( patient_name ) | !validateGender( groupbox_gender )) {
                return;
            }
            
            string patientname = patient_name.Text.Trim();
            int systolic = Decimal.ToInt32( numeric_systolic.Value );
            int diastolic = Decimal.ToInt32(numeric_diastolic.Value);
            string gender = radiobtn_male.Checked ? "Male" : "Female";

            
            doctor.addPatient( new Patient( patientname, gender, new MedRecord( systolic, diastolic ) ) );
            
            clearFields();
            MessageBox.Show( "Record added", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information );    
        }

        private bool validateField(TextBox textBox) {
            if (string.IsNullOrEmpty( textBox.Text )) {
                errorProvider.SetError( textBox, "This cannot be blank" );
                return false;
            } else {
                errorProvider.SetError( textBox, null );
                return true;
            }
        }

        private bool validateGender( GroupBox groupBox ) {

            if (!radiobtn_male.Checked && !radiobtn_female.Checked) {
                errorProvider.SetError( groupBox, "Choose a gender" );
                return false;
            } else {
                errorProvider.SetError( groupBox, null );
                return true;
            }
        }
        private void clearFields() {
            patient_name.Clear();
            radiobtn_male.Checked = false;
            radiobtn_female.Checked = false;
            numeric_systolic.Value = 0;
            numeric_diastolic.Value = 0;
        }
        private void Button_show_Click( object sender, EventArgs e ) {
            Data.DoctorList = doctors;
            RecordList recordList = new RecordList();
            recordList.Show();
        }

        private void Button_newrecord_Click( object sender, EventArgs e ) {
            groupBox2.Enabled = true;
            groupBox1.Visible = false;
        }

        private void Button2_Click( object sender, EventArgs e ) {
            if(!validateField( doctor_fname ) | !validateField( doctor_lname )) {
                return;
            }
            doctor_firstname = doctor_fname.Text.Trim();
            doctor_lastname = doctor_lname.Text.Trim();
            doctor = new Doctor( doctor_firstname, doctor_lastname );
            
            if (checkIfDoctorExist()) {
                MessageBox.Show( "Doctor already exist, Please enter a new one", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error );
                return;
            }
            doctors.Add( doctor );
            groupBox1.Visible = true;
            groupBox2.Enabled = false;
        }

        private bool checkIfDoctorExist() {
            int hit = 0;
            foreach (var doc in doctors.ToList()) {
                if (string.Equals( doc.GetCompleteName(), doctor.GetCompleteName() )) {
                    hit++;
                }
            }
            return hit == 0 ? false : true;
        }
    }
}
