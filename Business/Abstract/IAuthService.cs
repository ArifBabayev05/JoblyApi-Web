using System;
using Core.Entities.Concrete;
using Core.Utilities.Result;
using Core.Utilities.Security.JWT;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDTO userForRegisterDTO, string password);
        IDataResult<User> Login(UserForLoginDTO userForLoginDTO);

        IResult UserExist(string mail);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}

