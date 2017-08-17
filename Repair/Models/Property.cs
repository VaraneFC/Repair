using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repair.Models
{
    public class Property
    {
        public int FaultyID{ get; set; }
        public string SerialNo{ get; set; }
        public string DeviceType{ get; set; }
        public string FaultCategory{ get; set; }
        public string FaultType{ get; set; }
        public string Repair_Description{ get; set; }
        public string Repair_By{ get; set; }
        public string Repair_Status{ get; set; }
        public string Tested_By { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        public string By_Date { get; set; }
        public string Bank { get; set; }
        public string Owner { get; set; }
        public string RMA_NO { get; set; }
        public string Repair_Return{ get; set; }
    }
}