using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ACalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)addButton.IsChecked)
                {
                    addValues();
                }
                else if ((bool)subtractButton.IsChecked)
                {
                    subtractValues();
                }
                else if ((bool)scalarMultiplyButton.IsChecked)
                {
                    scalarMultiplyValues();
                }
                else if ((bool)scalarDivideButton.IsChecked)
                {
                    scalarDivideValues();
                }
                else if ((bool)multiplyButton.IsChecked)
                {
                    areaMultiplyValues();
                }
                else if ((bool)divideButton.IsChecked)
                {
                    areaDivideValues();
                }
            }
            catch (Exception caught)
            {
                //expression.Text = "";
                //result.Text = caught.Message;
            }
        }


        private void addValues()
        {
            double feetMeasA = 0;
            double inchMeasA = 0;
            double numMeasA = 0;
            double denomMeasA = 0;
            double feetMeasB = 0;
            double inchMeasB = 0;
            double numMeasB = 0;
            double denomMeasB = 0;


            feetMeasA = double.Parse(feetA.Text);
            inchMeasA = double.Parse(inchA.Text);
            numMeasA = double.Parse(numA.Text);
            denomMeasA = double.Parse(denomA.Text);
            feetMeasB = double.Parse(feetB.Text);
            inchMeasB = double.Parse(inchB.Text);
            numMeasB = double.Parse(numB.Text);
            denomMeasB = double.Parse(denomB.Text);


            double totalInchA = ArchtoEngr(feetMeasA, inchMeasA, numMeasA, denomMeasA);
            double totalInchB = ArchtoEngr(feetMeasB, inchMeasB, numMeasB, denomMeasB);
            double totalInchC = totalInchA + totalInchB;

            OutputOperationAnswer(totalInchC);

        }

        private void subtractValues()
        {
            double feetMeasA = 0;
            double inchMeasA = 0;
            double numMeasA = 0;
            double denomMeasA = 0;
            double feetMeasB = 0;
            double inchMeasB = 0;
            double numMeasB = 0;
            double denomMeasB = 0;


            feetMeasA = double.Parse(feetA.Text);
            inchMeasA = double.Parse(inchA.Text);
            numMeasA = double.Parse(numA.Text);
            denomMeasA = double.Parse(denomA.Text);
            feetMeasB = double.Parse(feetB.Text);
            inchMeasB = double.Parse(inchB.Text);
            numMeasB = double.Parse(numB.Text);
            denomMeasB = double.Parse(denomB.Text);


            double totalInchA = ArchtoEngr(feetMeasA, inchMeasA, numMeasA, denomMeasA);
            double totalInchB = ArchtoEngr(feetMeasB, inchMeasB, numMeasB, denomMeasB);
            double totalInchC = totalInchA - totalInchB;

            OutputOperationAnswer(totalInchC);

        }

        private void scalarMultiplyValues()
        {
            double feetMeasA = 0;
            double inchMeasA = 0;
            double numMeasA = 0;
            double denomMeasA = 0;
            double mult = 0;



            feetMeasA = double.Parse(feetA.Text);
            inchMeasA = double.Parse(inchA.Text);
            numMeasA = double.Parse(numA.Text);
            denomMeasA = double.Parse(denomA.Text);
            mult = double.Parse(multDiv.Text);



            double totalInchA = ArchtoEngr(feetMeasA, inchMeasA, numMeasA, denomMeasA);
            double totalInchC = totalInchA * mult;

            OutputOperationAnswer(totalInchC);
        }

        private void scalarDivideValues()
        {
            double feetMeasA = 0;
            double inchMeasA = 0;
            double numMeasA = 0;
            double denomMeasA = 0;
            double mult = 0;



            feetMeasA = double.Parse(feetA.Text);
            inchMeasA = double.Parse(inchA.Text);
            numMeasA = double.Parse(numA.Text);
            denomMeasA = double.Parse(denomA.Text);
            mult = double.Parse(multDiv.Text);



            double totalInchA = ArchtoEngr(feetMeasA, inchMeasA, numMeasA, denomMeasA);
            double totalInchC = totalInchA / mult;

            OutputOperationAnswer(totalInchC);
        }

        private void areaMultiplyValues()
        {
            double feetMeasA = 0;
            double inchMeasA = 0;
            double numMeasA = 0;
            double denomMeasA = 0;
            double mult = 0;



            feetMeasA = double.Parse(feetA.Text);
            inchMeasA = double.Parse(inchA.Text);
            numMeasA = double.Parse(numA.Text);
            denomMeasA = double.Parse(denomA.Text);
            mult = double.Parse(multDiv.Text);



            double totalInchA = ArchtoEngr(feetMeasA, inchMeasA, numMeasA, denomMeasA);
            double totalInchC = totalInchA * mult;

            OutputOperationAnswer(totalInchC);
        }

        private void areaDivideValues()
        {
            double feetMeasA = 0;
            double inchMeasA = 0;
            double numMeasA = 0;
            double denomMeasA = 0;
            double mult = 0;



            feetMeasA = double.Parse(feetA.Text);
            inchMeasA = double.Parse(inchA.Text);
            numMeasA = double.Parse(numA.Text);
            denomMeasA = double.Parse(denomA.Text);
            mult = double.Parse(multDiv.Text);



            double totalInchA = ArchtoEngr(feetMeasA, inchMeasA, numMeasA, denomMeasA);
            double totalInchC = totalInchA / mult;

            OutputOperationAnswer(totalInchC);
        }

        private double ArchtoEngr(double ft, double inch, double numer, double denom)
        {
            if (numer != 0 && denom != 0)
            {
                return (ft * 12 + inch + (numer / denom));
            }
            else
            {
                return (ft * 12 + inch);
            }
        }

        private void OutputOperationAnswer(double totalInch)
        {
            double feetMeasC = Math.Truncate(totalInch / 12);
            double inchMeasC = Math.Round((totalInch % 12), 2);
            totalInch = Math.Round(totalInch, 2);

            answerFeetBox.Text = feetMeasC.ToString();
            answerInchBox.Text = inchMeasC.ToString();
            answerEngrBox.Text = totalInch.ToString();
        }

        private void MoveAnswertoA()
        {
            feetA.Text = answerFeetBox.Text;
            inchA.Text = answerInchBox.Text;
            numA.Text = "0";
            denomA.Text = "0";
            //feetB.Focus();
        }


        private void Textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).SelectAll();
        }



        private void BtnClickMoveAnswertoA(object sender, RoutedEventArgs e)
        {
            MoveAnswertoA();
        }
    }
}

