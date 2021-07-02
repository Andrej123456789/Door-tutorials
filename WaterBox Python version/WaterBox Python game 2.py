
import turtle
import os

#start window
wn = turtle.Screen()
wn.title("Auto WaterBox game")
wn.bgcolor("black")
wn.setup(width=800, height=600)

#about
print("Welcome. Settings=S", "Water Active/Deactive = w/d")



# Ball water
ball = turtle.Turtle()
ball.speed(0)
ball.shape("circle")
ball.color("blue")
ball.penup()
ball.goto(0, 0)
ball.dx = 0.1
ball.dy = 0.1

# ball fire
ball2 = turtle.Turtle()
ball2.speed(0)
ball2.shape("circle")
ball2.color("red")
ball2.penup()
ball2.goto(0, 0)
ball2.dx = 0.1
ball2.dy = 0.1

#settings
settings = input("Type whats you want to do: ")
if settings == "color":
    color = input("Type your color: ")
    if color == "green":
        wn.bgcolor("green")
        print("If you cannot see color, try again or restart WaterBox game.")

#keyboard
wn.listen()
wn.onkeypress(settings, "s")



# Main game loop
while True:
    wn.update()
    
    # Move the ball
    ball.setx(ball.xcor() + ball.dx)
    ball.sety(ball.ycor() + ball.dy)
    ball2.setx(ball2.xcor() + ball2.dx)
    ball2.setx(ball2.ycor() + ball2.dy)

    # Border checking
    if ball.ycor() > 290:
        ball.sety(290)
        ball.dy *= -1

    if ball.ycor() > 290:
        ball.sety(290)
        ball.dy *= -1


    # Top and bottom
    if ball.ycor() < -1000:
        ball.sety(-100)
        ball.dy *= -1
        os.system("afplay bounce.wav&")
    
    elif ball.ycor() < -290:
        ball.sety(-290)
        ball.dy *= -1
        os.system("afplay bounce.wav&")


