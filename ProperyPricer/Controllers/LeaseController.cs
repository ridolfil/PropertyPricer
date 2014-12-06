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

        public LeaseController()
        {

            if (System.Web.HttpContext.Current.Session["leases"] == null)
            {
                leaseList = testFill();

                System.Web.HttpContext.Current.Session["leases"] = leaseList;
            }else{
                leaseList = new List<LeaseModels>();
                leaseList = System.Web.HttpContext.Current.Session["leases"] as List<LeaseModels>;
            }

        }

        private List<LeaseModels> leaseList;
        // GET: Lease
        public ActionResult Index()
        {

            return View(leaseList);
        }

        [HttpPost]
        public ActionResult AddLease(LeaseModels lease)
        {
            leaseList.Add(lease);
            System.Web.HttpContext.Current.Session["leases"] = leaseList;
            return View("Index", leaseList);
        }


        public ActionResult ShowCashflows(string id)
        {
            List< CashflowViewModel> lcf = new List<CashflowViewModel>();

            int lId = int.Parse(id)-1;

            Lease l = new Lease(leaseList[lId].LeaseStart,leaseList[lId].LeaseEnd,leaseList[lId].InitialRent);
            

            IDictionary<DateTime, double> cf = l.getCashflows();

            foreach (var i in cf)
            {
                CashflowViewModel a = new CashflowViewModel()
                {
                    Amount = i.Value,
                    Date = i.Key
                };

                lcf.Add(a);
            }

            return PartialView("_LeaseCashflows",lcf);
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
                    TenantName="Tenant 3",
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