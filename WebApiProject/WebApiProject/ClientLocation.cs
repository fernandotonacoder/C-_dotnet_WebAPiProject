
using System.Text.Json;

public class ClientLocation {


private string clientPostcode;
private double heathrowLatitude =  51.4700223;
private double heathrowLongitude = -0.4542955;

public ClientLocation(string clientPostcode)
{
    this.clientPostcode = clientPostcode;
}

private double getClientLatitude(string clientPostcode)
{
    this.clientPostcode = clientPostcode;

         HttpClient client = new HttpClient();
            var responseTask = client.GetAsync("http://api.postcodes.io/postcodes/" + clientPostcode);
            responseTask.Wait();
            if(responseTask.IsCompleted)
            {
                var result = responseTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var message = result.Content.ReadAsStringAsync();
                    message.Wait();
                    var apiResponse = JsonSerializer.Deserialize<DataStructure>(message.Result);
                    return apiResponse.Result.Latitude;
                }
            }
            return double.NaN;
            }

private double getClientLongitude(string clientPostcode)
{
    this.clientPostcode = clientPostcode;
         HttpClient client = new HttpClient();
            var responseTask = client.GetAsync("http://api.postcodes.io/postcodes/" + clientPostcode);
            responseTask.Wait();
            if(responseTask.IsCompleted)
            {
                var result = responseTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var message = result.Content.ReadAsStringAsync();
                    message.Wait();
                    var apiResponse = JsonSerializer.Deserialize<DataStructure>(message.Result);
                    return apiResponse.Result.Longitude;
                }
            }
            return double.NaN;
            }

// Get client distance from Heathrow airport in Kilometers
public double getClientKMDistanceFromHeathrow()
{
    
    double clientLatitude = getClientLatitude(clientPostcode);
    double clientLongitude = getClientLongitude(clientPostcode);


    // Haversine formula
    var R = 6372.8; // In kilometers
    var dLat = toRadians(heathrowLatitude - clientLatitude);
    var dLon = toRadians(heathrowLongitude - clientLongitude);
    var lat1 = toRadians(clientLatitude);
    var lat2 = toRadians(heathrowLatitude);

    var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
    var c = 2 * Math.Asin(Math.Sqrt(a));
    return R * c;
  }

  private static double toRadians(double angle) {
    return Math.PI * angle / 180.0;
  }

// Get client distance from Heathrow airport in Miles
public double getClientMilesDistanceFromHeathrow()
{

double miles = getClientKMDistanceFromHeathrow() * 0.621371;
return miles;
}

public string getClientDistanceFromHeathrow()
{
    string message = "Given the client's postcode " + clientPostcode + ", his/her distance from Heathrow Airport is: \n"
    + Math.Round(getClientKMDistanceFromHeathrow(), 2) + " kilometers / " + Math.Round(getClientMilesDistanceFromHeathrow(), 2) + " miles.";

    return message;

}
}