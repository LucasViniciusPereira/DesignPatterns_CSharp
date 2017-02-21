namespace Lv.Design.Patterns.GOF.Behavioral.ChainOfResponsibility
{
    public class ValidateClient : IValidade
    {
        public override bool Validate(string name, string password)
        {
            System.Diagnostics.Debug.WriteLine("Validação no Client.");

            bool isValid = false;

            if (!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(password))
                isValid = true;

            if (isValid == false && _next != null)
                isValid = _next.Validate(name, password);

            return isValid;
        }
    }
}
