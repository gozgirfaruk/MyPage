using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyPage.Models.Entity;
using MyPage.Context;
using System.Linq.Expressions;

namespace MyPage.Repositories
{
    public class GenericRepository<T> where T:class, new()
    {
        MyPageContext db = new MyPageContext();

        //LİSTELEME
        public List<T> TList()
        {
            return db.Set<T>().ToList();
        }
        //EKLEME
        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        //ID'YE GORE BULMA
        public T TFind(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
        //SİLME
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        //GÜNCELLEME
        public void TUpdate(T p)
        {
            db.SaveChanges();
        }





    }
}