﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Indexers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            Response.Write("Name of Employee with Id = 3: " + company[3]);
            Response.Write("<br>");
            Response.Write("Total Male Employee = " + company["Male"]);
        }
    }
}