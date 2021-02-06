using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //dış dünyaya neyi vermek istersen onu implemente et
    public interface ICategoryService 
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}
