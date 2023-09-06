
//parse string into string array and change errors
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderId = orderStream.Split(',');
Array.Sort(orderId);
for (int i = 0; i < orderId.Length; i++)
{
    if (orderId[i].Length != 4)
    {
        orderId[i] = orderId[i] + "\t- Error";
    }
}

foreach (string item in orderId)
{
    System.Console.WriteLine(item);
}