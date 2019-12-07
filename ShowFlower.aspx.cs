using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class ShowFlower : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             FLOWERDB db = new FLOWERDB();
             ShowFlowerInfo(db);
        }

        protected void ShowFlowerInfo(FLOWERDB db)
        {

            bool valid = true;
            string flower_id = Request.QueryString["flowerid"];
            if (String.IsNullOrEmpty(flower_id)) valid = false;

            if (valid)
            {
                 Flower flower_record = db.FindFlower(Int32.Parse(flower_id));

                flower_title.InnerHtml = flower_record.GetFlowerName();
                flower_name.InnerHtml = flower_record.GetFlowerName();
                flower_description.InnerHtml = flower_record.GetFlowerDescription();
            }
            else
            {
                valid = false;
            }


            if (!valid)
            {
                flower.InnerHtml = "There was an error finding that flower.";
            }
        }
    }
}