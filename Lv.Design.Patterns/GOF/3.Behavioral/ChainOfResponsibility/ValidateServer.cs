namespace Lv.Design.Patterns.GOF.Behavioral.ChainOfResponsibility
{
    public class ValidateServer : IValidade
    {
        public override bool Validate(string name, string password)
        {
            System.Diagnostics.Debug.WriteLine("Validação no Server.");

            bool isValid = false;

            if (name == "ADMIN" && password == "123456")
                isValid = true;

            if (_next != null)
                isValid = _next.Validate(name, password);

            return isValid;
        }
    }
}
