namespace IdokladSdk.Enums
{
    public enum DocumentTypeEnum
    {
        /// <summary>
        /// Faktura vydan�
        /// </summary>
        IssuedInvoice = 0,

        /// <summary>
        /// Z�lohov� faktura
        /// </summary>
        ProformaInvoice = 1,

        /// <summary>
        /// Faktura vydan� jako pokladn� doklad. Uchov�v� se pouze v ��seln� �ad�. 
        /// Nepou��v� se pro entity faktur!
        /// </summary>
        CashVoucher = 2,

        /// <summary>
        /// Dobropis pro fakturu
        /// </summary>
        CreditNote = 3,

        /// <summary>
        /// Bankovn� v�pis
        /// </summary>
        BankStatement = 4,

        /// <summary>
        /// Received Invoice only in numeric sequence.
        /// </summary>
        ReceivedInvoice = 5,

        /// <summary>
        /// Prodejka
        /// </summary>
        SalesReceipt = 6,

        /// <summary>
        /// ��tenka v EET
        /// </summary>
        RegisteredSale = 101
    }
}