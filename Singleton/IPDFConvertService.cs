namespace Singleton
{
    public interface IPDFConvertService
    {
        void Convert(string filePath, Session session);
        Session GetSession();
    }
}