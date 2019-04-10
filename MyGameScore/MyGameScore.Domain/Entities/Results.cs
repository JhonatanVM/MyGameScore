using System;

namespace MyGameScore.Domain.Entities
{
    public class Results
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int QuantityOfGames { get; set; }
        public int TotalScore { get; set; }
        public double AverageScore { get; set; }
        public int HighestScore { get; set; }
        public int LowestScore { get; set; }
        public int TimesRecordBeated { get; set; }

        public Results()
        {
        }

        public Results(DateTime startDate, DateTime endDate, int quantityOfGames, int totalScore, 
            double averageScore, int highestScore, int lowestScore, int timesRecordBeated)
        {
            StartDate = startDate;
            EndDate = endDate;
            QuantityOfGames = quantityOfGames;
            TotalScore = totalScore;
            AverageScore = averageScore;
            HighestScore = highestScore;
            LowestScore = lowestScore;
            TimesRecordBeated = timesRecordBeated;
        }
    }
}
