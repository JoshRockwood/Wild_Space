using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
  public float health = 100f;
  public float damage = 10f;
  
  public void TakeDamage(float amount)
  {
    health -= amount;

    if (health <= 0f)
    {
        Death();
    }
  }
  
  private void Death()
  {
    Destroy(gameObject);
  }

  void OnTriggerEnter(Collider other)
  {
    DamageDealer damageDealer = other.GetComponent<DamageDealer>();

    if (damageDealer != null)
    {
        TakeDamage(damageDealer.damageAmount);
    }
  }
}
