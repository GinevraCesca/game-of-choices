using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_of_choices
{
    public partial class Form1 : Form
    {
        int page = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 18;
            }

            DisplayPage();
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 9;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }

            DisplayPage();
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 14;
            }
            else if (page == 2)
            {
                page = 6;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 9)
            {
                page = 13;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 16)
            {
                page = 19;
            }

            DisplayPage();
            Refresh();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You worked hard for your company and when summer comes you decide to take a vacation. you have booked a low cost flight to...";
                    questionlable.Text = "Where would you go?";
                    button1.Text = "European Capital";
                    button2.Text = "Lapland";
                    button3.Text = "Maldives";
                    button1.Visible = true;
                    button3.Visible = true;
                    break;
                case 2:
                    outputLabel.Text = "After a long search among all the European capitals you have decided for Paris, the capital of love (and thieves of paintings).";
                    questionlable.Text = "So you decide to create a list of places to visit for the first day. Where do you choose to go?";
                    button1.Text = "Eiffel Tower";
                    button2.Visible = false;
                    button3.Text = "Louvre";
                    break;
                case 3:
                    outputLabel.Text = "You enjoy a beautiful sunny day admiring the Eiffel Tower and taking souvenir photos when you hear a woman scream. you turn around and see a man with a bag running in your direction.";
                    questionlable.Text = "What would you do?";
                    button1.Text = "You stop him";
                    button2.Visible = false;
                    button3.Text = "you ignore it and leave";
                    break;
                case 4:
                    outputLabel.Text = "you tried but you're a little out of shape. you end up in the hospital and your vacation is ruined.";
                    questionlable.Text = "Thanks for playing";
                    button1.Visible = false;
                    button2.Visible = true;
                    button2.Text = "Continue";
                    button3.Visible = false;
                    break;
                case 5:
                    outputLabel.Text = "You've decided chases aren't your thing and it's time to head back to the hotel. you wake up the next morning, ready to explore new areas of the city when you hear on TV that a thief has stolen the merry. you don't give it too much weight and decide to continue your holiday safely until the end.";
                    questionlable.Text = "Thanks for playing";
                    button1.Visible = false;
                    button2.Visible= true;
                    button2.Text = "Continue";
                    button3.Visible = false;
                    break;
                case 6:
                    outputLabel.Text = "You are the type of story. you get lost for hours admiring the museum and you don't notice the time passing, so much so that you find yourself inside even after closing time.";
                    questionlable.Text = "Where would you go?";
                    button1.Text = "To sleep in the sarcophagus";
                    button2.Visible = false;
                    button3.Text = "Looking for an exit";
                    break;
                case 7:
                    outputLabel.Text = "It is nothing. You spent the night in the company of your ancestors. When you wake up you feel a bit like Christ at Easter and you decide that it was enough for you as a unique and exciting experience, so you decide to take off and go home.";
                    questionlable.Text = "Thanks for playing";
                    button1.Visible = false;
                    button2.Visible = true;
                    button2.Text = "Continue";
                    button3.Visible = false;
                    break;
                case 8:
                    outputLabel.Text = "After searching the floors of the museum, you realize that you could just take the subway and go home.";
                    questionlable.Text = "Thanks for playing";
                    button1.Visible = false;
                    button2.Visible = true;
                    button2.Text = "Continue";
                    button3.Visible = false;
                    break;
                case 9:
                    outputLabel.Text = "You are a big lover of the cold and have opted for two weeks in an igloo in Lapland";
                    questionlable.Text = "The first thing you would like to do is?";
                    button1.Text = "see the Northern Lights";
                    button2.Visible = false;
                    button3.Text = "get on a sled pulled by dogs or reindeer";
                    break;
                case 10:
                    outputLabel.Text = "You have always dreamed of seeing the northern lights, so bright and colorful and perhaps with the expectation of speaking with some spirit. You start walking but you are surprised by a pack of wolves.";
                    questionlable.Text = "What do you decide to do?";
                    button1.Text = "light up a cigarette";
                    button2.Visible = false;
                    button3.Text = "run away";
                    break;
                case 11:
                    outputLabel.Text = "Ok ... it's not for everyone to stay calm in a moment of danger but you made the right choice: wolves are afraid of fire so pick up a twig and make them run away. after this experience you have had enough and you decide to go home.";
                    questionlable.Text = "Thanks for playing";
                    button1.Visible = false;
                    button2.Visible = true;
                    button2.Text = "Continue";
                    button3.Visible = false;
                    break;
                case 12:
                    outputLabel.Text = "You followed your instinct but unfortunately it did not lead you to the right path. You're dead, the wolves have torn you apart.";
                    questionlable.Text = "Thanks for playing";
                    button1.Visible=false;
                    button2.Visible=true;
                    button2.Text = "Continue";
                    button3.Visible=false;
                    break;
                case 13:
                    outputLabel.Text = "you didn't think twice when they asked you to ride Santa's sleigh. You have a lot of fun screaming at the top of your throat until you run into an avalanche. You are dead.";
                    questionlable.Text = "Thanks for playing";
                    button1.Visible = false;
                    button2.Visible = true;
                    button2.Text = "Continue";
                    button3.Visible=false;
                    break;
                case 14:
                    outputLabel.Text = "the sea is your habitat so you have decided to relax in a resort in the Maldives.";
                    questionlable.Text = "the first thing you would like to do is?";
                    button1.Text = "relax";
                    button2.Visible=false;
                    button3.Text = "explore";
                    break;
                case 15:
                    outputLabel.Text = "the first thing you wanted to do is visit this paradise on earth by taking a tour of the island and you come across a shipwreck on the beach. You enter the stranded boat and notice a ruined trunk that you decide to open.inside you find what appears to be a map for a treasure buried on the island.";
                    questionlable.Text = "Do you decide to go and look for it?";
                    button1.Text = "no";
                    button2.Visible = false;
                    button3.Text = "yes";
                    break;
                case 16:
                    outputLabel.Text = "you decide that to start your holiday it is better to spend time on a raft lulled by the waves and sunbathing. the sun tires you and you fall asleep after a while. when you wake up it is no longer docked on the beach but you have been swept away by the waves in the middle of the ocean.";
                    questionlable.Text = "You have two chances, what do you do?";
                    button1.Text = "you look for help";
                    button2.Visible = false;
                    button3.Text = "look for the land on the horizon";
                    break;
                case 17:
                    outputLabel.Text = "you start to follow the path marked on the map but you end up getting lost inside a darkened cave and can't find the exit.";
                    questionlable.Text = "Thanks for playing";
                    button1.Visible = false;
                    button2.Visible = true;
                    button2.Text = "Continue";
                    button3.Visible = false;
                    break;
                case 18:
                    outputLabel.Text = "you remembered that you had your cell phone with you so you just need to call for help and after a while you spot a helicopter. you are safe.";
                    questionlable.Text = "Thanks for playing";
                    button1.Visible =false;
                    button2.Visible = true;
                    button2.Text = "Continue";
                    button3.Visible= false;
                    break;
                case 19:
                    outputLabel.Text = "unfortunately you can't find what you were looking for. in its place you find yourself a hungry shark that begins to devour the raft. you are dead.";
                    questionlable.Text = "Thanks for playing";
                    button1.Visible=false;
                    button2.Visible =true;
                    button2.Text = "Continue";
                    button3.Visible = false;
                    break;
            }
        }
    }
}