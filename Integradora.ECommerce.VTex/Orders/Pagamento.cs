using System.Collections.Generic;
public class Self
{
    public string href { get; set; }
}

public class ConnectorResponses
{
    public string orderKey { get; set; }
    public string ReturnCode { get; set; }
    public object Message { get; set; }
    public string authId { get; set; }
    public string transactionIdentifier { get; set; }
    public string tid { get; set; }
    public string nsu { get; set; }
    public string authorizationCode { get; set; }
    public string acquirer { get; set; }
}

public class ConnectorResponse
{
    public string orderKey { get; set; }
    public string ReturnCode { get; set; }
    public object Message { get; set; }
    public string authId { get; set; }
    public string transactionIdentifier { get; set; }
    public string tid { get; set; }
    public string nsu { get; set; }
    public string authorizationCode { get; set; }
    public string acquirer { get; set; }
}

public class Field
{
    public string name { get; set; }
    public string value { get; set; }
}

public class RootPagamentos
{
    public string id { get; set; }
    public int paymentSystem { get; set; }
    public string paymentSystemName { get; set; }
    public object merchantName { get; set; }
    public string group { get; set; }
    public bool isCustom { get; set; }
    public bool allowInstallments { get; set; }
    public bool requiresAuthentication { get; set; }
    public bool allowIssuer { get; set; }
    public bool allowNotification { get; set; }
    public bool isAvailable { get; set; }
    public object description { get; set; }
    public string authorizationDate { get; set; }
    public Self self { get; set; }
    public string tid { get; set; }
    public string returnCode { get; set; }
    public object returnMessage { get; set; }
    public string status { get; set; }
    public string connector { get; set; }
    public ConnectorResponses ConnectorResponses { get; set; }
    public ConnectorResponse connectorResponse { get; set; }
    public bool ShowConnectorResponses { get; set; }
    public int value { get; set; }
    public int installmentsInterestRate { get; set; }
    public int installmentsValue { get; set; }
    public int referenceValue { get; set; }
    public int installments { get; set; }
    public string currencyCode { get; set; }
    public object provider { get; set; }
    public List<Field> fields { get; set; }
    public object sheets { get; set; }
}