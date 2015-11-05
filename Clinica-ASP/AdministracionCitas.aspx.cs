﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;

namespace Clinica_ASP
{
    public partial class AdministracionCitas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateFecha.Attributes["type"] = "date";
            txtHoraC.Attributes["type"] = "time";
        }

        protected void btnAgendar_Click(object sender, EventArgs e)
        {
            using (ClinicaAspEntities oConexion = new ClinicaAspEntities())
            {

                int ced = Convert.ToInt32(Session["cedula"]);
                Cita NuevaCita = new Cita();

                NuevaCita.Cedula = ced;
                NuevaCita.FechaCita = Convert.ToDateTime(DateFecha.Value);
                NuevaCita.HoraCita = Convert.ToString(txtHoraC.Value);
                NuevaCita.Descripcion = txtDescripcion.Value;

                oConexion.Cita.AddObject(NuevaCita);
                oConexion.SaveChanges();

                string Correo = Session["correo"].ToString();
                string NombreUsuario = Session["user"].ToString();

                MensajeAsignacionCita(Correo, NombreUsuario, DateFecha.Value, txtHoraC.Value);

                bool n = true;

                if (n == true)
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Se Agendo Correctamente la Cita')</script>");
                }

            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            int ced = Convert.ToInt32(Session["cedula"]);
            using (ClinicaAspEntities oConexion = new ClinicaAspEntities())
            {
                List<CitaPaciente> resultado = (from c in oConexion.Usuario
                                                join f in oConexion.Cita
                                                on c.Cedula equals f.Cedula
                                                where c.Cedula == ced
                                                select new CitaPaciente()
                                                {

                                                    Cedula = c.Cedula,
                                                    Nombre = c.NombreUsuario,
                                                    Apellido = c.ApellidoUsuario,
                                                    Fecha = f.FechaCita,
                                                    Hora = f.HoraCita,
                                                    Telefono = c.telefono
                                                }
                                                      ).ToList();

                GridView1.DataSource = resultado;
                GridView1.DataBind();
            }


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            using (ClinicaAspEntities oConexion = new ClinicaAspEntities())
            {
                int ced = Convert.ToInt32(Session["cedula"]);
                Cita CancelarCita = oConexion.Cita.Where(w => w.Cedula == ced).Single();

                oConexion.DeleteObject(CancelarCita);
                oConexion.SaveChanges();

                string Correo = Session["correo"].ToString();
                string NombreUsuario = Session["user"].ToString();

                MensajeCancelacionCita(Correo, NombreUsuario);

                bool ee = true;


                if (ee == true)
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Se Cancelo la Cita Correctamente')</script>");

                    List<CitaPaciente> resultado = (from c in oConexion.Usuario
                                                    join f in oConexion.Cita
                                                    on c.Cedula equals f.Cedula
                                                    where c.Cedula == ced
                                                    select new CitaPaciente()
                                                    {

                                                        Cedula = c.Cedula,
                                                        Nombre = c.NombreUsuario,
                                                        Apellido = c.ApellidoUsuario,
                                                        Fecha = f.FechaCita,
                                                        Hora = f.HoraCita,
                                                        Telefono = c.telefono
                                                    }
                                                     ).ToList();

                    GridView1.DataSource = resultado;
                    GridView1.DataBind();

                }
            }
        }

        public void MensajeAsignacionCita(string CorreoUsuario, string NombreUsuario, string Fecha, string Hora)
        {
            string mensaje = "Estimado usuario: "+NombreUsuario + "\n" +  Environment.NewLine + "Te recordamos que se ha realizado una solicitud de cita medica para el " +  Environment.NewLine
                              + Fecha + " a las " + Hora + Environment.NewLine + "Cordial Saludo," + Environment.NewLine + Environment.NewLine + "Portal Salud Web";
 
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("contactosclinicaweb@gmail.com", "Portal Salud Web", Encoding.UTF8);
            mail.Subject = "Notificación Fecha de la Cita";
            mail.Body = mensaje;
            mail.To.Add(CorreoUsuario);

            SmtpServer.Port = 587; //Puerto que utiliza Gmail para sus servicios

            SmtpServer.Credentials = new System.Net.NetworkCredential("contactosclinicaweb@gmail.com", "contactos2030");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }

        public void MensajeCancelacionCita(string CorreoUsuario, string NombreUsuario)
        {
            string mensaje = "Estimado usuario: " + NombreUsuario + "\n" + Environment.NewLine + "Te recordamos que has cancelado la cita medica que tenias agendado con nosotros" + Environment.NewLine
                              + Environment.NewLine + "Cordial Saludo," + Environment.NewLine + Environment.NewLine + "Portal Salud Web";

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("contactosclinicaweb@gmail.com", "Portal Salud Web", Encoding.UTF8);
            mail.Subject = "Notificación cancelación de la Cita";
            mail.Body = mensaje;
            mail.To.Add(CorreoUsuario);

            SmtpServer.Port = 587; //Puerto que utiliza Gmail para sus servicios

            SmtpServer.Credentials = new System.Net.NetworkCredential("contactosclinicaweb@gmail.com", "contactos2030");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
       
    }
}