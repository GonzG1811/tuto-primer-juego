using UnityEngine;

public class AccelerateMoveCommand : ICommand
{
    private readonly PlayerMovement playerMovement;
    private readonly float input;

    public AccelerateMoveCommand(PlayerMovement playerMovement, float input)
    {
        this.playerMovement = playerMovement;
        this.input = input;
    }

    public void Execute()
    {
        playerMovement.SetMovementStrategy(new AcelerateMovement());
        playerMovement.MovePlayer(input);
    }
}