using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int _life;

    private void OnTriggerEnter(Collider other)
    {
        Score.Instance.ChangeVal(10);
		other.gameObject.GetComponent<Trigger>().Effect(this);
    }
}
