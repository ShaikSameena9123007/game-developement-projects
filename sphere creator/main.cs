using UnityEngine;

public class SphereCreator : MonoBehaviour
{
    public int numberOfSpheres;
    public GameObject spherePrefab;

    void Start()
    {
        CreateSpheres();
    }

    void CreateSpheres()
    {
        for (int i = 0; i < numberOfSpheres; i++)
        {
            GameObject sphere = Instantiate(spherePrefab, RandomPosition(), Quaternion.identity);
            ChangeSphereColor(sphere);
        }
    }

    Vector3 RandomPosition()
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-10f, 10f);
        return new Vector3(x, y, 0f);
    }

    void ChangeSphereColor(GameObject sphere)
    {
        Renderer renderer = sphere.GetComponent<Renderer>();
        renderer.material.color = Random.ColorHSV();
    }
}
