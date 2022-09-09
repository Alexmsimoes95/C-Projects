using System.Data;
using System.Security.Cryptography;

namespace Euromillions_Generator_APP
{
    public partial class GeneratorAPP : Form
    {
        public GeneratorAPP()
        {
            InitializeComponent();
        }

        private void gen_btn_Click(object sender, EventArgs e)
        {
            //Numbers Randomization
            Random numbers = new Random();

            int numOne = numbers.Next(1, 50);
            int numTwo = numbers.Next(1, 50);
            int numThree = numbers.Next(1, 50);
            int numFour = numbers.Next(1, 50);
            int numFive = numbers.Next(1, 50);

            //Stars Randomization
            Random stars = new Random();
            int starOne = stars.Next(1, 12);
            int starTwo = stars.Next(1, 12);

            var j = $"{numOne} + {numTwo} + {numThree} + {numFour} + {numFive}";
            var z = $"{starOne} + {starTwo}";

            if (numOne != numTwo && numOne != numThree && numOne != numFour && numOne != numFive &&
                numTwo != numOne && numTwo != numThree && numTwo != numFour && numTwo != numFive &&
                numThree != numOne && numThree != numTwo && numThree != numFour && numThree != numFive &&
                numFour != numOne && numFour != numTwo && numFour != numThree && numFour != numFive &&
                numFive != numOne && numFive != numTwo && numFive != numThree && numFive != numFour &&
                starOne != starTwo)
            {
                genBox.Text = j;
                genBox2.Text = z;
            }
            else
            {
                genBox.Text = "Key is invalid. Generate again !";
                genBox2.Text = "Nothing to show here !";
            }
        }

        private async void clr_button_Click(object sender, EventArgs e)
        {
            genBox.Clear();
            genBox2.Clear();
        }
    }
}