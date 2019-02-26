using PayPal.AdaptivePayments;
using PayPal.AdaptivePayments.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpDemo
{
    public partial class paypalStart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            string returnUniformResourceLocator = Request.Url.OriginalString;
            string returnAuthority = Request.Url.Authority;
            string returnDnsSafeHost = Request.Url.DnsSafeHost;

            if (Request.UrlReferrer != null && Request.UrlReferrer.Scheme == "https")
            {
                returnUniformResourceLocator = returnUniformResourceLocator.Replace("http://", "https://");
                returnUniformResourceLocator = returnUniformResourceLocator.Replace(returnAuthority, returnDnsSafeHost);
            }

            string cancelUniformResourceLocator = Request.Url.OriginalString;
            string cancelAuthority = Request.Url.Authority;
            string cancelDnsSafeHost = Request.Url.DnsSafeHost;

            if (Request.UrlReferrer != null && Request.UrlReferrer.Scheme == "https")
            {
                cancelUniformResourceLocator = cancelUniformResourceLocator.Replace("http://", "https://");
                cancelUniformResourceLocator = cancelUniformResourceLocator.Replace(cancelAuthority, cancelDnsSafeHost);
            }

            this.returnURL.Text = returnUniformResourceLocator;
            this.cancelURL.Text = cancelUniformResourceLocator;
        }

        protected void ButtonAdaptivePayments_Click(object sender, EventArgs e)
        {
            NameValueCollection parameters = HttpContext.Current.Request.Params;
            ReceiverList receiverList = new ReceiverList();
            receiverList.receiver = new List<Receiver>();

            PayRequest request = new PayRequest();
            RequestEnvelope requestEnvelope = new RequestEnvelope("en_US");
            request.requestEnvelope = requestEnvelope;

            Receiver receiver1 = new Receiver();

            if (parameters["amount1"] != null && parameters["amount1"].Trim() != string.Empty)
            {
                // Required) Amount to be paid to the receiver
                receiver1.amount = Convert.ToDecimal(parameters["amount1"]);
            }

            if (parameters["mail1"] != null && parameters["mail1"].Trim() != string.Empty)
            {
                // Receiver's email address. This address can be unregistered with
                // paypal.com. If so, a receiver cannot claim the payment until a PayPal
                // account is linked to the email address. The PayRequest must pass
                // either an email address or a phone number. Maximum length: 127 characters
                receiver1.email = parameters["mail1"];
            }

            if (parameters["primaryReceiver1"] != null && parameters["primaryReceiver1"].Trim() != string.Empty)
            {
                receiver1.primary = Convert.ToBoolean(parameters["primaryReceiver1"]);
            }

            receiverList.receiver.Add(receiver1);

            Receiver receiver2 = new Receiver();

            if (parameters["amount2"] != null && parameters["amount2"].Trim() != string.Empty)
            {
                // (Required) Amount to be paid to the receiver
                receiver2.amount = Convert.ToDecimal(parameters["amount2"]);
            }

            if (parameters["mail2"] != null && parameters["mail2"].Trim() != string.Empty)
            {
                // Receiver's email address. This address can be unregistered with
                // paypal.com. If so, a receiver cannot claim the payment until a PayPal
                // account is linked to the email address. The PayRequest must pass
                // either an email address or a phone number. Maximum length: 127 characters
                receiver2.email = parameters["mail2"];
            }

            if (parameters["primaryReceiver2"] != null && parameters["primaryReceiver2"].Trim() != string.Empty)
            {
                receiver2.primary = Convert.ToBoolean(parameters["primaryReceiver2"]);
            }

            receiverList.receiver.Add(receiver2);

            ReceiverList receiverlst = new ReceiverList(receiverList.receiver);
            request.receiverList = receiverlst;

            // (Optional) Sender's email address. Maximum length: 127 characters
            if (parameters["senderEmail"] != null && parameters["senderEmail"].Trim() != string.Empty)
            {
                request.senderEmail = parameters["senderEmail"];
            }

            // The action for this request. Possible values are: PAY – Use this
            // option if you are not using the Pay request in combination with
            // ExecutePayment. CREATE – Use this option to set up the payment
            // instructions with SetPaymentOptions and then execute the payment at a
            // later time with the ExecutePayment. PAY_PRIMARY – For chained
            // payments only, specify this value to delay payments to the secondary
            // receivers; only the payment to the primary receiver is processed.
            if (parameters["actionType"] != null && parameters["actionType"].Trim() != string.Empty)
            {
                request.actionType = parameters["actionType"];
            }

            // URL to redirect the sender's browser to after canceling the approval
            // for a payment; it is always required but only used for payments that
            // require approval (explicit payments)
            if (parameters["cancelURL"] != null && parameters["cancelURL"].Trim() != string.Empty)
            {
                request.cancelUrl = parameters["cancelURL"];
            }

            // The code for the currency in which the payment is made; you can
            // specify only one currency, regardless of the number of receivers
            if (parameters["currencyCode"] != null && parameters["currencyCode"].Trim() != string.Empty)
            {
                request.currencyCode = parameters["currencyCode"];
            }

            // URL to redirect the sender's browser to after the sender has logged
            // into PayPal and approved a payment; it is always required but only
            // used if a payment requires explicit approval
            if (parameters["returnURL"] != null && parameters["returnURL"].Trim() != string.Empty)
            {
                request.returnUrl = parameters["returnURL"];
            }

            request.requestEnvelope = requestEnvelope;

            // (Optional) The URL to which you want all IPN messages for this
            // payment to be sent. Maximum length: 1024 characters
            if (parameters["ipnNotificationURL"] != null && parameters["ipnNotificationURL"].Trim() != string.Empty)
            {
                request.ipnNotificationUrl = parameters["ipnNotificationURL"];
            }

            AdaptivePaymentsService service = null;
            PayResponse response = null;
            try
            {
                // Configuration map containing signature credentials and other required configuration.
                // For a full list of configuration parameters refer in wiki page
                // (https://github.com/paypal/sdk-core-dotnet/wiki/SDK-Configuration-Parameters)
                Dictionary<string, string> config = new Dictionary<string, string>();
                config.Add("mode", "sandbox");
               
                config.Add("account1.apiUsername", "luan-facilitator_api1.hotmail.com");
                config.Add("account1.apiPassword", "WNC7H73KK7QLY6CN");
                config.Add("account1.apiSignature", "A9.v3Z12UkkZ8kOnhrv2qAmjnv2SABXeOdFqKG2Asz3RXgs6g0hpBAW1");
                config.Add("account1.applicationId", "APP-80W284485P519543T");
                config.Add("account2.apiUsername", "v-acxu-facilitator_api1.hotmail.com");
                config.Add("account2.apiPassword", "MU43Z6DP5BN5LXGK");
                config.Add("account2.apiSignature", "Azrd88-yJIzAw3F80eLg1SH7tacLACa3ekrXy1Mn5nEyKYVDA5BhkEx0");

                //< account apiUsername = "luan-facilitator_api1.hotmail.com" apiPassword = "WNC7H73KK7QLY6CN" apiSignature = "A9.v3Z12UkkZ8kOnhrv2qAmjnv2SABXeOdFqKG2Asz3RXgs6g0hpBAW1" />

                // Creating service wrapper object to make an API call and loading
                // configuration map for your credentials and endpoint
                service = new AdaptivePaymentsService(config);
     
                response = service.Pay(request);
            }
            catch (System.Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message);
                return;
            }

            Dictionary<string, string> responseValues = new Dictionary<string, string>();
            string redirectUrl = null;

            if (!response.responseEnvelope.ack.ToString().Trim().ToUpper().Equals(AckCode.FAILURE.ToString()) && !response.responseEnvelope.ack.ToString().Trim().ToUpper().Equals(AckCode.FAILUREWITHWARNING.ToString()))
            {
                redirectUrl = "http://localhost:53239/About.aspx" + "_ap-payment&paykey=" + response.payKey;

                // The pay key, which is a token you use in other Adaptive Payment APIs 
                // (such as the Refund Method) to identify this payment. 
                // The pay key is valid for 3 hours; the payment must be approved while the 
                // pay key is valid. 
                responseValues.Add("Pay Key", response.payKey);

                // The status of the payment. Possible values are:
                // CREATED – The payment request was received; funds will be transferred once the payment is approved
                // COMPLETED – The payment was successful
                // INCOMPLETE – Some transfers succeeded and some failed for a parallel payment or, for a delayed chained payment, secondary receivers have not been paid
                // ERROR – The payment failed and all attempted transfers failed or all completed transfers were successfully reversed
                // REVERSALERROR – One or more transfers failed when attempting to reverse a payment
                // PROCESSING – The payment is in progress
                // PENDING – The payment is awaiting processing
                responseValues.Add("Payment Execution Status", response.paymentExecStatus);

                if (response.defaultFundingPlan != null && response.defaultFundingPlan.senderFees != null)
                {
                    // Fees to be paid by the sender
                    responseValues.Add("Sender Fees", response.defaultFundingPlan.senderFees.amount + response.defaultFundingPlan.senderFees.code);
                }
            }

            responseValues.Add("Acknowledgement", response.responseEnvelope.ack.ToString().Trim().ToUpper());

            Display(HttpContext.Current, "ChainedPayment", "AdaptivePayments", responseValues, service.getLastRequest(), service.getLastResponse(), response.error, redirectUrl);
        }

        private void Display(HttpContext contextHttp, string method, string api, Dictionary<string, string> responseValues, string requestPayload, string responsePayload, List<ErrorData> errorMessages, string redirectUrl)
        {
         

            GridViewResponseValues.DataSource = responseValues;
            GridViewResponseValues.DataBind();
            if (errorMessages != null && errorMessages.Count > 0)
            {
                RepeaterError.DataSource = errorMessages;
                RepeaterError.DataBind();
                GridViewResponseValues.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
            }
            else
            {
                if (responseValues["Acknowledgement"].Equals(AckCode.SUCCESS.ToString()))
                {
                    GridViewResponseValues.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(0, 200, 100);
                }
                else
                {
                    GridViewResponseValues.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 0);
                }
                if (redirectUrl != null)
                {
                    LabelWebFlow.Text = "This API has Web Flow to redirect the user to complete the API call, please click the hyperlink to redirect the user to ";
                    HyperLinkWebFlow.Text = redirectUrl;
                    HyperLinkWebFlow.NavigateUrl = redirectUrl;
                    LabelWebFlowSuffix.Text = ".<br/><br/>";
                }
            }

            requestPayload = HttpUtility.UrlDecode(requestPayload);
            responsePayload = HttpUtility.UrlDecode(responsePayload);

            TextBoxRequest.Text = requestPayload;
            TextBoxResponse.Text = responsePayload;
        }
    }
}