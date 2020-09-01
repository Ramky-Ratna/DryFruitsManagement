using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataService
{
    public class DataRepository : IDataRepository
    {
        public void AddProduct(TblProducts product)
        {
            using(var context=new FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext())
            {
                    context.TblProducts.Add(product);
                    context.SaveChanges();
            }            
        }

        public void AddUser(TblUser user)
        {
            using (var context = new FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext())
            {
                context.TblUser.Add(user);
                context.SaveChanges();
            }
        }

        public void DeleteProduct(int productId)
        {
            using(var context=new FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext())
            {
                var product = context.TblProducts.Find(productId);
                context.TblProducts.Remove(product);
                context.SaveChanges();
            }
        }

        public void DeleteUser(int userId)
        {
            using (var context = new FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext())
            {
                var user = context.TblUser.Find(userId);
                context.TblUser.Remove(user);
                context.SaveChanges();
            }
        }

        public List<TblProducts> GetAllProducts()
        {
            using(var context=new FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext())
            {
                return context.TblProducts.ToList();
            }
        }

        public List<TblUser> GetAllUsers()
        {
            using (var context = new FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext())
            {
                var users = context.TblUser.ToList();
                return users;
            }

        }

        public TblProducts GetProductById(int productId)
        {
            using (var context=new FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext())
            {
                var product = context.TblProducts.Where(x => x.ProductId == productId).FirstOrDefault();
                return product;
            }
        }

        public TblUser GetUserById(int UserId)
        {
            using (var context = new FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext())
            {
                var user = context.TblUser.Where(x => x.UserId == UserId).FirstOrDefault();
                return user;
            }
        }

        public void UpdateUser(TblUser user)
        {
            using (var context = new FDRYFRUITSMANAGEMENTDATASERVICEDRYFRUITMANAGEMENTDBMDFContext())
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

        public void UpdatProduct(TblProducts user)
        {
            throw new NotImplementedException();
        }
    }
}
