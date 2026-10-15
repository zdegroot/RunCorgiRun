using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class KeyboardInput : MonoBehaviour
{
    public Corgi Corgi;
    public PoopPlacer PoopPlacer;
    
    public void Update()
    {
        // get the buttons pressed
        Keyboard keyboard = Keyboard.current;

        if (keyboard.wKey.isPressed)
        {
            Corgi.MoveManually(Vector2.up);
        }
        if (keyboard.sKey.isPressed)
        {
            Corgi.MoveManually(Vector2.down);
        }
        if (keyboard.aKey.isPressed)
        {
            Corgi.MoveManually(Vector2.left);
        }
        if (keyboard.dKey.isPressed)
        {
            Corgi.MoveManually(Vector2.right);
        }

        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            PoopPlacer.Place(Corgi.GetPosition());
        }
    }
}
