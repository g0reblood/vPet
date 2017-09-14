using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

public partial class inicio : System.Web.UI.Page
{


    private ColeccionPlayer colex
    {
        get { return (ColeccionPlayer)Session["Coleccion"]; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        if (Session["Coleccion"]!=null)
        {
            if (colex.Exists(x => x.User.Equals(txtUsuario.Text)) & colex.Exists(z => z.Password.Equals(txtPass.Text)))
            {
                Response.Redirect("CrearPet.aspx");
            }
        }
        else
        {
            lblMsg.Text = "El Usuario no Existe";
        }
    }
}