using PropertyModel;
using ProperyPricer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ProperyPricer.Controllers
{
    public class LeaseController : Controller
    {
        private List<LeaseModels> leaseList;
        // GET: Lease
        public ActionResult Index()
        {
            leaseList = testFill();

            return View(leaseList);
        }



        private List<LeaseModels> testFill(){

            List<LeaseModels> l = new List<LeaseModels>(new LeaseModels[]{
                new LeaseModels(){
                    TenantName = "Tenant 1",
                    LeaseStart= new DateTime(2003,5,12), 
                    LeaseEnd = new DateTime(2017,8,28),
                    Area = 4567,
                    Unit = "unit 1",
                    InitialRent = 12000},
                new LeaseModels(){
                    TenantName = "Tenant 2",
                    LeaseStart =new DateTime(2003,5,12),
                    LeaseEnd =new DateTime(2020,8,28),
                    Unit = "unit 2",
                    Area=345,
                    InitialRent = 1000},
                new LeaseModels(){
                    TenantName="tenant 3",
                    LeaseStart = new DateTime(2013,5,12),
                    LeaseEnd = new DateTime(2015,8,28),
                    Unit = "unit 3",
                    Area = 3769,
                    InitialRent = 10000
            },
           
            });
            return l;
        }
    }
}