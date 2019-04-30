using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exercise2_Composition {
    public partial class RecordList : Form {
        List<Doctor> doctors;
        public RecordList() {
            InitializeComponent();
            doctors = Mediator.DoctorList;
            foreach (var doctor in doctors) {
                ListViewItem listView = new ListViewItem( doctor.GetCompleteName() );
                listView.SubItems.Add(doctor.getNormalPatientCount().ToString());
                listView.SubItems.Add( doctor.getHypertensivePatientCount().ToString() );
                listView.SubItems.Add( doctor.PatientsList.ToArray().Length.ToString() );
                listview.Items.Add( listView );
            }
        }
    }
}
