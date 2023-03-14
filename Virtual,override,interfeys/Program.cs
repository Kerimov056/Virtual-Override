using Virtual_override_interfeys.Metoods;

Print print= new Print();     //Virtual olduqduan sonra hamsinin override olundu.
Print print2= new Pdf();
Print print3= new Excell();

print.Write();
print2.Write();
print3.Write();

Console.WriteLine("------------");

object[] objects = {print,print2,print3};
foreach (var item in objects)            
{                               //object'in override eldiyimin neticesi:
    Console.WriteLine(item);
}

