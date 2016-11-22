
SELECT
  SCHEMA_NAME(o.schema_id) AS Esquema,
  O.Name AS Tabla,
  P1.Value AS [Descripción Tabla],
  C.Name AS Columna,
  T.Name AS Tipo,
  C.max_length AS Longitud,
  C.[Precision] AS Presición,
  C.scale AS Escala,
  CASE
    WHEN C.Is_Nullable = 0 Then 'No'
    WHEN C.Is_Nullable = 1 Then 'Si'
  END [Nulo?],
  P2.value AS [Descripción Col]
FROM
 sys.tables O
  INNER JOIN sys.Columns C
    ON O.object_id = C.object_id
  INNER JOIN sys.Types T
    ON C.system_type_id = T.system_type_id
    AND C.system_type_id = T.user_type_id
  LEFT JOIN sys.extended_properties P1
    ON C.object_id = P1.major_id
    AND P1.minor_id = 0
    LEFT JOIN sys.extended_properties P2
    ON C.object_id = P2.major_id
    AND C.Column_id = P2.minor_id
    AND P2.Class = 1
ORDER BY
  O.Name,
  C.Column_id
GO