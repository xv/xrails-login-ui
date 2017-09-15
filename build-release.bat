@echo off
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe "XRails Login VS-2010.sln" /p:Configuration=Release /p:Platform="x86"

pause >nul