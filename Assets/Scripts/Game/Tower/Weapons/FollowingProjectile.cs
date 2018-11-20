using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FollowingProjectile : MonoBehaviour
{
  //1
  public Enemy enemyToFollow;
  //2
  public float moveSpeed = 15;

  private void Update()
  {
    if (enemyToFollow == null)
    {
      Destroy(gameObject);
    }
    else
    {
      transform.LookAt(enemyToFollow.transform);
      GetComponent<Rigidbody>().velocity = transform.forward * moveSpeed;
    }
  }

  public void OnTriggerEnter(Collider other)
  {
    if (other.GetComponent<Enemy>() == enemyToFollow)
    {
      OnHitEnemy();
    }
  }

  //6
  protected abstract void OnHitEnemy();

}
