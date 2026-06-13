# ExamenFinalAnalisis
Angel Alezander López Martínez 0907-23-6457 

# PARTE 1

# HISTORIAS DE USUARIO

## Sistema de Gestión de Incidentes de Red – NetGuard GT

---

## HU-01: Registrar un incidente de red

**Como:** coordinador de operaciones
**Quiero:** registrar un incidente ocurrido en uno de los sitios de red
**Para:** mantener un control centralizado de las fallas y evitar la pérdida de información.

### Descripción

El sistema deberá permitir registrar los incidentes que ocurran en las antenas, nodos o puntos de presencia POP de NetGuard GT. Cada incidente deberá contener la información necesaria para identificar la falla, conocer su gravedad y darle seguimiento.

### Criterios de aceptación

1. El incidente debe incluir título, descripción, sitio de red, tipo de incidente y severidad.
2. El sitio de red seleccionado debe existir dentro del sistema.
3. La severidad debe ser crítica, urgente, alta, media o baja.
4. El incidente debe registrarse inicialmente con el estado **Registrado**.
5. El sistema debe generar automáticamente un identificador único.
6. La fecha y hora de registro deben generarse automáticamente.
7. El sistema debe calcular la fecha límite de resolución de acuerdo con la severidad.
8. No debe permitirse registrar un incidente con campos obligatorios vacíos.
9. Al registrar el incidente debe crearse el primer registro en su historial.
10. El sistema debe responder con un mensaje indicando que el incidente fue creado correctamente.

### Prioridad

Alta.

### Estimación

5 puntos.

### Reglas de negocio relacionadas

* El tiempo máximo de resolución depende de la severidad.
* Los estados deben avanzar en el orden establecido.
* Debe existir un historial de cambios.

---

## HU-02: Consultar incidentes registrados

**Como:** coordinador de operaciones
**Quiero:** consultar los incidentes registrados en el sistema
**Para:** conocer su estado, severidad, técnico responsable y tiempo disponible para resolverlos.

### Descripción

El sistema deberá permitir consultar todos los incidentes registrados y buscar un incidente específico. La consulta ayudará a identificar incidentes pendientes, vencidos, escalados o sin técnico asignado.

### Criterios de aceptación

1. El sistema debe mostrar una lista con todos los incidentes registrados.
2. Cada incidente debe mostrar su identificador, título, sitio, severidad, estado y fecha de registro.
3. Debe mostrarse el técnico asignado cuando exista.
4. Cuando no exista un técnico asignado, debe indicarse que el incidente está pendiente de asignación.
5. Debe mostrarse la fecha límite de resolución.
6. Debe mostrarse si el incidente se encuentra escalado.
7. Debe permitirse consultar un incidente mediante su identificador.
8. Debe permitirse filtrar los incidentes por estado.
9. Debe permitirse filtrar los incidentes por severidad.
10. Debe permitirse filtrar los incidentes por técnico o sitio de red.
11. Cuando el incidente solicitado no exista, el sistema debe responder con un mensaje de error.
12. Los incidentes deben mostrarse ordenados desde el más reciente hasta el más antiguo.

### Prioridad

Alta.

### Estimación

3 puntos.

### Reglas de negocio relacionadas

* Control de los estados de los incidentes.
* Seguimiento del tiempo máximo de resolución.
* Reportes y consultas de incidentes.

---

## HU-03: Registrar técnicos y especialidades

**Como:** administrador del sistema
**Quiero:** registrar a los técnicos junto con sus especialidades
**Para:** asignar los incidentes únicamente al personal que tenga los conocimientos necesarios.

### Descripción

El sistema deberá permitir registrar a los 12 técnicos de NetGuard GT, indicando sus datos personales, estado y especialidades. Un técnico podrá tener una o varias especialidades.

### Criterios de aceptación

1. El técnico debe registrar nombre completo, correo electrónico, teléfono y estado.
2. El sistema debe generar automáticamente un identificador único para el técnico.
3. El correo electrónico no puede encontrarse repetido.
4. El técnico debe tener como mínimo una especialidad.
5. Las especialidades disponibles serán fibra óptica, microondas y sistemas electrónicos.
6. Un técnico puede tener más de una especialidad.
7. El técnico debe registrarse inicialmente como activo.
8. No debe permitirse asignar incidentes a técnicos inactivos.
9. Debe permitirse consultar las especialidades de cada técnico.
10. Debe mostrarse la cantidad de incidentes activos que tiene asignados.
11. No debe permitirse eliminar un técnico que tenga incidentes activos.
12. El sistema debe responder con un mensaje indicando que el técnico fue registrado correctamente.

### Prioridad

Alta.

### Estimación

3 puntos.

### Reglas de negocio relacionadas

* Un técnico no puede tener más de tres incidentes activos.
* Solo pueden asignarse técnicos con una especialidad compatible.
* Los técnicos inactivos no pueden recibir incidentes.

---


| Código | Historia de usuario                 | Prioridad | Estimación |
| ------ | ----------------------------------- | --------- | ---------: |
| HU-01  | Registrar un incidente de red       | Alta      |   5 puntos |
| HU-02  | Consultar incidentes registrados    | Alta      |   3 puntos |
| HU-03  | Registrar técnicos y especialidades | Alta      |   3 puntos |

**Estimación total: 11 puntos.**
