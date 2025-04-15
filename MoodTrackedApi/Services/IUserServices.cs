using MoodTrackedLib.Dtos;
using MoodTrackedLib.Entites;
using MoodTrackedLib.RequestModels;

namespace MoodTrackedApi.Services {
    public interface IUserServices {

        /// <summary>
        /// Lấy thông tin người dùng theo email
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Task<UserDto?> GetUserDtoByEmail(UserFilterEmail filter);

        /// <summary>
        /// Lấy thông tin người dùng theo bỘ lọc
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<UserDto?> GetUserDtoById(Guid id);

        /// <summary>
        /// Lấy thông tin người dùng theo bộ lọc
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Task<UserDto?> GetUserDto(UserFilterAll filter);

        /// <summary>
        /// Lấy danh sách người dùng theo bộ lọc
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Task<List<UserDto>> GetUserDtos(UserFilterAll filter);

        /// <summary>
        /// Tạo mới người dùng
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task<UserDto> CreateUser(User user);

        /// <summary>
        /// Cập nhật thông tin người dùng
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task<bool> UpdateUser(User user);

        /// <summary>
        /// Xóa người dùng --> xóa mềm
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task<bool> DeleteUser(User user);
        
    }
}
