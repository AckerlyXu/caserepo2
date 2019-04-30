<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paypalStart.aspx.cs" Inherits="WebFormCases2.csharpDemo.paypalStart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
	
}

table th {
	font-weight: normal;	
}

#permissionsdata {
	margin-top: 20px;
}

#permissionsdata td {
	padding: 10px 20px;
}

#permissionsdata td.left {
	border-right: solid 1px gray;
}

.overview {
	padding: 10px 20px;
	font-style: italic;
	width: 75%;
}

input.smallfield, select.smallfield {
	width: 105px;
	font-size: 12px;
}

input.xsmallfield, select.xsmallfield {
	width: 75px;
	font-size: 12px;
}

.open {
	display: block;
}

.closed {
	display: none;
}

#apidetails {
	padding: 10px 20px 30px 20px;
	font-style: italic;
	width: 75%;
}

.note {
	margin: 10px 10px;
	font-style: italic;
}

.section_header {
	margin: 20px 0px;
	font-weight: bold;
}

.submit {
	margin-top: 20px;
	margin-bottom: 20px;
}

ul.wizard {
	font-size: 16px;
	color: gray;
	list-style-type: none;
}

ul.wizard li {
	width: 20%;
}

ul.wizard li.current {
	color: black;
	font-weight: bold;
}

ul.wizard li.complete {
	color: black;
	background-image: url(images/tick.png);
	background-repeat: no-repeat;
	background-position: center right;
	padding-right: 50px;
}
    </style>
    <script src="../Scripts/jquery-3.3.1.js"></script>
    <script src="sdk_functions.js"></script>
</head>
<body>

    <div id="wrapper">
        <div id="header">
            <h3>Chained Payment</h3>
            <div id="apidetails">
                <p>
                    <i>A Chained Payment is a Payment from a sender that is indirectly split among multiple
                        receivers. It is an extension of a typical Payment from a sender to a receiver,
                        in which a receiver, known as the Primary Receiver, passes part of the Payment to
                        other Receivers, who are called Secondary Receivers. Create your PayRequest message
                        by setting the common fields. If you want more than a Simple Payment, add fields
                        for the specific kind of request, which include Parallel Payments, Chained Payments,
                        Implicit Payments, and Preapproved Payments.
                    </i>
                </p>
            </div>
        </div>
    </div>
    <form id="form1" runat="server">
        <div id="request_form">
            <div class="params">
                <div class="param_name">
                    Currency Code*</div>
                <div class="param_value">
                    <asp:TextBox runat="server" ID="currencyCode" Text="USD" />
                </div>
                <div class="param_name">
                    Action Type*</div>
                <div class="param_value">
                    <asp:DropDownList runat="server" ID="actionType">
                        <asp:ListItem Text="Pay" Value="PAY" Enabled="True" Selected="True"  />
                        <asp:ListItem Text="Pay Primary" Value="PAY_PRIMARY" />
                        <asp:ListItem Text="Create" Value="CREATE" Enabled="false" />
                    </asp:DropDownList>
                </div>
                <div class="param_name">
                    Cancel URL*</div>
                <div class="param_value">
                    <asp:TextBox runat="server" ID="cancelURL" />
                </div>
                <div class="param_name">
                    Return URL*</div>
                <div class="param_value">
                    <asp:TextBox runat="server" ID="returnURL" />
                </div>
                <div class="param_name">
                    IPN Notification URL (For receiving IPN call back from PayPal)
                </div>
                <div class="param_value">
                    <asp:TextBox runat="server" ID="ipnNotificationURL" />
                </div>
                <div class="param_name">
                    Sender Email
                </div>
                <div class="param_value">
                    <asp:TextBox runat="server" ID="senderEmail" Text="v-acxu-buyer@hotmail.com" />
                </div>
                <div class="section_header">
                    Receiver
                </div>
                <div class="note">
                    <i>Receiver is the party where funds are transferred to. A Primary Receiver receives
                        a Payment directly from the sender in a Chained Split Payment. A Primary Receiver
                        should not be specified when making a single or Parallel Split Payment. At most
                        one Receiver can be set as Primary Receiver.
                    </i>
                </div>
                <table>
                    <tr>
                        <th class="param_name">
                            Amount*
                        </th>
                        <th class="param_name">
                            Email*
                        </th>
                        <th>
                            Primary Receiver
                        </th>
                    </tr>
                    <tr>
                        <td class="param_value">
                            <asp:TextBox runat="server" ID="amount1" Text="3.00" />
                        </td>
                        <td class="param_value">
                            <asp:TextBox runat="server" ID="mail1" Text="v-acxu-facilitator@hotmail.com" />
                        </td>
                        <td>
                            <asp:DropDownList runat="server" ID="primaryReceiver1">
                                <asp:ListItem Text="True" Value="true" Selected="True" />
                                <asp:ListItem Text="False" Value="false" Enabled="false" />
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="param_value">
                            <asp:TextBox runat="server" ID="amount2" Text="2.00" />
                        </td>
                        <td class="param_value">
                            <asp:TextBox runat="server" ID="mail2" Text="luan-facilitator@hotmail.com" />
                        </td>
                        <td>
                            <asp:DropDownList runat="server" ID="primaryReceiver2">
                                <asp:ListItem Text="True" Value="true" Enabled="false" />
                                <asp:ListItem Text="False" Value="false" Selected="True" />
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <div class="submit">
                <asp:Button ID="ButtonAdaptivePayments" Text="ChainedPayment" runat="server" OnClick="ButtonAdaptivePayments_Click" />
            </div>
            <br />
        
        </div>




        <div class="showmessage">
            <asp:Repeater runat="server" ID="RepeaterError">
                <HeaderTemplate>
                    <b>Error</b>        
                </HeaderTemplate>
                <ItemTemplate>
                    <ul>
                        <li>
                            <i>
                                <%# Eval("message")%>
                            </i>
                        </li>
                    </ul> 
                </ItemTemplate>
                <FooterTemplate>
                    <i>Please refer to the Response object for further Error information.</i>
                    <br />
                    <br />
                </FooterTemplate>
            </asp:Repeater>
        </div>
        <asp:Label runat="server" ID="LabelResponseValues" Text="Response Values" Font-Bold="true" />
        <br />
        <br />
        <div>
            <asp:GridView runat="server" ID="GridViewResponseValues" AutoGenerateColumns="false">
                <RowStyle BackColor="#EFF3FB" />
                <AlternatingRowStyle BackColor="#FFFFFF" />
                <Columns>
                    <asp:BoundField DataField="Key" HeaderText="Key" />
                    <asp:BoundField DataField="Value" HeaderText="Value" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:Label runat="server" ID="LabelConsult" Text="Please refer to the Response object for the complete list of Response Values."
                Font-Italic="true" />
        </div>
        <br />
        <asp:Label runat="server" ID="LabelRequest" Text="Request" Font-Bold="true" />
        <br />
        <br />
        <asp:TextBox runat="server" ID="TextBoxRequest" TextMode="MultiLine" Rows="5" Width="95%" />
        <br />
        <br />
        <asp:Label runat="server" ID="LabelResponse" Text="Response" Font-Bold="true" />
        <br />
        <br />
        <asp:TextBox runat="server" ID="TextBoxResponse" TextMode="MultiLine" Rows="5" Width="95%" />
        <br />
        <br />
        <div>
            <asp:Label runat="server" ID="LabelNotePaymentType" Font-Bold="true" />
            <asp:Label runat="server" ID="LabelPrefixPaymentType" Font-Italic="true" />
            <asp:HyperLink runat="server" ID="HyperLinkPaymentType" Font-Italic="true" />
            <asp:Label runat="server" ID="LabelSuffixPaymentType" Font-Italic="true" />
        </div>
        <div>
            <asp:Label runat="server" ID="LabelNoteTransactionId" Font-Bold="true" />
            <asp:Label runat="server" ID="LabelPrefixTransactionId" Font-Italic="true" />
            <asp:HyperLink runat="server" ID="HyperLinkTransactionId" Font-Italic="true" />
            <asp:Label runat="server" ID="LabelSuffixTransactionId" Font-Italic="true" />
        </div>

   AP-84371313H78055230

    <asp:Label runat="server" ID="LabelWebFlow" Font-Italic="true" />
        <asp:HyperLink runat="server" ID="HyperLinkWebFlow" Font-Italic="true"  NavigateUrl="~/csharpDemo/paypalStart2.aspx"/>
        <br />
        /csharpDemo/paypalStart2.aspx?payKey=AP-9MY8222772927443P .
         <asp:HyperLink runat="server" ID="HyperLink1" Font-Italic="true"  NavigateUrl="~/csharpDemo/paypalStart2.aspx?"/>
        <asp:Label runat="server" ID="LabelWebFlowSuffix" Font-Italic="true" />
    </form>
</body></html>
