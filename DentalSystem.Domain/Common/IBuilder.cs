namespace DentalSystem.Domain.Common
{
    public interface IBuilder<out TEntity>
        where TEntity : IAggregateRoot
    {
        TEntity Build();
    }
}