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
            /*
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
            */

            //Test Array

            //Numbers
            int[] numbers = new int[5];

            Random random = new();

            numbers[0] = random.Next(1, 50);
            numbers[1] = random.Next(1, 50);
            numbers[2] = random.Next(1, 50);
            numbers[3] = random.Next(1, 50);
            numbers[4] = random.Next(1, 50);

            //stars

            int[] stars = new int[2];

            Random randstar = new();

            stars[0] = randstar.Next(1, 12);
            stars[1] = randstar.Next(1, 12);
           
            //condições

            if(numbers[0] != numbers[1] && numbers[0] != numbers[2] && numbers[0] != numbers[3] && numbers[0] != numbers[4] &&
               numbers[1] != numbers[0] && numbers[1] != numbers[2] && numbers[1] != numbers[3] && numbers[1] != numbers[4] &&
               numbers[2] != numbers[0] && numbers[2] != numbers[1] && numbers[2] != numbers[3] && numbers[2] != numbers[4] &&
               numbers[3] != numbers[0] && numbers[3] != numbers[1] && numbers[3] != numbers[2] && numbers[3] != numbers[4] &&
               numbers[4] != numbers[0] && numbers[4] != numbers[1] && numbers[4] != numbers[2] && numbers[4] != numbers[3] &&
               stars[0] != stars[1] && stars[1] != stars[0])
            {
                Array.Sort(numbers);
                genBox.Text = $"{numbers[0]} + {numbers[1]} + {numbers[2]} + {numbers[3]} + {numbers[4]}";
                
                Array.Sort(stars);
                genBox2.Text = $"{stars[0]} + {stars[1]}";
            }
            else
            {
                genBox.Text = "Key is invalid. Generate again";
                genBox2.Text = "Nothing to show here";
            }

            /*
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
            }*/
        }

        private async void clr_button_Click(object sender, EventArgs e)
        {
            genBox.Clear();
            genBox2.Clear();
        }

        private void expButton_Click(object sender, EventArgs e)
        {
            string txtPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            do
            {
                File.WriteAllText(Path.Combine(txtPath, "Program.txt"), $"Numbers:\n\n{genBox.Text} \n\nStars:\n\n{genBox2.Text}");

                string msg = $"Key exported to file {txtPath}\\Program.txt";
                MessageBox.Show(msg);
                break;
            } while (gen_btn_Click != null);

            //$"Numbers: {genBox.Text}\n\n Stars: {genBox2.Text}");
        }
    }
}