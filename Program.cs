/*
string country;
Console.WriteLine("What country do you live in?");
country = Convert.ToString(Console.ReadLine());

int rainFallOne;
Console.WriteLine("Please enter your first rainfall value: ");
rainFallOne = Convert.ToInt32(Console.ReadLine());

int rainFallTwo;
Console.WriteLine("Please enter your second rainfall value: ");
rainFallTwo = Convert.ToInt32(Console.ReadLine());

int rainFallThree;
Console.WriteLine("Please enter your third rainfall value: ");
rainFallThree = Convert.ToInt32(Console.ReadLine());

int rainFallFour;
Console.WriteLine("Please enter your fourth rainfall value: ");
rainFallFour = Convert.ToInt32(Console.ReadLine());

int rainFallFive;
Console.WriteLine("Please enter your fifth rainfall value: ");
rainFallFive = Convert.ToInt32(Console.ReadLine());

int rainFallSix;
Console.WriteLine("Please enter your sixth rainfall value: ");
rainFallSix = Convert.ToInt32(Console.ReadLine());

int rainFallSeven;
Console.WriteLine("Please enter your seventh rainfall value: ");
rainFallSeven = Convert.ToInt32(Console.ReadLine());

int rainFallEight;
Console.WriteLine("Please enter your eighth rainfall value: ");
rainFallEight = Convert.ToInt32(Console.ReadLine());

int rainFallNine;
Console.WriteLine("Please enter your ninth rainfall value: ");
rainFallNine = Convert.ToInt32(Console.ReadLine());

int rainFallTen;
Console.WriteLine("Please enter your tenth rainfall value: ");
rainFallTen = Convert.ToInt32(Console.ReadLine());

int rainFallEleven;
Console.WriteLine("Please enter your eleventh rainfall value: ");
rainFallEleven = Convert.ToInt32(Console.ReadLine());

int rainFallTwelve;
Console.WriteLine("Please enter your twelvth rainfall value: ");
rainFallTwelve = Convert.ToInt32(Console.ReadLine());

int averageRain;
averageRain = ((rainFallOne+rainFallTwo+rainFallThree+rainFallFour+rainFallFive+rainFallSix+rainFallSeven+rainFallEight+rainFallNine+rainFallTen+rainFallEleven+rainFallTwelve)/12);

Console.WriteLine("The average Rainfall in " +country +" is "+ averageRain);


//Declares the array
int[] rainfallAmt = new int[12];

//Lists the numbers in the array
rainfallAmt[0] = 84;
rainfallAmt[1] = 129;
rainfallAmt[2] = 52;
rainfallAmt[3] = 50;
rainfallAmt[4] = 145;
rainfallAmt[5] = 116;
rainfallAmt[6] = 97;
rainfallAmt[7] = 118;
rainfallAmt[8] = 113;
rainfallAmt[9] = 97;
rainfallAmt[10] = 83;
rainfallAmt[11] = 140;

int rainfallAverage;
rainfallAverage = (rainfallAmt[0] + rainfallAmt[1] + rainfallAmt[2] + rainfallAmt[3] + rainfallAmt[4] + rainfallAmt[5] + rainfallAmt[6] + rainfallAmt[7] + rainfallAmt[8] + rainfallAmt[9] + rainfallAmt[10] + rainfallAmt[11]) / 12);


Console.WriteLine("The average rainfall that year was: " + rainfallAverage);
*/

int[] ages = new int [11];
for (int i = 0; ages.Length; i++)
{
    Console.WriteLine("Enter age " + i + ": ");
    ages[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();

Array.Sort(ages);

for (int i = 0; i < ages.Length; i++)
{
    Console.WriteLine("Age " + 1 + " = " + ages[i]);
}




Console.ReadLine();
