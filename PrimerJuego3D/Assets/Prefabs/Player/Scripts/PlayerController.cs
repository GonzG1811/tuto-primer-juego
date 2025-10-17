using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;

    private readonly List<ICommand> commands = new List<ICommand>();

    void Start()
    {
        playerMovement = gameObject.GetComponent<PlayerMovement>();
        if (playerMovement == null)
        {
            Debug.LogError("PlayerController requiere un PlayerMovement en el mismo GameObject.");
            enabled = false;
        }
    }

    void Update()
    {
        commands.Clear();

        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0)
        {
            commands.Add(new MoveCommand(playerMovement, horizontalInput));
        }

        foreach (var command in commands)
        {
            command.Execute();
        }
    }
}