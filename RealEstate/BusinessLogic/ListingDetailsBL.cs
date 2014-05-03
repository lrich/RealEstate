using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstateRentals.ViewModels;
using System.Web.Mvc;
using RealEstate.Models;

namespace RealEstateRentals.BusinessLogic
{
    public class ListingDetailsBL
    {
        public ListingInformationVM GetListingInformation(int ListingID)
        {
            return new ListingInformationVM(); 
        }

        public bool UpdateListing(FormCollection myCollection)
        {
            return true;
        }

        public bool AddListing(FormCollection myCollection)
        {
           
            RealEstateEntities db = new RealEstateEntities();

            Listing oL = new Listing();
            
            return true;
        }

        public bool DeleteListing(int ListingID)
        {
            return true;
        }
    }
}