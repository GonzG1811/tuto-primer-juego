using UnityEngine;

[System.Serializable]
public class Player
{
    [SerializeField] private float velocity = 5f;
    [SerializeField] private float acceleration = 2f;

    public float Velocity
    {
        get => velocity;
        set => velocity = value;
    }

    public float Acceleration
    {
        get => acceleration;
        set => acceleration = value;
    }
}