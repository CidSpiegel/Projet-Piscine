using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
	public float Vitesse;

	void Update()
	{
		if (!isLocalPlayer)
		{
			return;
		}

		var x = Input.GetAxis("Horizontal") * Time.deltaTime * Vitesse;
		var y = Input.GetAxis("Vertical") * Time.deltaTime * Vitesse;

		transform.Translate(x, y, 0);
	}
}