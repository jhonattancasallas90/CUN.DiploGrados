namespace CUN.DiploGrados.Transversal.Common
{
    public interface IAppLogger<T>
    {
        // Vinculadsos al Docker - Traza en el servidor
        void LogInformation(string message, params object[] args);

        void LogWarning(string message, params object[] args);

        void LogError(string message, params object[] args);
    }
}
