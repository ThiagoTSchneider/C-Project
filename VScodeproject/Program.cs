using VScodeProject.Common.Models;

//create a array -->
//comply with the maximum capacity of the array 
int[] arr = new int[4];

arr[0] = 2;
arr[1] = 90;
arr[2] = 10;
arr[3] = 30;

//Array.Resize(ref arr, arr.Length * 2);

//Length means capacity of the array
//"contador" is known as Index - Indice
for (int contador = 0; contador < arr.Length; contador++)
{
    //print the array --> 
    Console.WriteLine($"Posição --> {contador} = {arr[contador]}");
}
//print the length of the Array --> 
Console.WriteLine($"Array Length --> {arr.Length}");

//For each | operator
//way easier and less code to write
int indexforeach = 0;
foreach(int arrvalue in arr)
{
    Console.WriteLine($"Array Value --> {arrvalue} - Index --> {indexforeach}");
    indexforeach++;
}

//Create a list -->
//Dynamic list, no need to determine the capacity
List<string> list = new List<string>();

//Add elements in the list
list.Add("Brazil");
list.Add("USA");
list.Add("UK");
list.Add("France");
list.Add("Italy");
list.Add("Germany");
list.Add("Spain");

//list items can be removed with list.Remove();

for(int index = 0; index < list.Count; index++)
{
    Console.WriteLine($"{index} Country --> {list[index]}");
}

//Foreach
//way easier and less code to write
foreach(string item in list)
{
    Console.WriteLine($"Country --> {item}");
}
