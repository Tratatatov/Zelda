using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMovable
{
    [SerializeField] private float _rotationSpeed = 0.5f;
    public float Radius = 5f;
    private float angle;
    public void Move()
    {

        angle += _rotationSpeed * Time.deltaTime;
        Vector2 position = new Vector2();
        position.x = Mathf.Cos(angle) * Radius;
        position.y = Mathf.Sin(angle) * Radius;
        transform.position = position;

    }
    private void Update()
    {
        Move();
    }
}
