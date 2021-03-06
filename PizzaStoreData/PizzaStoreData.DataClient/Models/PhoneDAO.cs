﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreData.DataClient.Models
{
    [DataContract]
    public class PhoneDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public bool Active { get; set; }
    }
}