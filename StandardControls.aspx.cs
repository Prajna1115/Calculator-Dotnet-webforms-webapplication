using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExamples
{
    public partial class StandardControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtVal2.Visible = false;

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if(lblOp.Text == "+" || lblOp.Text == "-" || lblOp.Text == "*" || lblOp.Text == "/")
            {
                txtVal2.Text = txtVal2.Text + 1;

            }
            else
                txtVal.Text = txtVal.Text + 1;

        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            if (lblOp.Text == "+" || lblOp.Text == "-" || lblOp.Text == "*" || lblOp.Text == "/")
            {
                txtVal2.Text = txtVal2.Text + 2;

            }
            else
                txtVal.Text = txtVal.Text + 2;

        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            if (lblOp.Text == "+" || lblOp.Text == "-" || lblOp.Text == "*" || lblOp.Text == "/")
            {
                txtVal2.Text = txtVal2.Text + 3;

            }
            else
                txtVal.Text = txtVal.Text + 3;

        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            if (lblOp.Text == "+" || lblOp.Text == "-" || lblOp.Text == "*" || lblOp.Text == "/")
            {
                txtVal2.Text = txtVal2.Text + 4;

            }
            else
                txtVal.Text = txtVal.Text + 4;

        }
        protected void btn5_Click(object sender, EventArgs e)
        {
            if (lblOp.Text == "+" || lblOp.Text == "-" || lblOp.Text == "*" || lblOp.Text == "/")
            {
                txtVal2.Text = txtVal2.Text + 5;

            }
            else
                txtVal.Text = txtVal.Text + 5;

        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            if (lblOp.Text == "+" || lblOp.Text == "-" || lblOp.Text == "*" || lblOp.Text == "/")
            {
                txtVal2.Text = txtVal2.Text + 6;

            }
            else
                txtVal.Text = txtVal.Text + 6;

        }

       
     

        


        protected void btn7_Click(object sender, EventArgs e)
        {
            if (lblOp.Text == "+" || lblOp.Text == "-" || lblOp.Text == "*" || lblOp.Text == "/")
            {
                txtVal2.Text = txtVal2.Text + 7;

            }
            else
                txtVal.Text = txtVal.Text + 7;

        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            if (lblOp.Text == "+" || lblOp.Text == "-" || lblOp.Text == "*" || lblOp.Text == "/")
            {
                txtVal2.Text = txtVal2.Text + 8;

            }
            else
                txtVal.Text = txtVal.Text + 8;

        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            if (lblOp.Text == "+" || lblOp.Text == "-" || lblOp.Text == "*" || lblOp.Text == "/")
            {
                txtVal2.Text = txtVal2.Text + 9;

            }
            else
                txtVal.Text = txtVal.Text + 9;

        }

       

        protected void btnPlus_Click1(object sender, EventArgs e)
        {
            lblOp.Text = "+";


        }

        protected void btnMinus_Click1(object sender, EventArgs e)
        {
            lblOp.Text = "-";

        }

        protected void btnDivision_Click1(object sender, EventArgs e)
        {
            lblOp.Text = "/";

        }

        protected void btnComma_Click(object sender, EventArgs e)
        {
            lblOp.Text = ",";

        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            if (lblOp.Text == "+" || lblOp.Text == "-" || lblOp.Text == "*" || lblOp.Text == "/")
            {
                txtVal2.Text = txtVal2.Text + 0;

            }
            else
                txtVal.Text = txtVal.Text + 0;


        }

        protected void btnMultiply_Click1(object sender, EventArgs e)
        {
            lblOp.Text = "*";

        }

        protected void btnEqual_Click1(object sender, EventArgs e)
        {
            if (lblOp.Text == "+")
            {
                int fval = int.Parse(txtVal.Text);
                int sval = int.Parse(txtVal2.Text);
                txtVal.Text = (fval + sval).ToString();
                lblOp.Text = "";
                txtVal2.Text = "";

            }
            if (lblOp.Text == "-")
            {
                int fval = int.Parse(txtVal.Text);
                int sval = int.Parse(txtVal2.Text);
                txtVal.Text = (fval - sval).ToString();
                lblOp.Text = "";
                txtVal2.Text = "";

            }
            if (lblOp.Text == "*")
            {
                int fval = int.Parse(txtVal.Text);
                int sval = int.Parse(txtVal2.Text);
                txtVal.Text = (fval * sval).ToString();
                lblOp.Text = "";
                txtVal2.Text = "";

            }
            if (lblOp.Text == "/")
            {
                int fval = int.Parse(txtVal.Text);
                int sval = int.Parse(txtVal2.Text);
                txtVal.Text = (fval / sval).ToString();
                lblOp.Text = "";
                txtVal2.Text = "";

            }


        }
    }
}