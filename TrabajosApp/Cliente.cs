using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajosEntity;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace TrabajosApp
{
     public class Cliente
    {
         ModuloTrabajosDataContext mtd = new ModuloTrabajosDataContext();

         public int CrearCliente(String nombre, String correo, String telefono)
         {
             CLIENTE cl = new CLIENTE();

             cl.Nombre = nombre;
             cl.Correo = correo;
             cl.Telefono = telefono;

             mtd.CLIENTE.InsertOnSubmit(cl);

             try
             {
                 mtd.SubmitChanges();
                 return cl.IdCliente;
             }
             catch (Exception e)
             {
                 
                 throw e;
             }
         }
         public CLIENTE BuscarCliente(int idCliente)
         {
             
             try
             {
                 var cliente = from c in mtd.CLIENTE where c.IdCliente == idCliente select c;

                 if (cliente.Count() > 0)

                     return cliente.First();
                 else
                     return null;
             }
             catch (Exception)
             {
                 
                 throw;
             }
         }
         public CLIENTE BuscarCliente(String nombre)
         {
             try
             {
                 var cliente = from c in mtd.CLIENTE where c.Nombre == nombre select c;
                 if (cliente.Count() > 0)
                     return cliente.First();
                 else
                     return null;
             }
             catch (Exception)
             {
                 throw;
             }
         }
         public IEnumerable BuscarCliente()
         {
             try
             {
                 return from c in mtd.CLIENTE
                        select c;
             }
             catch (Exception)
             {
                 
                 throw;
             }
         }
    }
}
