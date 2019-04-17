using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exercise2_Composition {
    public partial class RecordList : Form {
        List<Doctor> doctors;
        string columnTitles = "{0, 10}{1, 50}{2, 100}";
        public RecordList() {
            InitializeComponent();
            listbox.Items.Add(String.Format(columnTitles, "Doctor name", "Normal Patient","Patient count"));
            
            doctors = Data.DoctorList;

            foreach(var doctor in doctors) {
                listbox.Items.Add( doctor );
            }
        }
    }
}
