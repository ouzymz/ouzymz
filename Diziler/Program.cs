
int sayac = 0;

while (sayac < students2.Length)
{
    Console.WriteLine(String.Format(students2[counter]);
    sayac++;    
}

#region DoWhile ile

int counter = 0;

do
{
    Console.WriteLine(students2[counter]);
    counter++;

} while (counter < students2.Length);




#endregion

Array.Sort(students2); //harflere göre alfabatik sıralır

foreach (var item in students2)
{
    Console.WriteLine(item);
}

