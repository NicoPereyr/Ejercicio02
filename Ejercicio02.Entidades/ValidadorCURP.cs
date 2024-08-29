using System.Text.RegularExpressions;

namespace Ejercicio02.Entidades
{
    public static class ValidadorCURP
    {
        public static bool Validar(string curp)
        {
            return curp.Length == 18 && EsFormatoValido(curp);
        }

        public static string GenerarCurp(string nombreComp, DateTime fechaNac, string lugarNac, char sexo)
        {
            string[] nombreDiv = nombreComp.ToUpper().Split(' ');

            if (nombreDiv.Length < 3)
                throw new ArgumentException("El nombre completo debe incluir nombre, apellido paterno y apellido materno.");
            string iniciales = $"{nombreDiv[1][0]}{nombreDiv[2][0]}{nombreDiv[0][0]}";
            string fecha = fechaNac.ToString("aaMMdd");
            string aleatorio = "XXNN";
            string curp = iniciales + fecha + lugarNac + sexo + aleatorio;

            return curp;
        }
        private static bool EsFormatoValido(string curp)
        {
            string patron = @"^[A-Z]{4}\d{6}[A-Z]{6}\d{2}$";
            return Regex.IsMatch(curp, patron);
        }

    }
}
