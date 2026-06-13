# ExamenFinalAnalisis
Angel Alezander López Martínez 0907-23-6457 

# HISTORIAS DE USUARIO

## Sistema de Gestión de Incidentes de Red – NetGuard GT

---

## HU-01: Registrar incidente de red

**Como:** coordinador de operaciones.
**Quiero:** registrar un incidente ocurrido en uno de los sitios de red.
**Para:** mantener un control centralizado de las fallas y evitar la pérdida de información.

### Criterios de aceptación

1. El sistema debe solicitar título, descripción, sitio de red, tipo de incidente y severidad.
2. El incidente debe iniciar con el estado **Registrado**.
3. La fecha y hora de registro deben generarse automáticamente.
4. El sistema debe calcular el tiempo máximo de resolución según la severidad.
5. No debe permitirse registrar un incidente con datos obligatorios vacíos.

**Prioridad:** Alta.

---

## HU-02: Consultar incidentes

**Como:** coordinador de operaciones.
**Quiero:** consultar los incidentes registrados en el sistema.
**Para:** conocer su estado, severidad, técnico responsable y tiempo disponible de resolución.

### Criterios de aceptación

1. El sistema debe mostrar todos los incidentes registrados.
2. Debe permitirse consultar un incidente mediante su identificador.
3. La consulta debe mostrar el sitio, severidad, estado y técnico asignado.
4. Debe mostrarse si el incidente está vencido o escalado.
5. Si el incidente no existe, el sistema debe mostrar un mensaje de error.

**Prioridad:** Alta.

---

## HU-03: Registrar técnicos y especialidades

**Como:** administrador del sistema.
**Quiero:** registrar a los técnicos junto con sus especialidades.
**Para:** asignar los incidentes únicamente al personal capacitado.

### Criterios de aceptación

1. El sistema debe solicitar nombre, correo, teléfono y especialidad.
2. El correo electrónico del técnico no puede repetirse.
3. Cada técnico debe tener al menos una especialidad.
4. Las especialidades disponibles serán fibra óptica, microondas y sistemas electrónicos.
5. El técnico debe registrarse inicialmente como activo.

**Prioridad:** Alta.

---

## HU-04: Asignar incidente a un técnico

**Como:** coordinador de operaciones.
**Quiero:** asignar un incidente a un técnico disponible.
**Para:** asegurar que la falla sea atendida por una persona responsable y capacitada.

### Criterios de aceptación

1. El incidente debe encontrarse en estado **Registrado**.
2. El técnico debe estar activo.
3. El técnico debe tener una especialidad compatible con el tipo de incidente.
4. El técnico no puede tener más de tres incidentes activos.
5. Al realizar la asignación, el estado debe cambiar a **Asignado**.
6. La asignación debe registrarse en el historial.

**Prioridad:** Crítica.

---

## HU-05: Iniciar atención de un incidente

**Como:** técnico asignado.
**Quiero:** cambiar el estado del incidente a **En progreso**.
**Para:** informar que he comenzado a trabajar en la solución de la falla.

### Criterios de aceptación

1. El incidente debe encontrarse en estado **Asignado**.
2. Solo el técnico asignado puede iniciar la atención.
3. El estado debe cambiar de **Asignado** a **En progreso**.
4. La fecha y hora de inicio deben registrarse automáticamente.
5. El cambio debe guardarse en el historial del incidente.

**Prioridad:** Alta.

---

## HU-06: Resolver un incidente

**Como:** técnico asignado.
**Quiero:** marcar el incidente como resuelto y registrar la solución aplicada.
**Para:** dejar constancia de que la falla fue corregida.

### Criterios de aceptación

1. El incidente debe encontrarse en estado **En progreso**.
2. Solo el técnico asignado puede resolverlo.
3. El técnico debe ingresar una descripción de la solución.
4. El estado debe cambiar de **En progreso** a **Resuelto**.
5. El sistema debe indicar si el incidente fue resuelto dentro del SLA.
6. El cambio debe registrarse en el historial.

**Prioridad:** Crítica.

---

## HU-07: Cerrar un incidente

**Como:** coordinador de operaciones.
**Quiero:** cerrar un incidente después de verificar su solución.
**Para:** finalizar formalmente el proceso de atención.

### Criterios de aceptación

1. El incidente debe encontrarse en estado **Resuelto**.
2. El coordinador debe registrar una observación de cierre.
3. El estado debe cambiar de **Resuelto** a **Cerrado**.
4. La fecha y hora de cierre deben generarse automáticamente.
5. El incidente cerrado ya no debe contarse como carga activa del técnico.
6. El cambio debe registrarse en el historial.

**Prioridad:** Alta.

---

## HU-08: Reasignar un incidente

**Como:** coordinador de operaciones.
**Quiero:** reasignar un incidente a otro técnico.
**Para:** garantizar su atención cuando el técnico anterior no pueda continuar con el trabajo.

### Criterios de aceptación

1. El incidente puede reasignarse mientras no se encuentre cerrado.
2. El nuevo técnico debe estar activo.
3. El nuevo técnico debe tener la especialidad requerida.
4. El nuevo técnico debe tener menos de tres incidentes activos.
5. Debe registrarse el técnico anterior, el nuevo técnico y el motivo.
6. La reasignación debe conservarse en el historial.

**Prioridad:** Crítica.

---

## HU-09: Liberar un incidente

**Como:** técnico asignado.
**Quiero:** liberar un incidente que no puedo continuar atendiendo.
**Para:** permitir que otro técnico capacitado pueda tomarlo.

### Criterios de aceptación

1. Solo el técnico asignado puede liberar el incidente.
2. El técnico debe ingresar el motivo de la liberación.
3. El incidente debe quedar sin técnico asignado.
4. El incidente debe quedar disponible para otro técnico.
5. El incidente liberado ya no debe contarse en la carga del técnico anterior.
6. La liberación debe registrarse en el historial.

**Prioridad:** Alta.

---

## HU-10: Escalar incidentes automáticamente

**Como:** coordinador de operaciones.
**Quiero:** que los incidentes críticos o urgentes sean escalados automáticamente.
**Para:** evitar que las fallas importantes permanezcan sin atención ni seguimiento.

### Criterios de aceptación

1. El sistema debe revisar los incidentes críticos y urgentes.
2. El incidente debe permanecer en estado **Registrado** por más de dos horas.
3. El sistema debe marcar automáticamente el incidente como escalado.
4. El escalamiento no debe modificar el estado principal del incidente.
5. Un incidente no debe escalarse más de una vez.
6. La fecha del escalamiento debe registrarse en el historial.

**Prioridad:** Crítica.

---

## HU-11: Consultar historial de un incidente

**Como:** coordinador de operaciones.
**Quiero:** consultar el historial completo de un incidente.
**Para:** conocer los cambios y acciones realizadas durante su atención.

### Criterios de aceptación

1. El historial debe mostrar todos los cambios de estado.
2. Debe mostrar el estado anterior y el nuevo estado.
3. Debe mostrar la fecha y hora de cada cambio.
4. Debe mostrar la persona responsable de la acción.
5. Debe incluir asignaciones, reasignaciones, liberaciones y escalamientos.
6. Los registros del historial no deben poder eliminarse ni modificarse.

**Prioridad:** Alta.

---

## HU-12: Generar reportes de incidentes

**Como:** propietario de NetGuard GT.
**Quiero:** generar reportes de incidentes y cumplimiento de SLA.
**Para:** evaluar el rendimiento de los técnicos y la calidad del servicio.

### Criterios de aceptación

1. El reporte debe mostrar el total de incidentes registrados.
2. Debe mostrar los incidentes resueltos dentro y fuera del SLA.
3. Debe calcular el porcentaje de cumplimiento del SLA.
4. Debe mostrar los incidentes abiertos, resueltos, cerrados y escalados.
5. Debe permitir filtrar los resultados por fecha, severidad, sitio y técnico.
6. Debe mostrar el tiempo promedio de resolución.

**Prioridad:** Alta.

