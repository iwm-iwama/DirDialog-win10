@echo off
cls

:R0
	set rtn=

	for /f "usebackq delims=" %%s in (`iwm_DirDialog.exe`) do set rtn=%%s

	if "%rtn%"=="" goto :R9

	echo %rtn%
	echo.

	goto :R0
:R9

echo.
pause
exit
