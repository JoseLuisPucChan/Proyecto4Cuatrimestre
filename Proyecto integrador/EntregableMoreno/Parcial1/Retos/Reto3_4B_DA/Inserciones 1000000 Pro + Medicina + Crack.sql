

Declare @i  int = 1
Declare @Nombre varchar(max) = ''
Declare @Semestre int = 0
Declare @Grupo varchar(max) =''
Declare @Curp   varchar(max)=''
while @i<=100000
Begin

	  set  @Nombre = 'Alumno ' + convert(varchar(max),@i+'')
             if (@i<10000)
                Begin
                    set @Semestre = 1
                    if (@i >= 5000)
                    begin
                        set @Grupo = 'B'
                    end
                    else 
					Begin
					set @Grupo = 'A'
					end
                end
                else
                begin
                    if (@i >= 10000 AND @i< 40000)
                    Begin
                        SET @Semestre = 2;
                        if (@i >= 10000 AND @i < 25000)
                        Begin
                            set @Grupo = 'A'
                        end
                        else
                        begin
                            Set @Grupo = 'B'
                        end
                    end
                    else
                    BEGIN
                        if (@i >= 40000 AND @i < 100000)
                        bEGIN
                             set @Semestre = 3
                          set @Grupo = 'B'
                            if (@i >= 40000 AND @i < 60000)
                            BEGIN
                                set @Grupo ='C'
                            END
                        END
                    END
				END
                
                SET @Curp = 'Alumn' + convert(varchar(max),@i+'' )+ @Grupo +convert(varchar(max),+@Semestre+'')


		 Insert into Alumnos(nombre,semestre,grupo,curp) 
		 Values(@Nombre,@Semestre,@Grupo,@Curp)
		 set @i = @i +1
End

