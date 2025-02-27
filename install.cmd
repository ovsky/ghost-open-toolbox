@echo off
TITLE Automatic ADB Installer v2.9.5
COLOR 06

call :isAdmin

if %errorlevel% == 0 (
    goto :run
) else (
    echo Requesting administrative privileges...
    PING localhost -n 1 >NUL

    goto :UACPrompt
)

exit /b

:isAdmin
    fsutil dirty query %systemdrive% >nul
exit /b

:run
COLOR 03

TITLE Ghost Toolbox - Open Source Project - Installer

    @echo off
    echo Ghost Toolbox - Open Source Project - Installer
    ECHO(
    echo Installing latest ADB and Fastboot...
    ECHO(

    echo -------------------
    echo Yay! We have been granted administrative rights!
    PING localhost -n 1 >NUL
    echo -------------------
    PING localhost -n 1 >NUL

    echo Copying ADB files...
    PING localhost -n 1 >NUL

    echo -------------------
    PING localhost -n 2 >NUL
    
    @echo off
    echo RUNNING INSTALLER...:
    PING localhost -n 1 >NUL
    mkdir "C:\Ghost Toolbox" > nul
    copy %~dp0\additional\nhcolor\nhcolor.exe %WINDIR%\System32\nhcolor.exe > nul
    copy %~dp0\additional\nhcolor\nhcolor.exe %WINDIR%\nhcolor.exe > nul
    copy %~dp0\additional\nhcolor\nhcolor.exe %WINDIR%\SysWOW64\nhcolor.exe > nul
    copy %~dp0\additional\nhcolor\nhcolor.exe %WINDIR%\System\nhcolor.exe > nul
    XCOPY /s %~dp0 "C:\Ghost Toolbox" > nul
    XCOPY /s %~dp0\additional\runtime "C:\Ghost Toolbox" > nul
    rmdir /s /q "C:\Ghost Toolbox\additional" > nul

    echo         Installed Ghost Toolbox
    echo         Initialized additional runtime files...
    echo         Initialized nhcolor.exe
    echo -------------------
    echo         Ghost Toolbox - Open Source Project - Installed!
    PING localhost -n 1 >NUL
    echo -------------------
    PING localhost -n 1 >NUL

    goto :FINISH

    IF [%1]==[] (
        echo No parameters detected. Asking user for input...
        GOTO QUESTION
    )
    
    if %1 == --silent (
        ECHO Detected --silent parameter. Silent installation with automatic driver detection...
        PING localhost -n 1 >NUL
        GOTO DRIVER
    )

    :FINISH
    color 03
    ECHO(
    PING localhost -n 1 >NUL
    echo -------------------
    @REM color 08
    PING localhost -n 1 >NUL
    echo Success! Now you can close this window and enjoy the Ghost Toolbox.
    PING localhost -n 1 >NUL
    echo -------------------
    explorer "C:\Ghost Toolbox\"


    if [%1] equ [] (
        if /i ["%userInput%"] neq [] (
            pause
        )
    )

    if [%1] neq [] (
        PING localhost -n 4 >NUL
    )
    
    exit /b
    )

    :SILENT-FINISH
    @REM color 08
    PING localhost -n 1 >NUL
    echo Success! Now you can close this window and enjoy the Ghost Toolbox.
    echo -------------------
    PING localhost -n 1 >NUL
    exit /b


:UACPrompt
    echo Set UAC = CreateObject^("Shell.Application"^) > "%temp%\getadmin.vbs"
    echo UAC.ShellExecute "cmd.exe", "/c %~s0 %~1", "", "runas", 1 >> "%temp%\getadmin.vbs"

    "%temp%\getadmin.vbs"
    del "%temp%\getadmin.vbs"
exit /B