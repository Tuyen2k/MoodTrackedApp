namespace MoodTrackedApi.Services {
    public interface IAuthServices {
        /// <summary>
        /// Đăng nhập
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns> token - JWT </returns>
        public Task<string> Login(string email, string password);

        /// <summary>
        /// Đăng ký tài khoản
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Task<bool> Register(string email, string password);

        /// <summary>
        /// Thay đổi mật khẩu
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Task<bool> ChangePassword(string email, string password);

        /// <summary>
        /// Quên mật khẩu
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Mật khẩu mới</returns>
        public Task<bool> ForgotPassword(string email);

        /// <summary>
        /// Xác thực email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Task<bool> VerifyEmail(string email);

        /// <summary>
        /// Đếm số lần login thất bại
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Task<int> AccessFail(string email);

        /// <summary>
        /// Khóa tài khoản
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Task<bool> LockUser(string email);

        /// <summary>
        /// Mở khóa tài khoản
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Task<bool> UnlockUser(string email);

    }
}
