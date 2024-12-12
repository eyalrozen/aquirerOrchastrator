
using System.ComponentModel;

using System.Text.Json.Serialization;

namespace Orchestrator.Shared.HttpModels
{
    public class TransactionRequest
    {
        public string? AcquirerId { get; set; }
        public TransactionRequestActionType RequestActionType { get; set; }
        public TransactionRequestService RequestService { get; set; }
        public TransactionRequestIdentification? Identification { get; set; }
        public TransactionRequestFinancialData? Financial { get; set; }
        public TransactionRequestCaptureSplit? CaptureSplit { get; set; }
        public TransactionRequestCircumstance? Circumstance { get; set; }
        public TransactionRequestAcceptor? Acceptor { get; set; }
        public TransactionRequestCard? Card { get; set; }
        [JsonPropertyName("3DSecure")]
        public TransactionRequest3DSecure? Secure3D { get; set; }
        public TransactionRequestReversal? Reversal { get; set; }
        public object? Summary { get; set; }
        
    }
    public enum TransactionRequestActionType
    {
        Auth,
        AuthAndCapture,
        AuthIncremental,
        AuthReversal,
        AuthReversalPartial,
        Capture,
        CaptureSplit,
        PreAuth
    }
    public enum TransactionRequestService
    {
        Purchase,
        Refund,
        AccountVerification
    }

    public enum TransactionRequestCircumstanceChannel
    {
        Ecommerce,
        MailOrder,
        PhoneOrder,
        Poi
    }
    public enum TransactionRequestCircumstanceScaExemptionCause
    {
        LowValue,
        LowFraud,
        Delegation,
        TrustedAcceptor,
        SecureCorporate,
        Recurring,
        Mit,
        AuthenticationOutage
    }
    public enum TransactionRequestCircumstanceCardholderVerificationMethod
    {
        None,
        Cvv2,
        [Description ("3D Secure")]
        Secure3D,
        OfflinePin,
        OnlinePin,
        Signature
    }
    public enum TransactionRequestCircumstanceInitiatorType
    {
        Cardholder,
        Acceptor
    }
    public enum TransactionRequestCircumstanceMitCause
    {
        Unscheduled,
        Recurring,
        FixedRecurring,
        Installment,
        Resubmission,
        DelayedCharge,
        Reauthorization,
        NoShow,
        Deferred,
        Increment
    }
    public enum TransactionRequestReversalCause
    {
        ResponseInvalid,
        ResponseTimeout,
        SubsequentlyDeclined,
        ProcessingFailure,
        CustomerCancellation
    }
    public enum TransactionRequest3DSecureResult
    {
        Full,
        Attempt,
        MerchantRisk,
        IssuerRisk,
        DataOnly
    }
    public enum TransactionRequest3DSecureVersion
    {
        V1,
        V2
    }
    
    public class TransactionRequestIdentification
    {
        public string? RequestorId { get; set; }
        public string? ActionId { get; set; }
        public string? OriginalActionId { get; set; }
        public string? TransactionId { get; set; }
        public string? OriginalTransactionId { get; set; }
        public string? AcquirerId { get; set; }
        public string? CardAcceptorId { get; set; }
        public string? PspId { get; set; }
        public string? PspReference { get; set; }
        public string? MerchantReference { get; set; }
    }
    public class TransactionRequestFinancialData
    {
        public TransactionRequestAmount? RequestRequestAmount { get; set; }
    }
    public class TransactionRequestAmount
    {
        public string? Amount { get; set; }
        public string? Currency { get; set; }
    }
    public class TransactionRequestCaptureSplit
    {
        public int? CaptureSequenceNumber { get; set; }
        public int? CaptureSequenceCount { get; set; }
    }
    public class TransactionRequestCircumstance
    {
        public string? ActionDateTime { get; set; }
        public TransactionRequestCircumstanceChannel Channel { get; set; }
        public TransactionRequestCircumstanceScaExemptionCause ScaExemptionCause { get; set; }
        public TransactionRequestCircumstanceCardholderVerificationMethod cardholderVerificationMethod { get; set; }
        public TransactionRequestCircumstanceInitiatorType InitiatorType { get; set; }
        public bool? CredentialStorage { get; set; }
        public string? SchemeTransactionId { get; set; }
        public TransactionRequestCircumstanceMitCause MitCause { get; set; }
        public bool? Retry { get; set; }
    }

    public class TransactionRequestAcceptor
    {
        public string? MerchantCategoryCode { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? CountryCode { get; set; }
        public string? PaymentFacilitatorId { get; set; }
        public string? IndependentSalesOrgId { get; set; }
        public string? SubMerchantId { get; set; }
        public string? SchemeMerchantId { get; set; }
    }
    public class TransactionRequestCard
    {
        public string? CardNumber { get; set; }
        public string? ExpiryDate { get; set; }
        public string? Cvv2 { get; set; }
        public string? Tavv { get; set; }
        public string? EntryMode { get; set; }
    }
    public class TransactionRequest3DSecure
    {
        public TransactionRequest3DSecureResult Result { get; set; }
        public string? Ucaf { get; set; }
        public string? CvvData { get; set; }
        public string? Xid { get; set; }
        public string? TransactionId { get; set; }
        public TransactionRequest3DSecureVersion Version { get; set; }
    }

    public class TransactionRequestReversal
    {
        public TransactionRequestReversalCause ReversalCause { get; set; }
    }
}
