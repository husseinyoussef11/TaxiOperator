using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;
using TaxiOperator.Entities.Models.Simulator;
using TaxiOperator.Models;

namespace TaxiOperator.Repository.Simulator
{
    public class SimulatorRepository : ISimulatorRepository
    {
        public SimulatorRepository() { }

        public GlobalResponse AddMockData()
        {
            GlobalResponse resp = new GlobalResponse();
            using (var db = new TaxiOperatorContext())
            {
                var customer = new Models.Customer { IsVip = true, Name = "Customer1", Phonenumber = "123456" };
                var customer2 = new Models.Customer { IsVip = true, Name = "Customer2", Phonenumber = "555" };
                var customer3 = new Models.Customer { IsVip = true, Name = "Customer3", Phonenumber = "444" };
                var customers = new List<Models.Customer> { customer, customer2, customer3 };
                db.Customers.AddRange(customers);
                db.SaveChanges();
            }
            return resp;
        }

        public CapDriverAssignResponse CapDriverAssign(CapDriverAssignRequest request)
        {
            CapDriverAssignResponse resp = new CapDriverAssignResponse();
            using (var db = new TaxiOperatorContext())
            {
                var isFound = db.DriverCabs.Where(x => (x.IdDriver == request.idDriver || x.IdCab == request.idCab) && x.DateAssigned == request.date).Select(x => x.IsActive).FirstOrDefault();
                if (isFound == true)
                {
                    resp.statusCode.message = "Cab or Driver already assigned for this date";
                    resp.statusCode.code = 2;
                }
                else
                {
                    var driverCab = new Models.DriverCab
                    {
                        IdCab = request.idCab,
                        IdDriver = request.idDriver,
                        DateAssigned = request.date
                    };
                    db.DriverCabs.Add(driverCab);
                    db.SaveChanges();
                }

            }
            return resp;
        }

        public MonthlyLotteryResponse MonthlyLottery(MonthlyLotteryRequest request)
        {
            MonthlyLotteryResponse resp = new MonthlyLotteryResponse();
            using (var db = new TaxiOperatorContext())
            {
                var isFound = db.MonthlyLotteries.Where(x => x.Date.Equals(request.date)).Select(x => x.IdMonthlyLottery).FirstOrDefault();
                if (isFound == null || isFound == Guid.Empty)
                {
                    var query = from ct in db.Customers
                                orderby Guid.NewGuid()
                                where ct.IsVip == true
                                select new Entities.Models.Customer.Customer() { id = ct.IdCustomer, name = ct.Name, phonenumber = ct.Phonenumber };
                    resp.customer = query.FirstOrDefault();


                    var monthlyLottery = new Models.MonthlyLottery
                    {
                        IdCustomer = resp.customer.id,
                        Date = request.date
                    };
                    db.MonthlyLotteries.Add(monthlyLottery);
                    db.SaveChanges();
                }
                else
                {
                    resp.statusCode.message = "Already done for this month Or no vip customers";
                    resp.statusCode.code = 3;
                }

            }
            return resp;
        }

        public OrderResponse Order(OrderRequest request)
        {
            OrderResponse resp = new OrderResponse();
            using (var db = new TaxiOperatorContext())
            {
                var isFound = db.DriverCabs.Where(x => x.IdDriver == request.idDriver && x.IdCab == request.idCab && x.DateAssigned == request.date).Select(x => x.IsActive).FirstOrDefault();
                if (isFound == true)
                {
                    var order = new Models.Order
                    {
                        IdCab = request.idCab,
                        IdCustomer = request.idCustomer,
                        IdDriver = request.idDriver,
                        Source = request.source,
                        Destination = request.destination
                    };
                    db.Orders.Add(order);
                    db.SaveChanges();

                    //if customer has more than 4 order then he is vip (to be added as config in db and cached in code)
                    var customer = db.Customers.Where(x => x.IdCustomer.Equals(request.idCustomer)).FirstOrDefault();
                    customer.IsVip = true;
                    db.SaveChanges();
                }
                else
                {
                    resp.statusCode.message = "Driver not assigned to cab";
                    resp.statusCode.code = 3;
                }
            }
            return resp;
        }

        public GlobalResponse RemoveMockData()
        {
            GlobalResponse resp = new GlobalResponse();
            using (var db = new TaxiOperatorContext())
            {
                var all = from c in db.Customers select c;
                db.Customers.RemoveRange(all);
                db.SaveChanges();
            }
            return resp;
        }
    }
}
