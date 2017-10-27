using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TurOtomasyonu.Validations
{
    public class ComplexPassword:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string val = (string)value;

            bool IsValid = Regex.IsMatch(val, @"^(?=(.*\d){2})(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z\d]).{8,}$");

            if (IsValid)
                return ValidationResult.Success;
            else
                return new ValidationResult("En az 1 Sayı 1 Özel Karakter 1 Büyük 1 Küçük Harf ve en az 8 karakterden oluşacak şekilde giriniz");

        }
    }
}
