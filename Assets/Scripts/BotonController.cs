using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class BotonController : MonoBehaviour
{
    private UIDocument regreso;
    private Button botonRegreso;

    void OnEnable()
    {
        regreso = GetComponent<UIDocument>();
        var root = regreso.rootVisualElement;
        botonRegreso = root.Q<Button>("botonRegreso");

        botonRegreso.RegisterCallback<ClickEvent>(Regresar);
    }

    private void Regresar(ClickEvent evt)
    {
        // Regresar a la escena anterior
        SceneManager.LoadScene("Menu");
    }


}

