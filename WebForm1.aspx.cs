using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consumir_Web_services_de_terceros
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WSOnline.CalculatorSoapClient Ws = new WSOnline.CalculatorSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // consumismo el web service y convertimos los dos parametros
            Label1.Text = Ws.Add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(Textbox2.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // consumismo el web service y convertimos los dos parametros
            Label1.Text = Ws.Subtract(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(Textbox2.Text)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // consumismo el web service y convertimos los dos parametros
            Label1.Text = Ws.Multiply(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(Textbox2.Text)).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // consumismo el web service y convertimos los dos parametros
            Label1.Text = Ws.Divide(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(Textbox2.Text)).ToString();
        }
    }
}