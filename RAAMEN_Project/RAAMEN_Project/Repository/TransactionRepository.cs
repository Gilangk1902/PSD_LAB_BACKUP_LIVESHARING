using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Repository
{
    public class TransactionRepository
    {
        Database1Entities1 db = DatabaseSingleton.getInstance();

        //HEADER
        public void AddHeader(Header newHeader)
        {
            db.Headers.Add(newHeader);
        }

        public void DeleteHeader(int id)
        {
            db.Headers.Remove(db.Headers.Find(id));
        }

        public List<Header> GetAllHeader()
        {
            return db.Headers.ToList();
        }

        public List<Header> GetAllHeaderById(int id)
        {
            List<Header> list = (from header in db.Headers where header.id == id select header).ToList();
            return list;
        }

        public Header GetHeaderById(int id)
        {
            return db.Headers.Find(id);
        }

        public void UpdateHeader(int id, Header entity)
        {
            Header header = db.Headers.Find(id);
            header.Date = entity.Date;
            header.CustomerId = entity.CustomerId;
            header.StaffId = entity.StaffId;
        }

        //DETAIL
        public void AddDetail(Detail factory)
        {
            db.Details.Add(factory);
            db.SaveChanges();
        }

        public void DeleteDetail(int id)
        {
            db.Details.Remove(db.Details.Find(id));
            db.SaveChanges();
        }

        public List<Detail> GetAllDetail()
        {
            return db.Details.ToList();
        }

        public Detail GetDetailById(int id)
        {
            return db.Details.Find(id);
        }

        public void UpdateDetail(int id, Detail entity)
        {
            Detail detail = db.Details.Find(id);
            detail.Quantity = entity.Quantity;
            detail.Ramenid = entity.Ramenid;
            detail.Headerid = entity.Headerid;
            db.SaveChanges();
        }
    }
}