using UnityEngine;

public class SmoothMovement : IMovementStrategy
{
    public void Move(Transform transform, Player player, float direction)
    {
        float moveInX = direction * player.Velocity * Time.deltaTime;
        transform.Translate(moveInX, 0, 0);
    }
}