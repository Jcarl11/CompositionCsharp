using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Composition
{
    class Patient
    {
        private string name;
        private string gender;
        private MedRecord medRecord;

        public Patient( string name, string gender, MedRecord medRecord ) {
            this.name = name;
            this.gender = gender;
            this.medRecord = medRecord;
        }


        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        internal MedRecord MedRecord { get => medRecord; set => medRecord = value; }
    }
}
