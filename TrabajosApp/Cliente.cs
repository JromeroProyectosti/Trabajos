using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajosEntity;

namespace TrabajosApp
{
     public class Cliente
    {
        public void crearCliente(String nombre, String Correo, String Telefono)
        {
            ModuloTrabajosDataContext dc_modulo = new ModuloTrabajosDataContext();
            CLIENTE objCliente = new CLIENTE();

            objCliente.Nombre = nombre;
            objCliente.Correo = Correo;
            objCliente.Telefono = Telefono;

            dc_modulo.CLIENTE.InsertOnSubmit(objCliente);
            dc_modulo.SubmitChanges();

           
        }
    }
}
