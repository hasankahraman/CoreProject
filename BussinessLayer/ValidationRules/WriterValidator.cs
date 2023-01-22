using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Yazar e-posta adresi boş geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Yazar parolası boş geçilemez.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Yazar adı en az 2 karakter olmalıdır.");
            RuleFor(x => x.Name).MaximumLength(75).WithMessage("Yazar adı en fazla 75 karakter olmalıdır.");
        }
    }
}
