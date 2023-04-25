using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Models.Branch;
using TaxiOperator.Models;

namespace TaxiOperator.Repository.Branch
{
    public class BranchRepository : IBranchRepository
    {
        public BranchRepository() { }
        public AddBranchResponse Add(AddBranchRequest request)
        {
            AddBranchResponse resp = new AddBranchResponse();
            using (var db = new TaxiOperatorContext())
            {

                var branch = new Models.Branch { Name = request.name, Address = request.address, IdArea = request.idArea };
                db.Branches.Add(branch);
                db.SaveChanges();
                resp.id = branch.IdBranch;

                var branchDrivers = new List<Models.BranchDriver>();
                foreach (var driver in request.drivers)
                {
                    branchDrivers.Add( new Models.BranchDriver { IdBranch = resp.id, IdDriver = driver });
                }
                db.BranchDrivers.AddRange(branchDrivers);
                db.SaveChanges();

                var branchCabs = new List<Models.BranchCab>();
                foreach (var cab in request.cabs)
                {
                    branchCabs.Add(new Models.BranchCab { IdBranch = resp.id, IdCab = cab });
                }
                db.BranchCabs.AddRange(branchCabs);
                db.SaveChanges();

                var branchCustomers = new List<Models.BranchCustomer>();
                foreach (var customer in request.customers)
                {
                    branchCustomers.Add(new Models.BranchCustomer { IdBranch = resp.id, IdCustomer = customer });
                }
                db.BranchCustomers.AddRange(branchCustomers);
                db.SaveChanges();

            }
            return resp;
        }

        public DeleteBranchResponse Delete(DeleteBranchRequest request)
        {
            throw new NotImplementedException();
        }

        public ListBranchResponse List(ListBranchRequest request)
        {
            ListBranchResponse resp = new ListBranchResponse();
            using (var db = new TaxiOperatorContext())
            {
                var query = from br in db.Branches
                            where br.IsActive==true
                            select new Entities.Models.Branch.Branch() { id = br.IdBranch, address = br.Address,name=br.Name };
                resp.branches = query.Take(request.pageSize).Skip(request.page).ToList();
                resp.totalCount = resp.branches.Count();
            }
            return resp;

        }
    }
}
