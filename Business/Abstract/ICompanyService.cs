
using System;
using Core.Utilities.Result;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        IDataResult<Company> Get(int id);

        IDataResult<List<Company>> GetList();

        IResult Add(Company company);

        IResult Delele(Company company);

        IResult Update(Company company);
    }
}

