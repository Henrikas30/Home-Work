using Pamokos1.GameSample.Game;
using Pamokos1.GameSample.Game1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamokos1.GameSample.Game2
{
    class GameScreen
    {
        private int width;
        private int height;

        private Hero hero;
        private List<Enemy> enemies = new List<Enemy>();

        public GameScreen(int width, int height)
        {
            width = width;
            height = height;
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }


        public void MoveHeroLeft()
        {
            hero.MoveLeft();
        }

        public void MoveHeroRight()
        {
            hero.MoveRight();
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveDown();
            }
        }

        public Enemy GetEnemyById(int id)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }

            return null;
        }

        public void Render()
        {
            hero.PrintInfo();
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }
        }






    }
}
