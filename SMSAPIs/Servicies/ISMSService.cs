using Twilio.Rest.Api.V2010.Account;

namespace SMSAPIs.Servicies;
public interface ISMSService
{
    Task<MessageResource> SendAsync(string message, string to);
}