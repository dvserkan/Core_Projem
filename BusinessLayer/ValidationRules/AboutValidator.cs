using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Hakkında Bölüm Adı Boş Geçilemez");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon Numarası Alanı Boş Geçilemez");
        }

    }
}
