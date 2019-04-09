using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameScore.Application.Services.AppMatch.ViewModel
{
    public class MatchViewModel
    {
        public DateTime Date { get; set; }
        public int Score { get; set; }

        public MatchViewModel()
        {
        }

        public MatchViewModel(DateTime date, int score)
        {
            Date = date;
            Score = score;
        }
    }
}
