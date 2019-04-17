using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Composition {
    class MedRecord {
        private static int systolicMaxThreshold = 140;
        private static int systolicMinThreshold = 70;
        private static int diastolicMaxThreshold = 90;
        private static int diastolicMinThreshold = 60;
        private int systolic;
        private int diastolic;
        private string bp;

        public MedRecord( int systolic, int diastolic ) {
            this.systolic = systolic;
            this.diastolic = diastolic;
        }

        public void CheckCondition() {
            bp = systolic >= systolicMinThreshold 
                && systolic < systolicMaxThreshold
                && diastolic >= diastolicMinThreshold 
                && diastolic < diastolicMaxThreshold ? "NORMAL" : "HIGH";
        }
        public string Bp { get => bp; set => bp = value; }
    }
}
