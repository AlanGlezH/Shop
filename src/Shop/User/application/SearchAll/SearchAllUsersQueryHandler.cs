using Shop.Shared.Domain.Bus.Query;

namespace Shop.User.Application.SearchAll;
public class SearchAllUsersQueryHandler : QueryHandler<SearchAllUsersQuery, UsersResponse>
{
    private readonly UserSearcher _searcher;
    public SearchAllUsersQueryHandler(UserSearcher userSearcher)
    {
        _searcher = userSearcher;
    }

    public async Task<UsersResponse> Handle(SearchAllUsersQuery query)
    {
        return await _searcher.Search();
    }
}