namespace TheCatApp.Model.User
{
    public class UserModel
    {
        // User Status
        public bool UserIsLoggedIn { get; set; } = false;

        // User Data
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool EmailConfirmed { get; set; }
        public string UserName { get; set; }
        public bool AdModeSelected { get; set; } = true;
        public DateTime LastLoggedIn { get; set; }
        public DateTime LastAdViewed { get; set; }

    }
}
