@ECHO OFF
IF [%1] == [] GOTO NOARG
del source\MyApplication\bin\fubu-packages\%1
rmdir /s /q source\MyApplication\fubu-content
GOTO :EOF

:NOARG
@ECHO Specify a package (.zip) to uninstall
