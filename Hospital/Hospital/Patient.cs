using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    
class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string Department { get; set; }
        public double TreatmentCost { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Gender: {Gender}, Age: {Age}, Phone: {PhoneNumber}, State: {State}, Pincode: {Pincode}, Department: {Department}, Cost: {TreatmentCost}";
        }
    }

    
}

