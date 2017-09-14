﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Coleccion"] = null;
        Session["ColeccionPet"] = null;
    }


    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void btnReg_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registro.aspx");
    }
}