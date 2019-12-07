using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class ListFlowers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            flowers_result.InnerHtml = "";

            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = flower_search.Text;
            }

            string query = "select * from flowers_table";

            if (searchkey != "")
            {
                query += " WHERE flower_id like '%" + searchkey + "%' ";
                query += " OR flower_name like '%" + searchkey + "%' ";
                query += " or flower_description like '%" + searchkey + "%' ";
            }

            sql_debugger.InnerHtml = query;

            var db = new FLOWERDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            flowers_result.InnerHtml += "<table class=\"table table-bordered table-hover\"><tr><th>Flower Id</th><th>Flower Name</th><th>Flower Description</th><th>Update</th><th>Delete</th>";

            foreach (Dictionary<String, String> row in rs)
            {
                flowers_result.InnerHtml += "<tr>";

                flowers_result.InnerHtml += "<div class=\"listitem\">";

                string FlowerId = row["flower_id"];
                flowers_result.InnerHtml += "<td>" + FlowerId + "</td>";


                string Flower_name = row["flower_name"];
                //flowers_result.InnerHtml += "<td>" + Flower_name + "</td>";
                flowers_result.InnerHtml += "<td><div class=\"col4\"><a href=\"ShowFlower.aspx?FlowerId=" + FlowerId + "\">" + Flower_name + "</a></div></td>";

                string flower_description = row["flower_description"];
                flowers_result.InnerHtml += "<td>" + flower_description + "</td>";

                flowers_result.InnerHtml += "<td><a href=\"Update_Flower.aspx?flowerid=" + FlowerId + "\"><span class=\"glyphicon glyphicon-edit\"></span></a></td>";

                flowers_result.InnerHtml += "<td><a href=\"delete_flower.aspx?flowerid=" + FlowerId + "\"><span class=\"glyphicon glyphicon-trash\"></span></a></td>";

                flowers_result.InnerHtml += "</tr>";
            }

            flowers_result.InnerHtml += "</table>";
        }
    }
}