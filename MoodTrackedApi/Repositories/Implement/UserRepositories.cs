using Microsoft.EntityFrameworkCore;
using MoodTrackedLib;
using MoodTrackedLib.Entites;
using MoodTrackedLib.RequestModels;

namespace MoodTrackedApi.Repositories.Interface {
    public class UserRepositories : IUserRepositories {

        private readonly MoodTrackedDBContext _dbContext;
        public UserRepositories(MoodTrackedDBContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<bool> ChangePassword(User user, string newPassword) {
            user.PasswordHash = newPassword;
            _dbContext.Users.Update(user);
            var result = await _dbContext.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> UpdateFailAccess(User user, int fail) {
            user.AccessFailedCount = fail;
            _dbContext.Users.Update(user);
            var result = await _dbContext.SaveChangesAsync();
            return result > 0;
        }

        public async Task<User> CreateUser(User user) {
            var result = await _dbContext.Users.AddAsync(user);
            return result.Entity;
        }

        public async Task<bool> DeleteUser(User user) {
            user.IsDeleted = true;
            _dbContext.Users.Update(user);
            var result = await _dbContext.SaveChangesAsync();
            return result > 0;
        }

        public async Task<User?> GetUser(UserFilterAll filter) {
            var query = _dbContext.Users.AsQueryable();

            if (filter.Id != null) {
                query = query.Where(x => x.Id == filter.Id);
            }

            if (!string.IsNullOrEmpty(filter.Email)) {
                query = query.Where(x => x.Email == filter.Email);
            }
            if (!string.IsNullOrEmpty(filter.Name)) {
                query = query.Where(x => x.Name.Contains(filter.Name));
            }
            if (filter.AccessFailedCount != null) {
                query = query.Where(x => x.AccessFailedCount == filter.AccessFailedCount);
            }
            if (filter.IsActive != null) {
                query = query.Where(x => x.IsActive == filter.IsActive);
            }
            if (filter.IsDeleted != null) {
                query = query.Where(x => x.IsDeleted == filter.IsDeleted);
            }
            if (filter.LockoutEnabled != null) {
                query = query.Where(x => x.LockoutEnabled == filter.LockoutEnabled);
            }
            var user = await query.FirstOrDefaultAsync();

            return user;
        }

        public Task<User?> GetUserByEmail(UserFilterEmail filter) {
            var query = _dbContext.Users.AsQueryable();
            if (!string.IsNullOrEmpty(filter.Email)) {
                query = query.Where(x => x.Email == filter.Email);
            }
            if (filter.IsActive != null) {
                query = query.Where(x => x.IsActive == filter.IsActive);
            }
            if (filter.IsDeleted != null) {
                query = query.Where(x => x.IsDeleted == filter.IsDeleted);
            }
            if (filter.LockoutEnabled != null) {
                query = query.Where(x => x.LockoutEnabled == filter.LockoutEnabled);
            }
            var user = query.FirstOrDefaultAsync();
            return user;
        }

        public async Task<User?> GetUserById(Guid id) {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }

        public Task<List<User>> GetUsers(UserFilterAll filter) {
            var query = _dbContext.Users.AsQueryable();
            if (filter.Id != null) {
                query = query.Where(x => x.Id == filter.Id);
            }
            if (!string.IsNullOrEmpty(filter.Email)) {
                query = query.Where(x => x.Email == filter.Email);
            }
            if (!string.IsNullOrEmpty(filter.Name)) {
                query = query.Where(x => x.Name.Contains(filter.Name));
            }
            if (filter.AccessFailedCount != null) {
                query = query.Where(x => x.AccessFailedCount == filter.AccessFailedCount);
            }
            if (filter.IsActive != null) {
                query = query.Where(x => x.IsActive == filter.IsActive);
            }
            if (filter.IsDeleted != null) {
                query = query.Where(x => x.IsDeleted == filter.IsDeleted);
            }
            if (filter.LockoutEnabled != null) {
                query = query.Where(x => x.LockoutEnabled == filter.LockoutEnabled);
            }
            var users = query.ToListAsync();
            return users;
        }

        public async Task<bool> LockUser(User user) {
            user.LockoutEnabled = true;
            _dbContext.Users.Update(user);
            var result = await _dbContext.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> UnlockUser(User user) {
            user.LockoutEnabled = false;
            _dbContext.Users.Update(user);
            var result = await _dbContext.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> UpdateUser(User user) {
            _dbContext.Users.Update(user);
            var result = await _dbContext.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> UpdateUserStatus(User user, bool isActive) {
            user.IsActive = isActive;
            _dbContext.Users.Update(user);
            var result = await _dbContext.SaveChangesAsync();
            return result > 0;
        }
    }
}
