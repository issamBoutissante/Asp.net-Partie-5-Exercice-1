using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Partie_5_Exercice_1
{
    public partial class Confidencielle1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nom"] == null || Session["motPass"]==null)
            {
                Response.Redirect("Login.aspx");
            }

            Message.Text = $"Votre information confidencielle sont : {Session["nom"]} {Session["motPass"]}";
        }

        protected void goNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("Confidencielle2.aspx");
        }

        protected void Deconnecter_Click(object sender, EventArgs e)
        {
            Session["nom"] = null;
            Session["motPass"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}