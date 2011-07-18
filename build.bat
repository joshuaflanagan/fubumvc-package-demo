@ECHO OFF
tools\Nuget.exe install source\MyApplication\packages.config -OutputDirectory source\packages
%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe source\PackageDemo.sln
mkdir source\MyApplication\bin\fubu-packages
cmd /c fubu create-pak source\RemindersPackage reminders.zip -f
cmd /c fubu create-pak source\SuperHtml5Package html5.zip -f
