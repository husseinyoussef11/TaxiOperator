﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Entities.Models.Branch
{
    public class ByIdBranchResponse :  GlobalResponse
    {
        public Branch branch { get; set; }  
    }
}