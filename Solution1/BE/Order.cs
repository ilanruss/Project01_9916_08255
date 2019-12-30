﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Order
    {
        long HostingUnitKey;
        long GuestRequestKey;
        long OrderKey;
        DateTime CreateDate;//date order was made
        DateTime OrderDate;//date the email was sent to client 
        BEEnum.Status status;
        public long HostingUnitKey1 { get => HostingUnitKey; set => HostingUnitKey = value; }
        public long GuestRequestKey1 { get => GuestRequestKey; set => GuestRequestKey = value; }
        public long OrderKey1 { get => OrderKey; set => OrderKey = value; }
        public DateTime CreateDate1 { get => CreateDate; set => CreateDate = value; }
        public DateTime OrderDate1 { get => OrderDate; set => OrderDate = value; }
        public BEEnum.Status Status { get => status; set => status = value; }

        public override string ToString()
        {
            string to = "Hosting unit key: " + HostingUnitKey;
            to += "\n guest request key: " + GuestRequestKey;
            to += "\n order key: " + OrderKey;
            to += "\n Date the order was made: " + CreateDate.ToString();
            to += "\n Date email was sent to client: " + OrderDate.ToString();
            to += "\n status of the order: " + status.ToString();
            return to;
        }
    }
}
