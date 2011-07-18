@ECHO OFF
IF [%1] == [] GOTO NOARG
copy /y %1 source\MyApplication\bin\fubu-packages
GOTO :EOF

:NOARG
@ECHO Specify a package (.zip) to install
