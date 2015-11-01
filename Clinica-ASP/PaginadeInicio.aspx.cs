using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Text;

namespace Clinica_ASP
{
    public partial class PaginadeInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtEmail.Attributes["type"] = "email";

            if (Session["cedula"] != null)
            {
                loginUsuarios.Visible = false;
            }
            else
            {
                Session["nombre"] = null;
                loginUsuarios.Visible = true;
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Value;
            string pass = EncriptacionMD5(txtPass.Value);

            ClinicaAspEntities db = new ClinicaAspEntities();

            string queryPaciente = (from n in db.Pacientes
                                    where n.Email == email && n.contrasena == pass
                                    select n.NombrePaciente).FirstOrDefault();

            string queryMedico = (from n in db.Medicos
                                  where n.EmailM == email && n.contrasena == pass
                                  select n.NombreM).FirstOrDefault();

            if (queryPaciente != null)
            {
                int cedula = (from c in db.Pacientes
                              where c.Email == email && c.contrasena == pass
                              select c.CedulaPaciente).FirstOrDefault();

                Session["cedula"] = cedula.ToString();
                Session["tipousuario"] = "Paciente";
                Session["nombre"] = queryPaciente;
                loginUsuarios.Visible = false;
                Response.Redirect("PaginadeInicio.aspx");
            }
            else if (queryMedico != null)
            {
                int cedula = (from c in db.Medicos
                              where c.EmailM == email && c.contrasena == pass
                              select c.CedulaM).FirstOrDefault();
                Session["cedula"] = cedula.ToString();
                Session["tipousuario"] = "Medico";
                Session["nombre"] = queryMedico;
                loginUsuarios.Visible = false;
                Response.Redirect("PaginadeInicio.aspx");
            }
            else
            {
                lblMensaje.Text = "Usuario o Contraseña Incorrecto";
            }
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