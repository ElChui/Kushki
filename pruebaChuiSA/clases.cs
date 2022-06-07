using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pruebaChuiSA
{
    #region obtenerToken

    public class TokenRequest
    {
        private card _card;
        private double _totalAmount;
        private string _currency;

        public card card
        {
            get { return _card; }
            set { _card = value; }
        }
        public double totalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
        public string currency
        {
            get { return _currency; }
            set { _currency = value; }
        }        
    }

    public class card
    {
        private string _name;
        private string _number;
        private string _expiryMonth;
        private string _expiryYear;
        private string _cvv;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string number
        {
            get { return _number; }
            set { _number = value; }
        }
        public string expiryMonth
        {
            get { return _expiryMonth; }
            set { _expiryMonth = value; }
        }
        public string expiryYear
        {
            get { return _expiryYear; }
            set { _expiryYear = value; }
        }
        public string cvv
        {
            get { return _cvv; }
            set { _cvv = value; }
        }
    }

    public class TokenResponse
    {
        private string _token;

        public string token
        {
            get { return _token; }
            set { _token = value; }
        }       
    }

    #endregion

    #region makeACharge

    public class MakeACargeRequest
    {        
        private string _token;
        private amount _amount;
        private metadata _metadata;
        private contactDetails _contactDetails;
        private orderDetails _orderDetails;
        private productDetails _productDetails;
        private bool _fullResponse;

        public string token
        {
            get { return _token; }
            set { _token = value; }
        }
        public amount amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public metadata metadata
        {
            get { return _metadata; }
            set { _metadata = value; }
        }
        public contactDetails contactDetails
        {
            get { return _contactDetails; }
            set { _contactDetails = value; }
        }
        public orderDetails orderDetails
        {
            get { return _orderDetails; }
            set { _orderDetails = value; }
        }
        public productDetails productDetails
        {
            get { return _productDetails; }
            set { _productDetails = value; }
        }
        public bool fullResponse
        {
            get { return _fullResponse; }
            set { _fullResponse = value; }
        }
    }

    public class amount
    {
        private double _subtotalIva;
        private double _subtotalIva0;
        private double _ice;
        private double _iva;
        private string _currency;

        public double subtotalIva
        {
            get { return _subtotalIva; }
            set { _subtotalIva = value; }
        }
        public double subtotalIva0
        {
            get { return _subtotalIva0; }
            set { _subtotalIva0 = value; }
        }
        public double ice
        {
            get { return _ice; }
            set { _ice = value; }
        }
        public double iva
        {
            get { return _iva; }
            set { _iva = value; }
        }
        public string currency
        {
            get { return _currency; }
            set { _currency = value; }
        }
    }

    public class metadata
    {
        private string _Referencia;

        public string Referencia
        {
            get { return _Referencia; }
            set { _Referencia = value; }
        }
    }

    public class contactDetails
    {
        private string _documentType;
        private string _documentNumber;
        private string _email;
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;

        public string documentType
        {
            get { return _documentType; }
            set { _documentType = value; }
        }
        public string documentNumber
        {
            get { return _documentNumber; }
            set { _documentNumber = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string phoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
    }

    public class orderDetails
    {
        private string _siteDomain;
        private shippingDetails _shippingDetails;
        private billingDetails _billingDetails;      

        public string siteDomain
        {
            get { return _siteDomain; }
            set { _siteDomain = value; }
        }
        public shippingDetails shippingDetails
        {
            get { return _shippingDetails; }
            set { _shippingDetails = value; }
        }
        public billingDetails billingDetails
        {
            get { return _billingDetails; }
            set { _billingDetails = value; }
        }
    }

    public class shippingDetails
    {
        private string _name;
        private string _phone;
        private string _address1;
        private string _address2;
        private string _city;
        private string _region;
        private string _country;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }
        public string address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }
        public string city
        {
            get { return _city; }
            set { _city = value; }
        }
        public string region
        {
            get { return _region; }
            set { _region = value; }
        }
        public string country
        {
            get { return _country; }
            set { _country = value; }
        }
    }

    public class billingDetails
    {
        private string _name;
        private string _phone;
        private string _address1;
        private string _address2;
        private string _city;
        private string _region;
        private string _country;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }
        public string address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }
        public string city
        {
            get { return _city; }
            set { _city = value; }
        }
        public string region
        {
            get { return _region; }
            set { _region = value; }
        }
        public string country
        {
            get { return _country; }
            set { _country = value; }
        }
    }

    public class productDetails
    {
        private product[] _product;

        public product[] product
        {
            get { return _product; }
            set { _product = value; }
        }
    }

    public class product
    {
        private string _id;
        private string _title;
        private double _price;
        private string _sku;
        private double _quantity;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        public double price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string sku
        {
            get { return _sku; }
            set { _sku = value; }
        }
        public double quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
    }

    public class MakeACargeResponse
    {
        private string _ticketNumber;
        private string _transactionReference;
        private details _details;
       
        public string ticketNumber
        {
            get { return _ticketNumber; }
            set { _ticketNumber = value; }
        }
        public string transactionReference
        {
            get { return _transactionReference; }
            set { _transactionReference = value; }
        }
        public details details
        {
            get { return _details; }
            set { _details = value; }
        }        
    }

    public class binInfo
    {
        private string _bank;
        private string _type;

        public string bank
        {
            get { return _bank; }
            set { _bank = value; }
        }
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }        
    }

    public class details
    {
        private string _token;
        private bool _fullResponse;
        private string _recap;
        private string _acquirerBank;
        private string _ip;
        private string _maskedCardNumber;
        private double _approvedTransactionAmount;
        private double _subtotalIva;
        private double _subtotalIva0;
        private double _created;
        private string _responseCode;
        private string _transactionType;
        private string _approvalCode;
        private string _transactionStatus;
        private string _syncMode;
        private string _currencyCode;
        private string _merchantId;

        private string _processorId;
        private string _transactionId;
        private string _responseText;
        private string _cardHolderName;
        private string _lastFourDigits;
        private string _binCard;
        private string _paymentBrand;
        private double _iceValue;
        private double _requestAmount;
        private double _ivaValue;
        private string _merchantName;
        private string _processorName;
        private string _processorBankName;
        private string _transactionReference;
        private binInfo _binInfo;
        private string _cardCountry;
        private string[] _rules;

        public string token
        {
            get { return _token; }
            set { _token = value; }
        }
        public bool fullResponse
        {
            get { return _fullResponse; }
            set { _fullResponse = value; }
        }
        public string recap
        {
            get { return _recap; }
            set { _recap = value; }
        }
        public string acquirerBank
        {
            get { return _acquirerBank; }
            set { _acquirerBank = value; }
        }
        public string ip
        {
            get { return _ip; }
            set { _ip = value; }
        }
        public string maskedCardNumber
        {
            get { return _maskedCardNumber; }
            set { _maskedCardNumber = value; }
        }
        public double approvedTransactionAmount
        {
            get { return _approvedTransactionAmount; }
            set { _approvedTransactionAmount = value; }
        }
        public double subtotalIva
        {
            get { return _subtotalIva; }
            set { _subtotalIva = value; }
        }
        public double subtotalIva0
        {
            get { return _subtotalIva0; }
            set { _subtotalIva0 = value; }
        }
        public double created
        {
            get { return _created; }
            set { _created = value; }
        }
        public string responseCode
        {
            get { return _responseCode; }
            set { _responseCode = value; }
        }
        public string transactionType
        {
            get { return _transactionType; }
            set { _transactionType = value; }
        }
        public string approvalCode
        {
            get { return _approvalCode; }
            set { _approvalCode = value; }
        }
        public string transactionStatus
        {
            get { return _transactionStatus; }
            set { _transactionStatus = value; }
        }
        public string syncMode
        {
            get { return _syncMode; }
            set { _syncMode = value; }
        }
        public string currencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }
        public string merchantId
        {
            get { return _merchantId; }
            set { _merchantId = value; }
        }
        public string processorId
        {
            get { return _processorId; }
            set { _processorId = value; }
        }
        public string transactionId
        {
            get { return _transactionId; }
            set { _transactionId = value; }
        }
        public string responseText
        {
            get { return _responseText; }
            set { _responseText = value; }
        }
        public string cardHolderName
        {
            get { return _cardHolderName; }
            set { _cardHolderName = value; }
        }
        public string lastFourDigits
        {
            get { return _lastFourDigits; }
            set { _lastFourDigits = value; }
        }
        public string binCard
        {
            get { return _binCard; }
            set { _binCard = value; }
        }
        public string paymentBrand
        {
            get { return _paymentBrand; }
            set { _paymentBrand = value; }
        }
        public double iceValue
        {
            get { return _iceValue; }
            set { _iceValue = value; }
        }
        public double requestAmount
        {
            get { return _requestAmount; }
            set { _requestAmount = value; }
        }
        public double ivaValue
        {
            get { return _ivaValue; }
            set { _ivaValue = value; }
        }
        public string merchantName
        {
            get { return _merchantName; }
            set { _merchantName = value; }
        }
        public string processorName
        {
            get { return _processorName; }
            set { _processorName = value; }
        }
        public string processorBankName
        {
            get { return _processorBankName; }
            set { _processorBankName = value; }
        }
        public string transactionReference
        {
            get { return _transactionReference; }
            set { _transactionReference = value; }
        }
        public binInfo binInfo
        {
            get { return _binInfo; }
            set { _binInfo = value; }
        }
        public string cardCountry
        {
            get { return _cardCountry; }
            set { _cardCountry = value; }
        }
        public string[] rules
        {
            get { return _rules; }
            set { _rules = value; }
        }               
    }

    #endregion

    #region voidTransaction

    public class VoidTransactionRequest
    {
        private bool _fullResponse;

        public bool fullResponse
        {
            get { return _fullResponse; }
            set { _fullResponse = value; }
        }
    }

    public class VoidTransactionResponse
    {
        private string _ticketNumber;

        public string ticketNumber
        {
            get { return _ticketNumber; }
            set { _ticketNumber = value; }
        }
    }

    #endregion

}