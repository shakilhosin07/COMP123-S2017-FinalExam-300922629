using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
* Name: Shakil Hosin
* Date: August 17th, 2017
* Description: This is the ScoreBoard Class
* Version: 0.4 - Created the methods 
*/
namespace COMP123_S2017_FinalExam_300922629
{
    class ScoreBoard 
    {
        //PRIVATE INSTANCE VARIABLES
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        //PUBLIC PROPERTIES
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return this._score;
                
            }
            set
            {
                this._score = value;
                this._score = Convert.ToInt32(ScoreTextBox.Text);
                this._score = Convert.ToInt32(FinalScoreTextBox.Text);

            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                this._time = Convert.ToInt32(TimeTextBox.Text);
            }
            
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
               
            }
        }
        //CONSTRUCTORS


        //METHODS
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this._scoreTextBox = scoreTextBox;
            this._timeTextBox = timeTextBox;
            this._finalScoreTextBox = finalScoreTextBox;
        }
        public void UpdateTime()
        {
            int time = Convert.ToInt32(TimeTextBox.Text);
            do
            {
                time--;
                time = Time;
                TimeTextBox.Text = Convert.ToString(this.Time);
            } while (time != 0);
        }
    }
}
