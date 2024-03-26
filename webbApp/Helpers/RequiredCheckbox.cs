using System.ComponentModel.DataAnnotations;

namespace webbApp.Helpers;

public class RequiredCheckbox : ValidationAttribute
{
    public override bool IsValid(object? value) => value is bool b && b;
}
