using InstrumentWorld.DataAccess.Entities.Concrete;
using FluentValidation;

namespace InstrumentWorld.Business.ValidationRules
{
    public class BrandValidation:AbstractValidator<Brand>
    {
        public BrandValidation()
        {
            RuleFor(x=>x.BrandName).NotEmpty().WithMessage("Marka ismi boş olamaz");
        }
        
    }
}