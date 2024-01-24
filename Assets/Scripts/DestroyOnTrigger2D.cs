using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    [SerializeField] public GameObject Blood;

   private void OnTriggerEnter2D(Collider2D other) {
    if (other.tag == triggeringTag && enabled) {
            Destroy(this.gameObject);
            Instantiate(Blood,transform.position,Quaternion.identity);
        }
    }

    private void Update() {

    }
}