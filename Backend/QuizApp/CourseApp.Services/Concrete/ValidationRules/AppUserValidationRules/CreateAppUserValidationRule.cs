using FluentValidation;
using QuizApp.Dtos.Concrete.AppEntities.AppUser;

namespace QuizApp.Services.Concrete.ValidationRules.AppUserValidationRules
{
    public class CreateAppUserValidationRule : AbstractValidator<CreateAppUserDto>
    {
        public CreateAppUserValidationRule()
        {
             
        }
    }
}
