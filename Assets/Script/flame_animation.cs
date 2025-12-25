using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float timer = 0f;
    private float duration = 0.5f;
    private Vector3 final;
    private Vector3 initial;
    void Awake() {
        initial = transform.localScale;
        final = (Vector3)initial * 2.25f;
    }
    void Update() 
    {
        if (timer < duration)
        {
            timer += Time.deltaTime;
            float percentage = timer/ duration;
            transform.localScale = Vector3.Lerp(initial, final, percentage);
        }
    }

    // Update is called once per frame

}
