/* AUTHOR: DRAKE HETLAND
 * DATE: 10/24/2020
 * DESCRIPTION: EXAM 2: SHOW SKILLS USING LIST BOXES OR RADIAL BUTTONS, CHECK BOXES, 
 * DECISION STRUCTURES, SWITCH STATEMENTS, VARIABLES, AND ERROR HANDLING.*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam2Practical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //CREATES THE EXIT BUTTON
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //TELLS THE PROGRAM TO PRIORITZE THE OUTPUTS WITH SPORTS SELECTED
            if (sportsCheckBox.Checked)
            {
                //ALL OUTPUTS RELATED TO HAVING SPORTS SELECTED
                if (sportsCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobby: Sports";
                }
                if (sportsCheckBox.Checked && videoGamesCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports and Video Games";
                }
                else if (sportsCheckBox.Checked && photographyCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports and Photography";
                }
                else if (sportsCheckBox.Checked && readingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports and Reading";
                }
                else if (sportsCheckBox.Checked && writingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports and Writing";
                }
                else if (sportsCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports and Anime";
                }
                else if (sportsCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports and Collecting";
                }
                if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && photographyCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, and Photography";
                }
                else if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && readingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, and Reading";
                }
                else if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && writingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, and Writing";
                }
                else if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, and Anime";
                }
                else if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, and Collecting";
                }
                if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, Photography, and Reading";
                }
                else if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && photographyCheckBox.Checked && writingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, Photography, and Writing";
                }
                else if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && photographyCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, Photography, and Anime";
                }
                else if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && photographyCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, Photography, and Collecting";
                }
                if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked && writingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, Photography, Reading, and Writing";
                }
                else if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, Photography, Reading, and Anime";
                }
                else if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, Photography, Reading, and Collecting";
                }
                if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked && collectingCheckBox.Checked && writingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, Photography, Reading, Writting and Collecting";
                }
                else if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked && collectingCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, Photography, Reading, Anime and Collecting";
                }
                if (sportsCheckBox.Checked && videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked && collectingCheckBox.Checked && writingCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Sports, Video Games, Photography, Reading, Writting, Anime, and Collecting";
                }
            }
            //MOVES DOWN THE LIST TO PRORITIZING VIDEO GAMES AS THE SELECTED HOBBY
            else if (videoGamesCheckBox.Checked)
            {
                //ALL OUTPUTS FOR VIDEO GAMES
                if (videoGamesCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobby: Video Games";
                }
                if (videoGamesCheckBox.Checked && photographyCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games and Photography";
                }
                else if (videoGamesCheckBox.Checked && readingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games and Reading";
                }
                else if (videoGamesCheckBox.Checked && writingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games and Writing";
                }
                else if (videoGamesCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games and Anime";
                }
                else if (videoGamesCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games and Collecting";
                }
                if (videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games, Photography, and Reading";
                }
                else if (videoGamesCheckBox.Checked && photographyCheckBox.Checked && writingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games, Photography, and Writing";
                }
                else if (videoGamesCheckBox.Checked && photographyCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games, Photography, and Anime";
                }
                else if (videoGamesCheckBox.Checked && photographyCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games, Photography, and Collecting";
                }
                if (videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked && writingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games, Photography, Reading, and Writing";
                }
                else if (videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games, Photography, Reading, and Anime";
                }
                else if (videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games, Photography, Reading and Collecting";
                }
                if (videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked && writingCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games, Photography, Reading, Writing, and Anime";
                }
                else if (videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked && writingCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games, Photography, Reading, Writing, and Collecting";
                }
                if (videoGamesCheckBox.Checked && photographyCheckBox.Checked && readingCheckBox.Checked && writingCheckBox.Checked && animeCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Video Games, Photography, Reading, Writing, Anime, and Collecting";
                }
            }
            //MOVES DOWN THE LIST TO PRORITIZING PHOTOGRAPHY AS THE SELECTED HOBBY
            else if (photographyCheckBox.Checked)
            {
                //ALL OUTPUTS FOR PHOTOGRAPHY
                if (photographyCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobby: Photography";
                }
                if (photographyCheckBox.Checked && readingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Photography and Reading";
                }
                else if (photographyCheckBox.Checked && writingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Photography and Writing";
                }
                else if (photographyCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Photography and Anime";
                }
                else if (photographyCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Photography and Collecting";
                }
                if (photographyCheckBox.Checked && readingCheckBox.Checked && writingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Photography, Reading, and Writing";
                }
                else if (photographyCheckBox.Checked && readingCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Photography, Reading, and Anime";
                }
                else if (photographyCheckBox.Checked && readingCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Photography, Reading, and Collecting";
                }
                if (photographyCheckBox.Checked && readingCheckBox.Checked && writingCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Photography, Reading, Writing, and Anime";
                }
                else if (photographyCheckBox.Checked && readingCheckBox.Checked && writingCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Photography, Reading, Writing, and Collecting";
                }
                if (photographyCheckBox.Checked && readingCheckBox.Checked && writingCheckBox.Checked && animeCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Photography, Reading, Writing, Anime, and Collecting";
                }
            }
            //MOVES DOWN THE LIST TO PRORITIZING READING AS THE SELECTED HOBBY
            else if (readingCheckBox.Checked)
            {
                //ALL OUTPUTS FOR READING
                if (readingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobby: Reading";
                }
                if (readingCheckBox.Checked && writingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Reading and Writing";
                }
                else if (readingCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Reading and Anime";
                }
                else if (readingCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Reading and Collecting";
                }
                if (readingCheckBox.Checked && writingCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Reading, Writing, and Anime";
                }
                else if (readingCheckBox.Checked && writingCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Reading, Writing, and Collecting";
                }
                if (readingCheckBox.Checked && writingCheckBox.Checked && animeCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Reading, Writing, Anime, and Collecting";
                }
            }
            //MOVES DOWN THE LIST TO PRORITIZING WRITING AS THE SELECTED HOBBY
            else if (writingCheckBox.Checked)
            {
                //ALL OUTPUTS FOR WRITING
                if (writingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobby: Writting";
                }
                if (writingCheckBox.Checked && animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Writting and Anime";
                }
                else if (writingCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Writting and Collecting";
                }
                if (writingCheckBox.Checked && animeCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Writting, Anime, and Collecting";
                }
            }
            //MOVES DOWN THE LIST TO PRORITIZING ANIME AS THE SELECTED HOBBY
            else if (animeCheckBox.Checked)
            {
                //ALL OUTPUTS FOR ANIME
                if (animeCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobby: Anime";
                }
                if (animeCheckBox.Checked && collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobbies: Anime and Collecting";
                }
            }
            //MOVES DOWN THE LIST TO PRORITIZING COLLECTING AS THE SELECTED HOBBY
            else if (collectingCheckBox.Checked)
            {
                //OUTPUT FOR COLLECTING
                if (collectingCheckBox.Checked)
                {
                    hobbiesOutputLabel.Text = "Hobby: Collecting";
                }
            }
            //ALLOWS THE USER TO INPUT A NAME, ANDD HAS THE PROGRAM SHOW IT PROPERLY
            userNameLabel.Text = "Name: " + (nameTextBox.Text);
            
            //MATH SEQUENCE FOR ADDING THE AGE OF THE USER WITH HOW MANY YEARS LEFT IN PROGRAM
            try
            {
                //SETS VARIABLES
                int age = 0;
                int years = 0;
                int total = 0;

                //ALLOWS THE USER TO INPUT THE VALUES THEY WANT FOR AGE AND YEARS REMAINING
                age = int.Parse(ageTextBox.Text);
                years = int.Parse(yearsLeftInProgramTextBox.Text);

                //OUTPUTS THE AGE THEY WILL BE UPON GRADUATION
                total = age + years;
                ageOutputLabel.Text = "Age Upon Graduation: " + total.ToString("");
            }
            //CATCH STATEMENT IN CASE USER INPUTS A NON-INTEGER
            catch
            {
                MessageBox.Show("Please input integers only.");
            }

            //IF ELSE STATEMENT MAKSE SURE THE USER SELECTS AT LEAST ONE PROGRAM OF STUDY FROM THE LIST BOX
            if (programListBox.SelectedIndex != -1)
            {
                //SWITCH STATEMENT ALLOWS THE PROGRAM TO OUTPUT THE CORRECT STRING BASED ON THE OPTION THE USER SELECTS
                //COULDN'T FIGURE OUT HOW TO GET A TAB ORDER INTO THE LIST BOX
                switch (programListBox.SelectedIndex)
                {
                    case 0: 
                        programLabel.Text = "Program: A/A or A/S";
                        break;
                    case 1:
                        programLabel.Text = "Program: Aviation";
                        break;
                    case 2:
                        programLabel.Text = "Program: Computer Programming";
                        break;
                    case 3:
                        programLabel.Text = "Program: Engineering Technology";
                        break;
                    case 4:
                        programLabel.Text = "Program: Environmental Science";
                        break;
                    case 5:
                        programLabel.Text = "Program: Music";
                        break;
                    case 6:
                        programLabel.Text = "Program: Video Game Design";
                        break;
                    case 7:
                        programLabel.Text = "Program: Web Design";
                        break;
                }
                
            }

            else
            {
                MessageBox.Show("Please select a program of study.");
            }
            
            //CONGLOMERATES ALL RESPONSES INTO ONE. HONESTLY NOT SURE IF THIS IS THE RIGHT WAY TO DO IT, BUT IT WORKED AND AT LEAST LOOKS NICE WHEN IT IS RUNNING
            MessageBox.Show(userNameLabel.Text + Environment.NewLine + programLabel.Text + Environment.NewLine + ageOutputLabel.Text + Environment.NewLine + hobbiesOutputLabel.Text);
        }
    }
}