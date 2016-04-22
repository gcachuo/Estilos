namespace Estilos
{
    class globales
    {
        public string arraytofields(string[] arrayCadena)
        {
            var cadena = "";
            var index = 0;
            foreach (string campo in arrayCadena)
            {
                if (index != 0)
                {
                    cadena += ",";
                }
                cadena += "'" + campo + "'";
                index++;
            }
            return cadena;
        }
    }
    class Cliente
    {
        public string tabla = "Cliente";
        public string codigo = "codigoCliente CODIGO ";
        public string nombre = "nombreCliente NOMBRE ";
        public string estatus = "estatusCliente";
    }
}
