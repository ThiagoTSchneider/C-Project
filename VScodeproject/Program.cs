using VScodeProject.Common.Models;

//create a array -->
//comply with the maximum capacity of the array 
int[] arr = new int[3];

arr[0] = 2;
arr[1] = 90;
arr[2] = 10;

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
foreach(int arrvalue in arr)
{
    Console.WriteLine($"Array Value --> {arrvalue}");
}