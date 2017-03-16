using System;
using System.Linq;
using System.Collections.Generic;
	
namespace HomeWork1.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        public IQueryable<客戶資料> GetAll( string KeyWord="")
        {
            IQueryable<客戶資料> Result = base.All().Where(o=>o.IsDeleted ==false);
            if (!string.IsNullOrEmpty(KeyWord))
            {
                Result = Result.Where(o => o.客戶名稱.Contains(KeyWord));
            }
            return Result;
        }
        public override void Delete(客戶資料 entity)
        {
            entity.IsDeleted = true;
        }


        public 客戶資料 Find(int? id)
        {
            return GetAll().Where(o => o.Id == id).SingleOrDefault();
        }
    }

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}