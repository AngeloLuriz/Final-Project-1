namespace HttpClientLibrary.Tests.TestData
{
    class Booking
    {
        public static BookingDetailsModel bookingDetails()
        {

            return new BookingDetailsModel
            {
                Firstname = "Gelo",
                Lastname = "Luriz",
                Totalprice = 100,
                Depositpaid = true,
                Bookingdates = new Bookingdates()
                {
                    Checkin = DateTime.Parse("2022-11-01"),
                    Checkout = DateTime.Parse("2022-11-02")
                },
                Additionalneeds = "Breakfast"
            };
        }
    }
}