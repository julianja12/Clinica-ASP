using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace Clinica_ASP
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtEmail.Attributes["type"] = "email";
            DateFecha.Attributes["type"] = "date";
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (ClinicaAspEntities oConexion = new ClinicaAspEntities())
            {

                Pacientes nuevaPersona = new Pacientes();
                nuevaPersona.CedulaPaciente = Convert.ToInt32(txtIdentificacion.Value);
                nuevaPersona.NombrePaciente = txtNombres.Value;
                nuevaPersona.ApellidoPaciente = txtApellidos.Value;
                nuevaPersona.telefono = Convert.ToInt32(txtTelefono.Value);
                nuevaPersona.anionacimiento = Convert.ToDateTime(DateFecha.Value);
                nuevaPersona.Email = txtEmail.Value;

                if (EncriptacionMD5(txtPass.Value).Equals(EncriptacionMD5(txtPassValidar.Value)))
                {
                    nuevaPersona.contrasena = EncriptacionMD5(txtPass.Value);
                    try
                    {
                        oConexion.SaveChanges();
                        Response.Write("<script LANGUAGE='JavaScript' >alert('Te has registrado correctamente')</script>");
                    }
                    catch (Exception ex)
                    {
                        LblValidarEmail.Text = ex.Message;
                        Response.Write("<script LANGUAGE='JavaScript' >alert('Error!')</script>");
                    }
                }
                else
                {
                    //Mensaje encima o debajo del campo Verificar Contraseña
                    LblValidarEmail.Text = "Las contraseñas ingresadas deben coincidir";
                }

                oConexion.AddToPacientes(nuevaPersona);
                oConexion.SaveChanges();
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        public static string EncriptacionMD5(string Pass)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(Pass));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}