using System;
using System.ComponentModel.DataAnnotations.Schema;
using FluentValidation.Results;
using MyGameScore.Domain.Validations;

namespace MyGameScore.Domain.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
        public bool IsHighestScore { get; set; }

        [NotMapped]
        public ValidationResult ValidationResult { get; set; }

        public Match()
        {
        }

        public Match(DateTime date, int score)
        {
            Date = date;
            Score = score;
        }

        public bool IsValid()
        {
            ValidationResult = new MatchValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
