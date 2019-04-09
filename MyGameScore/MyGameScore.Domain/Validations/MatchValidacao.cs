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
        }

        public void ValidateDate()
        {
            RuleFor(e => e.Date)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("Date is invalid!");
        }
    }
}
