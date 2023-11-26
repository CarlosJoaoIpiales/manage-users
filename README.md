# Mangement Users

El proyecto realizar un CRUD de usuarios utilizando una base de datos SQL mangejada por SQL Server integration services

## Instrucciones de Instalación y Configuración

### Prerrequisitos

- Visual Studio 2022
- SQL Server Management Studio (SSMS)
- Git

### Clonar el Repositorio

1. Abre la línea de comandos o terminal.
2. Navega al directorio donde deseas clonar el proyecto.
3. Ejecuta el siguiente comando: git clone https://github.com/CarlosJoaoIpiales/manage-users.git

### Configurar la Base de Datos

1. Abre SQL Server Management Studio (SSMS).
2. Conéctate a tu instancia de SQL Server.
3. En el menú "Archivo", selecciona "Abrir" y luego "Archivo".
4. Navega hasta el script de la base de datos que viene con el proyecto y ábrelo.
5. Ejecuta el script para crear y configurar la base de datos.

### Configurar y Ejecutar la Aplicación

1. Abre Visual Studio 2022.
2. En la pantalla de inicio, selecciona "Abrir un proyecto o una solución".
3. Navega hasta el directorio del proyecto clonado y abre el archivo de solución (`.sln`).
4. Asegúrate de que todas las dependencias del proyecto estén restauradas correctamente.
5. Configura el string de conexión a la base de datos en el archivo `appsettings.json` o en el lugar correspondiente.
6. Compila y ejecuta la aplicación presionando `F5` o el botón "Iniciar" en Visual Studio.

### Uso

1. Una vez iniciado el proyecto aparecera la siguiente ventana:

![Captura de Pantalla de la Aplicación](https://i.ibb.co/y0pD776/Captura-de-pantalla-2023-11-26-123216.png)

2. Seleccionamos la opcion del menu usuarios y nos aparecera la siguiente pagina:

![Captura de Pantalla de la Aplicación](https://i.ibb.co/Q6FsQnv/Captura-de-pantalla-2023-11-26-123958.png)

3. Ahora podemos realizar un CRUD de usuarios:
* Tiene restricciones de solo letras cuando se ingrese un nombre o se edite un usuario
* Tiene restricciones de un rago de fecha que se ubica entre el 1990 y el año actual

###End
