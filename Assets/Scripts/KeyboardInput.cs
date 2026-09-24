using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardInput : MonoBehaviour
{
    public Corgi corgi;
    
    public void Update()
    {
        // get the buttons pressed
        Keyboard keyboard = Keyboard.current;

        if (keyboard.wKey.isPressed)
        {
            corgi.Move(Vector2.up);
        }
        if (keyboard.sKey.isPressed)
        {
            corgi.Move(Vector2.down);
        }
        if (keyboard.aKey.isPressed)
        {
            corgi.Move(Vector2.left);
        }
        if (keyboard.dKey.isPressed)
        {
            corgi.Move(Vector2.right);
        }
    }
}
