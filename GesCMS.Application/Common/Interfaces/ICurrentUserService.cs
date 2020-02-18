using System;
using System.Collections.Generic;
using System.Text;

namespace GesCMS.Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; }
        bool IsAuthenticated { get; }
    }
}
