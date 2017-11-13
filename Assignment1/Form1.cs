using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1{

    /// <summary>
    /// Form1 class contains button actions
    /// </summary>
    public partial class Form1 : Form {
        public Form1(){
            InitializeComponent();
        }


        /// <summary>
        /// This method contains actions to be performed when btn1 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e){
            DialogResult MyResult;

            MyResult = MessageBox.Show("You typed: " + box1.Text, "Button 1", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            btnLabel.Text = "You Clicked: " + MyResult.ToString();

        }//end btn1click

        /// <summary>
        /// this method contains actions to be performed when btn2 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e){

            DialogResult MyResult;

            MyResult = MessageBox.Show("You typed: " + box2.Text, "Button 2", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            btnLabel.Text = "You Clicked: " + MyResult.ToString();

        }//end btn2click

        /// <summary>
        /// this method contains actions to be performed when btn3 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e){

            DialogResult MyResult;

            MyResult = MessageBox.Show("You typed: " + box3.Text, "Button 3", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnLabel.Text = "You Clicked: " + MyResult.ToString();

        }//end btn3click

    }//end Form1class

}//end namespace
