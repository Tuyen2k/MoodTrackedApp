using MoodTrackedLib.Entites;
using MoodTrackedLib.RequestModels;

namespace MoodTrackedApi.Repositories {
    public interface IUserRepositories {

        /// <summary>
        /// Lấy thông tin người dùng theo email
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<User?> GetUserByEmail(UserFilterEmail filter);

        /// <summary>
        /// Lấy thông tin người dùng theo bỘ lọc
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<User?> GetUser(UserFilterAll filter);

        /// <summary>
        /// Lấy thông tin người dùng theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<User?> GetUserById(Guid id);

        /// <summary>
        /// Lấy danh sách người dùng theo bộ lọc
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>

        Task<List<User>> GetUsers(UserFilterAll filter);

        /// <summary>
        /// Tạo mới người dùng
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<User> CreateUser(User user);

        /// <summary>
        /// Cập nhật thông tin người dùng
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<bool> UpdateUser(User user);

        /// <summary>
        /// Xóa người dùng --> xóa mềm
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteUser(User user);

        /// <summary>
        /// Khóa người dùng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> LockUser(User user);

        /// <summary>
        /// Mở khóa người dùng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> UnlockUser(User user);

        /// <summary>
        /// Thay đổi mật khẩu người dùng
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        Task<bool> ChangePassword(User user, string newPassword);

        /// <summary>
        /// Cập nhật trạng thái người dùng
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isActive"></param>
        /// <returns></returns>
        Task<bool> UpdateUserStatus(User user, bool isActive);

        /// <summary>
        /// Đếm số lần đăng nhập thất bại của người dùng
        /// </summary>
        /// <param name="user"></param>
        /// <param name="count">số lần login sai</param>
        /// <returns></returns>
        Task<bool> UpdateFailAccess(User user, int count);

    }
}
