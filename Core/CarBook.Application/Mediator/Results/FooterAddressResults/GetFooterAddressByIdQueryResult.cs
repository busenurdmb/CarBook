﻿
namespace CarBook.Application.Mediator.Results.FooterAddressResult
{
    public class GetFooterAddressByIdQueryResult
    {
        public int FooterAddressID { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}