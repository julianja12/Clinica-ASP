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
    public partial class PgMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Para que reconosca el txtEmail como tipo email
            txtEmail.Attributes["type"] = "email";
            if (Session["cedula"] != null)
            {
                UsuarioL.Visible = true;
                RegistroL.Visible = false;
                MenuCitas.Visible = true;
                AdminUser.Visible = true; //temporalmente
                loginPrincipal.Visible = false;
            }
            else
            {
                UsuarioL.Visible = false;
                RegistroL.Visible = true;
                MenuCitas.Visible = false;
                AdminUser.Visible = false; //temporalmente
                loginPrincipal.Visible = true;
            }
            

        }

        protected void IngresarAction_Click(object sender, EventArgs e)
        {
            loginPrincipal.EnableViewState = true;
            string email = txtEmail.Value;
            string pass = txtPass.Value; //sin MD5

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
                Response.Redirect("PaginadeInicio.aspx");
            }
            else
	        {
	            lblMensaje.Text = "Usuario o Contraseña Incorrecto";
	        }
        }

        protected void CerrarSesionAction_Click(object sender, EventArgs e)
        {
            Session["cedula"] = null;
            Session["nombre"] = null;
            Session["tipousuario"] = null;
            UsuarioL.Visible = false;
            RegistroL.Visible = true;
            loginPrincipal.Visible = true;
            Page.ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.open('close.html', '_self', null);", true);
            Response.Redirect("PaginadeInicio.aspx");
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