using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardInput : MonoBehaviour
{
    public Corgi corgi;
    
    public void Update()
    {
        // get the buttons pressed
        Keyboard keyboard = Keyboard.current;

        if (keyboard.wKey.wasPressedThisFrame)
        {
            corgi.Move(Vector2.up);
        }
        else if (keyboard.sKey.wasPressedThisFrame)
        {
            corgi.Move(Vector2.down);
        }
        else if (keyboard.aKey.wasPressedThisFrame)
        {
            corgi.Move(Vector2.left);
        }
        else if (keyboard.dKey.wasPressedThisFrame)
        {
            corgi.Move(Vector2.right);
        }
    }
}
