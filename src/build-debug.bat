@echo off
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe "XRails-LoginUI VS-2010.sln" /p:Configuration=Debug /p:Platform="x86"

pause >nul