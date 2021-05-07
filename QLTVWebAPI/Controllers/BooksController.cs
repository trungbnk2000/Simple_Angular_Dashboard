using QLTVWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace QLTVWebAPI.Controllers
{
    public class BooksController : ApiController
    {
        private DBContext db = new DBContext();
        
        [System.Web.Http.HttpGet]
        //GET api ca table
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.Books.ToList());
        }
        
        [System.Web.Http.HttpGet]
        //GET api theo id
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.Books.FirstOrDefault(s => s.ID == id));
        }
        
        [System.Web.Http.HttpPost]
        //POST 
        public string Post(Book b)
        {
            try
            {
                db.Books.Add(b);
                db.SaveChanges();
                return "Them thanh cong!";
            }
            catch (Exception)
            {
                return "That bai";
            }
        }
        [System.Web.Http.HttpPut]
        //PUT
        public string Put(Book b)
        {
            try
            {
                db.Entry(b).State = EntityState.Modified;
                db.SaveChanges();
                return "Sua thanh cong!";
            }
            catch (Exception)
            {
                return "That bai";
            }
        }
        
        [System.Web.Http.HttpDelete]
        //DELETE
        public string Delete(int id)
        {
            try
            {
                Book b = db.Books.Find(id);
                db.Books.Remove(b);
                db.SaveChanges();
                return "Xoa thanh cong!";
            }
            catch (Exception)
            {
                return "That bai";
            }
        }
    }
}