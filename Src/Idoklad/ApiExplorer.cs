using IdokladSdk.Clients;

namespace IdokladSdk
{
    public class ApiExplorer
    {
        private readonly ApiContext _apiContext;
        private AgendaClient _agendaClient;
        private ContactClient _contactClient;
        private CreditNoteClient _creditNoteClient;
        private DocumentAddressClient _documentAddressClient;
        private IssuedInvoiceClient _issuedInvoiceClient;
        private PriceListClient _priceListClient;
        private ReceivedInvoiceClient _receivedInvoiceClient;
        private BankClient _bankClient;
        private BankStatementsClient _bankStatementsClient;
        private ConstantSymbolClient _constantSymbolClient;
        private CountryClient _countryClient;
        private CurrencyClient _currencyClient;
        private ExchangeRateClient _exchangeRateClient;
        private PaymentOptionClient _paymentOptionClient;
        private SystemClient _systemClient;
        private VatRateClient _vatRateClient;

        private BatchClient _batchClient;
        private CashRegisterClient _cashRegisterClient;
        private CashVoucherClient _cashVoucherClient;
        private IssuedDocumentPaymentClient _issuedDocumentPaymentClient;
        private NumericSequenceClient _numericSequenceClient;
        private ProformaInvoiceClient _proformaInvoiceClient;
        private ReceivedDocumentPaymentClient _receivedDocumentPaymentClient;
        private RegisteredSaleClient _registeredSaleClient;
        private SalesOfficeClient _salesOfficeClient;
        private SalesPosEquipmentClient _salesPosEquipmentClient;
        private SalesReceiptClient _salesReceiptClient;

        public ApiExplorer(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        public AgendaClient Agendas => _agendaClient ?? (_agendaClient = new AgendaClient(_apiContext));

        public BatchClient Batches => _batchClient ?? (_batchClient = new BatchClient(_apiContext));

        public ContactClient Contacts => _contactClient ?? (_contactClient = new ContactClient(_apiContext));

        public CreditNoteClient CreditNotes => _creditNoteClient ?? (_creditNoteClient = new CreditNoteClient(_apiContext));

        public DocumentAddressClient DocumentAddresses => _documentAddressClient ?? (_documentAddressClient = new DocumentAddressClient(_apiContext));

        public IssuedInvoiceClient IssuedInvoices => _issuedInvoiceClient ?? (_issuedInvoiceClient = new IssuedInvoiceClient(_apiContext));

        public PriceListClient PriceList => _priceListClient ?? (_priceListClient = new PriceListClient(_apiContext));

        public ReceivedInvoiceClient ReceivedInvoices => _receivedInvoiceClient ?? (_receivedInvoiceClient = new ReceivedInvoiceClient(_apiContext));

        public BankClient Banks => _bankClient ?? (_bankClient = new BankClient(_apiContext));

        public BankStatementsClient BankStatements => _bankStatementsClient ?? (_bankStatementsClient = new BankStatementsClient(_apiContext));

        public ConstantSymbolClient ConstantSymbols => _constantSymbolClient ?? (_constantSymbolClient = new ConstantSymbolClient(_apiContext));

        public CountryClient Countries => _countryClient ?? (_countryClient = new CountryClient(_apiContext));

        public CurrencyClient Currencies => _currencyClient ?? (_currencyClient = new CurrencyClient(_apiContext));

        public ExchangeRateClient ExchangeRates => _exchangeRateClient ?? (_exchangeRateClient = new ExchangeRateClient(_apiContext));

        public PaymentOptionClient PaymentOptions => _paymentOptionClient ?? (_paymentOptionClient = new PaymentOptionClient(_apiContext));

        public SystemClient System => _systemClient ?? (_systemClient = new SystemClient(_apiContext));

        public VatRateClient VatRates => _vatRateClient ?? (_vatRateClient = new VatRateClient(_apiContext));

        public CashRegisterClient CashRegister => _cashRegisterClient ?? (_cashRegisterClient = new CashRegisterClient(_apiContext));

        public CashVoucherClient CashVoucher => _cashVoucherClient ?? (_cashVoucherClient = new CashVoucherClient(_apiContext));

        public IssuedDocumentPaymentClient IssuedDocumentPayment => _issuedDocumentPaymentClient ?? (_issuedDocumentPaymentClient = new IssuedDocumentPaymentClient(_apiContext));

        public NumericSequenceClient NumericSequence => _numericSequenceClient ?? (_numericSequenceClient = new NumericSequenceClient(_apiContext));

        public ProformaInvoiceClient ProformaInvoice => _proformaInvoiceClient ?? (_proformaInvoiceClient = new ProformaInvoiceClient(_apiContext));

        public ReceivedDocumentPaymentClient ReceivedDocumentPayment => _receivedDocumentPaymentClient ?? (_receivedDocumentPaymentClient = new ReceivedDocumentPaymentClient(_apiContext));

        public RegisteredSaleClient RegisteredSale => _registeredSaleClient ?? (_registeredSaleClient = new RegisteredSaleClient(_apiContext));

        public SalesOfficeClient SalesOffice => _salesOfficeClient ?? (_salesOfficeClient = new SalesOfficeClient(_apiContext));

        public SalesPosEquipmentClient SalesPosEquipment => _salesPosEquipmentClient ?? (_salesPosEquipmentClient = new SalesPosEquipmentClient(_apiContext));

        public SalesReceiptClient SalesReceipt => _salesReceiptClient ?? (_salesReceiptClient = new SalesReceiptClient(_apiContext));
    }
}