using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class SystemInputFetch : MonoBehaviour
{
    public Vector2 WorldPosition {get; private set;} // Create a variable to store world pos the mouse, set as private set
    public event Action clicked; // Create a no-parameter event that would triggered when mouse is clicked

    private void OnMousemove(InputValue val) // Function that would activate when mouse is moved
    {
        Vector2 mouse_loc = val.Get<Vector2>(); // Get the vector2 value store it in the mouse_loc
        WorldPosition = Camera.main.ScreenToWorldPoint(val.Get<Vector2>()); // Convert the mouse to world location in real-time
    }

    private void OnMouseclick(InputValue val) // If left-mouse is clicked
    {
        if (val.Get<bool>()) // If that signal is a click but not release from click
        {
            clicked?.Invoke(); // Invoke the event for two other scripts to run(one is setActive = false to buttom, two is spawner column and squirrel)
        }
    }
}
