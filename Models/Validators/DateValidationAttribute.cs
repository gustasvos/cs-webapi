using System.ComponentModel.DataAnnotations;

namespace StoreMysql.Models.Validators
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class DateValidationAttribute : ValidationAttribute 
    {
        

        public override bool IsValid(object? value)
        {
            // DateTime dateofbirth = Convert.ToDateTime(value);
            // return dateofbirth <= DateTime.Now;

            DateTime dateofbirth = Convert.ToDateTime(value);
            DateTime today = DateTime.Today;

            // only considering the year
            int age = today.Year - dateofbirth.Year;

            if (dateofbirth <= DateTime.Now && age > 18)
                return true;
            else 
                return false;

            // return base.IsValid(value);
        }


    }
}