using UnityEngine;
using UnityEngine.UIElements;

public class CreditosScroller : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 30f; // Velocidad de desplazamiento
    private Label creditosText;
    private VisualElement contenedor;
    private float currentTop; // Variable para mantener la posición actual de top

    void Start()
    {
        // Obtén las referencias al contenedor y al texto
        var uiDocument = GetComponent<UIDocument>();
        contenedor = uiDocument.rootVisualElement.Q<VisualElement>("contenedor");
        creditosText = uiDocument.rootVisualElement.Q<Label>("creditos");

        // Establecer la posición inicial del texto fuera de la pantalla (en la parte inferior)
        currentTop = contenedor.resolvedStyle.height;
        creditosText.style.top = currentTop;
    }

    void Update()
    {
        // Mover el texto hacia arriba
        currentTop -= scrollSpeed * Time.deltaTime;
        creditosText.style.top = currentTop;

        // Si el texto sale completamente del contenedor, reiniciamos la posición
        if (currentTop + creditosText.resolvedStyle.height < 0)
        {
            currentTop = contenedor.resolvedStyle.height; // Reinicia al final del contenedor
        }
    }
}



