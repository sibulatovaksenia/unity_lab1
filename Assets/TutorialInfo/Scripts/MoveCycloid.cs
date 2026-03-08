using UnityEngine;

public class MoveCycloid : MonoBehaviour
{
    public float speed = 2f;
    private float t;

    void Update()
    {
        t += Time.deltaTime * speed;

        float x = t - Mathf.Sin(t);
        float y = 1 - Mathf.Cos(t);

        transform.position = new Vector3(x, y, transform.position.z);
    }
}