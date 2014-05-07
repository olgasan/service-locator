using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{
	private IServiceA a;
	private IServiceB b;

	private IServiceLocator DemoLocator
	{
		get { return DemoServiceLocator.Instance; }
	}

	private void Awake ()
	{
		a = DemoLocator.GetService <IServiceA> ();
		b = DemoLocator.GetService <IServiceB> ();
	}

	private void Start ()
	{
		Debug.Log (a.a);
		Debug.Log (b.b);
	}
}
