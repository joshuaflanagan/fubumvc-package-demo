@ECHO OFF
tools\Nuget.exe install source\MyApplication\packages.config -OutputDirectory source\packages
%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe source\PackageDemo.sln
