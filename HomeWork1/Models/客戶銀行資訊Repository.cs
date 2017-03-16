using System;
using System.Linq;
using System.Collections.Generic;
	
namespace HomeWork1.Models
{   
	public  class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
	{
        public IQueryable<客戶銀行資訊> GetAll(string KeyWord = "")
        {
            IQueryable<客戶銀行資訊> Result = base.All().Where(o => o.IsDeleted == false);
            if (!string.IsNullOrEmpty(KeyWord))
            {
                Result = Result.Where(o => o.銀行名稱.Contains(KeyWord));
            }
            return Result;
        }


        public override void Delete(客戶銀行資訊 entity)
        {
            entity.IsDeleted = true;
        }


        public 客戶銀行資訊 Find(int? id)
        {
            return GetAll().Where(o => o.Id == id).SingleOrDefault();
        }
    }

	public  interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
	{

	}
}