using System;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    List<OperationClaim> GetClaims(User user);

    void Add(User user);

    User GetByEmail(string email);
}

