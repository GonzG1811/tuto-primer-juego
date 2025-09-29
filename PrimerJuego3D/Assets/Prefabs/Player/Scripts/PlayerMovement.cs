using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 forceToApply;
    private float timeSinceLastForce;
    private float intervalTime;
    private void Start()
    {
        forceToApply = new Vector3(0, 0, 10);
        timeSinceLastForce = 0f;
        intervalTime = 2f;
    }

    private void FixedUpdate()
    {
        timeSinceLastForce += Time.fixedDeltaTime;
        if (timeSinceLastForce >= intervalTime)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(forceToApply,ForceMode.Impulse);
            timeSinceLastForce = 0f;
        }
    }
}
