using System;
using System.Collections.Generic;
using Pamokos1.GameSample.Game;
using Pamokos1.GameSample.Game1;
using Pamokos1.GameSample.Game2;

namespace Pamokos1.Lesson_9
{
    class GameProject
    {
       static void Main()
       {
           
            GameScreen myGame = new GameScreen(30, 20);

            myGame.SetHero(new Hero(5, 5, "HERO"));

            // create
            
            Random rnd = new Random();
            int enemyCount = 0;
            for (int i = 0; i < 10; i++)
            {
                
                myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }

            // print
           
            myGame.Render();

            // move
           
            myGame.MoveHeroLeft();
            myGame.MoveAllEnemiesDown();

            // print
           
            Enemy secondEnemy = myGame.GetEnemyById(1);
            if (secondEnemy != null)
            {
                
                secondEnemy.MoveDown();
            }

            myGame.Render();

            Console.ReadKey();
       }
    }
}
