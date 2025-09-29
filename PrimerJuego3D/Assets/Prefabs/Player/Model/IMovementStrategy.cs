using UnityEngine;

public interface IMovementStrategy
{
    void Move(Transform transform, Player player);
}