using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlığı boş geçemezsiniz.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçeriği boş geçemezsiniz.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Görseli boş geçemezsiniz.");
            RuleFor(x => x.Title).MaximumLength(150).WithMessage("En fazla 150 karakter girebilirsiniz.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("En az 5 karakter girebilirsiniz.");
        }
    }
}
