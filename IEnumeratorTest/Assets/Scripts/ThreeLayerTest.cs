using System.Collections;
using UnityEngine;

public class ThreeLayerTest : MonoBehaviour
{
	private void Start()
	{
		var coroutine = StartCoroutine(OuterEnumerator());

		// Only stops the outer coroutine, the inner-most IEnumerator is orphaned and keeps running as a seperate coroutine
		StopCoroutine(coroutine);
	}

	private IEnumerator OuterEnumerator()
	{
		yield return new IEnumeratorReturner().ThreeLayeredMovement(transform);
		Debug.Log(gameObject.name + ": First layer finished");
	}
}
