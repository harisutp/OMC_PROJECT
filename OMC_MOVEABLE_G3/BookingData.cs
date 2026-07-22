using System;

namespace OMC_PROJECT
{
    // Holds the details of the most recent booking so that
    // formPay can save them, formreceipt can display them, and
    // formDriverTracking can simulate the trip.
    public static class BookingData
    {
        public static string Pickup { get; set; }
        public static string Destination { get; set; }
        public static string DriverName { get; set; }
        public static string Car { get; set; }
        public static string PlateNumber { get; set; }
        public static decimal Fee { get; set; }
        public static decimal RemainingBalance { get; set; }
        public static string BookingId { get; set; }
        public static DateTime BookingTime { get; set; }
        public static int OrderID { get; set; }
        public static int DriverID { get; set; }

        // Map coordinates chosen in formLetsRide (real lat/lng from the
        // selection maps). Used by formDriverTracking for marker positions.
        public static double PickupLat { get; set; }
        public static double PickupLng { get; set; }
        public static double DropLat { get; set; }
        public static double DropLng { get; set; }

        // Trip state used across formPay, formreceipt and formDriverTracking.
        public static bool PaymentCompleted { get; set; }
        public static bool RideCancelled { get; set; }
        public static bool RefundCompleted { get; set; }
        public static bool PassengerPickedUp { get; set; }
        public static bool TripCompleted { get; set; }

        public static bool HasBooking
        {
            get { return !string.IsNullOrEmpty(BookingId); }
        }

        // Called when a new trip starts (formLetsRide -> NEXT) so state
        // from a previous trip can never leak into the new one.
        public static void ResetTripState()
        {
            PaymentCompleted = false;
            RideCancelled = false;
            RefundCompleted = false;
            PassengerPickedUp = false;
            TripCompleted = false;
        }
    }
}
