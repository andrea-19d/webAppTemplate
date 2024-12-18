﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.Entities.Response;
using WebApp.Domain.Entities.User;

namespace WebApp.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ActionStatus LoginUserStatus(User_Login_Data user);
        ActionStatus SigninUserStatus(User_Signin_Data user);
    };
}
