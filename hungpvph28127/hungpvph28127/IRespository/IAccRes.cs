using hungpvph28127.Models;
using Microsoft.AspNetCore.Identity;

namespace hungpvph28127.IRespository
{
    public interface IAccRes
    {
        public Task<IdentityResult> SignUpAsync(SignUpModels model);
        public Task<string> SignINAsync(SignInModel model);
    }
}
