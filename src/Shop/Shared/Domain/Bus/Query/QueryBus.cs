namespace Shop.Shared.Domain.Bus.Query;

public interface QueryBus
{
    Task<TResponse> Ask<TResponse>(Query request);
}