using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Composition
{
    class Doctor
    {
        private string fname;
        private string lname;
        private Patient patient;
        private List<Patient> patientsList = new List<Patient>();

        public Doctor( string fname, string lname ) {
            this.fname = fname;
            this.lname = lname;
        }

        public string GetCompleteName() {
            return String.Format( "{0}, {1}", lname, fname );
        }
        

        public void addPatient(Patient newpatient ) {
            this.patient = newpatient;
            patientsList.Add( this.patient );
        }

        public int getNormalPatientCount() {
            int count = 0;
            foreach(var patient in patientsList) {
                patient.MedRecord.CheckCondition();
                if( string.Equals( patient.MedRecord.Bp, "NORMAL" )) {
                    count++;
                }
            }
            return count;
        }

        public override string ToString() {
            String value = String.Format( "{0, 0}     {1,50}     {2,100}", 
                GetCompleteName(), 
                getNormalPatientCount().ToString(),
                patientsList.ToArray().Length.ToString());
            return value;
        }

        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        internal Patient Patient { get => patient; set => patient = value; }
        internal List<Patient> PatientsList { get => patientsList; set => patientsList = value; }
    }
}
