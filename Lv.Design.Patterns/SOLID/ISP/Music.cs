namespace Lv.Design.Patterns.SOLID.ISP
{
    public class Music : IFile, IArchiveMP3
    {
        public void Reproduce()
        {
            System.Diagnostics.Debug.WriteLine("Abrindo Arquivo MP3.");
        }
    }
}