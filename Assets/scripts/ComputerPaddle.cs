using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        // Check if the ball is moving towards the paddle (positive x velocity)
        // or away from the paddle (negative x velocity)
        if (ball.velocity.x > 0f)
        {
            // Move the paddle in the direction of the ball to track it
            if (this.ball.position.y > this.transform.position.y)
            {
                rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            // Move towards the center of the field and idle there until the
            // ball starts coming towards the paddle again
            if (this.transform.position.y > 0f)
            {
                rigidbody.AddForce(Vector2.down * this.speed);
            }
            else if (this.transform.position.y < 0f)
            {
                rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }

}
