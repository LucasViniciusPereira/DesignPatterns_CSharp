namespace Lv.Design.Patterns.GOF.Behavioral.ChainOfResponsibility
{
    public class FormValidade : IValidade
    {
        public override bool Validate(string name, string password)
        {
            System.Diagnostics.Debug.WriteLine("Validação no formulario.");

            bool isValid = false;

            if (_next != null)
                isValid = _next.Validate(name, password);

            return isValid;
        }
    }
}
