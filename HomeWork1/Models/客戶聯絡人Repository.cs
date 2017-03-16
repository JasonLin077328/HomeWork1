using System;
using System.Linq;
using System.Collections.Generic;
	
namespace HomeWork1.Models
{
    public class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
    {
        public IQueryable<客戶聯絡人> GetAll(string KeyWord = "")
        {
            IQueryable<客戶聯絡人> Result = base.All().Where(o => o.IsDeleted == false);
            if (!string.IsNullOrEmpty(KeyWord))
            {
                Result = Result.Where(o => o.姓名.Contains(KeyWord));
            }
            return Result;
        }
        

        public override void Delete(客戶聯絡人 entity)
        {
            entity.IsDeleted = true;
        }


        public 客戶聯絡人 Find(int? id)
        {
            return GetAll().Where(o => o.Id == id).SingleOrDefault();
        }

        public List<客戶聯絡人> GetAllFrom客戶ID(int 客戶Id)
        {
            return GetAll().Where(o => o.客戶Id == 客戶Id).ToList();
        }
    }

    public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}