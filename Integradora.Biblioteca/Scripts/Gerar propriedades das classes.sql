SELECT '      public ' ||
       CASE WHEN A.data_type = 'DATE'
            THEN 'DateTime?'
            WHEN A.data_type = 'NUMBER'
            THEN CASE WHEN A.data_scale > 0 
                      THEN 'double'
                      WHEN A.data_precision > 4
                      THEN 'long'
                      ELSE 'int'
                 END
            ELSE 'string'
       END || ' ' || 
       INITCAP(A.column_name) ||
       ' { get; set; }' PROPRIEDADE 
  FROM USER_TAB_COLUMNS A
 WHERE A.TABLE_NAME = 'PCCLIENT'
  ORDER BY A.column_name