namespace IdokladSdk.Enums
{
    public enum VatOnPayStatusEnum
    {
        /// <summary>
        /// Nen� v re�im
        /// </summary>
        Disabled = 0,

        /// <summary>
        /// Je v re�imu
        /// </summary>
        Enabled = 1,

        /// <summary>
        /// Faktura je v re�imu do data
        /// </summary>
        InvoiceNeedsTaxing = 2
    }
}