// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Please enter number");
int n = Convert.ToInt32(Console.ReadLine());
int exponential;
Console.WriteLine("please enter exponential to count");
while (!int.TryParse (Console.ReadLine(), out exponential) || exponential <=0){
    Console.WriteLine("Invalid input. Please enter positive integer number");
}
int result=1;
for(int j=1; j<=exponential; j++){
    result=result*n;
}
Console.WriteLine(result);