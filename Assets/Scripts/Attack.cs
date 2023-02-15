using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    public Transform Firepoint;
    public UnityEvent AttackEvent;
    public UnityEvent VisualEffectEvent;

    //Attack
    [HideInInspector] public  GameObject ObjectToDestroy;
    [SerializeField] PlayerMovement _playerMovement;

    private void Awake()
    {

    }
  
    public void ToAttack()
    {
        VisualEffectEvent.Invoke();
        RaycastHit2D hit = Physics2D.Raycast(Firepoint.position,Firepoint.up,_playerMovement.Radius);
        if (hit.collider!=null)
        {
            ObjectToDestroy = hit.collider.gameObject; // Add to temp container
            if (hit.collider.CompareTag("Good"))
            {
                AttackEvent.Invoke();
            }
            else if (hit.collider.CompareTag("Bad"))
            {
               // GameManager.GameOverEvent.Invoke();
            }
        }
    }
    public void DestroyObject()
    {
        ObjectToDestroy.SetActive(false);
    }
    private void Update()
    { 
    }
}