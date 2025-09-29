using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Player player;
    private IMovementStrategy movementStrategy;

    private Vector3 forceToApply;
    private float timeSinceLastForce;
    private float intervalTime;

    private void Start()
    {
        forceToApply = new Vector3(0, 0, 10);
        timeSinceLastForce = 0f;
        intervalTime = 2f;

        SetMovementStrategy(new SmoothMovement());
    }

    private void FixedUpdate()
    {
        timeSinceLastForce += Time.fixedDeltaTime;
        if (timeSinceLastForce >= intervalTime)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(forceToApply, ForceMode.Impulse);
            timeSinceLastForce = 0f;
        }

        MovePlayer();
    }

    public void SetMovementStrategy(IMovementStrategy strategy)
    {
        movementStrategy = strategy;
    }

    public void MovePlayer()
    {
        movementStrategy.Move(transform, player);
    }

    public void SetSmoothMovement()
    {
        SetMovementStrategy(new SmoothMovement());
    }

    public void SetAccelerateMovement()
    {
        SetMovementStrategy(new AcelerateMovement());
    }
}