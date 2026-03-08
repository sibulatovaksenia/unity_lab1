using UnityEngine;

public class MoveAstroid : MonoBehaviour
{
    public float speed = 2f;
    public float a = 3f;
    private float t;

    void Update()
    {
        t += Time.deltaTime * speed;

        float x = a * Mathf.Pow(Mathf.Cos(t), 3);
        float y = a * Mathf.Pow(Mathf.Sin(t), 3);

        transform.position = new Vector3(x, y, transform.position.z);
    }
}