echo off

echo Change to Current Directory
cd /d %~dp0

echo Deleting '.NET obj,bin' directories
for /f "delims=" %%a in ('dir /ad/s/b bin') do (rmdir /s/q "%%a")
for /f "delims=" %%a in ('dir /ad/s/b obj') do (rmdir /s/q "%%a")

echo Deleting 'C++ Debug,Release' directories
for /f "delims=" %%a in ('dir /ad/s/b Debug') do (rmdir /s/q "%%a")
for /f "delims=" %%a in ('dir /ad/s/b Release') do (rmdir /s/q "%%a")

echo Deleting 'Binaries' directories
for /f "delims=" %%a in ('dir /ad/s/b Binaries') do (rmdir /s/q "%%a")

echo Deleting 'TestResults' directories
for /f "delims=" %%a in ('dir /ad/s/b TestResults') do (rmdir /s/q "%%a")

echo Deleting 'NuGet Packages' directories
for /f "delims=" %%a in ('dir /ad/s/b packages') do (rmdir /s/q "%%a")
if %errorlevel% neq 0 goto :error

echo Deleting DslIncludeTemp directories
for /f "delims=" %%a in ('dir /ad/s/b DslIncludeTemp') do (rmdir /s/q "%%a")
if %errorlevel% neq 0 goto :error

echo Deleting Backup directories
for /f "delims=" %%a in ('dir /ad/s/b Backup') do (rmdir /s/q "%%a")
if %errorlevel% neq 0 goto :error

echo Deleting 'Non-Source' Files
for /f "delims=" %%a in ('dir /ah-hr/s/b *.vspscc') do (del /f/q "%%a")
for /f "delims=" %%a in ('dir /ah-hr/s/b *.vssscc') do (del /f/q "%%a")
for /f "delims=" %%a in ('dir /ah-hr/s/b *.suo') do (del /f/q "%%a")
for /f "delims=" %%a in ('dir /ah-hr/s/b *.user') do (del /f/q "%%a")
for /f "delims=" %%a in ('dir /ah-hr/s/b *.csproj.user') do (del /f/q "%%a")
for /f "delims=" %%a in ('dir /ah-hr/s/b ~*.*') do (del /f/q "%%a")

echo Deleting 'Azure Emulator' Files
rmdir /q/s "%localappdata%\dftmp"

ECHO:
ECHO:
CALL SetColor.bat 0A "---- Cleaned Successfully!"
ECHO(
pause
exit /b 0

:error
ECHO:
ECHO:
CALL SetColor.bat 04 "**** Failed Cleaning! error #%errorlevel% ****"
ECHO(
pause
exit /b %errorlevel%