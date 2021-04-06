using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Partie_5_Exercice_1
{
    public partial class Confidencielle2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nom"] == null || Session["motPass"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if((string)Session["nom"] == "Admin" && (string)Session["motPass"] == "1234")
            {
                Message.Text = $"Votre information confidencielle sont : {Session["nom"]} {Session["motPass"]}";
            }
            else
            {
                Response.Redirect("Confidencielle1.aspx");
            }
        }

        protected void Deconnecter_Click(object sender, EventArgs e)
        {
            Session["nom"] = null;
            Session["motPass"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}