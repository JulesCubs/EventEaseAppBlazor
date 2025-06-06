# EventEaseAppBlazor - English

## Application Overview

**EventEaseAppBlazor** is a web application developed with Blazor WebAssembly for event management and real-time user attendance tracking. It allows you to create, view, and delete events, as well as register and monitor participant attendance. The app features a modern and clear interface, using Bootstrap and Bootstrap Icons for an enhanced user experience.

### Main Features

- **Event management:** Create, list, and delete events with details such as name, date, location, description, organizer, and category.
- **Modern cards:** Display events in detailed, stylish cards.
- **Validations:** Forms with real-time validation and highlighted error messages.
- **Attendance tracking:** Register user check-in and check-out per event, monitoring active and finished sessions.
- **Event selection:** View to choose which event to register attendance for or review sessions.
- **Session visualization:** General list of all attendance sessions and event-specific details.
- **Intuitive navigation:** Modern navigation menu and quick links to all main views.

### How Copilot AI Developed This Project

The development of **EventEaseAppBlazor** was guided step by step by the user, with the assistance of GitHub Copilot, who:

1. **Planned the architecture:** Suggested the folder structure, models, and services needed for event and user session management.
2. **Implemented models and services:** Generated code for event and session models, as well as services to handle state and business logic.
3. **Designed the interface:** Proposed and developed Razor components for event cards, registration forms, and attendance tables, applying modern styles and validations.
4. **Managed state:** Implemented user session management to track real-time attendance, ensuring each record is linked to a specific event.
5. **Facilitated navigation:** Added views to select events, register attendance, and monitor sessions, integrating everything into a clear and attractive navigation menu.
6. **Solved errors and improved UX:** Helped debug common Blazor issues, routes, styles, and references, ensuring a smooth experience for the end user.
7. **Documented the process:** Explained each step, suggestion, and code snippet, allowing the user to understand and customize the app as needed.

### How to Run the Application

1. Clone the repository and open the solution in Visual Studio Code or your favorite IDE.
2. Restore packages and build the project:
   ```bash
   dotnet restore
   dotnet build
   ```
3. Run the application:
   ```bash
   dotnet run
   ```
4. Go to `http://localhost:5139` (or the port shown in the console) in your browser.

### Credits

Developed by Julián Cubillos with the assistance of **GitHub Copilot**.

---
# EventEaseAppBlazor - Español

## Resumen de la Aplicación

**EventEaseAppBlazor** es una aplicación web desarrollada en Blazor WebAssembly para la gestión de eventos y el monitoreo de la asistencia de los usuarios. Permite crear, visualizar y eliminar eventos, así como registrar y rastrear la asistencia de los participantes en tiempo real. La aplicación está diseñada con una interfaz moderna y clara, utilizando Bootstrap y Bootstrap Icons para una mejor experiencia de usuario.

### Funcionalidades principales

- **Gestión de eventos:** Crear, listar y eliminar eventos con detalles como nombre, fecha, ubicación, descripción, organizador y categoría.
- **Tarjetas modernas:** Visualización de eventos en tarjetas detalladas y estilizadas.
- **Validaciones:** Formularios con validaciones en tiempo real y mensajes de error destacados.
- **Rastreo de asistencia:** Registro de entrada y salida de usuarios por evento, con monitoreo de sesiones activas y finalizadas.
- **Selección de evento:** Vista para elegir a qué evento registrar asistencia o revisar sesiones.
- **Visualización de sesiones:** Listado general de todas las sesiones de asistencia y detalle por evento.
- **Navegación intuitiva:** Menú de navegación moderno y enlaces rápidos a todas las vistas principales.

### Cómo la IA de Copilot desarrolló este proyecto

El desarrollo de **EventEaseAppBlazor** fue guiado paso a paso por el usuario, con la asistencia de GitHub Copilot, quien:

1. **Planificó la arquitectura:** Sugirió la estructura de carpetas, modelos y servicios necesarios para la gestión de eventos y sesiones de usuario.
2. **Implementó modelos y servicios:** Generó el código para los modelos de eventos y sesiones, así como los servicios para manejar el estado y la lógica de negocio.
3. **Diseñó la interfaz:** Propuso y desarrolló componentes Razor para tarjetas de eventos, formularios de registro y tablas de asistencia, aplicando estilos modernos y validaciones.
4. **Gestionó el estado:** Implementó la gestión de sesiones de usuario para rastrear la asistencia en tiempo real, asegurando que cada registro esté vinculado a un evento específico.
5. **Facilitó la navegación:** Añadió vistas para seleccionar eventos, registrar asistencia y monitorear sesiones, integrando todo en un menú de navegación claro y atractivo.
6. **Solucionó errores y mejoró la experiencia:** Ayudó a depurar problemas comunes de Blazor, rutas, estilos y referencias, asegurando una experiencia fluida para el usuario final.
7. **Documentó el proceso:** Explicó cada paso, sugerencia y fragmento de código, permitiendo que el usuario entendiera y personalizara la aplicación según sus necesidades.

### Cómo ejecutar la aplicación

1. Clona el repositorio y abre la solución en Visual Studio Code o tu IDE favorito.
2. Restaura los paquetes y compila el proyecto:
   ```bash
   dotnet restore
   dotnet build
   ```
3. Ejecuta la aplicación:
   ```bash
   dotnet run
   ```
4. Accede a `http://localhost:5139` (o el puerto que indique la consola) desde tu navegador.

### Créditos

Desarrollado por Julián Cubillos con la asistencia de **GitHub Copilot**.

---
