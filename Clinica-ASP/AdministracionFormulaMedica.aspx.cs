﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clinica_ASP
{
    public partial class AdministracionFormulaMedica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarC_Click(object sender, EventArgs e)
        {
            int ced = Convert.ToInt32(txtConsultaC.Text);
            using (ClinicaAspEntities oConexion = new ClinicaAspEntities())
            {
                List<CitaHistoria> resultado = (from c in oConexion.Usuario
                                                join f in oConexion.Cita
                                                on c.Cedula equals f.Cedula
                                                where c.Cedula == ced
                                                select new CitaHistoria()
                                                {
                                                    IdCita = f.IdCita,
                                                    Cedula = c.Cedula,
                                                    Nombre = c.NombreUsuario,
                                                    Apellido = c.ApellidoUsuario,
                                                    Fecha = f.FechaCita,
                                                   
                                                }
                                                ).ToList();

                GridViewF.DataSource = resultado;
                GridViewF.DataBind();
            }
        }

        protected void bntFormula_Click(object sender, EventArgs e)
        {
            using (ClinicaAspEntities oConexion = new ClinicaAspEntities())
            {

                int IdCita = Convert.ToInt32(txtIdCita.Text);
                
                FormulaMedica NuevaFormula = new FormulaMedica();
          
                NuevaFormula.IdCita = IdCita;
                NuevaFormula.RecetaMedica = txtFormula.Text;

                oConexion.FormulaMedica.AddObject(NuevaFormula);
                oConexion.SaveChanges();
                bool n = true;

                if (n == true)
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Se Registro Correctamente la Formula Medica')</script>");
                }

            }
        }
    }
}