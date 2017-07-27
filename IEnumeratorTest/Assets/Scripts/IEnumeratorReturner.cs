using System.Collections;
using UnityEngine;

public class IEnumeratorReturner
{
	private const float MOVEMENT_DURATION = 3f;

	public IEnumerator ThreeLayeredMovement(Transform thingToMove)
	{
		yield return TwoLayeredMovement(thingToMove);
		Debug.Log(thingToMove.name + ": Second layer finished");
	}

	public IEnumerator TwoLayeredMovement(Transform thingToMove)
	{
		var startPos = thingToMove.position;

		var movement = thingToMove.up * 10f;
		var elapsedTime = 0f;
		while (elapsedTime < MOVEMENT_DURATION)
		{
			elapsedTime += Time.deltaTime;
			thingToMove.position = Vector3.Lerp(startPos, startPos + movement, elapsedTime);
			yield return null;
		}
		Debug.Log(thingToMove.name + ": Third layer finished");
	}
}