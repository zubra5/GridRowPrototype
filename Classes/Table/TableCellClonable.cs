using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace GridRowPrototype.Classes.Table
{
    public class TableCellClonable : TableCell
    {
        public TableCellClonable Clone(string text) {
            TableCellClonable cell = new TableCellClonable();
            cell.Text = text;
            return cell;
        }
    }
}