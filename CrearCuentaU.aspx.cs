using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.Objects;

namespace Chocoloco
{
    public partial class CrearCuentaU : System.Web.UI.Page
    {
        db_chocolateriaEntities13 choco = new db_chocolateriaEntities13();

        protected void Button2_Click(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            String strDate = "";
            strDate = dt.ToString("MM/dd/yyyy");
            Response.Write("<script>alert(strDate)</script>");

            /*  
             string rut = txtRut.Text;
             String.Format("{0:MM/dd/yyyy}", dt); 
             Persona p = choco.Persona.FirstOrDefault(x => x.per_rut == rut);
             if (p == null)
             {
                 if(txtPassword.Text == txtPassword2.Text)
                 {
                
                     Response.Write("<script>alert('password cachilupin')</script>");
                 p.per_rut = rut;
                 p.per_nombre = txtNombre.Text;
                 p.per_apellidoP = txtAp.Text;
                 p.per_apellidoM = txtApM.Text;
                 p.per_direccion = txtDireccion.Text;
                 p.per_telefono = int.Parse(txtTelefono.Text);
                 p.per_fechaNac = ("10/26/1994");
                     choco.Persona.AddObject(p);
                     Usuario u = new Usuario();
                     u.usu_nombre = txtNombre.Text;
                     u.pri_id = 0;
                     u.per_rut = rut;
                     u.usu_contrasena = txtPassword.Text;
                     u.usu_correo = txtEmail.Text;
                     u.usu_activo = true;
                     u.usu_log = false;
                     choco.Usuario.AddObject(u);
                     Response.Write("<script>alert('cachilupin')</script>");
                 }
                 else
                 {
                      Response.Write("<script>alert('password no coinciden')</script>");
                 }  
             }
             else
             {
                 Response.Write("<script>alert('Usuario ya registrado')</script>");
             }
             */
        }

    }
}