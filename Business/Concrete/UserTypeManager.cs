using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserTypeManager : IUserTypeService
    {
        IUserTypeDal _userTypeDal;

        public UserTypeManager(IUserTypeDal userTypeDal)
        {
            _userTypeDal = userTypeDal;

        }

        //select * from UserTypes where UserTypeId = 2
        public IDataResult<UserType> GetById(int userTypeId)
        {
            return new SuccessDataResult<UserType>(_userTypeDal.Get(u => u.UserTypeId == userTypeId));

        }

        public IDataResult<List<UserType>> GetAll()
        {
            return new SuccessDataResult<List<UserType>>(_userTypeDal.GetAll());
        }
    }
}
