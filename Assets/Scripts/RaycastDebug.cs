using UnityEngine;

public class RaycastDebug : MonoBehaviour
{
    [SerializeField] Transform _rayOrigin;
    //[SerializeField] float _rayDistance = 10f;


    [Header("Colors")]
    [SerializeField] private Color _badColor;
    [SerializeField] private Color _goodColor;
    private void OnDrawGizmos()
    {
        Ray ray = new Ray(_rayOrigin.position, _rayOrigin.up);
        Gizmos.DrawRay(ray);
    }
    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(_rayOrigin.position, _rayOrigin.up);
        if (hit.collider != null)
        {
            //Debug
            Debug.Log(hit.collider.name);

            SpriteRenderer sr = hit.collider.GetComponent<SpriteRenderer>();
            if (hit.collider.CompareTag("Good"))
            {
                SetColor(sr, _goodColor);
            }
            else if (hit.collider.CompareTag("Bad"))
            {
                SetColor(sr, _badColor);
            }
        }
    }
    private void SetColor(SpriteRenderer sr, Color newColor)
    {
        sr.color = newColor;
    }
}
