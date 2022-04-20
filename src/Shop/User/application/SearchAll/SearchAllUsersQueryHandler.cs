using Shop.Shared.Domain.Bus.Query;
using MediatR;
namespace Shop.User.Application.SearchAll;
public class SearchAllUsersQueryHandler : IRequestHandler<SearchAllUsersQuery, UsersResponse>
{
    private readonly UserSearcher _searcher;
    public SearchAllUsersQueryHandler(UserSearcher userSearcher)
    {
        _searcher = userSearcher;
    }

    public async Task<UsersResponse> Handle(SearchAllUsersQuery request, CancellationToken cancellationToken)
    {
        return await _searcher.Search();
    }
}