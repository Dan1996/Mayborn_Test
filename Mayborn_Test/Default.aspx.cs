using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mayborn_Test
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) // sets a condition for if page is not postback
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try // good pratice to do a try catch
            {
                // set the user entered contect to string variable so it can be used multiple times
                string strFirstName = txtFirst.Text; 
                string strLastName = txtLast.Text;
                string strFullName = strFirstName + " " + strLastName; // full name will be used for the outputs

                txtOutput.Text = strFullName; // text output box equals full name
                Directory.CreateDirectory("C:\\MaybornTest\\Output\\"); // create an output directory
                File.AppendAllText("C:\\MaybornTest\\Output\\Name.txt", strFullName); // append the output to a file. Append keeps all data with out deleting previous data
            }
            catch(Exception ex) //capture the expection 
            {
                string strDateTime = DateTime.Now.ToLongDateString().ToString() + "-" + DateTime.Now.ToLongTimeString().ToString(); // capture the time of the exception
                strDateTime = strDateTime.Replace(":", ""); // make the name directory friendly
                Directory.CreateDirectory("C:\\MaybornTest\\Logs"); // create a log directory
                File.AppendAllText("C:\\MaybornTest\\Logs\\logfile " + strDateTime +".txt", ex.ToString()); // put the exception in a log file, although unlikely append is used in case more than one expception occurs in the same second
            }
        }
    }
}