// найти расстояние между двумя точками в трехмерном пространстве, координаты вводятся с клавиатуры
Console.WriteLine("enter x-axis coordinate for 1st point: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter y-axis coordinate for 1st point: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter z-axis coordinate for 1st point: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter x-axis coordinate for 2nd point: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter y-axis coordinate for 2nd point: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter z-axis coordinate for 2nd point: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int sqCoordinate (int a1, int a2)
{
    int sqa = (a2-a1)*(a2-a1);
    return sqa;
}
int sqx = sqCoordinate (x1, x2);
int sqy = sqCoordinate (y1, y2);
int sqz = sqCoordinate (z1, z2);
int distToQ = sqx+sqy+sqz;
// {
//     int sqx = (x2-x1)*(x2-x1);
//     int sqy = (y2-y1)*(y2-y1);
//     int sqz = (z2-z1)*(z2-z1);
//     int sqDist = sqx+sqy+sqz;
//     return sqDist;
// }
//int distToQ= sqCoordinate(x1, x2, y1, y2, z1, z2);
double distance = Math.Sqrt(distToQ);
Console.WriteLine(distance);