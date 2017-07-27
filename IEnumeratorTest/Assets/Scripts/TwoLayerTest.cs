using UnityEngine;

namespace Assets.Scripts
{
	public class TwoLayerTest : MonoBehaviour
	{
		private void Start()
		{
			var coroutine = StartCoroutine(new IEnumeratorReturner().TwoLayeredMovement(transform));

			// Only stops the outer coroutine, the inner-most IEnumerator is orphaned and keeps running as a seperate coroutine
			StopCoroutine(coroutine);
		}
	}
}