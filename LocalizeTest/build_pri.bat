@echo off

REM "C:\Program Files (x86)\Windows Kits\10\bin\10.0.26100.0\x64\makepri.exe" createconfig /o /pv 10.0.0 /cf LocalizeTest/resources.xml /dq en-US_fr-FR
"C:\Program Files (x86)\Windows Kits\10\bin\10.0.26100.0\x64\makepri.exe" new /pr LocalizeTest\Strings\ /cf LocalizeTest/resources.xml /of LocalizeTest/resources.pri
