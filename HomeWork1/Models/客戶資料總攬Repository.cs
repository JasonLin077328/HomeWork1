using System;
using System.Linq;
using System.Collections.Generic;
	
namespace HomeWork1.Models
{   
	public  class 客戶資料總攬Repository : EFRepository<客戶資料總攬>, I客戶資料總攬Repository
	{
      

    }

    public  interface I客戶資料總攬Repository : IRepository<客戶資料總攬>
	{

	}
}