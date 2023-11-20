namespace TargetShooting
{
    public struct shot 
    {
        public int xShotCoordinate;
        public int yShotCoordinate;
    }
    public struct target
    {
        public int xCenter;
        public int yCenter;
        public int firstZoneRadius;
        public int secondZoneRadius;
        public int thirdZoneRadius;
    }
    internal class FiveShots
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            try
            {
                Console.WriteLine("Do you want to activate Blind-fire mode? y/n: ");
                string targetModeAnswer = Console.ReadLine();
                Console.WriteLine("Do you want to activate Shot-dispersion mode? y/n: ");
                string fireModeAnswer = Console.ReadLine();

                if (targetModeAnswer != "y" && targetModeAnswer != "n") //проверка корректного ввода (y/n)
                { throw new ArgumentOutOfRangeException("Incorrect answer"); }

                if (fireModeAnswer != "y" && fireModeAnswer != "n") //проверка корректного ввода (y/n)
                { throw new ArgumentOutOfRangeException("Incorrect answer"); }

                shot[] fiveShots = new shot[5];                     //массив для 5 выстрелов
                
                if (targetModeAnswer == "y") 
                {
                    target aTarget;
                    aTarget.xCenter = rnd.Next(0, 10);     //задаётся рандомная координата центра мишени по x
                    aTarget.yCenter = rnd.Next(0, 10);      //задаётся рандомная координата центра мишени по y
                    aTarget.firstZoneRadius = 1;            //радиус зоны 10 баллов
                    aTarget.secondZoneRadius = 2;          //радиус зоны 5 баллов
                    aTarget.thirdZoneRadius = 3;           //радиус зоны 1 балл
                    if (fireModeAnswer == "y")                   //стрельба в слепую с разбросом
                    {
                        Console.WriteLine("Blind-fire mode activated\nShot dispersion activated");
                        Console.WriteLine("The center of target is randomly located at coordinates\nbetween 0 and 10 in x and between 0 and 10 in y. You have 5 shots.");

                        int score = 0;

                        for (int i=0; i < 5; i++) 
                        {
                            
                                Console.WriteLine("Please enter integer x and y coordinates of your shot (use space for split): ");
                                String[] coordinates = Console.ReadLine().Split(' '); //массив для разделения x и y координат
                                fiveShots[i].xShotCoordinate = int.Parse(coordinates[0]) + rnd.Next(0, 1); //присвоение x координаты для i-ого выстрела с возможным разбросом
                                fiveShots[i].xShotCoordinate = int.Parse(coordinates[1]) + rnd.Next(0, 1); //присвоение y координаты для i-ого выстрела с возможным разбросом

                            if ((Math.Pow((fiveShots[i].xShotCoordinate - aTarget.xCenter), 2)) + // Проверка принадлежности координаты выстрела радиусу на 1 балл (x-a)^2 + (y-b)^2 > R^2    
                                (Math.Pow((fiveShots[i].yShotCoordinate - aTarget.yCenter), 2)) > //где a,b - координаты центра окружности; x,y - координаты выстрела; R - радиус зоны 1 балл.
                                Math.Pow(aTarget.thirdZoneRadius, 2)) 
                            { Console.WriteLine("You missed. Enter next shot: ");}
                            else
                            {
                                if (((Math.Pow((fiveShots[i].xShotCoordinate - aTarget.xCenter), 2)) + // Проверка принадлежности координаты выстрела радиусу на 5 баллов (x-a)^2 + (y-b)^2 > R^2 
                                (Math.Pow((fiveShots[i].yShotCoordinate - aTarget.yCenter), 2)) >      //где a,b - координаты центра окружности; x,y - координаты выстрела; R - радиус зоны 5 баллов.
                                Math.Pow(aTarget.secondZoneRadius, 2))) 
                                {
                                    score++;
                                    Console.WriteLine("You got 1 point. Enter next shot: ");
                                }
                                else 
                                {
                                    if (((Math.Pow((fiveShots[i].xShotCoordinate - aTarget.xCenter), 2)) + // Проверка принадлежности координаты выстрела радиусу на 5 баллов (x-a)^2 + (y-b)^2 > R^2 
                                    (Math.Pow((fiveShots[i].yShotCoordinate - aTarget.yCenter), 2)) >      //где a,b - координаты центра окружности; x,y - координаты выстрела; R - радиус зоны 10 баллов.
                                    Math.Pow(aTarget.firstZoneRadius, 2)))
                                    {
                                        score += 5;
                                        Console.WriteLine("You got 5 points. Enter next shot: ");
                                    }
                                    else 
                                    {
                                        score += 10;
                                        Console.WriteLine("You got 10 points. Enter next shot: ");
                                     }
                                }
                            }
                        }

                        Console.WriteLine("Your score: {0}", score);
                        
                    }
                    else                                                                                                        //Стрельба в слепую без разброса
                    {
                        Console.WriteLine("Blind-fire mode activated\nShot dispersion NOT activated");
                        Console.WriteLine("The center of target is randomly located at coordinates\nbetween 0 and 10 in x and between 0 and 10 in y. You have 5 shots.");
                        
                        int score = 0;

                        for (int i = 0; i < 5; i++)
                        {

                            Console.WriteLine("Please enter integer x and y coordinates of your shot (use space for split): ");
                            String[] coordinates = Console.ReadLine().Split(' '); //массив для разделения x и y координат
                            fiveShots[i].xShotCoordinate = int.Parse(coordinates[0]); //присвоение x координаты для i-ого выстрела с возможным разбросом
                            fiveShots[i].xShotCoordinate = int.Parse(coordinates[1]); //присвоение y координаты для i-ого выстрела с возможным разбросом

                            if ((Math.Pow((fiveShots[i].xShotCoordinate - aTarget.xCenter), 2)) + // Проверка принадлежности координаты выстрела радиусу на 1 балл (x-a)^2 + (y-b)^2 > R^2    
                                (Math.Pow((fiveShots[i].yShotCoordinate - aTarget.yCenter), 2)) > //где a,b - координаты центра окружности; x,y - координаты выстрела; R - радиус зоны 1 балл.
                                Math.Pow(aTarget.thirdZoneRadius, 2))
                            { Console.WriteLine("You missed. Enter next shot: "); }
                            else
                            {
                                if (((Math.Pow((fiveShots[i].xShotCoordinate - aTarget.xCenter), 2)) + // Проверка принадлежности координаты выстрела радиусу на 5 баллов (x-a)^2 + (y-b)^2 > R^2 
                                (Math.Pow((fiveShots[i].yShotCoordinate - aTarget.yCenter), 2)) >      //где a,b - координаты центра окружности; x,y - координаты выстрела; R - радиус зоны 5 баллов.
                                Math.Pow(aTarget.secondZoneRadius, 2)))
                                {
                                    score++;
                                    Console.WriteLine("You got 1 point. Enter next shot: ");
                                }
                                else
                                {
                                    if (((Math.Pow((fiveShots[i].xShotCoordinate - aTarget.xCenter), 2)) + // Проверка принадлежности координаты выстрела радиусу на 5 баллов (x-a)^2 + (y-b)^2 > R^2 
                                    (Math.Pow((fiveShots[i].yShotCoordinate - aTarget.yCenter), 2)) >      //где a,b - координаты центра окружности; x,y - координаты выстрела; R - радиус зоны 10 баллов.
                                    Math.Pow(aTarget.firstZoneRadius, 2)))
                                    {
                                        score += 5;
                                        Console.WriteLine("You got 5 points. Enter next shot: ");
                                    }
                                    else
                                    {
                                        score += 10;
                                        Console.WriteLine("You got 10 points. Enter next shot: ");
                                    }
                                }
                            }
                        }

                        Console.WriteLine("Your score: {0}", score);

                    }
                }

                else 
                {
                        target aTarget;
                        aTarget.xCenter = 0;     //задаётся координата центра мишени по x
                        aTarget.yCenter = 0;      //задаётся координата центра мишени по y
                        aTarget.firstZoneRadius = 1;            //радиус зоны 10 баллов
                        aTarget.secondZoneRadius = 2;          //радиус зоны 5 баллов
                        aTarget.thirdZoneRadius = 3;           //радиус зоны 1 балл

                        if (fireModeAnswer == "y")                   //Стрельба с разбросом в статичную мишень с координатой 0 и 0
                        {
                            Console.WriteLine("Blind-fire mode NOT activated\nShot dispersion activated");
                            Console.WriteLine("The center of target located at coordinates 0 in x and 0 in y. You have 5 shots.");

                            int score = 0;

                            for (int i = 0; i < 5; i++)
                            {

                                Console.WriteLine("Please enter integer x and y coordinates of your shot (use space for split): ");
                                String[] coordinates = Console.ReadLine().Split(' '); //массив для разделения x и y координат
                                fiveShots[i].xShotCoordinate = int.Parse(coordinates[0]) + rnd.Next(0, 2); //присвоение x координаты для i-ого выстрела с возможным разбросом
                                fiveShots[i].xShotCoordinate = int.Parse(coordinates[1]) + rnd.Next(0, 2); //присвоение y координаты для i-ого выстрела с возможным разбросом

                                if ((Math.Pow((fiveShots[i].xShotCoordinate - aTarget.xCenter), 2)) + // Проверка принадлежности координаты выстрела радиусу на 1 балл (x-a)^2 + (y-b)^2 > R^2    
                                    (Math.Pow((fiveShots[i].yShotCoordinate - aTarget.yCenter), 2)) > //где a,b - координаты центра окружности; x,y - координаты выстрела; R - радиус зоны 1 балл.
                                    Math.Pow(aTarget.thirdZoneRadius, 2))
                                { Console.WriteLine("You missed. Enter next shot: "); }
                                else
                                {
                                    if (((Math.Pow((fiveShots[i].xShotCoordinate - aTarget.xCenter), 2)) + // Проверка принадлежности координаты выстрела радиусу на 5 баллов (x-a)^2 + (y-b)^2 > R^2 
                                    (Math.Pow((fiveShots[i].yShotCoordinate - aTarget.yCenter), 2)) >      //где a,b - координаты центра окружности; x,y - координаты выстрела; R - радиус зоны 5 баллов.
                                    Math.Pow(aTarget.secondZoneRadius, 2)))
                                    {
                                        score++;
                                        Console.WriteLine("You got 1 point. Enter next shot: ");
                                    }
                                    else
                                    {
                                        if (((Math.Pow((fiveShots[i].xShotCoordinate - aTarget.xCenter), 2)) + // Проверка принадлежности координаты выстрела радиусу на 5 баллов (x-a)^2 + (y-b)^2 > R^2 
                                        (Math.Pow((fiveShots[i].yShotCoordinate - aTarget.yCenter), 2)) >      //где a,b - координаты центра окружности; x,y - координаты выстрела; R - радиус зоны 10 баллов.
                                        Math.Pow(aTarget.firstZoneRadius, 2)))
                                        {
                                            score += 5;
                                            Console.WriteLine("You got 5 points. Enter next shot: ");
                                        }
                                        else
                                        {
                                            score += 10;
                                            Console.WriteLine("You got 10 points. Enter next shot: ");
                                        }
                                    }
                                }
                            }

                            Console.WriteLine("Your score: {0}", score);

                        }
                    else                                                     //Стрельба без разброса в статичную мишень с координатой 0 и 0
                    {
                            Console.WriteLine("Blind-fire mode NOT activated\nShot dispersion NOT activated");
                            Console.WriteLine("The center of target located at coordinates 0 in x and 0 in y.You have 5 shots.");

                            int score = 0;

                            for (int i = 0; i < 5; i++)
                            {

                                Console.WriteLine("Please enter integer x and y coordinates of your shot (use space for split): ");
                                String[] coordinates = Console.ReadLine().Split(' '); //массив для разделения x и y координат
                                fiveShots[i].xShotCoordinate = int.Parse(coordinates[0]); //присвоение x координаты для i-ого выстрела с возможным разбросом
                                fiveShots[i].xShotCoordinate = int.Parse(coordinates[1]); //присвоение y координаты для i-ого выстрела с возможным разбросом

                                if ((Math.Pow((fiveShots[i].xShotCoordinate - aTarget.xCenter), 2)) + // Проверка принадлежности координаты выстрела радиусу на 1 балл (x-a)^2 + (y-b)^2 > R^2    
                                    (Math.Pow((fiveShots[i].yShotCoordinate - aTarget.yCenter), 2)) > //где a,b - координаты центра окружности; x,y - координаты выстрела; R - радиус зоны 1 балл.
                                    Math.Pow(aTarget.thirdZoneRadius, 2))
                                { Console.WriteLine("You missed. Enter next shot: "); }
                                else
                                {
                                    if (((Math.Pow((fiveShots[i].xShotCoordinate - aTarget.xCenter), 2)) + // Проверка принадлежности координаты выстрела радиусу на 5 баллов (x-a)^2 + (y-b)^2 > R^2 
                                    (Math.Pow((fiveShots[i].yShotCoordinate - aTarget.yCenter), 2)) >      //где a,b - координаты центра окружности; x,y - координаты выстрела; R - радиус зоны 5 баллов.
                                    Math.Pow(aTarget.secondZoneRadius, 2)))
                                    {
                                        score++;
                                        Console.WriteLine("You got 1 point. Enter next shot: ");
                                    }
                                    else
                                    {
                                        if (((Math.Pow((fiveShots[i].xShotCoordinate - aTarget.xCenter), 2)) + // Проверка принадлежности координаты выстрела радиусу на 5 баллов (x-a)^2 + (y-b)^2 > R^2 
                                        (Math.Pow((fiveShots[i].yShotCoordinate - aTarget.yCenter), 2)) >      //где a,b - координаты центра окружности; x,y - координаты выстрела; R - радиус зоны 10 баллов.
                                        Math.Pow(aTarget.firstZoneRadius, 2)))
                                        {
                                            score += 5;
                                            Console.WriteLine("You got 5 points. Enter next shot: ");
                                        }
                                        else
                                        {
                                            score += 10;
                                            Console.WriteLine("You got 10 points. Enter next shot: ");
                                        }
                                    }
                                }
                            }

                            Console.WriteLine("Your score: {0}", score);

                     
                    }

                }



            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }
    }
}