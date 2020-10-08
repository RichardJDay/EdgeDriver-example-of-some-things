using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OpenQA.Selenium;

namespace SimplyAutomationLloydsDC
{
    class GetSupplierList
    {


        public List<string> Suppliers(ReadOnlyCollection<IWebElement> participants)
        {

            var polygonSuppliers = new List<string>
            {
                $"Alpine Construction",
                "Armistead Buildings Services (ABS)",
                "Betacove Ltd",
                "Buildings Validation Solutions Ltd",
                "Camilleri Construction",
                "Capital Services",
                "Crawfords General and Subs - LA",
                "Crawford & Co General Loss",
                "Dale Building Maintenance",
                "EBL GROUP",
                "Alpine Construction",
                "Armistead Buildings Services (ABS)",
                "ABS Cleaning and Restoration Ltd",
                "Betacove Ltd",
                "Buildings Validation Solutions Ltd",
                "Camilleri Construction",
                "Capital Services",
                "Clark Contracts Ltd",
                "Dale Building Maintenance",
                "EBL GROUP",
                "Edinmore Contracts Ltd",
                "Heightvale",
                "Hemmings & Marshalsea",
                "HRNL",
                "Marlowe Industries Ltd",
                "McCane Construction",
                "MIDLANDS RESTORATION LTD",
                "Neways",
                "North East Building Services Ltd",
                "Phoenix Building Services",
                "Reeve Property Restoration Ltd",
                "Regent Develpoment",
                "RFM Building Repair LTD",
                "Roywood Contractors Ltd",
                "T Denman & Sons Ltd",
                "TBRN",
                "The Cotswold Group",
                "Titan Refurbishments Ltd",
                "Topmarx Construction Ltd"
            };

            List<string> membersList = new List<string> { };


            foreach (var company in participants)
            {

                string member = company.Text;

                foreach (string polygonSupplier in polygonSuppliers)
                {
                    if (polygonSupplier.Contains(member))
                    {
                        membersList.Add(member);


                    }

                }

            }

            return membersList;


        }
    }
}