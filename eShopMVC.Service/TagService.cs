using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Service
{
   public interface ITagService
    {
        Tag Add(Tag tag);
        void Update(Tag tag);
        Tag Delete(int id);
        IEnumerable<Tag> GetAll();
        Tag GetByID(int ID);
        void Save();
    }
}
