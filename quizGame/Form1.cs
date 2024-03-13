using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class Form1 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 14;



        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("Quiz Ended" + Environment.NewLine +
                                "You have answered " + score + " questions correcly" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine +
                                "Click Ok to play again"

                    );

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {

            

            switch(qnum)
            {

                case 1:

                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Mi az int alapértelmezett értéke?";

                    button1.Text = "Null";
                    button2.Text = "Nulla";
                    button3.Text = "0";
                    button4.Text = "NaN";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Mik lehetnek az Interfaceben?";

                    button1.Text = "Metódusok és adatokat";
                    button2.Text = "Metódusokat és tulajdonságokat";
                    button3.Text = "Tulajdonságok és adatok";
                    button4.Text = "Adatok és függvények";

                    correctAnswer = 2;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Melyik nem igazi objektum orientált porgramozási nyelv?";

                    button1.Text = "VB.NET";
                    button2.Text = "JAVA";
                    button3.Text = "C++";
                    button4.Text = "C#";

                    correctAnswer = 4;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Mi szerepelhet csak egyszer egy programban?";

                    button1.Text = "Namespace";
                    button2.Text = "Entry point";
                    button3.Text = "Class";
                    button4.Text = "Function";

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Minek köszönhető a streamreader használata?";

                    button1.Text = "System.IO";
                    button2.Text = "System.Data;";
                    button3.Text = "System.Kms";   
                    button4.Text = "System.Fortnite";

                    correctAnswer = 1;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Mi az entry point metódusa?";

                    button1.Text = "public static void Program()";
                    button2.Text = "public static void Main()";
                    button3.Text = "public static void main()";
                    button4.Text = "Semelyik";

                    correctAnswer = 2;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Az alábbiak közül melyik értéktípus a C#-ban";

                    button1.Text = "int32";
                    button2.Text = "double";
                    button3.Text = "decimal";
                    button4.Text = "Az összes";

                    correctAnswer = 4;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Melyik adattípust használnálhatsz enum-al?";

                    button1.Text = "int";
                    button2.Text = "string";
                    button3.Text = "boolean";
                    button4.Text = "mindegyik";

                    correctAnswer = 1;

                    break;

                case 9:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Mi az indexelő?";

                    button1.Text = "Lehetővé teszi egy osztály példányának tömbként történő indexelését";
                    button2.Text = "Lehetővé teszi az osztályos számlálót";
                    button3.Text = "Indexet hoz létre egy osztály példányaihoz";
                    button4.Text = "A fentiek kozül egyike sem.";

                    correctAnswer = 1;

                    break;

                case 10:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Az alábbiak közül melyik a helyes módja egy tömb deklarálásának C#-ban?";

                    button1.Text = "A int[] intArray = new int[];";
                    button2.Text = "int intArray[]=new int[5];";
                    button3.Text = "int[] intArray = new int[5];";
                    button4.Text = "int[5] intArray = new int[];";

                    correctAnswer = 3;

                    break;

                case 11:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Mit jelent a LINQ?";

                    button1.Text = "Local Integrated Query";
                    button2.Text = "Language Integrated Query";
                    button3.Text = "Lazy Integrated Query";
                    button4.Text = "Language Interface Query";

                    correctAnswer = 2;

                    break;

                case 12:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Mikor kapja meg az adat típusát a változó (var)?";

                    button1.Text = "Futtatáskor";
                    button2.Text = "Összeállítás közben";
                    button3.Text = "Bármikor";
                    button4.Text = "Applikáció elkészítésekor";

                    correctAnswer = 2;

                    break;

                case 13:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Mit jelent a ReadOnly?";

                    button1.Text = "Csak olvasni lehet";
                    button2.Text = "Csak írni lehet";
                    button3.Text = "Nem lehet írni";
                    button4.Text = "Nem lehet olvasni";

                    correctAnswer = 1;

                    break;

                case 14:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Milyen index számmal kezdődnek a listák?";

                    button1.Text = "1";
                    button2.Text = "-1";
                    button3.Text = "0";
                    button4.Text = "Egyiksem";

                    correctAnswer = 1;

                    break;
            }

        }

    }
}
