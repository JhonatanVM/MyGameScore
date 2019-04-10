using FluentValidation;
using MyGameScore.Domain.Entities;
using System;

namespace MyGameScore.Domain.Validations
{
    public class MatchValidation : AbstractValidator<Match>
    {
        public MatchValidation()
        {
            ValidateDate();
            ValidateScore();
        }

        public void ValidateDate()
        {
            RuleFor(e => e.Date)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("Date is invalid!");
        }

        public void ValidateScore()
        {
            RuleFor(e => e.Score)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Score is invalid!");
        }
    }
}
