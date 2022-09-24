using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using udemy1.Services.CharacterService;

namespace udemy1.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;

        public AuthRepository(DataContext context)
        {
            _context = context;
        }
        public Task<ServiceResponse<string>> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            ServiceResponse<int> response = new ServiceResponse<int>();

            if(await UserExists(user.Usernmae))
            {
                response.Success = false;
                response.Message = "User already exists.";
                return response;
            }
            CreatePAsswordHash(password,out byte[] passwordHash,out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            response.Data = user.Id;
            return response;
        }

        public async Task<bool> UserExists(string username)
        {
            return (await _context.Users.AnyAsync(udemy1 => udemy1.Usernmae.ToLower() == username.ToLower()));
        }

        private void CreatePAsswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt)
        {
            using (var hmac= new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}