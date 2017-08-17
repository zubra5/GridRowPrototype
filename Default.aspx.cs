using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GridRowPrototype.Classes.Table;

namespace GridRowPrototype
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TableCellClonable cell = new TableCellClonable();
            cell.Text = "Inital text";
            TableRow row = new TableRow();
            row.Cells.Add(cell);          
            row.Cells.Add(cell.Clone("Second text"));
            row.Cells.Add(cell.Clone("Prototype is easy pattern"));
            tblMain.Rows.Add(row);
        }
    }
}