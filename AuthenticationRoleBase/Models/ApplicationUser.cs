using Microsoft.AspNetCore.Identity;

namespace AuthenticationRoleBase.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
    }
}
