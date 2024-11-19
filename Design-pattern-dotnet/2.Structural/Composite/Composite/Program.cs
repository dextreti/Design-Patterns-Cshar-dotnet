// See https://aka.ms/new-console-template for more information




// Crear hojas
using Composite;

///El patrón de diseño Composite.- permite tratar objetos individuales y conjuntos de objetos de manera uniforme. 
///En lugar de distinguir entre objetos y colecciones, todos implementan la misma interfaz. 
///Esto facilita la construcción de estructuras jerárquicas, como árboles, 
///donde los "nodos" pueden ser tanto elementos individuales ("hojas") como agrupaciones de elementos ("compuestos").


IMenu entrada = new MenuItem("Entrada");
IMenu platoPrincipal = new MenuItem("Plato Principal");
IMenu postre = new MenuItem("Postre");

// Crear compuesto
IMenu menuPrincipal = new Menu("Menú Principal");
((Menu)menuPrincipal).AddItem(entrada);
((Menu)menuPrincipal).AddItem(platoPrincipal);
((Menu)menuPrincipal).AddItem(postre);

// Crear submenú
IMenu submenu = new Menu("Menú Infantil");
((Menu)submenu).AddItem(new MenuItem("Juguete"));
((Menu)submenu).AddItem(new MenuItem("Refresco"));

// Agregar submenú al menú principal
((Menu)menuPrincipal).AddItem(submenu);

// Mostrar la estructura del menú
menuPrincipal.Display();