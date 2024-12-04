using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Votos.Clases.Datos;

namespace Votos.Clases.Logica
{
    internal class AdministracionUsuarios
    {
        public static void ingresaUsuarios(string nombre , string apellido , int dni , string fec_nac, bool antecedentes)
        {
            string consulta = $"INSER INTO votantes VALUES ('{nombre}','{apellido}',{dni},{fec_nac},{antecedentes})";
            EjecutarConsultas.Altas(consulta);
        }
    }
}
