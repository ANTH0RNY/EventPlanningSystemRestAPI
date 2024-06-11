using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace EventPlanningSystemRestAPI.models;

public class User
{
    public int Id {get;set;}
    public string? Name{get; set;}
    public string? UserType{get; set;}
    public string? Password_harsh{get;set;}
    public int Permissions {get; set;}
    public string? Location {get; set;}
    public DateTime MemberSince {get; set;}
    public DateTime LastSeen {get; set;}
    

}
