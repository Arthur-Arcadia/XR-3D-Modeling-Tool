using UnityEngine;

/*
Codes below are composed of AI generated content and self-created content, AI content will be marked.
This code aims for self-rotation and jumping effect.
https://chatgpt.com
The code snippet appears in its original form.
*/

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 45f;   // Rotation Speed
    public float floatAmplitude = 0.05f; // Amplitude for jumping
    public float floatFrequency = 2f;   // Frequency for jumping

    private Vector3 startPos;

    void Start()
    {
        // Record initial place so that the jumping action is relative
        startPos = transform.position;
    }

    void Update()
    {
        // rotation
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Jumping up and down, like coin effect in Mario Game
        float newY = startPos.y + Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}

// End code snippet (Enables jumping and rotating)