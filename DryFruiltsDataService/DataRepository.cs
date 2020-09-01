using DryFruiltsDataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DryFruiltsDataService
{
    public class DataRepository : IDataRepository
    {
        public void AddUser(TblUser user)
        {
            using (var context = new DryFruitsServicesDBContext())
            {
                context.TblUser.Add(user);
                context.SaveChanges();
            }
        }

        public void DeleteUser(int userId)
        {
            using (var context = new DryFruitsServicesDBContext())
            {
                var user = context.TblUser.Find(userId);
                context.TblUser.Remove(user);
                context.SaveChanges();
            }
        }

        public List<TblUser> GetAllUsers()
        {
            using (var context = new DryFruitsServicesDBContext())
            {
                var users = context.TblUser.ToList();
                return users;
            }

        }

        public TblUser GetUserById(int UserId)
        {
            using (var context = new DryFruitsServicesDBContext())
            {
                var user = context.TblUser.Where(x => x.UserId == UserId).FirstOrDefault();
                return user;
            }
        }

        public void UpdateUser(TblUser user)
        {
            using (var context = new DryFruitsServicesDBContext())
            {
                var updateUser = context.TblUser.Find(user.UserId);
                updateUser.UserMobileNumber = user.UserMobileNumber;
                updateUser.UserEmail = user.UserEmail;
                updateUser.UserIsActive = user.UserIsActive;
                updateUser.UserUpdated = DateTime.Now;
                updateUser.UserPassword = user.UserPassword;
                //context.Update(updateUser);
                context.SaveChanges();
            }
        }

        public void AddProduct(TblProducts product)
        {
            try
            {
                using (var context = new DryFruitsServicesDBContext())
                {
                    context.TblProducts.Add(product);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteProduct(int productId)
        {
            try
            {
                using (var context = new DryFruitsServicesDBContext())
                {
                    var product = context.TblProducts.Find(productId);
                    context.TblProducts.Remove(product);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<TblProducts> GetAllProducts()
        {
            try
            {
                using (var context = new DryFruitsServicesDBContext())
                {
                    return context.TblProducts.ToList();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public TblProducts GetProductById(int productId)
        {
            try
            {
                using (var context = new DryFruitsServicesDBContext())
                {
                    var product = context.TblProducts.Where(x => x.ProductId == productId).FirstOrDefault();
                    return product;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdatProduct(TblProducts user)
        {
            throw new NotImplementedException();
        }
    }
}
