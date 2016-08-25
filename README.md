# Inter-Cars-Api-Tester

## Informacje ogólne

Aby pobrać dane w formacie XML należy wysłać zapytanie GET pod adres: https://katalog.intercars.com.pl/api/v2/External/{nazwa_akcji}?{nazwa_parametru}={wartość_parametru}, podając odpowiednią nazwę akcji. W zależności od wołanej metody wymagane są jej parametry przekazywane w tzw. Query Stringu. Dodatkowo każde zapytanie musi zawierać w nagłówku dwie wartości takie jak „kh_kod” oraz „token”. Kh_kod jest to numer klienta w InterCars, natomiast token jest specjalnym kluczem, który można uzyskać w ustawieniach programu IC_Katalog ONLINE.Poprawnie sformatowany nagłówek (Header HTTP) musi wyglądać w taki sposób:

kh_kod: 526318

token: 4a4bf416-0505-4b6d-bd3f-d2b610a1f3bd5

API udostępnia następujące metody:

• GetInvoices (Pobieranie dokumentu z uwzględnieniem zakresu dat)

• GetInvoice (Pobieranie pojedynczego dokumentu)


## Pobieranie dokumentów sprzedaży (GetInvoices)

Aby pobrać dane w formacie XML, należy wysłać zapytanie GET pod adres: https://katalog.intercars.com.pl/api/v2/External/, podając nazwę akcji GetInvoices oraz odpowiednie wartości parametrów oznaczone jako „from” (data początkowa), a także „to” (data końcowa). Całe zapytanie powinno mieć następującą postać. 

Adres żądania GET:

https://katalog.intercars.com.pl/api/v2/External/GetInvoices?from=20160301&to=20160601

Nagłówek HTTP:

kh_kod: 526318

token: 4a4bf416-0505-4b6d-bd3f-d2b610a1f3bd5

W odpowiedzi otrzymamy sformatowany dokument XML zawierający listę nagłówków faktur. 


## Pobieranie dokumentu sprzedaży (GetInvoice)

Aby pobrać dane w formacie XML, należy wysłać zapytanie GET pod adres: https://katalog.intercars.com.pl/api/v2/External/ podając nazwę akcji GetInvoice, oraz wartości dla parametru „id”. Całe zapytanie powinno mieć następującą postać. 

Adres żądania GET:

https://katalog.intercars.com.pl/api/v2/External/GetInvoice?id=110000031

Nagłówek HTTP:

Na przykład,

kh_kod: 526318

token: 4a4bf416-0505-4b6d-bd3f-d2b610a1f3bd5

W odpowiedzi otrzymamy sformatowany dokument XML zawierający nagłówek oraz pozycje faktury. 


## Przykładowe wywołanie z użyciem obiektu WebClient

var serverUrl = https://katalog.intercars.com.pl/api/v2/External/GetInvoice?id= 110000031;

var client = new System.Net.WebClient();

client.Headers["kh_kod"] = "526318";

client.Headers["token"] = "4a4bf416-0505-4b6d-bd3f-d2b610a1f3bd";

var result = client.DownloadString(serverUrl);


## Generowanie tokenów dostępowych

Aby otrzymać token. należy zalogować się na swoje konto w programie IC_Katalog ONLINE, przejść w „Ustawienia”, a następnie w „Udostępnianie dokumentów online”. Jeśli mamy niezweryfikowany adres e-mail, należy go potwierdzić wciskając przycisk „Potwierdź e-mail”. W przypadku, kiedy nie jest wyświetlony żaden adres w polu E-mail, skontaktuj się ze swoim przedstawieniem handlowym. Aby wygenerować token, użyj opcji „Generuj Token”. Zostanie wyświetlone okienko z regulaminem usługi. Należy uważnie przeczytać wszystkie postanowienia. Po akceptacji zostanie wygenerowany odpowiedni klucz. Po zamknięciu okna nie będzie możliwości jego ponownego wyświetlenia.

