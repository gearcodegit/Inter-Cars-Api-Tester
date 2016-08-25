# Inter-Cars-Api-Tester
1.General information

In order to share XML data you need to send GET request to:

https://katalog.intercars.com.pl/api/v2/External/{action_name}?{parameter_name}={parameter_value}, defining specific name of an action. Its parameters need to be given in so called Query String, depending on a type of a method. Additionally, each request must have two values in its header: “kh_kod” and “token”. Kh_kod is a customer’s number in Inter Cars system. Token is a specific key that can be obtained in “Settings” section in IC_Katalog ONLINE programme.

A well formatted header needs to look like this (HTTP Header):

For example, 
kh_kod: 526318
token: 4a4bf416-0505-4b6d-bd3f-d2b610a1f3bd5


API shares such methods:

•GetInvoices (sharing documents from a date range)

•GetInvoice (sharing single document)


2.Sharing invoices (GetInvoices)

To share such XML data, you need to send GET request to:

https://katalog.intercars.com.pl/api/v2/External/, fill the name of an action GetInvoices and fill its parameters marked as „from” (initial date), and „to” (finish date) 

Complete request should look like this: 

GET address request:
https://katalog.intercars.com.pl/api/v2/External/GetInvoices?from=20160301&to=20160601


HTTP header:
For example, 
kh_kod: 526318
token: 4a4bf416-0505-4b6d-bd3f-d2b610a1f3bd5

AS a result, you will get an XML document with a list of invoices’ headers.


3.Downloading an invoice (GetInvoice)

To share such XML data, you need to send GET request to:

https://katalog.intercars.com.pl/api/v2/External/ and fill the name of an action GetInvoice, and fill its parameters marked as „id”. 

Complete request should look like this: 

GET address request:
https://katalog.intercars.com.pl/api/v2/External/GetInvoice?id=110000031


HTTP header:
For example,
kh_kod: 526318
token: 4a4bf416-0505-4b6d-bd3f-d2b610a1f3bd5

As a result, you will get an XML document with invoice’s header and the list of items in the document.


4.Exemplary request using WebClient object

var serverUrl = https://katalog.intercars.com.pl/api/v2/External/GetInvoice?id= 110000031;

var client = new System.Net.WebClient();

client.Headers["kh_kod"] = "526318";

client.Headers["token"] = "4a4bf416-0505-4b6d-bd3f-d2b610a1f3bd";

var result = client.DownloadString(serverUrl);


An exemplary Widnows Forms application can be obtained from:

http://download.intercars.eu/cdn/pliki/APITester.zip


5.Generating access token

In order to generate access token, you need to log-in to Your IC_Katalog ONLINE account and go to “Settings” section. Next, choose “Share documents online” button. If your e-mail address has not been confirmed yet, you need to confirm it now clicking “Confirm e-mail”.

If there is no e-mail address in a field, please get in touch with your Inter Cars sales representative. 

To generate token, just click “Generate token” button. After accepting the terms and conditions, a proper token be generated. After closing the window, the token will not be displayed again. Therefore you may copy it to clipboard. 
