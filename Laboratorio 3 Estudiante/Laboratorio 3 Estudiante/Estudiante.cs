using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_Estudiante
{
    class Estudiante
    {

        // Field
        public string name;
        // Constructor that takes no arguments.
        public Estudiante()
        {
            name = "unknown";
        }
        // Constructor that takes one argument.
        public Estudiante(string nm)
        {
            name = nm;
        }
        // Method
        public void SetName(string newName)
        {
            name = newName;
        }
    }

}
