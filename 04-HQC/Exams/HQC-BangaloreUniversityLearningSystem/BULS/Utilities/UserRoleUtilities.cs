namespace BangaloreUniversityLearningSystem.Utilities
{
    using Models;

    public static class UserRoleUtilities
    {
        public static bool IsInRole(this User user, Role role)
        {
            var isInRole = user != null && user.Role == role;

            return isInRole;
        }
    }
}
