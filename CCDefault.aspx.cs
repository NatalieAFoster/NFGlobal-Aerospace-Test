using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;



public partial class _Default : System.Web.UI.Page
{

    //CURRENCY CONVERTER USING JSON API
    public class Rate
    {
        //read and write properties

        public string to { get; set; } //paired dataset 

        public string from { get; set; }

        public double rate { get; set; } // Time stamp and base are objects that could alo be extracted but not required for the programme


     }

    //This is a first attempt at using asp.Net, the comments will explain my logic for the code. However, even though the database it recognised in the system extraction to the currencies was not achieved

    protected void Button1_Click(object sender, EventArgs e )// when conversion buttion is press the following should take place
    {

        double amount; // amount entered by the user

        if (double.TryParse(Txt1.Text, out amount)) // amount entered in first text box converted to double output
        {

            WebClient web = new WebClient(); //webclient to download file
            
            string url = string.Format("http://api.fixer.io/latest?from={0}&to={1}", DDLfrom.SelectedItem.Value, DDLto.SelectedItem.Value); //bind json database and set drop down list parameter

            string rates = web.DownloadString(url); //extract rates

            Rate rate = new JavaScriptSerializer().Deserialize<Rate>(rates);  //deserialise JSON file

            double exchange = amount * rate.rate; //calculation for currency conversion
                     
            string message =  amount+ "  " + DDLfrom.SelectedItem.Text + "\\n"; // show about enter with name of currency chosen

            message += "The exchange rate for: " + DDLfrom.SelectedItem.Text + " to " + DDLto.SelectedItem.Text + " = " + exchange + "\\n"; // show exchange rate in message

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + message + "');", true);

        }

        else
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Invalid amount value.');", true);

        }

    }
    protected void DDL3_SelectedIndexChanged(object sender, EventArgs e)
    {


        //STANDARD CURRENCY CONVERTER 
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int amount; // amount to be entered by the user
       
        int.TryParse(Txt3.Text, out amount); //text box converted to interget input
       

        double currency1 = double.Parse(DDL3.SelectedItem.Value); //currency variable to converted value from dropdown list
        double currency2 = double.Parse(DDL4.SelectedItem.Value);
        double conversion; 
        double con = amount * currency1;//conversion for first inout for first seleted currency
       
       
        // if statements to produce error statement if the same currency is selected

        if (DDL3.SelectedValue == "1.2329" && DDL4.SelectedValue == "1.2329")
        {

            Label4.Text = "INCORRECT SELECTION";
        }
        else if (DDL3.SelectedValue == "0.9326" && DDL4.SelectedValue == "0.9326")
        {

            Label4.Text = "INCORRECT SELECTION";
        }
        else if (DDL3.SelectedValue == "0.6432" && DDL4.SelectedValue == "0.6432")
        {


            Label4.Text = "INCORRECT SELECTION";
        }

        else if (DDL3.SelectedValue == "1" && DDL4.SelectedValue == "1")
        {

            Label4.Text = "INCORRECT SELECTION";
        }

        else if (DDL3.SelectedValue == "123.454" && DDL4.SelectedValue == "123.454")
        {

            Label4.Text = "INCORRECT SELECTION";

            //Canadian Dollar Exhange
        }
        else if (DDL3.SelectedValue == "1.2329" && DDL4.SelectedValue == "0.9326") // when different selection are made from each comboBox a calculation for that currency will be performed
        {
            conversion = con * currency2; // currency is user input amount multiplied by the exchange rate
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " +conversion.ToString("N2"); // label 1 text, will display user input amount and name of current in comboBox 1 index selected as 0
            
        }

        else if (DDL3.SelectedValue == "1.2329" && DDL4.SelectedValue == "0.6432") {
           conversion = con * currency2;
           Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "1.2329" && DDL4.SelectedValue == "1") {
            conversion = con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "1.2329" && DDL4.SelectedValue == "123.454") {
           conversion = con * currency2;
           Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2");
        }

            //Swiss France Exchange

        else if (DDL3.SelectedValue == "0.9326" && DDL4.SelectedValue == "1.2329") {
            conversion = con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "0.9326" && DDL4.SelectedValue == "0.6432") {
            conversion = con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "0.9326" && DDL4.SelectedValue == "1") {
            conversion = con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "0.9326" && DDL4.SelectedValue == "123.454") {
            conversion = con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

         //Pound Sterling Exchange

        else if (DDL3.SelectedValue == "0.6432" && DDL4.SelectedValue == "1.2329") {
           conversion = con * currency2;
           Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 
        }

        else if (DDL3.SelectedValue == "0.6432" && DDL4.SelectedValue == "0.9326") {
           conversion = con * currency2;
           Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "0.6432" && DDL4.SelectedValue == "1") {
            conversion = con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "0.6432" && DDL4.SelectedValue == "123.454") {
          conversion = con * currency2;
          Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }
        //US Dollar

        else if (DDL3.SelectedValue == "1" && DDL4.SelectedValue == "1.2329") {
            conversion = con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "1" && DDL4.SelectedValue == "0.9326") {
           conversion = con * currency2;
           Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "1" && DDL4.SelectedValue == "0.6432") {
            conversion= con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "1" && DDL4.SelectedValue == "123.454") {
            conversion = con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }
        //Japanese Yen


        else if (DDL3.SelectedValue == "123.454" && DDL4.SelectedValue == "1.2329") {
            conversion = con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "123.454" && DDL4.SelectedValue == "0.9326") 
        {
            conversion = con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "123.454" && DDL4.SelectedValue == "0.6432") 
        {
            conversion = con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }

        else if (DDL3.SelectedValue == "123.454" && DDL4.SelectedValue == "1")         {
            conversion = con * currency2;
            Label4.Text = "The exchange rate is: " + DDL4.SelectedItem.Text + " " + conversion.ToString("N2"); 

        }
    }}

         
