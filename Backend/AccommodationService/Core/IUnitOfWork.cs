namespace AccommodationService.Core
{
    public interface IUnitOfWork : IDisposable
    {
        void Dispose();
    }
}
