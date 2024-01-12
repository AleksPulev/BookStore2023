namespace BookStore_C.Validators
{
    using BookStore_C.Models.Models;
    using BookStore_C.Models.Requests;
    using FluentValidation;

    public class GetAllBooksByAuthorRequestValidator : AbstractValidator<GetAllBooksByAuthorRequest>
    {
        public GetAllBooksByAuthorRequestValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotNull()
                .GreaterThanOrEqualTo(1);

            RuleFor(x => x.AfterDate)
                .NotNull();
        }
    }
}
