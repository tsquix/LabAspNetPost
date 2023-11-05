using Labolatorium_3.Models;
using System;
using System.Collections.Generic;

namespace Labolatorium_3.Models
{
    public interface IContactService
    {
        int Add(Contact item);
        void Delete(int id);
        List<Contact> FindAll();
        Contact? FindById(int id);
        void Update(Contact item);
    }
}
