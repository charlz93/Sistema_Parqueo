using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Capa_de_Datos
{
    public class Parametros
    {
        //Parametros
        public String Nombre { get; set; } //nombre de variable
        public Object Valor { get; set; } //dato de la variable
        public SqlDbType TipoDato { get; set; } //Tipo de dato de la variable
        public Int32 Tamanno { get; set; } //Tamaño del tipo de dato de la variable
        public ParameterDirection Direccion { get; set; } //Direccion de la variable ya sea de entrada o de salida
        
        //Constructores
        //Entrada
        public Parametros(string nombre, object valor)
        {
            Nombre = nombre;
            Valor = valor;
            Direccion = ParameterDirection.Input;
        }

        //Salida
        public Parametros(string nombre, object valor, int tamanno)
        {
            Tamanno = tamanno;
            Nombre = nombre;
            Valor = valor;
            Direccion = ParameterDirection.Output;
        }

        


    }
}
