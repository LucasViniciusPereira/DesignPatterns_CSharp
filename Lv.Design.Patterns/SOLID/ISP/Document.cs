namespace Lv.Design.Patterns.SOLID.ISP
{
    public class Document : IFile, IArchiveText
    {
        public void Open()
        {
            System.Diagnostics.Debug.WriteLine("Abrindo Arquivo Texto.");
        }
    }
}