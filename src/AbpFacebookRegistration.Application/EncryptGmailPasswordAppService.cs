using Volo.Abp.Application.Services;
using Volo.Abp.Security.Encryption;

namespace AbpFacebookRegistration.Application
{
  public class EncryptGmailPasswordAppService : ApplicationService
  {
    public IStringEncryptionService _encryptionService { get; set; }


    public string EncryptGmailPassword()
    {
      return _encryptionService.Encrypt("YourGmailPasswordHere");
    }
  }
}