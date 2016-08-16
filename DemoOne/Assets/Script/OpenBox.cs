using UnityEngine;
using System.Collections;

public class OpenBox : MonoBehaviour {
	private Transform m_left_Transform;
	private Transform m_right_Transform;
	private Transform m_top_Transform;

	private bool box_flag ;// open true close is false
	private int topMax = 110;
	private int leftMax = 110;
	private int rightMax = 110;
	private Component[] m_list;
	// Use this for initialization
	void Start () {
		m_list = GetComponentsInChildren<Component> ();
		foreach (Component m in m_list)
		{
			if (m.name == "BoxTopLeft"){
				m_left_Transform = m.transform;
			}
			if (m.name == "BoxTopRight"){
				m_right_Transform = m.transform;
			}
			if (m.name == "BoxTop"){
				m_top_Transform = m.transform;
			}
						
		}
		Open ();
	}
	
	// Update is called once per frame
	void Update () {
//		Open ();
	}
	public void Open () {
		for (int i = 0; i < topMax; i++) {
			m_top_Transform.Rotate(Vector3.left,1);

		}
		for (int i = 0; i < leftMax; i++) {
			m_left_Transform.Rotate(Vector3.forward,1);

		}
		for (int i = 0; i < rightMax; i++) {
			m_right_Transform.Rotate(Vector3.forward,-1);

		}
	}
	public void Colse(){

	}
}
