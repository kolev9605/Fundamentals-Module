namespace Exam.Interface
{
    public interface IOutputWriter
    {
        void WriteLine(string messege);
        void WriteLine(string format, params object[] args);
    }
}
