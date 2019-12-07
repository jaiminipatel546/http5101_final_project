using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class Add_Flower : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void add_flower(object sender, EventArgs e)
        {
            //create connection
            FLOWERDB db = new FLOWERDB();

            Flower add_flower = new Flower();
            add_flower.SetFlowerName(add_flower_name.Text);
            add_flower.SetFlowerDescription(add_flower_description.Text);
            
            // flower added to the database
            db.AddFlower(add_flower);


            Response.Redirect("ListFlowers.aspx");
        }
    }
}