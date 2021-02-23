using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(79, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();
            
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(75, 25, '%','#','@');
            Point food = foodCreator.CreateFood();
            Point spsfood = foodCreator.CreateSpsFood();
            Point badfood = foodCreator.CreateBadFood();
            food.Draw();
            int score = 0;

            Params settings = new Params();
            Sounds sound = new Sounds(settings.GetResourcesFolder()); 
            sound.Play();
            Sounds soundEat = new Sounds(settings.GetResourcesFolder()); 


            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    score++;
                    soundEat.EatPlay();
                    
                    if (score > 2)
                    {
                        spsfood = foodCreator.CreateSpsFood(); 
                        spsfood.Draw(); 
                        badfood = foodCreator.CreateBadFood();
                        badfood.Draw();
                    }
                }
                Colors col = new Colors(score);
                Speed spe =new Speed(score);
                if (snake.Eat(spsfood))
                {
                    score += 4;
                    soundEat.PlaySpsEat();
                }
                if (snake.Eat(badfood))
                {
                    score -= 4;
                    soundEat.PlayBadEat();
                }

                else
                {
                    snake.Move();
                    Thread.Sleep(100);
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                    
                }
            }
            sound.PlayStop();
            TotalScore(score);
            Leader name = new Leader(score);
        }
        
        static void WriteInt(string text1,int text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.Write(text1);
            Console.WriteLine(text);
        }

        static void TotalScore(int score)
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor=ConsoleColor.Green;
            Console.SetCursorPosition( xOffset, yOffset++ );
            WriteInt(" Ваши очки: ",score,xOffset,yOffset++);
        }

    }
}
