using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clinica_ASP
{
    public partial class PgMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cedula"] != null)
            {
                UsuarioL.Visible = true;
                RegistroL.Visible = false;
                MenuCitas.Visible = true;
                AdminUser.Visible = true; //temporalmente
            }
            else
            {
                UsuarioL.Visible = false;
                RegistroL.Visible = true;
                MenuCitas.Visible = false;
                AdminUser.Visible = false; //temporalmente
            }
            
        }

        protected void CerrarSesionAction_Click(object sender, EventArgs e)
        {
            Session["cedula"] = null;
            Session["nombre"] = null;
            Session["tipousuario"] = null;
            UsuarioL.Visible = false;
            RegistroL.Visible = true;
            Session.Clear();
            Response.Redirect("PaginadeInicio.aspx");
        }

    }
}