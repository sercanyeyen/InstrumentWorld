using InstrumentWorld.DataAccess.Entities.Concrete;
using FluentValidation;

namespace InstrumentWorld.Business.ValidationRules
{
    public class ChildCategoryValidator : AbstractValidator<ChildCategory>
    {
        public ChildCategoryValidator()
        {
             RuleFor(x=>x.ChildCategoryName).NotEmpty().WithMessage("Alt kategori ismi boş olamaz");
        }
    }
}