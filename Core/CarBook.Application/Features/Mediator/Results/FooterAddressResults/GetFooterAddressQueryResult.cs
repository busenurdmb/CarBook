namespace CarBook.Application.Features.Mediator.Results.FooterAddressResults
{
    public class GetFooterAddressQueryResult
    {
        public int FooterAddressID { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
