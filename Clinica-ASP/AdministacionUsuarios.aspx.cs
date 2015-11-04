﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clinica_ASP
{
    public partial class AdministacionUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {

                Response.Redirect("Principal.aspx");

            }
        }

        protected void btnRol_Click(object sender, EventArgs e)
        {
            using (ClinicaAspEntities oConexion = new ClinicaAspEntities())
            {
                TipoUsuario NuevoRol = new TipoUsuario();

                NuevoRol.Cedula = Convert.ToInt32(txtCedula.Text);
                NuevoRol.IdTipoUsuario = Convert.ToInt32(ddlTipo.SelectedValue);
                NuevoRol.NombreTipoUsuario = ddlTipo.SelectedItem.Text;


                oConexion.TipoUsuario.AddObject(NuevoRol);
                oConexion.SaveChanges();
                bool n = true;

                if (n == true)
                {
                    txtCedula.Text = "";
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Se Asigno el Rol Correctamente')</script>");
                }

            }
        }
    }
}