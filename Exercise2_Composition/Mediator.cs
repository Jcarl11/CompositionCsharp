using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Composition {
    static class Mediator {
        private static List<Doctor> doctorList;

        internal static List<Doctor> DoctorList { get => doctorList; set => doctorList = value; }
    }
}
