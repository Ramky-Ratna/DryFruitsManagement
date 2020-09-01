using DryFruiltsDataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DryFruiltsDataService
{
    public interface IDataRepository
    {
        List<TblUser> GetAllUsers();
        TblUser GetUserById(int UserId);
        void AddUser(TblUser user);
        void UpdateUser(TblUser user);
        void DeleteUser(int userId);
        List<TblProducts> GetAllProducts();
        TblProducts GetProductById(int UserId);
        void AddProduct(TblProducts user);
        void UpdatProduct(TblProducts user);
        void DeleteProduct(int userId);
    }
}
