using PayPal.AdaptivePayments;
using PayPal.AdaptivePayments.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpDemo
{
    public partial class paypalStart2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                TextBox1.Text = Request["payKey"];
            }
}

        protected void Button1_Click(object sender, EventArgs e)
        {

            ReceiverList receiverList = new ReceiverList();
            receiverList.receiver = new List<Receiver>();
            PaymentDetailsRequest request = new PaymentDetailsRequest(new RequestEnvelope("en_US"));
            RequestEnvelope requestEnvelope = new RequestEnvelope("en_US");
            request.requestEnvelope = requestEnvelope;
            request.payKey = TextBox1.Text;
            AdaptivePaymentsService service = null;
            PaymentDetailsResponse response = null;
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


            service = new AdaptivePaymentsService(config);
            response = service.PaymentDetails(request);
            PaymentInfo info = response.paymentInfoList.paymentInfo[0]; //--loop through the paymentInfo to get all the transactionId

            Response.Write("<br/>");
   
            foreach (var item in response.paymentInfoList.paymentInfo)
            {
               
                Response.Write("receiver:" + item.receiver.accountId + "&nbsp;&nbsp;&nbsp;" + "transactionId:" + item.transactionId
                    + "&nbsp;&nbsp;&nbsp;"+"senderTransactionid:"+item.senderTransactionId);
                Response.Write("<br/>");
               
            }


        }
    }
}