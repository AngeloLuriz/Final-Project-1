﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientLibrary
{
    class BookingDetailsModel
    {
        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("totalprice")]
        public long Totalprice { get; set; }

        [JsonProperty("depositpaid")]
        public bool Depositpaid { get; set; }

        [JsonProperty("bookingdates")]
        public Bookingdates Bookingdates { get; set; }

        [JsonProperty("additionalneeds")]
        public string Additionalneeds { get; set; }
    }

    public partial class Bookingdates
    {
        [JsonProperty("checkin")]
        public DateTime Checkin { get; set; }

        [JsonProperty("checkout")]
        public DateTime Checkout { get; set; }
    }

    class BookingModel
    {
        [JsonProperty("bookingid")]
        public int BookingId { get; set; }

        [JsonProperty("booking")]
        public BookingDetailsModel Booking { get; set; }
    }
}