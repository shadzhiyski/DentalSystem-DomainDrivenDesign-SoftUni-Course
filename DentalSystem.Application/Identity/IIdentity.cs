using System.Threading.Tasks;
using DentalSystem.Application.Common;
using DentalSystem.Application.Identity.Commands;
using DentalSystem.Application.Identity.Commands.ChangePassword;
using DentalSystem.Application.Identity.Commands.LoginUser;

namespace DentalSystem.Application.Identity
{
    public interface IIdentity
    {
        Task<Result<IUser>> RegisterAsync(UserInputModel userInput);

        Task<Result<LoginSuccessModel>> LoginAsync(UserInputModel userInput);

        Task<Result> ChangePasswordAsync(ChangePasswordInputModel changePasswordInput);
    }
}