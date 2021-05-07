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
    public class MembershipCardsController : ApiController
    {
        private DBContext db = new DBContext();
        //GET api ca table
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.MembershipCards.ToList());
        }

        //GET api theo id
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.MembershipCards.FirstOrDefault(s => s.ID == id));
        }

        //POST 
        public string Post(MembershipCard mc)
        {
            try
            {
                db.MembershipCards.Add(mc);
                db.SaveChanges();
                return "Them thanh cong!";
            }
            catch (Exception)
            {
                return "That bai";
            }
        }

        //PUT
        public string Put(MembershipCard mc)
        {
            try
            {
                db.Entry(mc).State = EntityState.Modified;
                db.SaveChanges();
                return "Sua thanh cong!";
            }
            catch (Exception)
            {
                return "That bai";
            }
        }

        //DELETE
        public string Delete(int id)
        {
            try
            {
                MembershipCard mc = db.MembershipCards.Find(id);
                db.MembershipCards.Remove(mc);
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