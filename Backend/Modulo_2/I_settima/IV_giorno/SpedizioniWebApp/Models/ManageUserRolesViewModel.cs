namespace SpedizioniWebApp.Models
{
    public class ManageUserRolesViewModel
    {
        public ManageUserRolesViewModel()
        {
            UserRoles = new List<UserRolesViewModel>();
        }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<UserRolesViewModel> UserRoles { get; set; }
    }

    public class UserRolesViewModel
    {
        public string RoleName { get; set; }
        public bool Selected { get; set; }
    }
}
