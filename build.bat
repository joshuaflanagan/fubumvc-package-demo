@ECHO OFF
tools\Nuget.exe install source\MyApplication\packages.config -OutputDirectory source\packages
msbuild source\PackageDemo.sln
