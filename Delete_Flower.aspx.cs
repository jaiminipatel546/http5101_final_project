using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class Delete_Flower : System.Web.UI.Page
    {
        protected void Delete_flower(object sender, EventArgs e)
        {
            bool valid = true;
            string flower_id = Request.QueryString["flowerid"];

            if (String.IsNullOrEmpty(flower_id)) valid = false;

            FLOWERDB db = new FLOWERDB();

            if (valid)
            {
                db.DeleteFlower(Int32.Parse(flower_id));
                Response.Redirect("ListFlowers.aspx");
            }
            else
            {
                valid = false;
            }
        }

    }
}
