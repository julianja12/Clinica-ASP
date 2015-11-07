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
                RegistroL.Visible = false;
                UsuarioL.Visible = true;

                if (Session["tipoUsuario"].ToString()=="1")
                {
                    AdminUser.Visible = true;
                    AdminFormula.Visible = false;
                    MenuCitas.Visible = false;
                    ReportesL.Visible = true;
                }
                else if (Session["tipoUsuario"].ToString()=="2")
                {
                    AdminUser.Visible = false;
                    AdminFormula.Visible = true;
                    MenuCitas.Visible = false;
                    ReportesL.Visible = false;
                }
                else
                {
                    AdminUser.Visible = false;
                    AdminFormula.Visible = false;
                    MenuCitas.Visible = true;
                    ReportesL.Visible = false;
                }
            }
            else
            {
                UsuarioL.Visible = false;
                RegistroL.Visible = true;
                MenuCitas.Visible = false;
                AdminUser.Visible = false;
                AdminFormula.Visible = false;
            }
            
        }

        protected void CerrarSesionAction_Click(object sender, EventArgs e)
        {
            Session["cedula"] = null;
            Session["user"] = null;
            Session["tipousuario"] = null;
            Session["correo"] = null;
            UsuarioL.Visible = false;
            RegistroL.Visible = true;
            AdminUser.Visible = false;
            AdminFormula.Visible = false;
            MenuCitas.Visible = false;
            Session.Clear();
            Response.Redirect("PaginadeInicio.aspx");
        }

    }
}