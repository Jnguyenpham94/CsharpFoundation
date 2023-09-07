const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
//quantity
const string openSpan = "<span>";
const string closeSpan = "</span>";
const string openDiv = "<div>";
const string closeDiv = "</div>";

int openingPosition = input.IndexOf(openSpan) + 6;
int closingPosition = input.IndexOf(closeSpan);
int length = closingPosition - openingPosition;
// System.Console.WriteLine(openingPosition);
// System.Console.WriteLine(closingPosition);
quantity = input.Substring(openingPosition, length);

//output
int openDivPosition = input.IndexOf(openDiv);
// System.Console.WriteLine(openDivPosition);
output = input.Remove(openDivPosition, openDivPosition + 5);
int endDivPosition = output.IndexOf(closeDiv);
// System.Console.WriteLine(endDivPosition);
// System.Console.WriteLine(output);
output = output.Remove(endDivPosition, 6);
output = output.Replace("&trade", "&reg");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");