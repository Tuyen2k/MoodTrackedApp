
namespace MoodTrackedApi.Services.Implement {
    public class AuthServices : IAuthServices {
        public Task<int> AccessFail(string email) {
            throw new NotImplementedException();
        }

        public Task<bool> ChangePassword(string email, string password) {
            throw new NotImplementedException();
        }

        public Task<bool> ForgotPassword(string email) {
            throw new NotImplementedException();
        }

        public Task<bool> LockUser(string email) {
            throw new NotImplementedException();
        }

        public Task<string> Login(string email, string password) {
            throw new NotImplementedException();
        }

        public Task<bool> Logout(string email) {
            throw new NotImplementedException();
        }

        public Task<bool> Register(string email, string password) {
            throw new NotImplementedException();
        }

        public Task<string> ResetPassword(string email, string password) {
            throw new NotImplementedException();
        }

        public Task<bool> UnlockUser(string email) {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyEmail(string email) {
            throw new NotImplementedException();
        }
    }
}
