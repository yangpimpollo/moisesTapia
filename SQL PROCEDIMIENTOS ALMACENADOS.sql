USE EDUCA
GO

--VALIDACION
CREATE PROCEDURE VALIDACION
(
@Nombre as varchar(100),
@Curso as varchar(100)
)
AS 
BEGIN
SELECT C.cur_nombre,A.alu_nombre FROM MATRICULA
inner join CURSO C
ON MATRICULA.cur_id=C.cur_id
inner join ALUMNO A
ON MATRICULA.alu_id=A.alu_id
END

--CONSULTA GENERAL
CREATE PROCEDURE CONSULTA
AS
BEGIN
SELECT cur_nombre as CURSO, 
cur_vacantes as VACANTES, 
cur_matriculados as MATRICULADOS,
CASE 
	When (CURSO.cur_matriculados/CURSO.cur_vacantes) >= 0.5 
	then 'INCIA'
	ELSE 'PROCESO'
END AS CONDICION
FROM CURSO
END

--Insertar Datos de Matricula
CREATE PROCEDURE matricula
(@cur_id int ,
@alu_id int,
@mat_fecha datetime, 
@mat_precio money,
@mat_cuotas int,
@mat_nota int
)
AS
SET NOCOUNT ON
BEGIN
INSERT INTO MATRICULA VALUES(@cur_id,
@alu_id,
@mat_fecha,  @mat_precio,
@mat_cuotas, @mat_nota)
END