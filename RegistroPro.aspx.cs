using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.Objects;

namespace Chocoloco
{
    public partial class RegistroPro : System.Web.UI.Page
    {
        db_chocolateriaEntities12 choco = new db_chocolateriaEntities12();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
            int id = int.Parse(cbbCategoria.SelectedValue);
            Categoria c = choco.Categoria.FirstOrDefault(x => x.cat_id == id);
            Producto p = new Producto();
            p.pro_Nombre = txtNombre.Text;
            p.pro_Precio = int.Parse(txtPrecio.Text);
          
        }

            
            
        }
    }
