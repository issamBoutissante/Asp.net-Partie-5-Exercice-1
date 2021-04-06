using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Partie_5_Exercice_1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Application["visites"] = (int)Application["visites"] + 1;
                Message.Text = $"Nombre visiteur est : {(int)Application["visites"]}";
                this.Unload += (object obj, EventArgs ev) =>
                  {
                      Application["visites"] = (int)Application["visites"] - 1;
                  };
            }
        }

        protected void Connecter_Click(object sender, EventArgs e)
        {
            if (Nom.Text == "issam" || Nom.Text == "Admin" || MotPass.Text == "1234")
            {
                Session["nom"] = Nom.Text;
                Session["motPass"] = MotPass.Text;
                Response.Redirect("Confidencielle1.aspx");
            }
            Response.Write("mot de pass incorrect");
            return;
        }
    }
}