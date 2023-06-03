using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace Shooter3
{
    public partial class Shooter : Form
    {
        Random rnd;

        int plSpeed;

        PictureBox[] bulets;
        int bulletsspeed;

        PictureBox[] enemys;
        int enemySpeed;

        PictureBox[] meteor;
        int knifspeed;

        PictureBox[] hardEnemys;
        int hardEnemyspeed;

        WindowsMediaPlayer Shoot;
        WindowsMediaPlayer Music;

        int Score;
        int Level;
        public Shooter()
        {
            InitializeComponent();
        }

        private void Shooter_Load(object sender, EventArgs e)
        {
            //Инициализация
            rnd = new Random();
            bulets = new PictureBox[1];
            enemys = new PictureBox[10];
            int sizeEnemy = rnd.Next(60, 90);
            meteor = new PictureBox[2];
            hardEnemys = new PictureBox[5];


            //Музыка
            Shoot = new WindowsMediaPlayer();
            Shoot.URL = "C:\\mygame\\music\\shot.mp3";
            Shoot.settings.volume = 10;
            Music = new WindowsMediaPlayer();
            Music.URL = "C:\\mygame\\music\\fonemusic.mp3";
            Music.settings.setMode("loop", true);
            Music.settings.volume = 25;

            //Скорости
            plSpeed = 7;
            bulletsspeed = 80;
            enemySpeed = 3;
            knifspeed = 8;
            hardEnemyspeed = 5;

            //Очки и уровень сложности
            Score = 0;
            Level = 1;

            //Изображения
            Image fotoEnemy = Image.FromFile("C:\\mygame\\images\\meteoritVar.png");
            Image fotoMeteor = Image.FromFile("C:\\mygame\\images\\meteorit.png");
            Image fotoHardEnemy = Image.FromFile("C:\\mygame\\images\\meteor.png");

            //Определение обьектов
            for (var i = 0; i < hardEnemys.Length; i++)//определяем сложного врага
            {
                hardEnemys[i] = new PictureBox();
                hardEnemys[i].Size = new Size(80, 80);
                hardEnemys[i].BackColor = Color.Transparent;
                hardEnemys[i].Image = fotoHardEnemy;
                hardEnemys[i].SizeMode = PictureBoxSizeMode.Zoom;
                hardEnemys[i].Location = new Point((i + 1) * rnd.Next(90, 160) + 1080, rnd.Next(450, 500));
                hardEnemys[i].Visible = false;
                this.Controls.Add(hardEnemys[i]);
            }

            for (var i = 0; i < meteor.Length; i++)//определяем метеориты
            {
                meteor[i] = new PictureBox();
                meteor[i].Size = new Size(50, 50);
                meteor[i].BackColor = Color.Transparent;
                meteor[i].SizeMode = PictureBoxSizeMode.Zoom;
                meteor[i].Image = fotoMeteor;
                meteor[i].Location = new Point((i + 1) * rnd.Next(100, 600), 0);
                meteor[i].Visible = false;
                this.Controls.Add(meteor[i]);
            }

            for (var i = 0; i < enemys.Length; i++)//определяем каждого злодея
            {
                enemys[i] = new PictureBox();
                enemys[i].Size = new Size(50, 50);
                enemys[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemys[i].BackColor = Color.Transparent;
                enemys[i].Image = fotoEnemy;
                enemys[i].Location = new Point((i + 1) * rnd.Next(90, 160) + 1080, rnd.Next(150, 500));
                this.Controls.Add(enemys[i]);
            }

            for (var i = 0; i < bulets.Length; i++)//определяем пульки
            {
                bulets[i] = new PictureBox();
                bulets[i].BorderStyle = BorderStyle.None;
                bulets[i].Size = new Size(20, 5);
                bulets[i].BackColor = Color.Blue;
                this.Controls.Add(bulets[i]);
            }

            Music.controls.play();
        }

        private void Right_Tick(object sender, EventArgs e)
        {
            if (staticPers.Left < 1150)
            {
                staticPers.Left += plSpeed;
            }
        }

        private void Left_Tick(object sender, EventArgs e)
        {
            if (staticPers.Left < 1150)
            {
                staticPers.Left -= plSpeed;
            }
        }

        private void Up_Tick(object sender, EventArgs e)
        {
            staticPers.Top -= plSpeed;
        }

        private void Down_Tick(object sender, EventArgs e)
        {
            staticPers.Top += plSpeed;
        }

        private void Shooter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Left.Start();
            }

            if (e.KeyCode == Keys.Right)
            {
                Right.Start();
            }

            if (e.KeyCode == Keys.Up)
            {
                Up.Start();
            }

            if (e.KeyCode == Keys.Down)
            {
                Down.Start();
            }
            if (e.KeyCode == Keys.Space)
            {
                Shoot.controls.play();
                for (var i = 0; i < bulets.Length; i++)
                {
                    CollisionRipWithSimplEnmys();
                    CollisionRipWithHardEnemys();
                    CollisionRipWithMeteor();
                    if (bulets[i].Left > 1280)
                    {
                        bulets[i].Location = new Point(staticPers.Location.X + 100 + i * 50, staticPers.Location.Y + 50);
                    }
                }
            }
        }

        private void Shooter_KeyUp(object sender, KeyEventArgs e)
        {
            Left.Stop();
            Right.Stop();
            Up.Stop();
            Down.Stop();
        }

        private void MoveBulletsTimer_Tick(object sender, EventArgs e)
        {
            for (var i = 0; i < bulets.Length; i++)
            {
                bulets[i].Left += bulletsspeed;
            }
        }

        private void Enemies_Tick(object sender, EventArgs e)
        {
            MoveEnemys(enemys, enemySpeed);
        }

        private void MoveEnemys(PictureBox[] enemys, int speed)//Траектория движения врагов
        {
            for (var i = 0; i < enemys.Length; i++)
            {
                enemys[i].Left -= speed + (int)(Math.Sin(enemys[i].Left * Math.PI / 180) * Math.Cos(enemys[i].Left * Math.PI / 100));
                CollisionRipWithSimplEnmys();
            }
        }

        private void KnifMove_Tick(object sender, EventArgs e)
        {
            if (Level >= 5)
            {
                MoveKnifs(meteor, knifspeed);
            }
        }

        private void MoveKnifs(PictureBox[] knife, int knifspeed)//траектория кинжалов
        {
            for (var i = 0; i < knife.Length; i++)
            {
                knife[i].Visible = true;
                knife[i].Top += knifspeed;
                CollisionRipWithMeteor();
            }
        }

        private void HardMove_Tick(object sender, EventArgs e)
        {
            if (Level >= 2)
            {
                MoveHardEnemys(hardEnemys, hardEnemyspeed);
            }
        }

        private void MoveHardEnemys(PictureBox[] enemy, int speed)//траектория слож.врагов
        {
            for (var i = 0; i < enemy.Length; i++)
            {
                enemy[i].Visible = true;
                enemy[i].Left -= speed;
                enemy[i].Top -= rnd.Next(0, 3);
                if (enemy[i].Location.X <= 600)
                {
                    enemy[i].Left -= speed;
                    enemy[i].Top += 3;
                }
                CollisionRipWithHardEnemys();
            }
        }

        //Уничтожение злодеев пульками
        private void CollisionRipWithSimplEnmys()//столкновение пули и зла
        {
            for (var i = 0; i < enemys.Length; i++)
            {
                if (bulets[0].Bounds.IntersectsWith(enemys[i].Bounds))
                {
                    Score += 1;
                    PointsScore.Text = (Score < 10) ? "0" + Score.ToString() : Score.ToString();
                    if (Score % 10 == 0)
                    {
                        Level += 1;
                        LevelsNumber.Text = Level.ToString();
                    }

                    if (enemySpeed <= 5)
                    {
                        enemySpeed++;
                    }
                    enemys[i].Location = new Point((i + 1) * rnd.Next(150, 250) + 1280, rnd.Next(100, 500));
                    bulets[0].Location = new Point(2000, staticPers.Location.Y + 50);
                }

                if (staticPers.Bounds.IntersectsWith(enemys[i].Bounds))//если зло настигло покемона
                {
                    staticPers.Visible = false;//покемон исчезает
                    DeathOfThePerson("Game over");
                }
            }
        }

        private void CollisionRipWithMeteor()
        {
            for (var i = 0; i < meteor.Length; i++)
            {
                if (staticPers.Bounds.IntersectsWith(meteor[i].Bounds))//если кинжал попал в покемона
                {
                    staticPers.Visible = false;//покемон исчезает
                    DeathOfThePerson("Game over");
                }

                if (meteor[i].Location.Y > 650) { meteor[i].Location = new Point(rnd.Next(150, 600), 0); }

                if (bulets[0].Bounds.IntersectsWith(meteor[i].Bounds))
                {
                    meteor[i].Location = new Point(rnd.Next(100, 600), 0);
                    bulets[0].Location = new Point(2000, staticPers.Location.Y + 50);
                }
            }
        }

        private void CollisionRipWithHardEnemys()
        {
            for (var i = 0; i < hardEnemys.Length; i++)
            {
                if (bulets[0].Bounds.IntersectsWith(hardEnemys[i].Bounds))
                {
                    hardEnemys[i].Size = new Size(30, 30);
                    if (bulets[0].Bounds.IntersectsWith(hardEnemys[i].Bounds))
                    {
                        Score += 5;
                        PointsScore.Text = (Score < 10) ? "0" + Score.ToString() : Score.ToString();
                        if (Score % 10 == 0)
                        {
                            Level += 1;
                            LevelsNumber.Text = Level.ToString();
                        }
                        hardEnemys[i].Size = new Size(100, 100);
                        hardEnemys[i].Location = new Point((i + 1) * rnd.Next(150, 250) + 1280, rnd.Next(100, 500));
                        bulets[0].Location = new Point(2000, staticPers.Location.Y + 50);
                    }
                }

                if (hardEnemys[i].Location.X<=0)
                {
                    hardEnemys[i].Location = new Point((i + 1) * rnd.Next(150, 250) + 1280, rnd.Next(100, 500));
                }

                if (staticPers.Bounds.IntersectsWith(hardEnemys[i].Bounds))//если зло настигло покемона
                {
                    staticPers.Visible = false;//покемон исчезает
                    DeathOfThePerson("Game over");
                }
            }
        }

        //Описание лейбла при окончании игры
        private void DeathOfThePerson(string str)
        {
            label1.Text = str;
            label1.Location = new Point(500, 62);
            label1.Visible = true;

            Music.controls.stop();
            Enemies.Stop();
            MoveBulletsTimer.Stop();
            HardMove.Stop();
            MeteorMove.Stop();
        }
    }
}
