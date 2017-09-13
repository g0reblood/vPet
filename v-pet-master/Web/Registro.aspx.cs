using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

public partial class Registro : System.Web.UI.Page
{
    private ColeccionPlayer colex
    {
        get
        {
            if (Session["Coleccion"]==null)
            {
                Session["Coleccion"] = new ColeccionPlayer();
            }
            return (ColeccionPlayer)Session["Coleccion"];
        }
        set { Session["Coleccion"] = value; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        if (chkSi.Checked)
        {
            Player play = new Player();
            try
            {
                play.Name = txtNombreUser.Text;
                play.User = txtUserid.Text;
                play.Mail = txtCorreo.Text;
                play.Password = txtPass.Text;

                colex.Add(play);
                lblMsg.Text = "Se ha registrado Exitosamente!!";

                txtNombreUser.Text = "";
                txtUserid.Text = "";
                txtCorreo.Text = "";
                txtPass.Text = "";
                chkSi.Checked = false;
            }
            catch (Exception ex)
            {
                lblMsg.Text = "No se ha registrado " + ex.Message;
            }
        }
        else
        {
            lblMsg.Text = "Debe aceptar Terminos y Condiciones";
        }
    }
}