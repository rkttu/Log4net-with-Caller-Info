@echo off
pushd "%~dp0"

if exist RedistPackages rd /s /q RedistPackages
if not exist RedistPackages\libs mkdir RedistPackages\libs

set project=ClouDeveloper.Log4net.CallerInfo
.nuget\nuget.exe pack "%project%\%project%.csproj" -Build -Symbols -IncludeReferencedProjects -OutputDirectory "RedistPackages\libs" -Properties configuration=Release

set project=log4net-callerinfo
.nuget\nuget.exe push "RedistPackages\libs\%project%.*.nupkg"

start RedistPackages

popd
@echo on