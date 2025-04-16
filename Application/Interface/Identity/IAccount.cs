namespace IMS.Application.Interface.Identity;
internal interface IAccount
{
    Task<ServiceResponse> CreateUserAsync(RegisterDto registerDto);
    Task<ServiceResponse> LoginAsync(LoginDto loginDto);
    Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUsersWithClaimsAsync();
    Task SetUpAsync();
    Task<ServiceResponse> UpdateUserAsync();
    Task SaveActivityAsync();
    Task<IEnumerable<ActivityTrackerResponseDTO>> GetActivitiesAsync();
}
