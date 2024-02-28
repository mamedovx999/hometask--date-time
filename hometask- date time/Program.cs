
#region Task1
//void ReverseNumber(string[] word)
//{
//	string[] newArr = new string[word.Length];
//	int index = 0;
//	for (int i = word.Length - 1; i >= 0; i--)
//	{
//		newArr[index] = word[i];
//		index++;
//	}
//	foreach (var item in newArr)
//	{
//		Console.WriteLine(item);
//	}
//}
//string[] stringarr = { "Salam ", "Necesen", "Pb301" };
//ReverseNumber(stringarr);

// basqa cur
void ReverseNumber(string[] word)
{
    string[] newArr = new string[0];
    for (int i = word.Length - 1; i >= 0; i--)
    {
        AddItem(ref newArr, word[i]);
    }

    foreach (var item in newArr)
    {
        Console.WriteLine(item);
    }
}
string[] stringarr = { "Salam", "Necesen", "Pb301" };
ReverseNumber(stringarr);

void AddItem(ref string[] arr, string item)
{
    Array.Resize(ref arr, arr.Length + 1);
    arr[arr.Length - 1] = item;
}
#endregion
#region Task2
//Console.WriteLine("Dogum tarixinizi daxil edin");
//var birthday =  DateTime.Parse(Console.ReadLine());
//var age = DateTime.Now.Year - birthday.Year;
//Console.WriteLine(age);
#endregion
#region Task3
//using System.ComponentModel.Design;

//int year = 2022;
//if ((year % 400 == 0 || year % 100 != 0) && (year % 4 == 0))
//{
//    Console.WriteLine("leap year ");
//}
//else
//{
//    Console.WriteLine(" leap year deyil");
//}

#endregion