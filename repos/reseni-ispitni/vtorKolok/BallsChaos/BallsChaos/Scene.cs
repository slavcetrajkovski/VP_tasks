﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BallsChaos
{
    [Serializable]
    public class Scene
    {
        public List<Ball> balls { get; set; }

        public Scene() { 
            balls = new List<Ball>();
        }

        public void AddBall(Point p)
        {
            Ball ball = new Ball(p);
            balls.Add(ball);
        }

        public void Draw(Graphics g)
        {
            foreach (Ball ball in balls)
            { 
                ball.Draw(g);
            }
        }

        public void MoveBalls(int left, int top, int width, int height)
        {
            foreach (Ball ball in balls)
            {
                ball.Move(left, top, width, height);
            }
        }

        public void isTouching()
        {
            for(int i = 0; i < balls.Count; i++)
            {
                for(int j = i + 1; j < balls.Count; j++)
                {
                    if (balls[i].isTouching(balls[j]))
                    {
                        balls[i].Flag = true;
                        balls[j].Flag = true;
                    }
                }
            }

            for(int i = balls.Count - 1; i >= 0; i--)
            {
                if (balls[i].Flag)
                {
                    balls.RemoveAt(i);
                }
            }
        }
    }
}
