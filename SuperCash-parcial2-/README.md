# 🛒 SuperCash - Sistema de Gestión de Inventario y Ventas

SuperCash es una aplicación de escritorio diseñada para optimizar las operaciones de pequeños y medianos negocios, permitiendo un control eficiente de usuarios, productos y ventas.

## Información del Proyecto
* **Cátedra:** Programación I
* **Catedrático:** Ing. Francisco Daniel Peñate Mena
* **Institución:** Universidad Dr. Andrés Bello (Regional Chalatenango)
* **Tema:** Diseño de Formularios o Vistas

## Integrantes
1. **Vilma Leslena Hernandez Mejia**
2. **José Angel Sanchez Mancia**
3. **Diego Josue Martinez Salguero**
4. **Oscar Eduardo Pineda Aguilar**
5. **Yohalmo Joel Coto Perez**

## Arquitectura del Sistema
El proyecto está dividido en los siguientes módulos para separar las responsabilidades:
* **Models:** Definición de las entidades y objetos de negocio (ej. Producto, Usuario).
* **Data:** Encargada del acceso y manejo de los datos. Para este avance, gestiona las listas estáticas (datos en memoria) simulando la base de datos.
* **Forms:** Interfaz gráfica de usuario (GUI) construida con Windows Forms en C#. Contiene todas las pantallas y la lógica de navegación.
* **Helpers:** Clases de apoyo con utilidades estáticas, enfocadas en la validación de datos (emails, precios, control de stock) y manipulación de la UI.

## Funcionalidades en este Avance
* **Login Estático:** Acceso controlado mediante credenciales predefinidas.
* **Navegación Básica:** Flujo funcional entre el menú principal y formularios secundarios.
* **Datos en Memoria:** Uso de listas estáticas para simular una base de datos real.
* **Validaciones Avanzadas:** Control de ingresos de datos (solo letras, solo números, formato de correo).
* **Control de Stock:** Alertas visuales cuando un producto alcanza niveles mínimos.
* **Visualización de Datos:** Reportes dinámicos utilizando `DataGridView`.

## Instrucciones de Ejecución
1. Clonar el repositorio: `git clone <url-del-repositorio>`
2. Abrir el archivo `Proyecto SuperCash.sln` en **Visual Studio**
3. Restaurar los paquetes NuGet (si aplica).
4. Presionar `F5` o el botón **Iniciar** para ejecutar la aplicación.

---
© Todos los Derechos Reservados - Grupo 5 - Ingeniería en Sistemas y Computación - 2026
