using UnityEngine;

public class TestCubeController : MonoBehaviour
{
    GameObject m_player;

	// Use this for initialization
	void Start()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");
    }


    void OnCollisionStay(Collision other)
    {
        if (other.transform.tag == "Player")
        {
        }
    }
}
