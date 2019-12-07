using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class Update_FLower : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FLOWERDB db = new FLOWERDB();
                ShowFlowerInfo(db);
            }
        }
        protected void Update_Flower(object sender, EventArgs e)
        {

            //this connection instance is for editing data
            FLOWERDB db = new FLOWERDB();

            bool valid = true;
            string flower_id = Request.QueryString["flowerid"];
            if (String.IsNullOrEmpty(flower_id)) valid = false;
            if (valid)
            {
                Flower new_flower = new Flower();
                new_flower.SetFlowerName(flower_name_update.Text);
                new_flower.SetFlowerDescription(flower_description_update.Text);

                try
                {
                    db.UpdateFlower(Int32.Parse(flower_id), new_flower);
                    Response.Redirect("ShowFlower.aspx?flowerid=" + flower_id);
                }
                catch
                {
                    valid = false;
                }

            }

            if (!valid)
            {
                flower.InnerHtml = "There was an error updating that flower.";
            }

        }

        protected void ShowFlowerInfo(FLOWERDB db)
        {

            bool valid = true;
            string flower_id = Request.QueryString["flowerid"];
            if (String.IsNullOrEmpty(flower_id)) valid = false;

            if (valid)
            {

                Flower flower_record = db.FindFlower(Int32.Parse(flower_id));
                flower_update.InnerHtml = flower_record.GetFlowerName();
                flower_name_update.Text = flower_record.GetFlowerName();
                flower_description_update.Text = flower_record.GetFlowerDescription();
            }

            if (!valid)
            {
                flower.InnerHtml = "There was an error finding that flower.";
            }
        }
    }
}