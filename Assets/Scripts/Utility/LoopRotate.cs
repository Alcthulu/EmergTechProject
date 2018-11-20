using System.Collections;
using UnityEngine;

public class LoopRotate : MonoBehaviour
{
  public Vector3 rotation;
	
	// Update is called once per frame
	void Update ()
  {
    transform.Rotate(rotation * Time.deltaTime);	
	}
}
