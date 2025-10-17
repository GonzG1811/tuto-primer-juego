using UnityEngine;

public class AcelerateMovement : IMovementStrategy
{
    private float currentSpeed = 0f;

    public void Move(Transform transform, Player player, float direction)
    {
        currentSpeed += direction * player.Acceleration * Time.deltaTime;
        currentSpeed = Mathf.Clamp(currentSpeed, -player.Velocity, player.Velocity);
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
    }
}