namespace OMC_PROJECT
{
    // Shared application data used by every form.
    // There must be only ONE balance in the whole system: AppData.Balance.
    public static class AppData
    {
        public static decimal Balance { get; set; } = 0.00m;
    }
}
