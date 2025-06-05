# EventEaseAppBlazor

EventEaseAppBlazor es una aplicación Blazor diseñada para buscar y mostrar eventos. La aplicación permite a los usuarios explorar eventos con detalles como el nombre del evento, la fecha y la ubicación. Además, los usuarios pueden navegar entre los detalles de los eventos generados.

## Estructura del Proyecto

El proyecto contiene los siguientes archivos y carpetas:

- **EventEaseAppBlazor.sln**: Archivo de solución que agrupa el proyecto.
- **Program.cs**: Punto de entrada de la aplicación Blazor.
- **App.razor**: Define la estructura principal de la aplicación y el enrutamiento.
- **wwwroot/index.html**: Página HTML principal servida al navegador.
- **Pages/Index.razor**: Página de inicio que puede mostrar una lista de eventos.
- **Pages/EventDetails.razor**: Página que muestra los detalles de un evento específico.
- **Components/EventCard.razor**: Componente que muestra los detalles de cada evento.
- **Models/Event.cs**: Clase que representa un evento con propiedades como nombre, fecha y ubicación.
- **Shared/MainLayout.razor**: Diseño principal de la aplicación que incluye un menú de navegación.

## Instrucciones para Ejecutar la Aplicación

1. Asegúrate de tener instalado .NET SDK en tu máquina.
2. Clona el repositorio o descarga el código fuente.
3. Abre una terminal y navega a la carpeta del proyecto.
4. Ejecuta el siguiente comando para restaurar las dependencias:
   ```
   dotnet restore
   ```
5. Para ejecutar la aplicación, utiliza el siguiente comando:
   ```
   dotnet run
   ```
6. Abre tu navegador y navega a `http://localhost:5000` para ver la aplicación en acción.

## Contribuciones

Las contribuciones son bienvenidas. Si deseas contribuir, por favor abre un issue o envía un pull request.

## Licencia

Este proyecto está bajo la licencia MIT.