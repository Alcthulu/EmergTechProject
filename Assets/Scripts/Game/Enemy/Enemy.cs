using UnityEngine;

public class Enemy : MonoBehaviour {
  public float maxHealth = 100f;
  public float health = 100f;
  public float moveSpeed = 3f;
  public int goldDrop = 10;

  public int pathIndex = 0;

  private int wayPointIndex = 0;
  
  void OnGotToLastWayPoint() {
    Die();
  }
  
  public void TakeDamage(float amountOfDamage) {
    health -= amountOfDamage;

    if (health <= 0) {
      Die();
    }
  }


  void Die() {
    if (gameObject != null) {
      Destroy(gameObject);
    }
  }
}
