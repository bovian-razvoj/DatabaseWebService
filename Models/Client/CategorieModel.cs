﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseWebService.Models.Client
{
    public class CategorieModel
    {
        public int idKategorija { get; set; }
        public string Koda { get; set; }
        public string Naziv { get; set; }
        public DateTime ts { get; set; }
        public int tsIDOsebe { get; set; }
    }
}