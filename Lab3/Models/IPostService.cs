using Labolatorium_3.Models;
using System;
using System.Collections.Generic;

namespace Labolatorium_3.Models
{
    public interface IPostService
    {
        int Add(Post item);
        void Delete(int id);
        void Update(Post item);
        List<Post> FindAll();
        Post? FindById(int id);
    }
}
