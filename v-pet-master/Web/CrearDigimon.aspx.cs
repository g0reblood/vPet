using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
public partial class _Default : System.Web.UI.Page
{
    private ColeccionPet colex
    {
        get
        {

            return (ColeccionPet)Session["Coleccion"];
        }

    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        Random rnd = new Random();
        //var values = Enum.GetValues(typeof(typePet));
       // typePet tipoAleatorio = (typePet)values[R(0, values.Length)];

   
   

        VPet pet = new VPet();
        Pet baby = new Pet();

        baby.Attack = rnd.Next(1, 100);
        baby.Defense = rnd.Next(1, 100);
        baby.Health = rnd.Next(1, 100);
        baby.EvPoint = rnd.Next(1, 100);

        pet.Name = txtNombre.Text;
        pet.Poop = rnd.Next(1, 100);
        pet.Age = rnd.Next(1, 10);
        pet.Ex= rnd.Next(1, 100);
        pet.Date = DateTime.Now;
     


    }
}